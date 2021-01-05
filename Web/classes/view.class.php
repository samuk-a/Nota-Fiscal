<?php
class View
{
  protected $file;
  protected $data = [];
  protected $includes = [];
  private static $baseview = 'views';

  public function __construct($file, array $data = [], array $includes = []) {
    $this->file = $file;
    $this->data = $data;
    $this->includes = $includes;
  }

  public function render() {
    return $this->createClosureContext();
  }

  public static function e404() {
    header("HTTP/1.0 404 Not Found");
  }

  protected function createClosureContext() {
    $caller = function ($file, array $data, array $includes) {
      ob_start();
      extract($data);
      $file = 'views/'.$file.'.php';
      if (!file_exists($file))
        self::e404();
      else {
        asort($includes);
        foreach ($includes as $include => $priority) {
          if ($priority < 50)
            include_once 'views/includes/'.$include.'.php';
        }
        include_once $file;
        foreach ($includes as $include => $priority) {
          if ($priority > 50)
            include_once 'views/includes/'.$include.'.php';
        }
      }

      return ob_get_clean();
    };
    return $caller->bindTo($this->createObjectContext())->__invoke($this->file, $this->data, $this->includes);
  }

  protected function createObjectContext() {
    $object = new StdClass;
    $object->Html = (object) 'Simulate instance';
    return $object;
  }
}

?>
