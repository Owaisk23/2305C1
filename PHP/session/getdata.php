<?php 

session_start();

if(isset($_SESSION['username'])){
echo "<h1>Welcome ".ucwords($_SESSION['username'])." to Our Website</h1>";
echo "<h3>Your Password is ".$_SESSION['password']."</h3>";

?>
<a href="./end.php">LOGOUT</a>

<?php 

}
else{
header("Location: start.php");
    // echo "Please <a href='./start.php'>Login</a>  to continue.";
}
?>
