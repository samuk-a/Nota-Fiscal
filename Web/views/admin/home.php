<div class="modal" id="modal-download">
  <div class="modal-content">
    <h3 class="center">Baixar</h3>
    <p>Por favor, escolha a versão que você deseja realizar o download</p>
    <div class="row">
      <div class="col s12">
        <?php
        $badges = [
          ['class' => 'green darken-2', 'text' => 'Recomendada'],
          ['class' => 'purple darken-2', 'text' => 'Mais antiga'],
          ['class' => 'red darken-1', 'text' => 'Experimental']
        ];
        if (isset($versoes) && !empty($versoes))
          for ($i=0; $i < count($versoes) && $i < 3; $i++):?>
          <div class="row">
            <div class="col s10">
              Versão <?=$versoes[$i]['versao']?> - <?=number_format($versoes[$i]['tamanho'] / 1024 / 1024, 2)?> MB<br>
              <?if ($versoes[$i]['experimental'] && $i < 2) $i++;?>
              <span class="new badge <?=$badges[$i]['class']?>" data-badge-caption=""><?=$badges[$i]['text']?></span>
            </div>
            <div class="col s2">
              <a href="/Installs/<?=$versoes[$i]['arquivo']?>" class="btn btn-small full-width orange darken-3" download="Setup-v<?=$versoes[$i]['versao']?><?=$versoes[$i]['experimental']?'-EXP':''?>.exe">Download</a>
            </div>
          </div>
          <hr>
        <?endfor;?>
      </div>
    </div>
  </div>
</div>
<div class="container">
  <div class="row">
    <div class="col s12 center">
      <h3><?=$title;?></h3>
    </div>
  </div>
  <div class="row">
    <div class="col s12 right-align">
      <button class="btn btn-large blue waves-effect waves-light modal-trigger" data-target="modal-download"><i class="material-icons left">get_app</i>Baixar</button>
    </div>
  </div>
  <div class="row">
    <div class="col s12">
      <canvas id="vendas" width="5" height="2" class="hide-on-small-only"></canvas>
      <canvas id="vendas-mob" width="5" height="3" class="hide-on-med-and-up"></canvas>
    </div>
  </div>
</div>
<?if (count($vendas['num']) > 0):?>
<script>
  document.addEventListener('DOMContentLoaded', function() {
    var vendas = new Chart('vendas', {
      type: 'line',
      data: {
        labels: months.splice(-<?=key($vendas['num'])-1?>, <?=count($vendas['num'])?>),
        datasets: [{
          label: '# Vendas',
          data: <?=json_encode(array_values($vendas['num']))?>,
          lineTension: 0,
          backgroundColor: 'rgba(3, 131, 8, 0.66)',
          borderColor: 'rgba(3, 131, 8, 0.66)',
          fill: false,
          showLine: true
        },
        {
          label: 'Total R$',
          data: <?=json_encode(array_values($vendas['total']))?>,
          lineTension: 0,
          backgroundColor: 'rgba(219, 151, 0, 0.66)',
          borderColor: 'rgba(219, 151, 0, 0.66)',
          fill: false,
          showLine: true
        }]
      },
      options: {
        scales: {
          yAxes: [{
            ticks: {
              beginAtZero: true
            }
          }]
        }
      }
    });
    var vendas = new Chart('vendas-mob', {
      type: 'line',
      data: {
        labels: months.splice(-<?=key($vendas['num'])-1?>, <?=count($vendas['num'])?>),
        datasets: [{
          label: '# Vendas',
          data: <?=json_encode(array_values($vendas['num']))?>,
          lineTension: 0,
          backgroundColor: 'rgba(3, 131, 8, 0.66)',
          borderColor: 'rgba(3, 131, 8, 0.66)',
          fill: false,
          showLine: true
        },
        {
          label: 'Total R$',
          data: <?=json_encode(array_values($vendas['total']))?>,
          lineTension: 0,
          backgroundColor: 'rgba(219, 151, 0, 0.66)',
          borderColor: 'rgba(219, 151, 0, 0.66)',
          fill: false,
          showLine: true
        }]
      },
      options: {
        scales: {
          yAxes: [{
            ticks: {
              beginAtZero: true
            }
          }]
        }
      }
    });
  });
</script>
<?endif;?>
