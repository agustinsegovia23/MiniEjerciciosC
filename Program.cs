//------- MINI EJERCICIOS DE C# de W3SCHOOLS -----------------//
//EJ 1 
// Insert the missing part of the code below to output "Hello World!".
// Console.WriteLine("Hello, World!");
// EJ 2
// Comments in C# are written with special characters. Insert the missing parts:
//This is a single-line comment
/* This is a multi-line comment */ 
// EJ 3
// Create a variable named myNum and assign the value 50 to it.
// int myNum = 50;
// EJ 4
// Create a variable named myName and assign the value "John" to it.
// string myName = "John";
// EJ 5
// Display the sum of 5 + 10, using two variables: x and y.
//  int x = 5;
//  int y = 10;
//  Console.WriteLine(x + y);
// EJ 6
// Create an int variable called z, assign x + y to it, and display the result.
//  int x = 5;
//  int y = 10;
//  int z = x + y;
//  Console.WriteLine(z);
// EJ 7
// Fill in the missing parts to create three variables of the same type, using a comma-separated list:
// int x = 5, y = 6, z = 50;
// Console.WriteLine(x + y + z);
// EJ 8
// Fill in the missing parts to create three variables of the same type, using a comma-separated list:
// int x = 5, y = 6, z = 50;
// Console.WriteLine(x + y + z);
// EJ 9
// Create two boolean variables, named yay and nay, and add appropriate values to them:
// bool yay = true;
// bool nay = false;
// EJ 10
// Create a greeting variable, and display the value of it:
// string greeting = "Hello";
// Console.WriteLine(greeting);
// EJ 11
// Type Casting - Use the correct conversion method to convert the int variable to a string:
// int myInt = 10;
// Console.WriteLine(Convert.ToString(myInt));
// EJ 12
// Fill in the missing parts to get user input, stored in the variable userName:
// Console.WriteLine("Enter username:");
// string userName = Console.ReadLine();
// Console.WriteLine("Username is: " + userName);
// EJ 13
// Fill in the missing parts to print a number put in by the user:
// Console.WriteLine("Think of a number:");
// int myNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your number is: " + myNum);
// EJ 14
// Multiply 10 with 5, and print the result.
// Console.WriteLine(10 * 5);
// EJ 15
// Divide 10 by 5, and print the result.
// Console.WriteLine(10 / 5);
// EJ 16
// Use the correct operator to increase the value of the variable x by 1.
// int x = 10;
// x++;
// EJ 17
// Use the addition assignment operator to add the value 5 to the variable x.
// int x = 10;
// x += 5;
// EJ 18
// Use the correct method to print the highest value of x and y.
// int x = 5;
// int y = 10;
// Console.WriteLine(Math.Max(x, y));+
// EJ 19
// Use the correct method to print the square root of x.
// Console.WriteLine(Math.Sqrt(64));
// EJ 20
// Use the correct method to round the number 2.6 to its nearest integer.
// Console.WriteLine(Math.Round(2.6));
// EJ 21
// Fill in the missing part to create a greeting variable of type string and assign it the value Hello.
// string greeting = "Hello";
// EJ 22
// Use the correct operator to concatenate two strings:
// string firstName = "John ";
// string lastName = "Doe";
// string name = firstName + lastName;
// Console.WriteLine(name);
// EJ 23
// Use the string interpolation method to concatenate two strings:
// string firstName = "John";
// string lastName = "Doe";
// string name = $"My full name is: {firstName} {lastName}";
// Console.WriteLine(name);
// EJ 24
// Access the first character (H) in myString and print the result:
// string myString = "Hello";
// Console.WriteLine(myString[0]);
// EJ 25
// Use the correct property to print the length of the txt string.
// string txt = "Hello";
// Console.WriteLine(txt.Length);
// EJ 26
// Use the correct method to output the value of the txt string to upper case letters.
// string txt = "Hello World";
// Console.WriteLine(txt.ToUpper());
// EJ 27
// Fill in the missing parts to print the values True and False:
// bool isCodingFun = true;
// bool isFishTasty = false;
// Console.WriteLine(isCodingFun);
// Console.WriteLine(isFishTasty);
// EJ 28
// Fill in the missing parts to print the value True:
// int x = 10;
// int y = 9;
// Console.WriteLine(x > y);
// EJ 29
// Print "Hello World" if x is greater than y.
// int x = 50;
// int y = 10;
// if (x > y) 
//  {
//       Console.WriteLine("Hello World");
//  }
// EJ 30
// Print "Hello World" if x is equal to y.
// int x = 50;
// int y = 50;
// if (x == y) 
// {
//   Console.WriteLine("Hello World");
// }
// EJ 31
// Print "Yes" if x is equal to y, otherwise print "No".
// int x = 50;
// int y = 50;
// if (x == y) {
//   Console.WriteLine("Yes");
// } else {
//   Console.WriteLine("No");
// }
// EJ 32
// Print "1" if x is equal to y, print "2" if x is greater than y, otherwise print "3".
// int x = 50;
// int y = 50;
// if (x == y) {
//   Console.WriteLine("1");
// } else if (x > y) {
//   Console.WriteLine("2");
// } else{
//   Console.WriteLine("3");
// }   
// EJ 33
// Insert the missing parts to complete the following "short hand if...else statement" (ternary operator):
// int time = 20;
// string result = (time < 18) ? "Good day." : "Good evening.";
// Console.WriteLine(result);

// EJ 34
// Insert the missing parts to complete the following switch statement.
// int day = 2;
// switch (day) {
// case 1:
//     Console.WriteLine("Monday");
//     break;  
// case 2: 
//     Console.WriteLine("Tuesday");
//     break;}

// EJ 35
// Complete the switch statement, and add the correct keyword at the end to specify some code to run if there is no case match in the switch statement.
// int day = 3;
// switch (day) {
// case 1:
//     Console.WriteLine("Today is Saturday");
//     break;  
// case 2:
//     Console.WriteLine("Today is Sunday");    
// break;  
// default:
//     Console.WriteLine("Looking forward to the Weekend");
//     break;
// }

// EJ 36
// Print i as long as i is less than 6.
// int i = 1;
// while (i < 6) {
//   Console.WriteLine(i);
//   i++;
// }

// EJ 37
// Use the do/while loop to print i as long as i is less than 6.
// int i = 1;
// do{
//   Console.WriteLine(i);
//   i++;
// }while (i < 6);

// EJ 38
// Use a for loop to print "Yes" 5 times:
// for(int i = 0; i < 5; i++){
//   Console.WriteLine("Yes");
// }

// EJ 39
// Stop the loop if i is 5.
// for (int i = 0; i < 10; i++) 
// {
//   if (i == 5) 
//     {
//       break;  
//     }
//   Console.WriteLine(i);
// }

// EJ 40
// In the following loop, when the value is "4", jump directly to the next value.
// for (int i = 0; i < 10; i++) 
// {
//   if (i == 4) 
//   {
//     continue;
//   }
//   Console.WriteLine(i);
// }

// EJ 41
// Create an array of type string called cars.
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

// EJ 42
// Print the value of the second element in the cars array.
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// Console.WriteLine(cars[1]);

// EJ 43
// Change the value from "Volvo" to "Opel", in the cars array.
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// cars[0] = "Opel";
// Console.WriteLine(cars[0]);

// EJ 44
// Loop through the elements in the cars array using the foreach loop.
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// foreach (string i in cars){
//   Console.WriteLine(i);
// }

// EJ 45
// Use the correct method to sort the cars array.
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// Array.Sort(cars);
// foreach (string i in cars)
// {
//   Console.WriteLine(i);
// } 
 
 // EJ 46
//  Create a method named MyMethod and call it inside Main().
// static void myMethod() {
//   Console.WriteLine("I just got executed!");
// }
// static void Main(string[] args)
// {
//     myMethod();
// }

// EJ 47
// Insert the missing parts to call MyMethod two times.
// static void MyMethod() 
// {
//   Console.WriteLine("I just got executed!");
// }
// static void Main(string[] args){
// MyMethod();
// MyMethod();
// }

// EJ 48
// Add a fname parameter of type string to MyMethod.
// static void MyMethod(string fname) 
// {
//   Console.WriteLine(fname + " Refsnes");
// }

// static void Main(string[] args)
// {
//   MyMethod("Liam");
//   MyMethod("Jenny");
//   MyMethod("Anja");
// }

// EJ 49
// Insert the missing part to print the number 8 in Main, by using a specific keyword inside MyMethod:
// static int MyMethod(int x) {
//     return 5 + x;
// }
// static void Main(string[] args){
//   Console.WriteLine(MyMethod(3));
// }

// EJ 50
// Create a class called MyClass.
// class MyClass

// EJ 51
// Create an object of MyClass called myObj.
// MyClass myObj = new MyClass();

// EJ 52
// Create an object of Car called myObj, and use it to set the value of maxSpeed to 200.
// class Car 
// {
//    int maxSpeed;
//     static void Main(string[] args)
//   {
//     Car myObj = new Car();    
//     myObj.maxSpeed = 200;
//     Console.WriteLine(myObj.color);
//     Console.WriteLine(myObj.maxSpeed);  }
// }

// EJ 53
// Call the fullThrottle() method from the object:
// class Car 
// {  public void fullThrottle()
//   {
//     Console.WriteLine("The car is going as fast as it can!"); 
//   }
//   static void Main(string[] args)
//   {
//     Car myObj = new Car();
//     myObj.fullThrottle();
//   }
// }

// EJ 54
// Create a constructor of Car, and call it:
// class Car
// {
//   public string model;
//   public car()
//   {
//     model = "Mustang";
//   }
//     static void Main(string[] args)
//   {
//       Car Ford = new Car();
//       Console.WriteLine(Ford.model);
//   }
// }

// EJ 55
// Use an access modifier to make the model variable NOT accessible from outside its own class.
// private string model;

// EJ 56
// The Car class should inherit the class members from the Vehicle class. Fill in the missing part to make this possible.
// class Car : Vehicle

// EJ 57
// Fill in the missing parts to output an error message if an error occurs.
// try{
//   int[] myNumbers = {1, 2, 3};
//   Console.WriteLine(myNumbers[10]);
// }catch(Exception e)
// {
//   Console.WriteLine(e.Message);
// }

// EJ 58
// Fill in the missing parts to execute some code, after the exception statements, regardless of the result.
// try{
//   int[] myNumbers = {1, 2, 3};
//   Console.WriteLine(myNumbers[10]);
// }catch(Exception e){
//   Console.WriteLine("Something went wrong.");
// }
// finally
// {
//   Console.WriteLine("The 'try catch' is finished.");
// }
