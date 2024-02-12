<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    // basics
    // echo("Owais Ahmed Khan");

    // variable declare dollar sign $
    // $a = -23;
    // $Name = "Owais";
    // $name = "Owais Ahmed Khan";

    // print($Name);

    // echo "<h1>this is my name: $name</h1>";
    // echo "<h1>this is my ".($a + 10)." result generated!</h1>"

    // builtmethods
    // absolute neg to positive
    // echo $a;
    // echo abs(-999);
    // echo round(9.4);
    // echo floor(9.8);
    // echo ceil(9.2);
    // echo sqrt(625);

    // string methods
    // $str = "hello world! Pakistan zindabad";
    // // ucwords() capital first letter for each word
    // echo ucwords($str);
    // // strrev() reverse strng
    // echo strrev($str);
    // // str_word_count() count word
    // echo str_word_count($str);

    // Datatypes in php
    // Number
    // $num1 = 10; //int
    // $num2 = 10.77; //float
    // $num3 = 1.770980714981347; //double

    // // string
    // $hello = "Hello welcome in PHP class"; //string

    // // boolean

    // $userResponse = true;
    // $eligbleVote = false;

    // arrays
    // $students = array("Ebad", "Areesha", "Taha", 77, "M.Ali", "Azhar", "Abdullah");
    //                   // 0     1          2       3    4         5          6
    // echo $students[6];

    // functions
    // function add(){
    //     echo 23 + 55;
    // }

    // // calling func
    // add();

    // func with parameters and arguments

    // function add($a, $b){
    //     echo $a + $b;
    // }

    // // calling with arguments
    // // add(50, 70); 
    // add(80, 79); 

    // func with return type

    // function add($a, $b){
    //     return $a + $b;
    // }

    // // calling with arguments
    // // add(50, 70); 
    // $sum =  add(77, 57); 
    // echo $sum;

    // Conditional statemnets
    // $age = 33;

    // if($age > 18){
    //     echo "You r eligible for vote";
    // }else{
    //     echo "You r not eligible for vote";
    // }

    // if elseif else

    $age = 18;

    if($age > 18){
        echo "You r eligible for vote";
    }elseif ($age = 18){
        echo '<script>alert("you r eligble but get your cnic first")</script>';
    }
    else{
        echo "You r not eligible for vote";
    }






















?>
</body>
</html>