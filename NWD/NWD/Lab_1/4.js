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

        console.log(hasSameBread(p1,p2))

        rl.close();
    })
});

// DO NOT CHANGE ABOVE THIS LINE!!!!

function hasSameBread(niza1,niza2) { // Write this function
return niza1[0] === niza2[0] && niza1[niza1.length - 1] === niza2[niza2.length - 1]
}
// proveruva dali prvio element od dvete nizi e ist i poslednio dali e ist i na dvete i vrakja true ili false
