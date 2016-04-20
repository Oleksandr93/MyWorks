<?php


class Router
{
    private $routes;

    public function __construct()
    {
        $routerPath = ROOT . '/config/routes.php';
        $this->routes = include($routerPath);
    }


    /**
     * Returns request string
     */
    private function getURL()
    {
        if (!empty($_SERVER['REQUEST_URL'])) {
            return trim($_SERVER['REQUEST_URL'], '/');
        }
    }


    public function run()
    {
        // Получить строку запроса
        $uri = $this->getURL();


        // Проверить наличие такого запроса в routes.php
        foreach ($this->routes as $uriPattern => $path) {
            // Сравниваем $urlPattern и $url
            if (preg_match("~$uriPattern~", $uri)) {
                echo '<br>Где ищем (запрос который набрал пользователь): ', $uri;
                echo '<br>Что ищем(совпадение из правила)): ', $uriPattern;
                echo '<br>Кто обрабатывает: ' . $path;


                // Получаем внтренныий путь из внешнего согласно правилу.
                $internalRoute = preg_replace("~uriPattern~", $path, $uri);

                echo '<br><br>Нужно сформировать:' . $internalRoute;

                // Определить контроллер, action, параметры

                $segments = explode('/', $internalRoute);

                $controllerName = array_shift($segments) . 'Controller';
                $controllerName = ucfirst($controllerName);

                $actionName = 'action' . ucfirst(array_shift($segments));

                echo '<br>controller name: ' . $controllerName;
                echo '<br>action name: ' . $actionName;
                $parameters = $segments;
                echo '<pre>';
                print_r($parameters);


                die;


                // Подключить файл класса-контроллера
                $controllerFile = ROOT . '/controllers/' .
                    $controllerName . ' .php';

                if (file_exists($controllerFile)) {
                    include_once($controllerFile);
                }


                // Создать обьект, вызвать метод(т.е. action)
                $controllerObject = new $controllerName;

                $result = call_user_func_array(array($controllerObject, $actionName), $parameters);

                if ($result != null) {
                    break;
                }
            }
        }
    }
}






