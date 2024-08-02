<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Products;

class ProductController extends Controller
{
     public function index(){
          return view('products.index', [
              'products'=> products::get()
          ]);
      }
   
   public function create(){
        return view('products.create');
   }

   public function store(Request $request){
    // validate data
    $request->validate([
        'name' => 'required',
        'description' => 'required',
        'image' => 'required|mimes:jpeg,jpg,png,gif|max:10000'
    ]);

    // upload image
    $imageName = time().'.'.$request->image->extension();
    $request->image->move(public_path('products'), $imageName);

    $product = new Products;
    $product-> image = $imageName;
    $product->name = $request->name;
    $product->description = $request->description;

    $product->save();
    return back()->withSuccess('Product Created... !!!');

   }

   public function update(Request $request, $id){
     // validate data
     $request->validate([
         'name' => 'required',
         'description' => 'required',
         'image' => 'required|mimes:jpeg,jpg,png,gif|max:10000'
     ]);
 
     $product = Products::where('id', $id)->first();

     if(isset($request->image)){
          // upload image
     $imageName = time().'.'.$request->image->extension();
     $request->image->move(public_path('products'), $imageName);
     $product-> image = $imageName;
     
     }
     $product->name = $request->name;
     $product->description = $request->description;
 
     $product->save();
     return back()->withSuccess('Product Updated... !!!');
 
    }

   public function edit($id){
     $product = Products::where('id',$id)->first();

     return view('products.edit',['product' => $product]);
    }

    public function destroy($id){
        $product = Products::where('id', $id)->first();
        $product->delete();
        return back()->withSuccess('Product updated.. !!!');
    }
}





