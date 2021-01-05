<?php
class Router
{
  private static $routes = array();
  private static $pathNotFound = null;
  private static $methodNotAllowed = null;

  private static function add($expression, $function, $method = 'get') {
    array_push(self::$routes, array(
      'expression'=>$expression,
      'function'=>$function,
      'method'=>$method
    ));
  }

  public static function get($expression, $function) {
    self::add($expression, $function, 'get');
  }

  public static function post($expression, $function) {
    self::add($expression, $function, 'post');
  }

  public static function pathNotFound($function) {
    self::$pathNotFound = $function;
  }

  public static function methodNotAllowed($function) {
    self::$methodNotAllowed = $function;
  }

  public static function run($basepath = '/') {
    $parsed_url = parse_url($_SERVER['REQUEST_URI']);

    $path = isset($parsed_url['path']) ? $parsed_url['path'] : '/';
    $method = $_SERVER['REQUEST_METHOD'];
    $path_match_found = false;
    $route_match_found = false;
    foreach (self::$routes as $route) {
      if ($basepath != '' && $basepath != '/') {
        $route['expression'] = '('.$basepath.')'.$route['expression'];
      }
      $route['expression'] = '^'.$route['expression'].'$';
      if (preg_match('#'.$route['expression'].'#', $path, $matches)) {
        $path_match_found = true;
        if (strtolower($method) == strtolower($route['method'])) {
          array_shift($matches);
          if ($basepath != '' && $basepath != '/') {
            array_shift($matches);
          }
          call_user_func_array($route['function'], $matches);
          $route_match_found = true;
          break;
        }
      }
    }
    if (!$route_match_found) {
      if ($path_match_found) {
        header("HTTP/1.0 405 Method Not Allowed");
        if(self::$methodNotAllowed){
          call_user_func_array(self::$methodNotAllowed, array($path, $method));
        }
      } else {
        header("HTTP/1.0 404 Not Found");
        if(self::$pathNotFound) {
          call_user_func_array(self::$pathNotFound, array($path));
        }
      }
    }
  }
}

?>
