    function difference(arr1,arr2){
        //// Write this function
        arr1 = removeNestedArrays(arr1);
        arr2 = removeNestedArrays(arr2);
        let res = [];
        for(let i=0;i<arr1.length;i++){ // ako go neam element od arr1 vo res dodadi
            if(!res.includes(arr1[i])) {
                res.push(arr1[i]);
            }
        }
        for(let i=0;i<arr2.length;i++){ // ako go neam element od arr2 vo res dodadi
            if(!res.includes(arr2[i])){
                res.push(arr2[i]);
            }
        }
        return res;
    }
    //add more code/functions if you need
	// 
    function removeNestedArrays(arr) {
        let result = [];
        while (arr.length !== 0) {
            let nextElement = arr.pop(); // zemi element od kraj
            if (Array.isArray(nextElement)) { // ako taj element e array
                arr.push(...nextElement); //butni go u nizata na kraj pa ama kako posebni elementi spread
            } else {
                result.unshift(nextElement);//dodadi na pocetok ako ne e arej vo rezultat niza
            }
        }

        return result;
    }