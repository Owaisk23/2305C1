onmessage = function(e){
    let result = 0;
    for(let i = 0; i<10000000000; i++){
        result += i;
    }

    this.postMessage(result);
}