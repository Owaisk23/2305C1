let products = [
  {
    id: 1,
    img: "img1.avif",
    title: "Gaming Headphone 1",
    desc: "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolorem, autem.",
    price: 3999,
    off: 20,
  },
  {
    id: 2,
    img: "img2.jpg",
    title: "Gaming Headphone 2",
    desc: "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolorem, autem.",
    price: 4500,
    off: 80,
  },
  {
    id: 3,
    img: "img3.jpg",
    title: "Gaming Headphone 3",
    desc: "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolorem, autem.",
    price: 2500,
    off: 11,
  },
  {
    id: 4,
    img: "img4.avif",
    title: "Gaming Headphone 4",
    desc: "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolorem, autem.",
    price: 1500,
    off: 60,
  },
  {
    id: 5,
    img: "img4.avif",
    title: "Gaming Headphone 5",
    desc: "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolorem, autem.",
    price: 1000,
    off: 30,
  },
];

let html = "";

products.forEach((e) => {
  const discountPrice = (e.price * (e.off / 100)) / 100;

  let iconBackgroundColor = ""; // Initialize the background color variable

  if (discountPrice > 0 && discountPrice <= 10) {
    iconBackgroundColor = "red";
  } else {
    iconBackgroundColor = "orange";
  }

  html += `
      <div class="item">
        <div class="icon" style="background-color: ${iconBackgroundColor};">
          ${discountPrice.toFixed(1)} %
        </div>
        <div class="item-img">
          <img src="images/${e.img}" alt="" width="100%">
        </div>
        <div class="item-content">
          <h1>${e.title}</h1>
          <p>${e.desc}</p>
          <h4>Price: <span>${(e.price - discountPrice).toFixed(
            2
          )}</span> Rs</h4>
          <div class="item-link">
            <button onClick="addtocart('${
              e.id
            }')" class="btn"><i class="fa-brands fa-opencart"></i> Add To Cart</button>
          </div>
        </div>
      </div>
    `;
});


const cartItems = JSON.parse(localStorage.getItem("data")) || [];

const addtocart = (id) => {
  const existingItem = cartItems.find((item) => item.id === id);
  
  if (existingItem) {
    existingItem.quantity += 1;
    alert("Item already exist")
  } else {
    const newItem = { id: id, quantity: 1 };
    alert("Item added successfully")
    cartItems.push(newItem);

    window.location.reload()
  }
  
  localStorage.setItem("data", JSON.stringify(cartItems));

  
};
document.getElementById("data").innerHTML = html;


document.getElementById('quantity').innerHTML = `(${cartItems.length})`