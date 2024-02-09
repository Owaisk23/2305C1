
var car = {
    name : "Mehran",
    model : "1998",
    brand : "Suzuki",
}

console.log(car.model);


class Vehicle {
    constructor(name, brand, year, engine){
        this.name = name;
        this.brand = brand;
        this.year = year;
        this.engine = engine;
    }
    start(){
        console.log(`${this.brand} ${this.name} is belongs to ${this.year} & ${this.engine}`)
    }
}


let yaris = new Vehicle("Yaris", "Toyota", "2019", "1300cc");
let mehran = new Vehicle("Mehran", "Suzuki", "2000", "800cc")
let LandCruiser = new Vehicle("Land Cruiser ZX", "Toyota", "2023", "4500cc")


yaris.start();
LandCruiser.start();
mehran.start();


class MotorBike extends Vehicle{
    constructor(name, brand, year, engine, fuelTank, seatingCapacity){
        super(name, brand, year, engine),
        this.fuelTank = fuelTank;
        this.seatingCapacity = seatingCapacity;
    }
    kick(){
        console.log(`${this.name} ${this.brand} has power of ${this.engine} make year is ${this.year} ki bike one kick start hai uspe at a time ${this.seatingCapacity} or uska fuel tank itne litre ka hai ${this.fuelTank}`)
    }
}

let harley = new MotorBike("HarleyDavidson", "AmericanBrand", "1998", "3000cc", "23litre", "3person");

harley.kick();