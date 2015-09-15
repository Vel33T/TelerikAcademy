var Person = Class.create({
    init: function (firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    },

    introduce: function () {
        return "Name: " + this.firstName + " " + this.lastName + ", Age: " + this.age;
    }
});

var Student = Class.create({
    init: function (firstName, lastName, age, grade) {
        this._super = new this._super(arguments);
        this._super.init(firstName, lastName, age);
        this.grade = grade;
    },

    introduce: function () {
        return this._super.introduce() + ", grade: " + this.grade;
    }
});
Student.inherit(Person);

var Teacher = Class.create({
    init: function (firstName, lastName, age, speciality) {
        this._super = new this._super(arguments);
        this._super.init(firstName, lastName, age);
        this.speciality = speciality;
    },

    introduce: function () {
        return this._super.introduce() + ", speciality: " + this.speciality;
    }
});
Teacher.inherit(Person);

var School = Class.create({
    init: function (name, town, classes) {
        this.name = name;
        this.town = town;
        this.classes = classes;
    },

    introduce: function () {
        var str = "Name:" + this.name + ", Town:" + this.town + ", Classes:";
        for (var i = 0; i < this.classes.length; i++) {
            str += this.classes[i].name + ", ";
        }
        return str.substr(0, str.length - 2);
    }
});

var Course = Class.create({
    init: function (name, capacity, students, formTeacher) {
        this.name = name;
        this.capacity = capacity;
        this.students = students;
        this.formTeacher = formTeacher;
    },

    introduce: function () {
        var str = "Name:" + this.name + ", Capacity:" + this.capacity + ", Students:";
        for (var i = 0; i < this.students.length; i++) {
            str += this.students[i].introduce() + ", ";
        }
        str += "Form-teacher" + this.formTeacher.introduce();
        return str;
    }
});

var student1 = new Student("Gosho", "Goshov", 25, 4);
var student2 = new Student("Ivan", "Ivanov", 28, 7);
var student3 = new Student("Pesho", "Peshov", 26, 5);
var teacher1 = new Teacher("Munio", "Muniov", 24, "C# cources");
var teacher2 = new Teacher("Icho", "Picho", 27, "JS cources");
console.log(student1.introduce());
console.log(student2.introduce());
console.log(teacher1.introduce());
console.log(teacher2.introduce());

var classOne = new Course("First class", 10, new Array(student1, student2, student3), teacher1);
var classTwo = new Course("Second Class", 2, new Array(student1, student3), teacher2);
console.log(classOne.introduce());
console.log(classTwo.introduce());
var school = new School("Telerik", "Sofia", new Array(classOne, classTwo));
console.log(school.introduce());