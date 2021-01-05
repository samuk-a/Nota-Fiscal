<?php
/**
 * DB
 */
class DB extends Connection
{
  private $table = '';

  public function __construct($table) {
    $this->getConnection();
    $this->table = $table;
  }

  public function dd($value) {
    echo "<pre>", print_r($value, true), "</pre>";
    die();
  }

  public function selectOne($conditions, $orderBy = []) {
    $sql = "SELECT * FROM $this->table";
    $i = 0;
    foreach ($conditions as $key => $value) {
      if ($i === 0) {
        $sql .= " WHERE $key=?";
      } else {
        $sql .= " AND $key=?";
      }
      $i++;
    }
    if (!empty($orderBy)) {
      $i = 0;
      foreach ($orderBy as $key => $value) {
        if ($i === 0) {
          $sql .= " ORDER BY $key $value";
        } else {
          $sql .= ", $key $value";
        }
        $i++;
      }
    }
    $sql .= ' LIMIT 1';
    $stmt = $this->executeQuery($sql, $conditions);
    $record = $stmt->get_result()->fetch_assoc();
    return $record;
  }

  public function selectAll($conditions = [], $orderBy = []) {
    $sql = "SELECT * FROM $this->table";
    if (!empty($conditions)) {
      $i = 0;
      foreach ($conditions as $key => $value) {
        if ($i === 0) {
          $sql .= " WHERE $key=?";
        } else {
          $sql .= " AND $key=?";
        }
        $i++;
      }
    }
    if (!empty($orderBy)) {
      $i = 0;
      foreach ($orderBy as $key => $value) {
        if ($i === 0) {
          $sql .= " ORDER BY $key $value";
        } else {
          $sql .= ", $key $value";
        }
        $i++;
      }
    }
    if (empty($conditions)) {
      $stmt = $this->connection->prepare($sql);
      $stmt->execute();
    } else {
      $stmt = $this->executeQuery($sql, $conditions);
    }
    $records = $stmt->get_result()->fetch_all(MYSQLI_ASSOC);
    return $records;
  }

  public function create($data) {
    $sql = "INSERT INTO $this->table SET";
    $i = 0;
    foreach ($data as $key => $value) {
      if ($i === 0)
        $sql .= " $key=?";
      else
        $sql .= ", $key=?";
      $i++;
    }
    $stmt = $this->executeQuery($sql, $data);
    $id = $stmt->insert_id;
    return $id;
  }

  private function executeQuery($sql, $data) {
    $stmt = $this->connection->prepare($sql);
    $values = array_values($data);
    $types = str_repeat('s', count($values));
    $stmt->bind_param($types, ...$values);
    $stmt->execute();
    return $stmt;
  }
}

?>
