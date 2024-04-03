<?php 
include("../include/header.php");
include("../include/connection.php");
include("./nav.php");


?>
<style>
.card:hover{
    box-shadow: rgba(0, 0, 0, 0.4) 0px 2px 4px, rgba(0, 0, 0, 0.3) 0px 7px 13px -3px, rgba(0, 0, 0, 0.2) 0px -3px 0px inset;
}

</style>
<div class="container my-4" >
    <div class="row" style="margin-top:150px;">
<?php 

if(isset($_GET['p_id'])){
$p_id=$_GET['p_id'];

    $getClothesByCategory="SELECT * FROM `clothes` as c inner join `category` as cat on c.category_id=cat.category_id
     where c.id='$p_id'
     ORDER by c.id DESC;";
    $getClothesByCategory_run=mysqli_query($connection, $getClothesByCategory) or die("failed");
    if(mysqli_num_rows($getClothesByCategory_run) > 0){
    while($cloth=mysqli_fetch_assoc($getClothesByCategory_run)){
        $id=$cloth['id'];
        echo'<div class="col-lg-6 col-md-6 col-sm-12">
  <img src="images/'.$cloth['image'].'" class="card-img-top" alt="..." height=400></div>
  <div class="col-lg-6 col-md-6 col-sm-12">
  <div class="card-body">
    <h5 class="card-title">'.$cloth['name'].'  <span class="badge text-bg-danger">'.$cloth['category_name'].'</span></h5>
    <p class="card-text">'.$cloth['description'].'</p>
    <p class="card-text">'.$cloth['price'].' PKR</p>
    <form action="" method="post">
<input type="number" name="qty" id="qty" placeholder="Enter quantity">
<input type="submit" class="btn btn-outline-danger" name="addtocart"value="Add to cart">
</form> 
  </div>
  </div>
 
        ';

        if(isset($_POST['addtocart'])){
$price=$cloth['price'];
$qty=$_POST['qty'];
$total=$price * $qty;

if($qty <= 0){
    echo '<script>alert("Please add one or more in quantity.")
    window.location.href="productdetails.php?p_id='.$id.'";
    </script>';
}else{
$addtoCart="INSERT INTO `cart`(`p_id`, `qty`, `price`, `total`) VALUES ('$p_id','$qty','$price','$total')";
            $addtoCart_run=mysqli_query($connection, $addtoCart) or die("failed to add");
            if($addtoCart_run){
                    echo '<script>alert("Product added to cart successfully.")
                    window.location.href="index.php";
                    </script>';
            }else{
                      echo '<script>alert("Failed to add product in cart.")
                    window.location.href="index.php";
                    </script>';
            }
        }
    }
} 
    }
}else{
    header("location: index.php");
}
?>
    </div>
</div>

<?php 
include("./footer.php");
?>
