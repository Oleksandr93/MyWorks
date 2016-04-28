<?php

session_start();

function loggedin()
{
    if (isset($_SESSION['user_id']) && !empty($_SESSION['user_id']))
    {
        return true;
    } else    {
        return false;
    }
}

if(loggedin()){
    $my_id = $_SESSION['user_id'];
    $user_query = mysqli_query("SELECT username, user_level FROM users WHERE id='$my_id'");
    $run_user = mysqli_fetch_array($user_query);
    $username = $run_user['username'];
    $user_level = $run_user['user_level'];
    $query_level = mysqli_query("SELECT name FROM user_level WHERE  id='$user_level'");
    $run_level = mysqli_fetch_array($query_level);
    $level_name = $run_level['name'];
}
