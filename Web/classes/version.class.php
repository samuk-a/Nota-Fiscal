<?php
/**
 * Version
 */
class Version
{
  public $version;
  public $file;
  public $size;
  public $experimental;
  public $uploaded;

  public function __construct($version, $file, $size, $experimental = false) {
    $this->version = $version;
    $this->file = $file;
    $this->size = $size;
    $this->experimental = $experimental;
  }

  public static function getVersions() {
    $db = new DB('tb_versoes');
    $versions = $db->selectAll(['experimental'=>false], ['uploaded' => 'DESC']);
    $return = [];
    $i = 0;
    foreach ($versions as $version) {
      if ($i == 2) break;
      $return[] = $version;
      $i++;
    }
    $exp = $db->selectOne(['experimental'=>true], ['uploaded' => 'DESC']);
    if ($exp) $return[] = $exp;
    return $return;
  }

  public function save() {
    $db = new DB('tb_versoes');
    $data = [
      'versao' => $this->version,
      'arquivo' => $this->file,
      'tamanho' => $this->size,
      'experimental' => $this->experimental
    ];
    $last = $db->create($data);
    return $last != 0;
  }
}

?>
