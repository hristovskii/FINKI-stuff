// TODO: write the function;
var fib_next = (() => {
    let a = 0;
    let b = 1;
    return () => {
        let fib = a + b;
        a = b;
        b = fib;
        return fib;
    }

})();
//clouser
//console.log(fib_next())// returns 1
