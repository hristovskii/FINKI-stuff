let Human = function (name,age){ // konstruktor za covek
    this.age = age;
    this.name = name;
    this.stomach = [];
}

Human.prototype.eat = function (food){ metod za eat
    if(this.stomach.length < 10){
        this.stomach.push(food);
    }
}

Human.prototype.digest = function (){ metod za digest
    this.stomach = [];
}

Human.prototype.toString = function (){ toString metod
    return this.name + ", " + this.age;
}

let Baby = function (name,age,favoriteToy){ konstruktor za baby koe go povikuva konstruktoro human
    Human.call(this,name,age);
    this.favoriteToy = favoriteToy;
}

Baby.prototype = Object.create(Human.prototype); baby nasleduva od human
Baby.prototype.constructor = Baby; baby funkcijata e kostruktor potencirame

Baby.prototype.play = function (){ i metod na baby praveme play
    return "Baby " + this.name + ', ' + this.age + ' is playing with ' + this.favoriteToy;
}
