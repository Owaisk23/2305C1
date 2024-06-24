<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class AppController extends Controller
{
    public function index(){
        return "Hello in LARAVEL controller 2305C1";
        






        
        // $name= "accord";
        // $year = "2003";
        // $color = 'Silver';
        // Using Compact method
        // return view("welcome", compact("name", "year", "color"));

        // Using associative array
        // return view("welcome", array(
        //     'name' => $name,
        //     'year' => $year, 
        //     'color' => $color,
        // ));

        // Using with method
        // return view("welcome")->with('name')->with('year')->with('color');

    }
}
