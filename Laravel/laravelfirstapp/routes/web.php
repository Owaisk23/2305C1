<?php

use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('welcome');
});
// basic route
Route::get('/about', function (){
    return view('about');
});
// another way
Route::view('/services', 'services');

// Route with required Parameters
// Route::get('/product/{paramname}', function (){
//     return view('products');
// });

// Route with optional parameters

Route::get('/product/{prodid?}', function (){
    return view('products');
});






