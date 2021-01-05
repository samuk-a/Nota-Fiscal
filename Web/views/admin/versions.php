<div class="modal" id="new-version">
  <div class="modal-content">
    <h3 class="center">Adicionar Versão</h3>
    <div class="row">
      <form id="form-version" class="col s12" action="./versions/add" method="post" enctype="multipart/form-data" autocomplete="off">
        <div class="row">
          <div class="input-field col s12 l4">
            <input type="text" name="versao" id="versao" class="validate" required>
            <label for="versao">Versão</label>
          </div>
          <div class="file-field input-field col s12 l4">
            <div class="btn">
              <span>Arquivo</span>
              <input type="file" name="arquivo" required accept=".exe">
            </div>
            <div class="file-path-wrapper">
              <input type="text" class="file-path validate">
            </div>
          </div>
          <div class="col s12 l4 center">
            <label>Experimental?</label>
            <div class="switch">
              <label>
                Não
                <input type="checkbox" name="experimental">
                <span class="lever"></span>
                Sim
              </label>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col s12 right-align">
            <button type="submit" class="btn waves-effect waves-light green">Enviar</button>
          </div>
        </div>
      </form>
    </div>
    <div class="row">
      <div class="col s12">
        <div class="progress-wrapper hide">
          <div class="progress">
            <div class="determinate" style="width: 0%"></div>
          </div>
          <p class="center">0%</p>
        </div>
      </div>
    </div>
  </div>
</div>
<div class="container">
  <div class="row">
    <div class="col s12 center">
      <h3><?=$title?></h3>
    </div>
  </div>
  <div class="fixed-action-btn">
    <a href="#new-version" class="btn-floating btn-large waves-effect waves-light red modal-trigger"><i class="material-icons">add</i></a>
  </div>
  <div class="row">
    <?php if (isset($versoes) && !empty($versoes)):?>
    <table class="col s12 centered responsive-table">
      <thead>
        <tr>
          <th>Versão</th>
          <th>Arquivo</th>
          <th>Tamanho</th>
          <th>Experimental</th>
          <th>Data de Upload</th>
        </tr>
      </thead>
      <tbody>
        <?php foreach ($versoes as $ver):?>
        <tr>
          <td><?=$ver['versao']?></td>
          <td><a href="/Installs/<?=$ver['arquivo']?>" download="<?=$ver['arquivo']?>"><?=$ver['arquivo']?></a></td>
          <td><span class="tooltipped" data-tooltip="<?=$ver['tamanho']?> bytes"><?=number_format($ver['tamanho'] / 1024 / 1024, 2)?> MB</span></td>
          <td><?=$ver['experimental'] ? 'Sim' : 'Não'?></td>
          <td><?=date_format(date_create($ver['uploaded']), 'd/m/Y H:i:s')?></td>
          <td></td>
        </tr>
        <?php endforeach;?>
      </tbody>
    </table>
    <?php endif;?>
  </div>
</div>
<script>
  $(document).ready(function () {
    var progressWrapper = $('.progress-wrapper')[0];
    var progressBar = $('.progress-wrapper .progress .determinate')[0];
    var progressText = $('.progress-wrapper p')[0];
    $('#form-version').ajaxForm({
      dataType: 'json',
      beforeSubmit: () => {
        var percent = '0%';
        $(progressWrapper).removeClass('hide');
        $(progressBar).width(percent);
        $(progressText).html(percent);
      },
      uploadProgress: (event, position, total, complete) => {
        var percent = complete + '%';
        $(progressBar).width(percent);
        $(progressText).text(percent);
      },
      error: (res, status, e) => {
        M.toast({html:'Oops, algo de muito ruim aconteceu ao enviar!'});
        console.log(res);
      },
      success: xhr => {
        M.toast({html:xhr.msg});
        if (xhr.status && xhr.status == 200) {
          console.error(xhr);
        }
      }
    });
  });
</script>
