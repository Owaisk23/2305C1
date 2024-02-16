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
        $students = array("Azhar", "Haseeb", "Bilal", "Ali");

        // echo "<pre>";
        // print_r($students);
        // echo "</pre>";

        // foreach
        // foreach($students as $key => $value){
        //     echo "$key: $value <br>";
        // }

        // Associative Array
        $student = [
            "name" => "Owais Ahmed",
            "age" => 23,
            "education" => "BSCS",
            "JobTitle" => "Software Developer"
        ];

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

        // echo $result[1][0];


        // echo "<pre>";
        // print_r($result);
        // echo "</pre>";

        // echo "<table border=2 cellpadding=7px>
        //     <h1>Student Result</h1>
        //     <tr>
        //         <th>Name</th>
        //         <th>Percentage</th>
        //     </tr>
        // ";

        // foreach($result as $key1 => $value1){
        //         echo "<tr>";
        //         foreach($value1 as $key2 => $value2){
        //             echo "<td>$value2</td>";
                    
        //     }
        //     echo "</tr>";
        // }
        
        // echo "</table>";

        // Multidimesional associative array

        $marks = [
                "Azhar" => ["English" => 77, "Maths" => 88, "Physics" => 95],
                "Ali" => ["English" => 71, "Maths" => 98, "Physics" => 99],
                "Bilal" => ["English" => 72, "Maths" => 68, "Physics" => 50],
                "Haider" => ["English" => 67, "Maths" => 58, "Physics" => 80]
        ];

        // echo "<pre>";
        // print_r($marks);
        // echo "</pre>";
    
        // echo $marks['Bilal']['English'];
    
        // name | English | Maths | Physics
        echo "<table border=2 cellpadding=7px>
            <h1>Student Result</h1>
            <tr>
                <th>Name</th>
                <th>English</th>
                <th>Maths</th>
                <th>Physics</th>
            </tr>
        ";

        foreach($marks as $key1 => $value1){
                echo "<tr>";
                echo "<td>$key1</td>";
                foreach($value1 as $key2 => $value2){
                    echo "<td>$value2</td>";
                    
            }
            echo "</tr>";
        }
        
        echo "</table>";


    ?>
</body>
</html>