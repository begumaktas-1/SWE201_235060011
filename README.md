# StudentGrade Console Application

This project is a simple C# console application created for the SWE201 lab course.

## Purpose

The application represents a student with:
- Student number
- Full name
- Midterm grade
- Final grade

It calculates the average and determines if the student has passed or failed.

## Class Structure

The project includes:

- `Student` class:
  - Member variables: `_studentNumber`, `_fullName`, `_midterm`, `_final`
  - Properties: `StudentNumber`, `FullName`, `Midterm`, `Final`
  - Constructors: empty constructor and constructor with parameters
  - Member functions: `CalculateAverage()`, `GetStatus()`
  - `ToString()` override for formatted output

- `Program` class:
  - `Main` method creates `Student` objects, performs operations and writes results to the console.

## How to Run

1. Open the project in Visual Studio.
2. Build the solution.
3. Run the application.
4. Check the console output.
