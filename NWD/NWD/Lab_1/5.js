'use strict'

var readline = require('readline');
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
    terminal: false
});

rl.question('', (p1) => {
    rl.question('', (p2) => {
        p1 = p1.split(", ")
        p2 = p2.split(", ")

        console.log(merge(p1,p2))

        rl.close();
    })
});

// DO NOT CHANGE ABOVE THIS LINE!!!!

const merge = function(niza1,niza2){
    let rez = [];
    for(let i=0;i<niza1.length;i++){
        rez.push([niza1[i],niza2[i]]);
    }
    return rez;
} // Write this function
prave nova niza pr vlez [1,2,3] i [4,5,6]
on vrakja [[1,4],[2,5],[3,6]]