<?php 
include ("../include/header.php");
require("../include/connection.php");

if(isset($_POST['signup'])){
    //prevent sql injection real escape string
   $username= mysqli_real_escape_string($connection, $_POST['username']);//   \<\?php
   $email= mysqli_real_escape_string($connection, $_POST['email']);
   $password= mysqli_real_escape_string($connection, $_POST['password']);

  $encrypedPassword=password_hash($password, PASSWORD_BCRYPT);
//  echo  $encrypedPassword=MD5($password);
$check="SELECT * FROM users WHERE email='$email';";
$res=mysqli_query($connection,$check) or die("failed");

if(mysqli_num_rows($res) > 0){
    echo "<script>alert('Already registered. Please Login Now..!.')
    window.location.href='login.php';
    </script>;";
}
else{
   $insert="INSERT INTO `users`( `username`, `email`, `password`) VALUES ('$username','$email','$encrypedPassword');";
   $result=mysqli_query($connection , $insert) or die("failed to insert query.");
if($result){
   echo "<script>alert('Account Succesfully Created.')
   window.location.href='login.php';
   </script>;";
}
else{
    echo "<script>alert('Failed to Create your account.')</script>";
}}
}
?>
<body>
    <div class="container my-4">
    <h1 class="text-center">Signup</h1>
<form action="" method="post" class="form-group">
<input type="text" name="username" id="" class="form-control my-2" placeholder="Enter username">
<input type="email" name="email" id="" class="form-control my-2" placeholder="Enter email">
<input type="password" name="password" id="" class="form-control my-2" placeholder="Enter a strong password">
<input type="submit" name="signup" id="" class="form-control btn btn-primary my-2">
</form>
</div>
</body>
</html>