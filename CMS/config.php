<?php
ob_start();
ini_set("display_errors", true);
date_default_timezone_set("Europe/Kiev");
define( "DB_DSN", "mysql:host=localhost;dbname=cms;charset=utf8" );
define("DB_USERNAME", "mysql" );
define("DB_PASSWORD", "mysql" );
define("CLASS_PATH", "classes" );
define("TEMPLATE_PATH", "templates" );
define("HOMEPAGE_NUM_ARTICLES", 5 );
define("ADMIN_USERNAME", "mysql" );
define("ADMIN_PASSWORD", "mysql" );
require (CLASS_PATH . "/Article.php" );
require( CLASS_PATH . "/Category.php" );


function handleException( $exception )
{
    echo "Sorry, a problem occurred. Please try later.";
    error_log( $exception->getMessage() );
}

set_exception_handler('handleException');

