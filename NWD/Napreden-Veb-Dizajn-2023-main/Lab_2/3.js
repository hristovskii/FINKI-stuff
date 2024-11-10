function flatten(arr) { // otstranuva gi podnizite
    //// Write this function
    let res = [];
    while (arr.length !== 0){
        let nextElement = arr.pop();
        if(Array.isArray(nextElement)){
            arr.push(...nextElement);
        }
        else {
            res.unshift(nextElement);
        }
    }
    return res;
}