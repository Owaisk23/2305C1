<?php 

// print_r($_POST);
require("connection.php");

 $id=$_POST['id'];
 $name=$_POST['name'];
 $contact=$_POST['contact'];
 $city=$_POST['city'];
 
$update="UPDATE `student` set `name`='$name',`contact`='$contact',`city`='$city' WHERE id= '$id';";



$result=mysqli_query($connection , $update) or die("failed to insert query.");
if($result){
   echo "<script>alert('Student`s Details Updated.')</script>;";
   header("location: index.php");
}
else{
    echo "<script>alert('Sorry, Failed to update this record.')</script>";
}

?>