<?php 
include "../include/header.php";
require "../include/connection.php";

if(isset($_POST['submit']) && $_SERVER['REQUEST_METHOD']=="POST"){

$name=$_POST['name'];
$price=$_POST['price'];
$description=$_POST['description'];
$category_id=$_POST['category_id'];

if($_FILES['image']['error'] ==4){
    echo "
    <script>alert('Image not found')</script>";
}else{

$imgname=$_FILES['image']['name'];
$tmpname=$_FILES['image']['tmp_name'];
$size=$_FILES['image']['size'];

$validExtensions=["png","jpg","jpeg"];
// abc.jpg
$extension= explode(".",$imgname);// ["abc", "jpg"]
// print_r($extension);
$extension= strtolower(end($extension));//jpg

if($size > 1000000){
    echo "<script>alert('File too large')</script>";
}elseif(!in_array($extension, $validExtensions)){
    echo "<script>alert('File type not supported')</script>";
}else{

$insert="INSERT INTO `clothes`( `name`, `description`, `price`, `image`, `category_id`) VALUES  ('$name','$description','$price','$imgname','$category_id')";
$result=mysqli_query($connection, $insert) or die("failed");
if($result){
    move_uploaded_file($tmpname, "images/".$imgname);
    echo "<script>alert('Outfit registered succesfully')</script>";
}
}
}
}
?>
<body>
    <?php 
    include("./nav.php");
    ?>
<div class="container" style="margin-top:120px;">
        <h1 class="text-center display-3 fw-semibold">Add Outfit</h1>

<form action="" method="post" enctype="multipart/form-data">
<input class="form-control my-3" type="text" name="name" id="name" placeholder="Enter name">
<input class="form-control my-3" type="text" name="description" id="description" placeholder="Enter description">
<input class="form-control my-3" type="number" name="price" id="price" placeholder="Enter price">
<input class="form-control my-3" type="file" name="image" id="image" accept=".jpg, .png, .jpeg" >
<select name="category_id" id="category_id" class="form-control my-3" >
    <option value="" disabled selected>Choose category</option>
<?php 
$getCategories="SELECT * from category;";
$getCategories_run=mysqli_query($connection, $getCategories) or die("failed to get categories");
if(mysqli_num_rows($getCategories_run) > 0){
    while($category=mysqli_fetch_assoc($getCategories_run)){
        echo'<option value="'.$category['category_id'].'" >'.$category['category_name'].'</option>';
    }
}


?>

</select>
<input class="form-control my-3 btn btn-dark" type="submit" name="submit" value="ADD">
</form>
    </div>
    <?php 
    
    include("./footer.php");
    ?>
</body>
</html>