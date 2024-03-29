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

<div class="container" style="margin-top:120px;">
    <div class="row">
<?php 
if(isset($_POST["search"])){


$query=$_POST["search"];
$query;

    $search="SELECT * FROM `clothes` c inner join `category` cat on c.category_id=cat.category_id where c.name like '%$query%' or c.description like '%$query%' or c.price like '%$query%' or cat.category_name like '%$query%' order by c.id desc;";
    $search_run=mysqli_query($connection, $search) or die("failed");
    if(mysqli_num_rows($search_run) > 0){
        echo'<h5 class="text-center display-4">Showing results for "'.$query.'"</h5>';

    while($cloth=mysqli_fetch_assoc($search_run)){
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
else{
   

  echo'
  <div class="container" style="height:60vh">
  
  <h5 class="text-center display-4">No Record Found</h5></div>';
}
}
else{
    header("location: index.php");
}



?>


    </div>
</div>

<?php 
include("./footer.php");
?>