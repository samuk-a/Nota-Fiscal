using System.Reflection;
using System.Windows.Forms;

namespace Notinha.Controller {
	public class AppInfo {
		public static string Title {
			get {
				var assm = Assembly.GetExecutingAssembly();
				var attr = (AssemblyTitleAttribute)assm.GetCustomAttribute(typeof(AssemblyTitleAttribute));
				if (attr != null && !string.IsNullOrEmpty(attr.Title))
					return attr.Title;
				return string.Empty;
			}
		}
		public static string Copyright {
			get {
				var assm = Assembly.GetExecutingAssembly();
				var attr = (AssemblyCopyrightAttribute)assm.GetCustomAttribute(typeof(AssemblyCopyrightAttribute));
				if (attr != null && !string.IsNullOrEmpty(attr.Copyright))
					return attr.Copyright;
				return string.Empty;
			}
		}
		public static string Version {
			get {
				return Application.ProductVersion;
			}
		}
		public static string Company {
			get {
				var assm = Assembly.GetExecutingAssembly();
				var attr = (AssemblyCompanyAttribute)assm.GetCustomAttribute(typeof(AssemblyCompanyAttribute));
				if (attr != null && !string.IsNullOrEmpty(attr.Company))
					return attr.Company;
				return string.Empty;
			}
		}
	}
}
