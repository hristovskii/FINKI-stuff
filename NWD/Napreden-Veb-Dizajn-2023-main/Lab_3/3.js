let Car = function (model,milesPerGallon){ // konstruktor car
    this.tank = 0;
    this.odometar = 0;
    this.model = model;
    this.milesPerGallon = milesPerGallon;
}

Car.prototype.fill = function (gallons){ // metod fill
    this.tank = this.tank + gallons;
}

Car.prototype.drive = function (miles){ metod drive
    if(miles/this.milesPerGallon <= this.tank){
        this.tank = this.tank - miles/this.milesPerGallon;
        this.odometar = this.odometar + miles;
        return "Vehicle has " + this.odometar + " miles and " + this.tank + " gallons left.";
    }
    else {
        let drivenMiles = this.tank * this.milesPerGallon;
        this.odometar = this.odometar + drivenMiles;
        this.tank = 0;
        return "Vehicle ran out of gas after driving " + drivenMiles + " miles. Vehicle now has " + this.odometar +" miles on the odometer and " + this.tank + " gallons of gas.";
    }
}

