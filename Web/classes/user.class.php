<?php
/**
 * User
 */
class User
{
  public $email;
  public $pass;

  public function login() {
    $db = new DB('tb_funcionarios');
    $user = $db->selectOne(['email' => $this->email]);
    if ($user && password_verify($this->pass, $user['pass'])) {
      $_SESSION['id'] = $user['id'];
      $_SESSION['nome'] = $user['nome'];
      $_SESSION['admin'] = $user['admin'];
      return true;
    } else return false;
  }
}

?>
