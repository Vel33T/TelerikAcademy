var Person = {
    init: function (firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    },

    introduce: function () {
        return "Name: " + this.firstName + " " + this.lastName + ", Age: " + this.age;
    }
};

var Student = Person.extend({
    init: function (firstName, lastName, age, grade) {
        this._super = Object.create(this._super);
        this._super.init(firstName, lastName, age);
        this.grade = grade;
    },

    introduce: function () {
        return this._super.introduce() + ", grade: " + this.grade;
    }
});

var Teacher = Person.extend({
    init: function (firstName, lastName, age, speciality) {
        this._super = Object.create(this._super);
        this._super.init(firstName, lastName, age);
        this.speciality = speciality
    },

    introduce: function () {
        return this._super.introduce() + ", speciality: " + this.speciality;
    }
});

var School = {
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
};

var Course = {
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
};

var student1 = Object.create(Student);
student1.init("Gosho", "Goshov", 25, 4);
var student2 = Object.create(Student);
student2.init("Ivan", "Ivanov", 28, 7);
var student3 = Object.create(Student);
student3.init("Pesho", "Peshov", 26, 5);
var teacher1 = Object.create(Teacher);
teacher1.init("Munio", "Muniov", 24, "C# cources");
var teacher2 = Object.create(Teacher);
teacher2.init("Icho", "Picho", 27, "JS cources");
console.log(student1.introduce());
console.log(student2.introduce());
console.log(teacher1.introduce());
console.log(teacher2.introduce());

var classOne = Object.create(Course);
classOne.init("First class", 10, new Array(student1, student2, student3), teacher1);
var classTwo = Object.create(Course);
classTwo.init("Second Class", 2, new Array(student1, student3), teacher2);
console.log(classOne.introduce());
console.log(classTwo.introduce());
var school = Object.create(School);
school.init("Telerik", "Sofia", new Array(classOne, classTwo));
console.log(school.introduce());