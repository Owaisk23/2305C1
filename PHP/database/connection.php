<?php
    $server = "localhost";
    $username = "root";
    $db_pass = "";
    $dbname = "2305c1";

    $connection = mysqli_connect($server, $username, $db_pass, $dbname);

    if (!$connection){
        die("Failed to connect");
    }else{
        echo "database connected";
    }

?>