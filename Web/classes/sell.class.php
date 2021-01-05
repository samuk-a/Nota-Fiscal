<?php
/**
 * Sell
 */
class Sell
{
  public static function getMonth($year) {
    $db = new DB('tb_vendas');
    $sells = $db->selectAll(['YEAR(data_venda)' => $year], ['data_venda' => 'ASC']);
    $return = [];
    for ($month = 0, $i = 0; $i < count($sells);) {
      if (date_format(date_create($sells[$i]['data_venda']), 'm') > $month) {
        $month++;
        continue;
      }
      $return['num'][$month] = ($return['num'][$month] ?? 0) + 1;
      $return['total'][$month] = ($return['total'][$month] ?? 0) + $sells[$i]['total'];
      $i++;
    }
    return $return;
  }
}

?>
