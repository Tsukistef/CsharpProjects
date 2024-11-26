// See https://aka.ms/new-console-template for more information
using Methods.Exercise;


// creating an instance of a class
Person baby = new Person();

baby.LastName = "Jonas";
baby.FirstName = "John";
baby.DateofBirth = new DateOnly(1999, 01, 01); ;

baby.PrintFullName();
baby.GenerateTaxCode();

var taxNumber = baby.GetTaxNumber();

Console.WriteLine(taxNumber);

Teacher teacher = new Teacher();
teacher.LastName = "Smith";
teacher.GenerateTeacherIdNum();
var teacherId = teacher.GetTeacherIdNum();

Console.WriteLine(teacherId);

// abstract classes cannot be instantiated
// var square = new Square();

Rectangle rectangle = new(10, 20);
var rectangleArea = rectangle.Area();
Console.WriteLine($"The area of the rectangle is: {rectangleArea}");

Square square = new(10);
var squareArea = square.Area();
Console.WriteLine($"The are of the square is: {squareArea}");
