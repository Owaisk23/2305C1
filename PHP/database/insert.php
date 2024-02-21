<?php 
// include ("connection.php");
require("connection.php");

if(isset($_POST['Add'])){

 $name=$_POST['name'];
 $contact=$_POST['contact'];
 $city=$_POST['city'];
 
$insert = "INSERT INTO `student`(`name`, `contact`, `city`) VALUES ('$name','$contact','$city');";
$result = mysqli_query($connection , $insert) or die("failed to insert query.");
if($result){
   echo "<script>alert('Student`s Details added.')</script>;";
}
else{
    echo "<script>alert('Sorry, Failed to insert this record.')</script>";
}
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</head>
<body>
    <div class="container my-4">
    <h1 class="text-center">Enter Student Details</h1>
<form action="" method="post" class="form-group">
<input type="text" name="name" id="" class="form-control my-2" placeholder="Enter student name">
<input type="number" name="contact" id="" class="form-control my-2" placeholder="Enter student contact no">
<input type="text" name="city" id="" class="form-control my-2" placeholder="Enter student city">
<input type="submit" name="Add" id="" class="form-control btn btn-primary my-2">
</form>
</div>
</body>
</html>