<html>
<head>
    <title>Profile - Admin Panel</title>
</head>
<body>

<?php include 'connect.php'; ?>

<?php include 'functions.php'; ?>

<?php include 'title_bar.php'; ?>


<h3>Admin Panel System</h3>


<?php
if ($user_level != 1){
    header('Location: profile.php');
}
?>

<p>
<a href='admin.php?type=user'>User Settings</a> |
<a href=''>Level Settings</a>
</p>


<p>
<?php
    if(isset($_GET['type']) && !empty($_GET['type'])){
  ?>
<table>
    <tr><td width='150px'>Users</td><td>Options</td></tr>

    <?php
     $list_query = mysqli_query("SELECT id, username, type FROM users");
    while ($run_list = mysqli_fetch_array($list_query)){
        $u_id = $run_list['id'];
        $u_username = $run_list['username'];
        $u_type = $run_list['type'];
    ?>
    <tr><td><?php echo $u_username?></td><td>


    <?php
    if ($u_type == 'a'){
    echo "<a href='option.php'?u_id=$u_id&type=$u_type'>Deactivate</a>";
    } else{
    echo "<a href ='option.php'?u_id=$u_id&type=$u_type'>Activate</a>";
    }
    ?>
    </td></tr>
    <?php
    }
    ?>

</table>
<?php
}else{
        echo "Select Options Above ! ";
    }

?>
</p>
</body>
</html>