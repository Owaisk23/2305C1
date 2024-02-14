<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php    
        // Indexes arrays
        // $students = array("Azhar", "Haseeb", "Bilal", "Ali");

        // echo "<pre>";
        // print_r($students);
        // echo "</pre>";

        // foreach
        // foreach($students as $key => $value){
        //     echo "$key: $value <br>";
        // }

        // Associative Array
        // $student = [
        //     "name" => "Owais Ahmed",
        //     "age" => 23,
        //     "education" => "BSCS",
        //     "JobTitle" => "Software Developer"
        // ];

        // echo $student["JobTitle"];

        // echo "<pre>";
        // print_r($student);
        // echo "</pre>";

        // foreach
        // foreach($student as $key => $value){
        //     echo "$key: $value <br>";
        // }

        // MultiDimesional Array


        $result = [
            ["Taha", 88],
            ["Ebad", 98],
            ["Ali", 78],
            ["Bilal", 82]
        ];

        // echo $result[3][1];


        echo "<pre>";
        print_r($result);
        echo "</pre>";



    ?>
</body>
</html>