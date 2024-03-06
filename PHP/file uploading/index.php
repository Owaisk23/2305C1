<?php 
include "../include/header.php";
require "../include/connection.php";

if(isset($_POST['submit']) && $_SERVER['REQUEST_METHOD']=="POST"){
echo $name=$_POST['name'];
echo $price=$_POST['price'];
// echo"<pre>";
// print_r($_FILES['image']);
// echo"</pre>";
if($_FILES['image']['error'] == 4){
    echo "
    <script>alert('Image not found')</script>";
}else{

$imgname=$_FILES['image']['name'];
$tmpname=$_FILES['image']['tmp_name'];
$size=$_FILES['image']['size'];

$validExtensions=["png","jpg","jpeg"];
// tecno.jpg
$extension= explode(".",$imgname);// ["tecno", "jpg"]
// print_r($extension);
$extension= strtolower(end($extension));//jpg

if($size > 1000000){
    echo "<script>alert('File too large')</script>";
}elseif(!in_array($extension, $validExtensions)){
    echo "<script>alert('File type not supported')</script>";
}else{
$newimgname = uniqid().".".$extension;//4545gh45rt454242.jpg
$insert="INSERT INTO `mobiles`( `name`, `price`, `image`) VALUES ('$name','$price','$newimgname')";
$result=mysqli_query($connection, $insert) or die("failed");
if($result){
    move_uploaded_file($tmpname, "images/".$newimgname);
    echo "<script>alert('Product registered succesfully')</script>";
}
}
}
}
?>
<body>
<div class="container">
        <h1 class="text-center display-3 fw-semibold">PRODUCT REGISTERATION</h1>

<form action="" method="post" enctype="multipart/form-data">
<input class="form-control my-3" type="text" name="name" id="name" placeholder="Enter mobile's name">
<input class="form-control my-3" type="number" name="price" id="price" placeholder="Enter mobile's price">
<input class="form-control my-3" type="file" name="image" id="image" accept=".jpg, .png, .jpeg" >
<input class="form-control my-3 btn btn-success" type="submit" name="submit" value="ADD">
</form>
    </div>
    <img src="./images/65e820de42e92.jpg" alt="">
</body>
</html>