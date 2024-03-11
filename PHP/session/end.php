<?php 
session_start();
session_unset();
session_destroy();

echo "Your  have been logged out. Please go to start file again";
header("Location: start.php");
?>

<a href="./start.php">Click here to start again</a>