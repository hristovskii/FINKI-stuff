'use strict'

var readline = require('readline');
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
    terminal: false
});

rl.question('', (p1) => {
        p1 = p1.split(", ")

        console.log(incrementItems(p1))

        rl.close();

});

// DO NOT CHANGE ABOVE THIS LINE!!!!

function incrementItems(niza) { // Write this function
  for(let i=0;i<niza.length;i++){
      niza[i]++;
  }
  return niza;
}
// dobivame niza i sekoj element od nizata go incrementirame za 1