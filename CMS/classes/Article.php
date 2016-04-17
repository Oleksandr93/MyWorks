<?php

/*
    Класс для обработки статей
*/

class Article
{
    // Свойства

    /**
     * @var int ID статей из базы данных
     */

    public $id = null;

    /**
     * @var int Дата первой публикации статьи
     */

    public $publication_Date = null;

    /**
     * @var int ID категории статьи
     */
    public $categoryId = null;

    /**
     * @var string Полное название статьи
     */

    public $title = null;

    /**
     * @var string Краткое описание статьи
     */

    public $summary = null;

    /**
     * @var string HTML содержание статьи
     */

    public $content = null;




    /**
     * Устанавливаем свойства с помощью значений в заданном массиве
     *
     * @params assoc Значение свойств
    */

    public function  __construct( $data = array() )
    {
        if ( isset( $data['id'])) $this->id = (int) $data['id'];
        if( isset( $data['publication_Date'] ) )
            $this->publication_Date = (int) $data['publication_Date'];
        if ( isset( $data['categoryId'] ) )
            $this->categoryId = (int) $data['categoryId'];
        if ( isset( $data['title'] ) ) $this->title =
            preg_replace ( "/[^\.\,\-\_\'\"\@\?\!\:\$ а-яА-ЯёЁa-zA-Z0-9()]/", "", $data['title'] );
        if ( isset( $data['summary'] ) ) $this->summary =
            preg_replace ( "/[^\.\,\-\_\'\"\@\?\!\:\$ а-яА-ЯёЁa-zA-Z0-9()]/", "", $data['summary'] );
        if (isset( $data['content'] ) ) $this->content = $data['content'];
    }



    /**
     * устанавливаем свойства с помощью значений формы
     * редактирования записи в заданном массиве
     *
     *@params assoc Значение записи формы
     */

    public function storeFormValues ( $params )
    {
        // Сохраняем все параметры
        $this->__costruct( $params );

        // разбираем и сохраняем дату публикации
        if ( isset($params['publication_Date'] ) )
        {
            $publication_Date = explode ('-'. $params['publication_Date'] );

            if ( count($publication_Date) == 3)
            {
                list ($y, $m, $d) = $publication_Date;
                $this->publication_Date = mktime(0, 0, 0, $m, $d, $y);
            }
        }
    }


    /**
     * Возвращаем обьект статьи соответсвующий заданному ID стать
     *
     * @params int ID статьи
     * @return Article|false Обьект статьи или false, если запись не найдена или возникли проблемы
     */


    public static function getById( $id )
    {
        $conn = new PDO(DB_DSN, DB_USERNAME, DB_PASSWORD );
        $sql = "SELECT *, UNIXTIMESTAMP(publication_Date) AS publication_Date FROM articles WHERE id = :id";
        $st = $conn->prepare( $sql );
        $st->bindValue( ":id", $id, PDO::PARAM_INT );
        $st->execute();
        $row = $st->fetch();
        $conn = null;
        if ( $row ) return new Article( $row );
    }


    /**
     * Возвращает все (или диапазон) обьектов статей в базе данных
     *
     * @params int Optional Количество строк (по умолчанию все)
     * @params string Optional Столбец по которому производится сортировка статей(по умолчанию "publication_Date DESC")
     * return Array|false Двух элементный массив: results=> массивб список обьектов статей;
     * totalRows => общее количество статей
     */

    public static function  getList( $numRows = 100000, $categoryId=null, $order = "publication_Date DESC" )
    {
        $conn = new PDO( DB_DSN, DB_USERNAME, DB_PASSWORD );
        $categoryClause = $categoryId ? "WHERE categoryId = :categoryId" : "";
        $sql = "SELECT SQL_CALC_FOUND_ROWS *, UNIX_TIMESTAMP(publication_Date) AS publication_Date
            FROM articles $categoryClause
            ORDER BY " . mysql_escape_string($order) . " LIMIT :numRows";

        $st = $conn->prepare( $sql );
        $st->bindValue( ":numRows", $numRows, PDO::PARAM_INT );
        if ( $categoryId ) $st->bindValue( ":categoryId", $categoryId, PDO::PARAM_INT );
        $st->execute();
        $list = array();

        while ( $row = $st->fetch() )
        {
            $article = new Article( $row );
            $list[] = $article;
        }



        // Получаем общее количество статей, которые соответствуют критерию
        $sql = "SELECT FOUND_ROWS() AS totalRows";
        $totalRows = $conn->query( $sql )->fetch();
        $conn = null;
        return ( array( "results" =>$list, "totalRows"=> $totalRows[0] ) );
    }


    /**
     * Вставляем текущий обьект статьи в базу данных, устанавливаем его свойства
     *
     */

    public function Insert()
    {
        // Есть у обьекта статьи ID?
        if ( !is_null( $this->id ) ) trigger_error(
            "Article::insert(): Attempt to insert an Article object that already has its ID property set 
            (to $this->id).", E_USER_ERROR);

        // Вставляем статью
        $conn = new PDO(DB_DSN, DB_USERNAME, DB_PASSWORD );
        $sql = "INSERT INTO articles ( publication_Date, categoryId, title, summary, content ) VALUES 
( FROM_UNIXTIME(:publication_Date), :categoryId, :title, :summary, :content )";
        $st = $conn->prepare( $sql );
        $st->bindValue( ":publication_Date", $this->publication_Date, PDO::PARAM_INT );
        $st->bindValue( ":categoryId", $this->categoryId, PDO::PARAM_INT );
        $st->bindValue( ":title", $this->title, PDO::PARAM_STR );
        $st->bindValue( ":summary", $this->summary, PDO::PARAM_STR );
        $st->bindValue( ":content", $this->content, PDO::PARAM_STR );
        $st->execute();
        $this->id = $conn->lastInsertId();
        $conn = null;
    }


    /**
     * Обновляем текущий обьект статьи в базе данных
     */

    public function update()
    {
        // есть ли у обьекта статьи ID
        if ( is_null( $this->id ) ) trigger_error(
            "Article::update(): Attempt to update an Article object that does not have 
            its ID property set.", E_USER_ERROR );

        // Обновляем статью
        $conn = new PDO( DB_DSN, DB_USERNAME, DB_PASSWORD );
        $sql = "UPDATE articles SET publication_Date=FROM_UNIXTIME(:publication_Date), 
categoryId=:categoryId, title=:title, summary=:summary, content=:content WHERE id = :id";
        $st = $conn->prepare( $sql );
        $st->bindValue( ":publication_Date", $this->publication_Date, PDO::PARAM_INT );
        $st->bindValue( ":categoryId", $this->categoryId, PDO::PARAM_INT );
        $st->bindValue( ":title", $this->title, PDO::PARAM_STR );
        $st->bindValue( ":summary", $this->summary, PDO::PARAM_STR );
        $st->bindValue( ":content", $this->content, PDO::PARAM_STR );
        $st->bindValue( ":id", $this->id, PDO::PARAM_INT );
        $st->execute();
        $conn = null;
    }


    /**
     * Удаляем текущий обьект статьи из базы данных
     */

    public function delete()
    {
        // Есть ли у обьекта статьи ID?
        if ( is_null( $this->id ) ) trigger_error
        ("Article::delete():Attempt to delete an Article object that does not have its
        ID property set.", E_USER_ERROR );

        // Удаляем статью
        $conn = new PDO( DB_DSN, DB_USERNAME, DB_PASSWORD );
        $st = $conn->prepare ( "DELETE FROM articles WHERE id = :id LIMIT 1" );
        $st->bindValue( ":id", $this->id, PDO::PARAM_INT );
        $st->execute();
        $conn = null;
    }
}
