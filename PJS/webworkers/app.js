let btn1 = document.getElementById('btn1')
btn1.addEventListener('click', () => {
    let result = 0;
    for(let i = 0; i<10000000000; i++){
        result += i;
    }
    document.querySelector('#output').innerHTML =  result;

})

let btn2 = document.querySelector('#btn2');
btn2.addEventListener('click', () => {
    document.querySelector('#hi').innerHTML += " Hi!!"
})