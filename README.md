# Practice-Abstraction

This project demonstrates the use of abstraction in C#. It simulates a company's employee management system where each employee has common attributes but different roles. 
The project uses an abstract base class to define common properties and an abstract method that is implemented by derived classes to display the employee's role.

## Features
Abstract Base Class (Company): Defines common attributes such as Name, Surname, and Department, and an abstract method Mission().

### Derived Classes:

SoftwareDeveloper: Represents a software developer with a specific implementation of the Mission() method.
ProjectManager: Represents a project manager with its own implementation of the Mission() method.
SalesManager: Represents a sales manager and implements the Mission() method accordingly.

## How It Works
Define Common Attributes: The Company abstract class includes properties that are common to all employees and an abstract method Mission() which must be implemented by derived classes.

Implement Roles: Each derived class (SoftwareDeveloper, ProjectManager, SalesManager) provides its own implementation of the Mission() method. This method prints a role-specific message to the console.

Create and Use Objects: In the Main method of the Program class, instances of the derived classes are created. Each instance is initialized with specific details (name, surname, department), and the Mission() method is called to display the employee's role.


![image](https://github.com/user-attachments/assets/56f85093-65ca-4066-a994-267d71659496)

### Requirements and Technologies used
C# Compiler (e.g., .NET SDK

Basic understanding of object-oriented programming and abstraction
