<?php

include 'connect.php';

include 'functions.php';

$u_id = $_GET['u_id'];
$type = $_GET['type'];

if ($type == 'a') {

    mysqli_query("UPDATE 'users' SET 'type' ='d' WHERE 'id' = '$u_id'");
    header('Location: admin.php?type=user');

}else if($type == 'd') {
    mysqli_query("UPDATE 'users' SET 'type' ='a' WHERE 'id' ='$u_id'");
    header('Location: admin.php?type=user');
}