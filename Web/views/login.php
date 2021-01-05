<div class="container">
  <div class="row">
    <h2 class="col s12 center">Login</h2>
  </div>
  <?if (isset($error)):?>
  <div class="row">
    <div class="col s12 error">
      <p><?=$error?></p>
    </div>
  </div>
  <?endif;?>
  <div class="row">
    <form action="/login" class="col s12" method="post" autocomplete="off">
      <div class="row">
        <div class="input-field col s12">
          <input type="email" id="email" class="validate" required name="email" value="<?=isset($email)?$email:''?>">
          <label for="email">Email</label>
        </div>
        <div class="input-field col s12">
          <input type="password" id="password" class="validate" required name="password">
          <label for="password">Senha</label>
        </div>
      </div>
      <div class="row">
        <div class="col s12 right-align">
          <button class="btn green darken-2 waves-effect waves-light">Entrar</button>
        </div>
      </div>
    </form>
  </div>
</div>
