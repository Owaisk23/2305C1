<?php 


?>

<form action="start.php" method="post">

<input type="text" name="username" id="" placeholder="enter your name">
<input type="password" name="password" id="" placeholder="enter your password">
<input type="submit" value="login" name="login">
</form>
<?php
if(isset($_POST['login'])){

    session_start();
$_SESSION['username']=$_POST['username'];
$_SESSION['password']=$_POST['password'];

header("Location: getdata.php");

}

?>