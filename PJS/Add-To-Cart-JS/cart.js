

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
  



  const cartItems = JSON.parse(localStorage.getItem("data")) || [];

// Reference to the tbody element
const cartTbody = document.getElementById('cart');

// Function to render cart items in the table
function renderCartItems() {
  // Clear existing content in the tbody
  cartTbody.innerHTML = '';

  // Loop through cartItems and create table rows
  cartItems.forEach((cartItem, index) => {
    const product = products.find(product => product.id == cartItem.id);

    if (product) {
      const row = document.createElement('tr');
      const discountPrice = (product.price * (product.off / 100)) / 100;
      row.innerHTML = `
        <td>${index + 1}</td>
        <td><img src="images/${product.img}" alt="" class="img" width="100px"></td>
        <td class="title">${product.title}</td>
        <td><input type="number" value="${cartItem.quantity}" min="1"></td>
        <td>Rs <span>${(product.price - discountPrice).toFixed(2)}</span></td>
        <td><button onclick="removeItem(${index})">Remove</button></td>
      `;
      cartTbody.appendChild(row);
    }
  });
}

// Function to remove an item from the cart
function removeItem(index) {
  // Remove the item at the specified index from cartItems array
  cartItems.splice(index, 1);
  
  // Update local storage with the modified cartItems array
  localStorage.setItem('data', JSON.stringify(cartItems));

  // Render the updated cart items in the table
  renderCartItems();
  alert("Item removed successfully")

  window.location.reload()
}

// Initial render of cart items when the page loads
renderCartItems();
document.getElementById('quantity').innerHTML = `(${cartItems.length})`