using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Object Oriented Programming - Employee");

    employee unknown = new employee(); //constructor with no parameters
    unknown.Intro();

    employee john = new employee("John", "Smith", "1234", 45, "active");
    john.Intro();
  }
}