function add_to(f) { 

    let args = [];

    function insert(val) { metod za objekto aggregator
        args.push(val);
        return aggregator;
    }

    function result() { metod za objekto agregator
        return args.reduce(f);
    }

    const aggregator = { insert, result }; objekt agregator so metodi sva

    return aggregator;
}