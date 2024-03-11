<?php 
include ("../include/header.php");
require("../include/connection.php");
if(isset($_POST['signin']) && $_SERVER['REQUEST_METHOD']=="POST"){
   $email= mysqli_real_escape_string($connection, $_POST['email']);
  $password= mysqli_real_escape_string($connection, $_POST['password']);
   $check="SELECT * FROM users WHERE email='$email';";
   $result=mysqli_query($connection , $check) or die("failed to insert query.");
if($result){
if(mysqli_num_rows($result) == 1){
$row=mysqli_fetch_assoc($result);
$regUsername=$row['username'];
$regEmail=$row['email'];
$regPass=$row['password'];//hash
$verifyPass=password_verify($password, $regPass);
if($verifyPass){
    session_start();
    $_SESSION['email']=$regEmail;
    $_SESSION['username']=$regUsername;
       echo "<script>alert('Successfully logged in.')
       window.location.href='home.php';</script>";  
}else{
    echo "<script>alert('Invalid Credentials.')</script>;";
}
}
else{
     echo "<script>alert('Pehle account bana kr aao.')
       window.location.href='signup.php';</script>;";
}
}}
?>
<body>
    <div class="container my-4">
    <h1 class="text-center">Log In</h1>
<form action="" method="post" class="form-group">
<input type="email" name="email" id="" class="form-control my-2" placeholder="Enter email">
<input type="password" name="password" id="" class="form-control my-2" placeholder="Enter a strong password">
<a href="forgetpass.php">Forget your password?</a>
<input type="submit" name="signin" id="" class="form-control btn btn-dark my-2">
</form>
</div>
</body>
</html>
