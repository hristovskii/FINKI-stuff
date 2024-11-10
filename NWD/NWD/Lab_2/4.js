function group(arr, len) {
    let res = [];
    
    let numOfSubArrays = arr.length / len;
    numOfSubArrays = Math.ceil(numOfSubArrays);
    
    for (let i = 0; i < numOfSubArrays; i++) {
        res.push([]);
    }
    
    for (let i = 0; i < arr.length; i++) {
        res[i % numOfSubArrays].push(arr[i]);
    }

    return res;
}