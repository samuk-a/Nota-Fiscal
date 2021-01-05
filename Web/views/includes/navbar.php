<?include 'header.php';?>
<nav>
  <div class="nav-wrapper orange darken-2">
    <a href="/" class="brand-logo hide-on-small-only">Auto Elétrica Canassa</a>
    <a href="/" class="brand-logo hide-on-med-and-up">A.E. Canassa</a>
    <a href="#" data-target="mobile" class="sidenav-trigger"><i class="material-icons">menu</i></a>
    <ul id="nav-mobile" class="right hide-on-med-and-down">
      <?if (isset($_SESSION['id'])):?>
      <li><a href="<?=$_SESSION['admin']?'/admin':'/'?>">Olá, <?=$nome;?></a></li>
      <li><a href="/logout">Logout</a></li>
      <?else:?>
      <li><a href="/login">Login</a></li>
      <?endif;?>
    </ul>
  </div>
</nav>
<ul class="sidenav" id="mobile">
  <?if (isset($_SESSION['id'])):?>
  <li><a href="<?=$_SESSION['admin']?'/admin':'/'?>">Olá, <?=$nome;?></a></li>
  <li><a href="/logout">Logout</a></li>
  <?else:?>
  <li><a href="/login">Login</a></li>
  <?endif;?>
</ul>
