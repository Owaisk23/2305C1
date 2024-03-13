<?php 
include ("../include/header.php");
session_start();
if(isset($_SESSION['username'])){
?>
<style>
.me-7{
    margin-right:100px;
}
</style>
<body>
<nav class="navbar navbar-expand-lg bg-dark navbar-dark">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Aptech</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
      </ul>
      <div class="d-flex me-7" >
      <div class="nav-item dropdown text-light">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
          <?php echo $_SESSION['username'] ?>
          </a>
      <ul class="dropdown-menu me-4">
            <li><a class="dropdown-item" href="#"><?php echo $_SESSION['email'] ?></a></li>
            <li> <a class="mx-3 btn btn-outline-success" href="logout.php" type="submit">LOG OUT</a></li>
          </ul>
</div>
       
</div>
    </div>
  </div>
</nav>

</body>
</html>
<?php 
}else{
    header("location: login.php");
}
?>