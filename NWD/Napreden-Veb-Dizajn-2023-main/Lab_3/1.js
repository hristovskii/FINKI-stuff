let Human = function (name,age){//construktor za human
    this.age = age;
    this.name = name;
    this.stomach = [];
}

Human.prototype.eat = function (food){ // metod eat
    if(this.stomach.length < 10){
        this.stomach.push(food);
    }
}

Human.prototype.digest = function (){ // metod digest
    this.stomach = [];
}

Human.prototype.toString = function (){ // metod toString
    return this.name + ", " + this.age;
}

