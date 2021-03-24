using System;

class employee
{
  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;

  public employee()
  {
    firstname = "unknown";
    lastname = "unknown";
    id = "unknown";
    age = 0;
    employmentstatus = "active";
  }

  public employee(string efirstname, string elastname, string eid, int eage, string eemploymentstatus)
  {
    firstname = efirstname;
    lastname = elastname;
    id = eid;
    age =eage;
    employmentstatus = eemploymentstatus;
  }

  public void Intro()
  {
    Console.WriteLine("First name is " + firstname);
    Console.WriteLine ("Last name is " + lastname);
    Console.WriteLine ("ID is " + id);
    Console.WriteLine ("Age is " + age);
    Console.WriteLine ("Employment status is " + employmentstatus);
  }

}