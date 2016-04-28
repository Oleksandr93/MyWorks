<html>
<head>
    <title>Register - Admin Panel</title>
</head>
<body>

<?php include 'connect.php'; ?>

<?php include 'functions.php'; ?>

<?php include 'title_bar.php'; ?>

<h3>Login Here :</h3>


<form method='post'>

    <?php

    if(isset($_POST['submit'])){
        $username = $_POST['username'];
        $password = md5($_POST['password']);

        if(empty($username) or empty($password)){
            echo "<p>Fields Empty!</p>";
        } else {
           $check_login = mysqli_query("SELECT id, type FROM users WHERE username= '$username' 
AND password= '$password'");
            if (mysqli_num_rows($check_login == 1)){
                $run = mysqli_fetch_array($check_login);
                $user_id = $run['id'];
                $type = $run['type'];
                if ($type == 'd')
                {
                    echo "<p>Your account is deactivated by the site Admin.</p>";
                }
                else{
                    $_SESSION['user_id'] = $user_id;
                    header('Location: index.php');
                }
            } else {
                echo "<p>User Name or Password incorrect !</p>";
            }
        }
    }

    ?>
    User Name : <br />
    <input type='text' name='username' />
    <br/><br/>

    Password : <br />
    <input type='password' name='password' />
    <br/><br/>
    <input type='submit' name='submit'  value='Login' />
</form>
</body>
</html>