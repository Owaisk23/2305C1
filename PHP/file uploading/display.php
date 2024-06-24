<?php
include "../include/header.php";
require "../include/connection.php";
$getAll="SELECT * FROM `mobiles`";
$result=mysqli_query($connection,$getAll);
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body><div class="container">
    <div class="row">
<?php
if(mysqli_num_rows($result)>0){
    while ($row=mysqli_fetch_assoc($result)) {
        $image=$row['image']
        ?>
        <div class="col-lg-4">
<img src="images/<?=$image?>" alt="">
</div>
        <?php
    }
}

?>

    </div>
</div>
    
</body>
</html>