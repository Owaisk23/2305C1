(async function () {
  const response = await fetch("./film.json");

  const movies = await response.json();

  console.log(movies);

  var movieBox = document.getElementById("moviebox");
  var display = document.getElementById("searchedMovie");

  renderMovies();
  
   let btn=document.getElementById("btn");
  btn.addEventListener('click',searchMovie)
  
  

  function renderMovies() {

    movies.forEach((element) => {
      let carousel_id = element.Title.replace(/\s+/g, "");//iamlegend
      
      movieBox.innerHTML += `
        <div class="col-lg-3 col-md-6 col-sm-12 my-2 ">
        <div class="card mx-1 bg-dark text-light px-2"  style="width: 100%;">
        <div class="card-body">
        <div id="${carousel_id}" class="carousel slide">
            <div class="carousel-inner">
            <div class="carousel-item active">
              <img src="${element.Images[0]}" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
              <img src="${element.Images[1]}" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
              <img src="${element.Images[2]}" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
              <img src="${element.Images[3]}" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
              <img src="${element.Images[4]}" class="d-block w-100" alt="...">
            </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#${carousel_id}" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
            </button>
        </div>
        </div>
                        <div class="card-text">
                            <ul class="list-unstyled">
                                <li class="h2">Title: ${element.Title}</li>
                                <li><b>Year:</b> ${element.Year}</li>
                                <li><b>Released:</b> ${element.Released}</li>
                                <li><b>Genre:</b> ${element.Genre} </li>
                                <li><b>Director:</b> ${element.Director}</li>
                                <li><b>Writer:</b> ${element.Writer}</li>
                                <li><b>Actors:</b> ${element.Actors}</li>
                                <li><b>Language:</b> ${element.Language}</li>
                                <li><b>Country:</b> ${element.Country}</li>
                                <li><b>Awards:</b> ${element.Awards}</li>
                            </ul>
                        </div>
                    </div>
            </div></div>
            `;
    });
  }

  function searchMovie() {

  let query = document.getElementById("query").value.toLowerCase();
  // ABCD==> abcd
  movieBox.innerHTML="";
  // display.innerHTML = query; 

  let test=[]
  movies.forEach(element => {
    test.push(element.Title.toLowerCase()) 
  });
  console.log(test)

let match=false;

  for(let i=0;i<test.length;i++){
    
    if(query==test[i]){
      match=true;
      var index=i;//
    }

    if(match==true){
      display.innerHTML = 
      `
      <div class="col-lg-6 col-md-6 col-sm-12 my-4 mx-auto">
        <div class="card mx-1 bg-dark text-light px-2"  style="width: 100%;">
        <div class="card-body">
        <div id="${'HARIS'+index}" class="carousel slide">
            <div class="carousel-inner">
            <div class="carousel-item active">
              <img src="${movies[index].Images[0]}" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
              <img src="${movies[index].Images[1]}" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
              <img src="${movies[index].Images[2]}" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
              <img src="${movies[index].Images[3]}" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
              <img src="${movies[index].Images[4]}" class="d-block w-100" alt="...">
            </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#${'ab'+index}" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
            </button>
        </div>
        </div>
                  <div class="card-text">
                            <ul class="list-unstyled">
                                <li class="h2">Title: ${movies[index].Title}</li>
                                <li><b>Year:</b> ${movies[index].Year}</li>
                                <li><b>Released:</b> ${movies[index].Released}</li>
                                <li><b>Genre:</b> ${movies[index].Genre} </li>
                                <li><b>Director:</b> ${movies[index].Director}</li>
                                <li><b>Writer:</b> ${movies[index].Writer}</li>
                                <li><b>Actors:</b> ${movies[index].Actors}</li>
                                <li><b>Language:</b> ${movies[index].Language}</li>
                                <li><b>Country:</b> ${movies[index].Country}</li>
                                <li><b>Awards:</b> ${movies[index].Awards}</li>
                            </ul>
                            <a href="#" class="btn btn-success">Play Now</a>
                            <a href="#" class="btn btn-danger">Download</a>
                        </div>
                    </div>
            <a href="./index.html" class="my-3 btn btn-light d-grid gap-2">GO Back</a></div>
            </div>

      `;
    }
    else{
      display.innerHTML="<div class='my-5 text-center'><h3>Oops not found...😪</h3><p>Please Try other Movies</p></div>"
    }
  }
}
})();
