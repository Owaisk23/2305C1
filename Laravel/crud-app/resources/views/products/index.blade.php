<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <title>Document</title>
</head>
<body>
    <nav class="navbar navbar-expand-sm bg-dark">

        <ul class="navbar-nav">
            <li class="nav-item">
                <a class="nav-link text-light" href="/">Products</a>
            </li>
        </ul>
    </nav>

    <div class="container">
        <div class="text-end">
            <a href="products/create" class="btn btn-dark mt-2">New Product</a>
        </div>

    <table class="table table-hover mt-2">
        <thead>
            <th>Sno.</th>
            <th>Name</th>
            <th>Image</th>
            <th>Action</th>
        </thead>
        <tbody>
            @foreach($products as $product)
            <tr>
            <td>{{ $loop->index+1 }}</td>
            <td>{{ $product->name }}</td>
            <td>
                <img src="products/{{$product->image}}" class="rounded-circle" width="50" height="50"/>
            </td>
                    <td>
                        <a href="products/{{$product->id}}/edit" class="btn btn-dark btn-sm">Edit</a>
                        <a href="products/{{$product->id}}/delete" class="btn btn-danger btn-sm">Delete</a>
                    </td>
            </tr>
            @endforeach
        </tbody>
    </table>
    </div>
</body>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</html>