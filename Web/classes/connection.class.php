<?php
/**
 * Connection
 */
abstract class Connection
{
  protected $connection = null;

  protected function getConnection() {
    if ($this->connection != null)
      return $this->connection;
    $this->connection = new MySQLi(HOST, USER, PASS, NAME);
    if ($this->connection->connect_error)
      die('Database connection error: ' . $this->connection->connect_error);
  }
}

?>
