Function.prototype.inherit = function (parent) {
    this.prototype = new parent();
    this.prototype.constructor = parent;
}

Function.prototype.extend = function (parent) {
    for (var i = 1; i < arguments.length; i++) {
        var propertyName = arguments[i];
        this[propertyName] = parent[propertyName];
    }
    return this;
}

// Vehicles Module
var VehiclesNS = (function () {

    var WHEEL_NUMBER = 4;

    //Acts like abstract Class
    function PropulsionUnit() {

        var getAcceleration = function () { };
        return {
            getAcceleration: getAcceleration
        };
    }

    //Wheel
    function Wheel(radius) {
        if (!radius || radius <= 0 || isNaN(radius)) {
            throw {
                message: "Wheel should have positive radius!",
                name: "Propulsion Unit Error"
            };
        }

        radius = radius | 0;

        this.getAcceleration = function () {
            return 2 * Math.PI * radius;
        }
    }
    Wheel.inherit(PropulsionUnit);

    //PropellingNozzle
    function PropellingNozzle(power, afterburner) {
        if (!power || power <= 0 || isNaN(power)) {
            throw {
                message: "Nozzle power should be positive!",
                name: "Propulsion Unit Error"
            };
        }
        if (afterburner !== 'ON' && afterburner !== 'OFF') {
            throw {
                message: "Afterburner should be 'ON' or 'OFF'!",
                name: "Propulsion Unit Error"
            };
        }

        this.power = power | 0;
        this.afterburner = afterburner;

        this.getAcceleration = function () {
            if (afterburner === 'ON') {
                return power * 2;
            }
            else if (afterburner === 'OFF') {
                return power;
            }
        }
    }
    PropellingNozzle.inherit(PropulsionUnit);

    //Propeller
    function Propeller(finsNumber, spinDirection) {
        if (!finsNumber || finsNumber <= 0 || isNaN(finsNumber)) {
            throw {
                message: "Propeller should have positive number of fins!",
                name: "Propulsion Unit Error"
            };
        }
        if (!spinDirection || (spinDirection !== 'clockwise' && spinDirection !== 'counter-clockwise')) {
            throw {
                message: "Propeller should have spin direction 'clockwise' or 'counter-clockwise'!",
                name: "Propulsion Unit Error"
            };
        }
        this.spinDirection = spinDirection;
        this.finsNumber = finsNumber | 0;

        this.getAcceleration = function () {
            if (this.spinDirection == 'clockwise') {
                return finsNumber;
            }
            else if (this.spinDirection == 'counter-clockwise') {
                return -finsNumber;
            }
        }
    }
    Propeller.inherit(PropulsionUnit);

    //-----------------------------------------
    //Vehicles part
    //Acts like abstract class
    function Vehicle(speed, propulsionUnits) {
        this.speed = speed | 0;
        this.propulsionUnits = propulsionUnits;

        this.accelerate = function () {
            for (var i = 0; i < propulsionUnits.length; i++) {
                speed += propulsionUnits[i].getAcceleration();
            }
        }
    }

    //Land Vehicle
    function LandVehicle(speed, wheels) {
        if (wheels.length != WHEEL_NUMBER) {
            throw {
                message: "Land vehicle should have 4 wheels!",
                name: "Vehicle Error"
            };
        }

        Vehicle.call(this, speed, wheels);
    }
    LandVehicle.inherit(Vehicle);

    //Air Vehicle
    function AirVehicle(speed, propellingNozzle) {

        this.setAfterburnersState = function (state) {
            this.propulsionUnits[0].afterburner = state;
        }

        Vehicle.call(this, speed, [propellingNozzle]);
    }
    AirVehicle.inherit(Vehicle);

    //Water Vehicle
    function WaterVehicle(speed, propellers) {

        this.setPropellersSpinDirection = function (spinDirection) {
            for (var i = 0; i < this.propulsionUnits.length; i++) {
                this.propulsionUnits[i].spinDirection = spinDirection
            }

            Vehicle.call(this, speed, propellers);
        }
    }
    WaterVehicle.inherit(Vehicle);

    //Amphibious Vehicle
    function Amphibia(speed, wheels, propeller, mode) {
        var propulsionUnits = [];
        propulsionUnits.push(propeller);
        for (var i = 0; i < wheels.length; i++) {
            propulsionUnits.push(wheels[i]);
        }

        this.mode = mode;
        this.setMode = function (mode) {
            this.mode = mode;
        }

        Vehicle.call(this, speed, propulsionUnits);
    }
    Amphibia.inherit(Vehicle);
    Amphibia.extend(WaterVehicle, "setPropellersSpinDirection");

    Amphibia.prototype.accelerate = function () {
        if (this.mode == "land") {
            for (var i = 1; i < this.propulsionUnits.length; i++) {
                this.speed += this.propulsionUnits[i].getAcceleration();
            }
        }
        else {
            this.speed = this.propulsionUnits[0].getAcceleration();
        }
    }

    return {
        Wheel: Wheel,
        PropellingNozzle: PropellingNozzle,
        Propeller: Propeller,
        LandVehicle: LandVehicle,
        WaterVehicle: WaterVehicle,
        AirVehicle: AirVehicle,
        Amphibia: Amphibia,
    }
})();