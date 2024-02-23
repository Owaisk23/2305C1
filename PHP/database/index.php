<?php 
include "header.php";
$server="localhost";
$username="root";
$dbpass="";
$dbname="2305c1";

$connection=mysqli_connect($server,$username,$dbpass,$dbname);
if($connection){
 
// echo "Connected SUCCESSFULLY"
$read="SELECT * FROM `student`;";
$result=mysqli_query($connection,$read);
if($result){
if(mysqli_num_rows($result) > 0){

?>
<table class="table">
  <thead>
    <tr>
      <th scope="col">ID</th>
      <th scope="col">Student Name</th>
      <th scope="col">Contact</th>
      <th scope="col">City</th>
      <th scope="col">Actions</th>
    </tr>
  </thead>
  <tbody>   
<?php   
while($row=mysqli_fetch_assoc($result)){

    echo "<tr>";
    echo "<td scope='row'>".$row['id']."</td>"; //id
    echo "<td>".$row['name']."</td>"; //name
    echo "<td>".$row['contact']."</td>"; //contact
    echo "<td>".$row['city']."</td>"; //city
    // echo '<td>
    // <a href="update.php?id='.$row["id"].'" class="btn btn-success px-2 mx-2">Edit</a>
    // <a href="delete.php?id='.$row["id"].'" class="btn btn-danger">Delete</a>
    // </td>';
    echo '<td>
    <a href="#" class="btn btn-success px-2 mx-2">Edit</a>
    <a href="#" class="btn btn-danger">Delete</a>
    </td>'; //action
    echo "</tr>";
    
}
?>
</tbody>
</table>
<?php
}
else{
    echo "<script>alert('record not found')</script>";
}
}else{
echo "<script>alert('Failed to execute query')</script>";
}

}else{
    die("Failed to connect");

}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
</body>
</html>