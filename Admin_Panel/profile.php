<html>
<head>
    <title>Profile - Admin Panel</title>
</head>
<body>

<?php include 'connect.php'; ?>

<?php include 'functions.php'; ?>

<?php include 'title_bar.php'; ?>


<h3>Profile- Admin Panel System</h3>


<p>You are logged in as <b><?php echo $username ?></b>< [ <?php echo $level_name ?> ]/p>

<p>

    <?php
        if($user_level == 1){
            echo "<a href='admin.php'>Admin Panel</a>";
        }
    ?>

</p>


</body>
</html>