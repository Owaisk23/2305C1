<?php 
include ("../include/header.php");
require("../include/connection.php");

if(isset($_POST['resetpass']) && $_SERVER['REQUEST_METHOD']=="POST"){
  $password= mysqli_real_escape_string($connection, $_POST['password']);
  $cpassword= mysqli_real_escape_string($connection, $_POST['cpassword']);
  
  if(isset($_GET['token'])){
    $token=$_GET['token'];
  }else{
    $token="";
  }
  if(isset($_GET['email'])){
    $email=$_GET['email'];
  }else{
    $email="";
  }

   $check="SELECT * FROM users WHERE email='$email' AND token='$token';";
   $result=mysqli_query($connection , $check) or die("failed to insert query.");

if(mysqli_num_rows($result) > 0){
$row=mysqli_fetch_assoc($result);
if(!$password=="" && !$cpassword=="" && $password==$cpassword){
    $newtoken=md5(rand());
    $hashpass=password_hash($password,PASSWORD_BCRYPT);


$updatePass="UPDATE `users` SET `password`='$hashpass',`token`='$newtoken' WHERE  email='$email' ;";
$updatePass_run=mysqli_query($connection , $updatePass) or die("failed to insert query.");
if($updatePass_run){
 echo"<script>alert('Your password has been updated. You can now login with your new password')
    window.location.href='login.php';
    </script>;";
}
else{
    echo"<script>alert('Something went wrong. Please try again later.')</script>;";
}
}
else{
    echo"<script>alert('Passwords should match and must not be empty.')</script>;";
}
}
else{
     echo "<script>alert('Invalid token.')
       window.location.href='login.php';</script>;";
}
}
?>
<body>
    <div class="container my-4">
    <h1 class="text-center">Enter New Password</h1>
<form action="" method="post" class="form-group">
<input type="password" name="password" id="" class="form-control my-2" placeholder="Enter a strong password">
<input type="password" name="cpassword" id="" class="form-control my-2" placeholder="Confirm your password">

<input type="submit" name="resetpass" id="" class="form-control btn btn-dark my-2">
</form>
</div>
</body>
</html>
