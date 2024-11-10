function dropUntil(array, predicate) { // predicate e funkcija
    let res = [];
    let found = false;

    for (let i=0;i<array.length;i++) {
        if (predicate(array[i])) {// ako na taa funkcija i ja prateme array togash found ide true
            found = true;
        }
//ovoa ni treba posho posle prvio uspeshen predicate dodaj gi site natam
        if (found) {
            res.push(array[i]);
        }
    }

    return res;
}

