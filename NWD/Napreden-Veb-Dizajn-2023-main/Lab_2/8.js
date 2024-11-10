function curry(func, ...args) {
    //// Write this function
    if (args.length >= func.length) {
        return func(...args);
    } else {
        return function(...moreArgs) {
            return curry(func, ...args, ...moreArgs);
        };
    }
}

function format_date(day, month, year) {
    //// Write this function
    return `${day}.${month}.${year}`;
}

var date = curry(format_date);