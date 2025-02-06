# Roadmap for Learning Desktop Software Development with C# and MS SQL

---

## Table of Contents

https://github.com/gridlocdev/csharp-learning-roadmap

1. [Setting Up the Development Environment](#1-setting-up-the-development-environment)
2. [Introduction to C# and Programming Basics](#2-introduction-to-c-and-programming-basics)
3. [Control Structures](#3-control-structures)
4. [Object-Oriented Programming (OOP)](#4-object-oriented-programming-oop)
5. [Windows Forms Applications](#5-windows-forms-applications)
6. [Working with MS SQL Server](#6-working-with-ms-sql-server)
7. [Quizzes and Programming Tests](#7-quizzes-and-programming-tests)
8. [Final Test](#8-final-test)

---

## 1. Setting Up the Development Environment

### **Goal**: Ensure students have a working environment for development.

* **1.1 Install Visual Studio**
  * Choose the C# Desktop Development workload during installation.
  * Understand how to use Visual Studio to create and debug projects.

---

## 2. Introduction to C# and Programming Basics

### **Goal**: Teach programming fundamentals and introduce basic C# concepts.

#### **2.1 Introduction to Programming**
- **What is Programming?**: Explanation of what it means to write a program and how computers execute instructions.
- **What is a Compiler?**: Overview of how compilers work and why they are important for C#.
- **What is an IDE (Integrated Development Environment)?**: Introduction to Visual Studio, how to write and debug code using it.
  
#### **2.2 Basic C# Syntax and Constructs**
- **Variables and Data Types**: 
  * Introduction to common data types like `int`, `string`, `bool`, etc.
  * How to declare and use variables in C#.
- **Constants and Enumerations**: 
  * Understanding constants (`const`) and enumerations (`enum`).
- **Operators**: 
  * Arithmetic, logical, comparison, and assignment operators in C#.
- **Control Structures**: 
  * Decision-making: `if` statements, `switch` statement.
  * Repetition: `for` loop, `while` loop.

#### **2.3 Functions and Methods**
- **Creating Functions**: How to create functions/methods to organize code.
- **Parameters and Return Types**: Understanding method parameters, return types, and how to call methods with arguments.
- **Method Overloading**: How to create methods with the same name but different parameter lists.

#### **2.4 Exception Handling**
- **Try-Catch-Finally**: Introduction to exception handling in C#.
- **Common Exceptions**: Handling common exceptions like `NullReferenceException`, `FormatException`, etc.

---

## 3. Control Structures

### **Goal**: Master the use of control structures like `if` statements, `switch`, and loops in C#.

#### **3.1 If-Else Statements**
- Understand how to use `if`, `else`, and `else if` to make decisions in your code.
  
#### **3.2 Switch-Case Statements**
- Learn when to use `switch` instead of multiple `if` statements.

#### **3.3 Loops**
- **For Loop**: Use `for` to repeat a block of code a fixed number of times.
- **While Loop**: Use `while` to repeat a block of code as long as a condition is true.

**Test Example:**
- Write a program to check whether a number is positive, negative, or zero.
- Build a simple calculator using a `switch` statement.
- Print the multiplication table for a number using a `for` loop.
- Create a countdown timer using a `while` loop.

---

## 4. Arrays and Lists

### **Goal**: Teach how to work with **Arrays** and **Lists** in C# to handle collections of data.

#### **4.1 Arrays**
- **What is an Array?**: Introduction to arrays as fixed-size collections of data.
- **Declaring and Initializing Arrays**: How to declare and initialize arrays.
- **Accessing Array Elements**: Accessing, updating, and looping through array elements.
- **Multidimensional Arrays**: Introduction to 2D arrays and how to access elements in a matrix-style array.

#### **4.2 Lists**
- **What is a List?**: Learn about dynamic collections of data that can grow or shrink in size.
- **Creating and Using Lists**: How to declare and manipulate lists in C#.
- **Common List Operations**: Adding, removing, and accessing elements in a list.
- **Looping Through Lists**: Use loops and `foreach` to iterate through lists.

#### **4.3 Differences Between Arrays and Lists**
- Understand when to use **arrays** (fixed-size) versus **lists** (dynamic size).
- Discuss performance differences, use cases, and memory management.

**Test Example:**
- Create a program that takes user input to fill an array of numbers and then outputs them.
- Create a program that uses a list to store names and prints them using a loop.
- Build a program that manipulates both arrays and lists by sorting, adding, and removing elements.


---

## 5. Object-Oriented Programming (OOP)

### **Goal**: Teach the fundamental principles of OOP using C#.

#### **5.1 Classes and Objects**
- **What is a Class?**: Introduction to the concept of a class as a blueprint for objects.
- **Creating Objects**: How to create and instantiate objects from a class.

#### **5.2 Properties and Methods**
- **Properties**: Learn how to define and use properties to represent the state of an object.
- **Methods**: Understand how to define methods to represent behaviors of objects.

#### **5.3 Inheritance**
- **What is Inheritance?**: Learn how one class can inherit from another class, gaining its properties and methods.
- **Overriding Methods**: Understand how to override base class methods in derived classes.

#### **5.4 Polymorphism**
- **What is Polymorphism?**: Learn how polymorphism allows you to use derived classes in place of base classes, making code more flexible.

#### **5.5 Encapsulation**
- **What is Encapsulation?**: Learn how to keep data private within a class and expose it only through public methods (getters and setters).

**Test Example:**
- Create a `Car` class with properties like `Model`, `Year`, and `Color`.
- Implement a `Dog` and `Cat` class that overrides the `Speak()` method.
- Build a simple bank account system using inheritance, with `BankAccount` and `SavingsAccount`.

---

## 6. Windows Forms Applications

### **Goal**: Learn how to create desktop applications using Windows Forms.

#### **.1 Introduction to Windows Forms**
- Learn how to create a new Windows Forms application in Visual Studio.
- Add controls like buttons, labels, textboxes, and data grids to forms.

#### **6.2 Event Handling**
- Understand event-driven programming: handle events like button clicks, text changes, etc.

#### **6.3 Connecting to Databases with ADO.NET**
- Learn how to connect to a **SQL Server** database using ADO.NET.
- Perform basic database operations such as **Insert**, **Select**, **Update**, and **Delete** from a Windows Forms application.

**Test Example:**
- Build a login form that validates user credentials.
- Create a data entry form that saves data into a SQL Server database and displays it in a `DataGridView`.

---

## 7. Working with MS SQL Server

### **Goal**: Learn how to interact with **MS SQL Server** to manage data.

#### **7.1 Install SQL Server**
  * Install **SQL Server Express**.
  * Install **SQL Server Management Studio (SSMS)** for database management.
  * Set up a local SQL Server database.
  * Understand how to create a database and tables using SQL.

#### **7.2 Creating Databases and Tables**
- Write SQL queries to create a database and define tables (e.g., `Books`, `Users`).

#### **7.3 Performing CRUD Operations**
- Learn how to perform **Create**, **Read**, **Update**, and **Delete** operations in SQL using SQL queries.
- Interact with these databases from C# using **ADO.NET**.

#### **7.4 Querying and Managing Data**
- Use SQL commands to retrieve, modify, and delete data in SQL Server.

**Test Example:**
- Write SQL to create a `Books` table with columns like `BookID`, `Title`, and `Author`.
- Use **ADO.NET** in C# to insert a new record into the `Books` table.
- Retrieve and display records from the `Books` table in a `DataGridView`.

---

## 8. Quizzes and Programming Tests

For each topic, quizzes and programming tests are provided to assess understanding and reinforce learning.

### **Quizzes**:
- **C# Basics**: Test basic syntax, variables, and control structures.
- **OOP Concepts**: Test understanding of classes, inheritance, and polymorphism.
- **Windows Forms**: Test ability to create basic forms and handle events.
- **SQL**: Test knowledge of CRUD operations and database management.

### **Programming Tests**:
- **Control Structures**: Create programs that use `if`, `switch`, `for`, and `while` loops.
- **OOP**: Build simple applications using classes, objects, and inheritance.
- **Windows Forms**: Create forms to interact with a database.
- **SQL**: Perform CRUD operations on a database using ADO.NET.

---

## 9. Final Test

The final test will require students to build a **Student Management System** using the skills they’ve learned throughout the course.

### **Final Project Requirements**:
- Create a Windows Forms application that allows users to:
  - **Add** a student to the database.
  - **View** all students in a list.
  - **Update** student details.
  - **Delete** a student from the database.
  
- The application should use **ADO.NET** to perform database operations and handle user input via forms.

### **Bonus**:
- Handle errors and exceptions in the application (e.g., invalid user input, database connection issues).

---

## Conclusion

This roadmap will guide you through every step of learning desktop software development with **C#**, **.NET Framework**, and **MS SQL Server**. By the end of the course, you will have the skills to create desktop applications and interact with databases.

---

## Additional Resources
- [Microsoft Docs: C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Microsoft Docs: ADO.NET](https://docs.microsoft.com/en-us/dotnet/framework/data/ado-net/)
- [SQL Server Tutorials](https://www.sqlservertutorial.net/)

---

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
