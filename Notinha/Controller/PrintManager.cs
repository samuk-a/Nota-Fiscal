using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using Notinha.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.IO;

namespace Notinha.Controller {
	class PrintManager {
		private readonly string path = @"C:\Temp\";
		private readonly string name = "note.pdf";

		public void GenerateDocument(Venda venda)
		{
			try {
				if (!Directory.Exists(path))
					Directory.CreateDirectory(path);
			} catch {
				Messages.ShowError("Falha ao criar o diretório.\nPor favor, tente novamente\n\nSe o problema persistir, crie \"C:\\Temp\\");
				return;
			}
			PdfWriter writer = new PdfWriter(path + name);
			PdfDocument pdf = new PdfDocument(writer);
			Document document = new Document(pdf);
			Paragraph header = new Paragraph(Properties.Settings.Default.HEADER)
				.SetTextAlignment(TextAlignment.CENTER)
				.SetFontSize(15).SetBold();
			Paragraph subheader = new Paragraph(Properties.Settings.Default.SUBHEADER)
				.SetTextAlignment(TextAlignment.CENTER)
				.SetFontSize(12);
			Paragraph subheader1 = new Paragraph(Properties.Settings.Default.SUBHEADER1)
				.SetTextAlignment(TextAlignment.CENTER)
				.SetFontSize(12);
			Paragraph subheader2 = new Paragraph(Properties.Settings.Default.SUBHEADER2)
				.SetTextAlignment(TextAlignment.CENTER)
				.SetFontSize(12);
			LineSeparator ls = new LineSeparator(new SolidLine());
			PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
			float[] cells = { 10, 45, 11f, 18f, 10f, 15f };
			Table theader = GenerateHeader(font, cells, Border.NO_BORDER, venda);
			float[] cellItens = { 10, 5, 5, 50, 15, 15 };
			Table itensHeader = GenerateItensHeader(font, cellItens, Border.NO_BORDER);
			Table itens = GenerateItens(font, cellItens, Border.NO_BORDER, venda);
			float[] cellDetails = { 85, 15 };
			Table details = GenerateDetails(font, cellDetails, Border.NO_BORDER, venda);
			Table detailsDate = GenerateDetailsDate(font, cellDetails, Border.NO_BORDER, venda);

			document.Add(header)
				.Add(subheader)
				.Add(subheader1)
				.Add(subheader2)
				.Add(ls)
				.Add(theader)
				.Add(ls)
				.Add(itensHeader)
				.Add(ls)
				.Add(itens)
				.Add(ls)
				.Add(details)
				.Add(ls)
				.Add(detailsDate);
			document.Close();
		}

		public void Print()
		{
			Process process = new Process {
				StartInfo = new ProcessStartInfo {
					Verb = "open",
					FileName = path + name,
				},
			};
			process.Start();
		}

		private void GenerateRow(PdfFont font, ref Table table, Border border, params Paragraph[] cells)
		{
			foreach (Paragraph p in cells) {
				Cell cell = new Cell();
				cell.SetVerticalAlignment(VerticalAlignment.MIDDLE);
				if (p != null)
					cell.Add(p.SetFont(font).SetFontSize(8));
				table.AddCell(cell.SetBorder(border));
			}
		}

		private Table GenerateHeader(PdfFont font, float[] cells, Border border, Venda venda)
		{
			Table theader = new Table(UnitValue.CreatePercentArray(cells)).UseAllAvailableWidth();
			// Row 1
			Paragraph nome = new Paragraph("Nome:");
			Paragraph nomeV = new Paragraph(venda.Cliente.Nome).SetBold();
			Paragraph cod = new Paragraph("Código:").SetTextAlignment(TextAlignment.RIGHT);
			Paragraph codV = new Paragraph(venda.Cod.ToString()).SetBold();
			// Row 2
			Paragraph razSoc = new Paragraph("Raz Soc.:");
			Paragraph razSocV = new Paragraph(venda.Cliente.RazSoc ?? "").SetBold();
			Paragraph doc = new Paragraph();
			ulong docLong = Convert.ToUInt64(venda.Cliente.Doc);
			Paragraph docV;
			if (docLong == 0)
			{
				docV = new Paragraph();
			}
			else
			{

				if (venda.Cliente.Doc.Length == 11)
				{
					doc = new Paragraph("CPF:").SetTextAlignment(TextAlignment.RIGHT);
					docV = new Paragraph(docLong.ToString(@"000\.000\.000\-00"));
				}
				else
				{
					doc = new Paragraph("CNPJ:").SetTextAlignment(TextAlignment.RIGHT);
					docV = new Paragraph(docLong.ToString(@"00\.000\.000\/0000\-00"));
				}
			}
			
			Paragraph fone = new Paragraph("Fone:").SetTextAlignment(TextAlignment.RIGHT);
			Paragraph foneV;
			if (venda.Cliente.Fone == null) foneV = new Paragraph();
			else foneV = new Paragraph(Convert.ToUInt64(venda.Cliente.Fone).ToString(@"(00) 0000\-0000"));
			// Row 3
			Paragraph end = new Paragraph("Endereço:");
			Paragraph endV = new Paragraph(venda.Cliente.Endereco ?? "");
			Paragraph cidade = new Paragraph("Cidade:").SetTextAlignment(TextAlignment.RIGHT);
			Paragraph cidadeV = new Paragraph(venda.Cliente.Cidade ?? "");
			Paragraph cep = new Paragraph("Cep:").SetTextAlignment(TextAlignment.RIGHT);
			Paragraph cepV;
			if (venda.Cliente.Cep == null) cepV = new Paragraph("");
			else cepV = new Paragraph(Convert.ToUInt64(venda.Cliente.Cep).ToString(@"00 000\-000"));
			// Row 4
			Paragraph bairro = new Paragraph("Bairro:");
			Paragraph bairroV = new Paragraph(venda.Cliente.Bairro ?? "");
			Paragraph tipoVenda = new Paragraph("Tipo venda:").SetTextAlignment(TextAlignment.RIGHT);
			Paragraph tipoVendaV = new Paragraph(venda.Tipo.ToString()).SetBold();

			GenerateRow(font, ref theader, border, nome, nomeV, null, null, cod, codV);
			GenerateRow(font, ref theader, border, razSoc, razSocV, doc, docV, fone, foneV);
			GenerateRow(font, ref theader, border, end, endV, cidade, cidadeV, cep, cepV);
			GenerateRow(font, ref theader, border, bairro, bairroV, tipoVenda, tipoVendaV, null, null);

			return theader;
		}

		private Table GenerateItensHeader(PdfFont font, float[] cells, Border border)
		{
			Table table = new Table(UnitValue.CreatePercentArray(cells)).UseAllAvailableWidth();
			Paragraph cod = new Paragraph("Código").SetTextAlignment(TextAlignment.CENTER);
			Paragraph qtd = new Paragraph("Qtd.").SetTextAlignment(TextAlignment.CENTER);
			Paragraph un = new Paragraph("Und").SetTextAlignment(TextAlignment.CENTER);
			Paragraph desc = new Paragraph("Descrição").SetTextAlignment(TextAlignment.CENTER);
			Paragraph valor = new Paragraph("Vr Unit.").SetTextAlignment(TextAlignment.CENTER);
			Paragraph total = new Paragraph("Total").SetTextAlignment(TextAlignment.CENTER);

			GenerateRow(font, ref table, border, cod, qtd, un, desc, valor, total);
			return table;
		}

		private Table GenerateItens(PdfFont font, float[] cells, Border border, Venda venda)
		{
			Table table = new Table(UnitValue.CreatePercentArray(cells)).UseAllAvailableWidth();
			foreach (KeyValuePair<Item, uint> item in venda.Itens) {
				Paragraph cod = new Paragraph(item.Key.Cod);
				Paragraph qtd = new Paragraph(item.Value.ToString()).SetTextAlignment(TextAlignment.RIGHT);
				Paragraph un = new Paragraph(item.Key.Unidade);
				Paragraph desc = new Paragraph(item.Key.Descricao);
				Paragraph valor = new Paragraph(item.Key.Valor.ToString()).SetTextAlignment(TextAlignment.CENTER);
				Paragraph total = new Paragraph((item.Key.Valor * item.Value).ToString()).SetTextAlignment(TextAlignment.RIGHT);
				GenerateRow(font, ref table, border, cod, qtd, un, desc, valor, total);
			}
			return table;
		}

		private Table GenerateDetails(PdfFont font, float[] cells, Border border, Venda venda)
		{
			Table table = new Table(UnitValue.CreatePercentArray(cells)).UseAllAvailableWidth();
			Paragraph sub = new Paragraph("SUB TOTAL:").SetTextAlignment(TextAlignment.RIGHT);
			Paragraph desconto = new Paragraph("DESCONTO:").SetTextAlignment(TextAlignment.RIGHT);
			Paragraph total = new Paragraph("TOTAL:").SetTextAlignment(TextAlignment.RIGHT).SetBold();
			decimal totalF = venda.Total + venda.Desconto;
			Paragraph subV = new Paragraph(totalF.ToString()).SetTextAlignment(TextAlignment.RIGHT);
			Paragraph descV = new Paragraph("-" + venda.Desconto).SetTextAlignment(TextAlignment.RIGHT);
			Paragraph totalV = new Paragraph(venda.Total.ToString()).SetTextAlignment(TextAlignment.RIGHT);

			GenerateRow(font, ref table, border, sub, subV);
			GenerateRow(font, ref table, border, desconto, descV);
			GenerateRow(font, ref table, border, total, totalV);
			return table;
		}

		private Table GenerateDetailsDate(PdfFont font, float[] cells, Border border, Venda venda)
		{
			Table table = new Table(UnitValue.CreatePercentArray(cells)).UseAllAvailableWidth();
			Paragraph data = new Paragraph("Data:").SetTextAlignment(TextAlignment.RIGHT);
			Paragraph orcamento = new Paragraph("Data Orçamento:").SetTextAlignment(TextAlignment.RIGHT);
			Paragraph dataV = new Paragraph(venda.DataVenda.ToString()).SetTextAlignment(TextAlignment.RIGHT);
			Paragraph orcamentoV = new Paragraph(venda.DataOrcamento.ToShortDateString()).SetTextAlignment(TextAlignment.RIGHT);

			GenerateRow(font, ref table, border, data, dataV);
			GenerateRow(font, ref table, border, orcamento, orcamentoV);
			return table;
		}
	}
}
