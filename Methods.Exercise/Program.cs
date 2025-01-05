// See https://aka.ms/new-console-template for more information
using Classes.Exercise;
using Classes.Exercise.Classes.PersonDemo;

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

Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
var cuboidPerimeter = cuboid.Perimeter();
var cuboidVolume = cuboid.Volume();
Console.WriteLine($"The area of the cuboid is: {cuboidArea}");
Console.WriteLine($"The perimeter of the cuboid is: {cuboidPerimeter}");
Console.WriteLine($"The volume of the cuboid is: {cuboidVolume}");

Sphere sphere = new(7);
var sphereArea = sphere.Circumference();
var sphereVolume = sphere.Volume();
Console.WriteLine($"The area of the cuboid is: {sphereArea}");
Console.WriteLine($"The volume of the cuboid is: {sphereVolume}");
