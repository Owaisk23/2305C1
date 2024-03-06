<?php 

$server="localhost";
$username="root";
$dbpass="";
$dbname="2305c1";

$connection=mysqli_connect($server,$username,$dbpass,$dbname);
if(!$connection){
    die("Failed to connect");
}
// else{
//     echo"connected";
// }
?>