<?php
require_once 'autoload.php';
Router::get('/', function() {
  $view = new View('home', ['nome'=>$_SESSION['nome']??''], ['navbar'=>0,'footer'=>99]);
  echo $view->render();
});
Router::get('/login', function() {
  if (isset($_SESSION['id'])) header('Location: /');
  $title = 'Login';
  $view = new View('login', ['title'=>$title], ['navbar'=>0,'footer'=>99]);
  echo $view->render();
});
Router::get('/admin', function() {
  if (!isset($_SESSION['admin']) || !$_SESSION['admin']) View::e404();
  else {
    $vendas = Sell::getMonth(date('Y'));
    $title = 'Painel Administrativo';
    $view = new View('admin/home', ['title'=>$title, 'nome'=>$_SESSION['nome'], 'versoes'=>Version::getVersions(), 'vendas'=>$vendas], ['navbar'=>0,'footer'=>99]);
    echo $view->render();
  }
});
Router::get('/admin/versions', function() {
  if (!isset($_SESSION['admin']) || $_SESSION['admin'] < 2) View::e404();
  else {
    $title = 'Controle de Versões';
    $view = new View('admin/versions', ['title'=>$title, 'nome'=>$_SESSION['nome'], 'versoes'=>Version::getVersions()], ['navbar'=>0,'footer'=>99]);
    echo $view->render();
  }
});
Router::get('/logout', function() {
  session_destroy();
  header('Location: /');
});
Router::post('/login', function() {
  $user = new User();
  $user->email = $_POST['email'];
  $user->pass = $_POST['password'];
  if ($user->login()) {
    if ($_SESSION['admin']) {
      header('Location: /admin');
    } else {
      header('Location: /');
    }
  } else {
    $view = new View('login', ['title'=>'Login','email'=>$user->email,'error'=>'Dados incorretos'], ['navbar'=>0,'footer'=>99]);
    echo $view->render();
  }
});
Router::post('/admin/versions/add', function() {
  $folder = 'Installs/';
  if (!is_writable($folder) || !is_dir($folder) || !isset($_POST) || empty($_POST) || !isset($_FILES) || empty($_FILES)) {
    die(json_encode(['status' => 500, 'msg' => 'Erro interno! Tente novamente mais tarde']));
  }
  $version = $_POST['versao'];
  $file = $_FILES['arquivo']['tmp_name'];
  $name = $_FILES['arquivo']['name'];
  $size = $_FILES['arquivo']['size'];
  $testing = isset($_POST['experimental']) ? 1 : 0;
  if (move_uploaded_file($_FILES['arquivo']['tmp_name'], $folder . $name)) {
    $newVersion = new Version($version, $name, $size, $testing);
    $save = $newVersion->save();
    if ($save) {
      die(json_encode(['status' => 200, 'msg' => 'Versão cadastrada com sucesso! '.$save]));
    } else {
      die(json_encode(['status' => 500, 'msg' => 'Erro ao cadastrar a versão! '.$save]));
    }
  } else {
    die(json_encode(['status' => 500, 'msg' => 'Erro ao fazer o upload da versão!']));
  }
});
Router::run('/');

function dd($data) {
  echo '<pre>';
  print_r($data);
  echo '</pre>';
  die();
}
?>
