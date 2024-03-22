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
<!-- buttons -->
<div class="container" style="margin-top:120px;">
<?php 
if(isset($_GET['cat_id'])){
    $active="";
}else{
    $active="active";

}
?>


<div class="d-flex justify-content-center">
<a href="index.php" class="btn btn-outline-dark <?=$active?> mx-2">ALL</a>
<?php 
$getCategories="SELECT * from category;";
$getCategories_run=mysqli_query($connection, $getCategories) or die("failed to get categories");
if(mysqli_num_rows($getCategories_run) > 0){
    while($category=mysqli_fetch_assoc($getCategories_run)){
        $active_category="";
        if(isset($_GET['cat_id'])){
            if($_GET['cat_id']==$category['category_id']){

                $active_category="active";

            }else{
                $active_category="";
            }


        }
        echo'<a href="index.php?cat_id='.$category['category_id'].'" class="btn btn-outline-dark '.$active_category.' mx-2" >'.$category['category_name'].'</a>';
    }
}

?>
</div>


</div>
<!-- buttons end -->
<div class="container my-4">
    <div class="row">
<?php 

if(isset($_GET['cat_id'])){
$cat_id=$_GET['cat_id'];

    $getClothesByCategory="SELECT * FROM `clothes` as c inner join `category` as cat on c.category_id=cat.category_id
     where c.category_id='$cat_id'
     ORDER by c.id DESC;";
    $getClothesByCategory_run=mysqli_query($connection, $getClothesByCategory) or die("failed");
    if(mysqli_num_rows($getClothesByCategory_run) > 0){
    while($cloth=mysqli_fetch_assoc($getClothesByCategory_run)){
        $id=$cloth['id'];
        echo'
        <div class="col-lg-4 col-md-6 col-sm-12">
        <div class="card" >
  <img src="images/'.$cloth['image'].'" class="card-img-top" alt="..." height=400>
  <div class="card-body">
 
    <h5 class="card-title">'.$cloth['name'].'  <span class="badge text-bg-danger">'.$cloth['category_name'].'</span></h5>
    <p class="card-text">'.$cloth['description'].'</p>
    <p class="card-text">'.$cloth['price'].'</p>
   

    <a href="productdetails.php?p_id='.$id.'" class="btn btn-outline-danger">Add to cart</a>
  </div>
</div>
        </div>
        
        ';
    }
}
}else{
    // echo "get all";
    $getAllClothes="SELECT * FROM `clothes` as c inner join `category` as cat on c.category_id=cat.category_id ORDER by c.id DESC;";
    $getAllClothes_run=mysqli_query($connection, $getAllClothes) or die("failed");
    if(mysqli_num_rows($getAllClothes_run) > 0){
        while($cloth=mysqli_fetch_assoc($getAllClothes_run)){
        $id=$cloth['id'];
        echo'
        <div class="col-lg-4 col-md-6 col-sm-12">
        <div class="card" >
  <img src="images/'.$cloth['image'].'" class="card-img-top" alt="..." height=400>
  <div class="card-body">
 
    <h5 class="card-title">'.$cloth['name'].'  <span class="badge text-bg-danger">'.$cloth['category_name'].'</span></h5>
    <p class="card-text">'.$cloth['description'].'</p>
   
    <p class="card-text">'.$cloth['price'].'</p>
   

    <a href="productdetails.php?p_id='.$id.'" class="btn btn-outline-danger">Add to cart</a>
  </div>
</div>
        </div>
        
        ';
    }
}


}
?>
    </div>
</div>

<?php 
include("./footer.php");
?>