<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\ProductController;


Route::get('/', [ProductController::class, 'index'])->name('products.index');
Route::get('/products/create', [ProductController::class, 'create'])->name('products.create');
Route::post('/products/store', [ProductController::class, 'store'])->name('products.store');

Route::get('products/{id}/edit', [ProductController::class, 'edit']);
Route::put('products/{id}/update', [ProductController::class, 'update']);
Route::get('products/{id}/delete', [ProductController::class, 'destroy']);
