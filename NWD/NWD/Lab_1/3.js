'use strict'

var readline = require('readline');
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
    terminal: false
});

rl.question('', (p1) => {
        p1 = Number(p1)

        console.log(howManyStickers(p1))

        rl.close();

});

// DO NOT CHANGE ABOVE THIS LINE!!!!

function howManyStickers(lines) { // Write this function
 return lines*6*lines;
}
//voa so kockata kolku stikeri ima linii^2 * 6



