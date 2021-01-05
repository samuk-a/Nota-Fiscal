<?php
session_start();
spl_autoload_register(function($name) {
  include 'classes/'.strtolower($name).'.class.php';
});
?>
