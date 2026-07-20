// class --> private var --> set method --> get data type method ---> return ---> main func ---> output

// class Student
// {
//     private string Name;
//     public void SetName(string name)
//     {
//         Name = name;
//     }
//     public string GetName()
//     {
//         return Name;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student s1 = new Student();
//         s1.SetName("Hassan khan");
//         Console.Write(s1.GetName());
//     }
// }


// Task 1 -----
// class Car
// {
//     private string Brand = "";

//     public void SetBrand(string brand)
//     {
//         Brand = brand;
//     }
//     public string GetBrand()
//     {
//         return Brand;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Car C = new Car();
//         C.SetBrand("Toyota");
//         Console.Write(C.GetBrand());
//     }
// }

// Task 02 ------

// class Person
// {
//     private string Name = "";
//     private int Age = 0;

//     public void SetName(string name)
//     {
//         Name = name;
//     }
//     public string GetName()
//     {
//         return Name;
//     }
//     public void SetAge(int age)
//     {
//         Age = age;
//     }
//     public int GetAge()
//     {
//         return Age;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Person P = new Person();
//         P.SetName("Hassan");
//         Console.WriteLine(P.GetName());
//         P.SetAge(90);
//         Console.Write(P.GetAge());
//     }
// }

// Task:03----------
// class Bankaccount
// {
//     private int Balance = 0;

//     public void SetBalance(int balance)
//     {
//         if (balance > 0)
//         {
//             Balance = balance;
//             // Console.WriteLine("Current Balance: " + Balance);
//         }
//         else
//         {
//             Console.WriteLine("Invalid Balance");
//         }
//     }

//     public int GetBalance()
//     {
//         return Balance;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Bankaccount b = new Bankaccount();
//         b.SetBalance(1000);
//         Console.WriteLine(b.GetBalance());
//     }
// }

// 1) Create a Person class with private fields name and age. Use properties for encapsulation. Create a derived class Student that adds a rollNumber. Display all details.

// using System.Security.Claims;

// class Person
// {
//     private string Name = "";
//     private int Age = 0;

//     public void SetName(string name)
//     {
//         Name = name;
//     }
//     public string GetName()
//     {
//         return Name;
//     }
//     public void SetAge(int age)
//     {
//         Age = age;
//     }
//     public int GetAge()
//     {
//         return Age;
//     }
// }

// class Student : Person
// {
//     public int rollNum = 0;


//     public void Show(int rnum)
//     {
//         rollNum = rnum;
//         Console.WriteLine("Student Name: " + GetName());
//         Console.WriteLine("Student Age: " + GetAge());
//         Console.WriteLine("Student roll number: " + rollNum);
//     }

// }

// class Program
// {
//     static void Main()
//     {
//         Student S = new Student();
//         S.SetName("Hassan");
//         S.SetAge(90);
//         S.Show(5);
//     }
// }

// 2) Create a Vehicle base class with a method Start(). Inherit a Car class from Vehicle and add a method Drive(). Create an object of Car and call both methods.

// class Vehicle
// {
//     public void Start()
//     {
//         Console.WriteLine("Vehicle started");
//     }
// }
// class Car : Vehicle
// {
//     public void Drive()
//     {
//         Console.WriteLine("Driving");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Car c = new Car();
//         c.Start();
//         c.Drive();
//     }
// }

// 3) Design an Employee class with private salary field. Use getter and setter methods to access salary. Create a derived class Manager and display manager details along with salary.

// class Employee
// {
//     private int Salary;
//     public void SetSalary(int salary)
//     {
//         Salary = salary;
//     }
//     public int GetSalary()
//     {
//         return Salary;
//     }
// }

// class Manager : Employee
// {
//     public void Show()
//     {
//         Console.WriteLine("This is manager");
//         Console.WriteLine("Salary is: " + GetSalary());
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Manager m = new Manager();
//         m.SetSalary(1000);
//         m.Show();
//     }
// }

// 4) Create a BankAccount class with a private balance variable. Provide Deposit() and Withdraw() methods. Create a derived class SavingsAccount and demonstrate account operations.

// class BankAccount
// {
//     private int balance = 1000;

//     public void SetBalance(int ammont)
//     {
//         balance = balance + ammont;
//     }
//     public int GetBalance()
//     {
//         return balance;
//     }
//     public void SetWithdraw(int depositeAmmount)
//     {
//         balance = balance - depositeAmmount;
//     }
//     public int GetWithdraw()
//     {
//         return balance;
//     }

// }


// class Program()
// {
//     static void Main()
//     {

//         BankAccount b = new BankAccount();
//         Console.Write("enter 1 for (deposite) or 2 for (withdrowal) ");
//         int userInput = int.Parse(Console.ReadLine());
//         if (userInput == 1)
//         {
//             Console.Write("Enter deposite ammount: ");
//             int ammount = int.Parse(Console.ReadLine());
//             b.SetBalance(ammount);
//             Console.WriteLine("Current balance: " + b.GetBalance());
//         }
//         else if (userInput == 2)
//         {
//             Console.Write("Enter Withdraw ammount: ");
//             int withdrawAmmount = int.Parse(Console.ReadLine());
//             b.SetWithdraw(withdrawAmmount);
//             Console.WriteLine("Current balance: " + b.GetWithdraw());


//         }
//         else
//         {
//             Console.WriteLine("no withdraw avaliable");
//         }


//     }
// }

// ------------------------------------
//           Abstraction
// ------------------------------------

// Question 1
// Create an abstract class Vehicle with an abstract method DisplayInfo().
// Derive Car and Bike classes that include private fields for brand and speed.
// Use properties for encapsulation and override the DisplayInfo() method.

// abstract class Vehicle
// {
//     private string brand;
//     private int speed;
//     public string Brand
//     {
//         get { return brand; }
//         set { brand = value; }
//     }
//     public int Speed
//     {
//         get { return speed; }
//         set { speed = value; }
//     }
//     public abstract void DisplayInfo();
// }

// class Car : Vehicle
// {
//     public override void DisplayInfo()
//     {
//         Console.WriteLine("-----------------Car info-------------------");
//         Console.WriteLine("Brand: " + Brand);
//         Console.WriteLine("Speed: " + Speed + " K/M");
//     }
// }

// class Bike : Vehicle
// {
//     public override void DisplayInfo()
//     {
//         Console.WriteLine("-----------------Bike info-------------------");
//         Console.WriteLine("Brand: " + Brand);
//         Console.WriteLine("Speed: " + Speed + " K/M");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Car car = new Car();
//         car.Brand = "Honda";
//         car.Speed = 102;
//         car.DisplayInfo();

//         Bike bike = new Bike();
//         bike.Brand = "Toyota";
//         bike.Speed = 110;
//         bike.DisplayInfo();
//     }
// }

//  Question 2
// Create a class BankAccount with private fields: accountNumber, balance.
// Use public methods Deposit() and Withdraw() with balance checks.
// Show how encapsulation keeps the balance safe from direct modification.

// class BankAccount
// {
//     private string accountNumber;
//     private int balance;

//     public string accNum
//     {
//         get { return accountNumber; }
//         set { accountNumber = value; }
//     }
//     public int blce
//     {
//         get { return balance; }
//         set { balance = value; }
//     }

//     public void Deposit(int dep)
//     {
//         balance += dep;
//         Console.WriteLine("Balance: " + balance);

//     }

//     public void Withdrw(int wtd)
//     {
//         balance -= wtd;
//         Console.WriteLine("Balance: " + balance);


//     }
// }

// class Program
// {
//     static void Main()
//     {
//         BankAccount bk = new BankAccount();
//         bk.accNum = "abc";
//         bk.blce = 1000;

//         // bk.Deposit(500);
//         bk.Withdrw(500);
//     }
// }

// -------------------- Abstraction and polymorphism --------------------------------
// Question:1 
// Create an abstract class Employee with an abstract method CalculateSalary().
// Make two child classes FullTimeEmployee and PartTimeEmployee.

// Full-time salary = fixed monthly salary

// Part-time salary = hoursWorked × hourlyRate
// Use a simple if statement to print “Low income” if salary < 20000.


// abstract class Empoyee
// {
//     private int monthly_salary = 50000;
//     public int Full_salary
//     {
//         get { return monthly_salary; }
//     }

//     public abstract void CalculateSalary();
// }

// class FullTimeEmployee : Empoyee
// {
//     public override void CalculateSalary()
//     {
//         Console.WriteLine("your are Full time employee and your salary is: " + Full_salary);

//     }
// }

// class PartTimeEmployee : Empoyee
// {
//     private int hourlyRate = 200;
//     public int hour_rate
//     {
//         get { return hourlyRate; }
//     }
//     private int hoursWorked;
//     public int hours
//     {
//         get { return hoursWorked; }
//         set { hoursWorked = value; }
//     }
//     public override void CalculateSalary()
//     {
//         int part_time_salary = hour_rate * hours;
//         Console.WriteLine("Your are a part time employee and you woorked " + hours + " hours.");
//         Console.WriteLine("Your salary is: " + part_time_salary);

//     }
// }

// class Program
// {
//     static void Main()
//     {
//         FullTimeEmployee fullemp = new FullTimeEmployee();
//         fullemp.CalculateSalary();

//         PartTimeEmployee prtemp = new PartTimeEmployee();
//         Console.Write("Enter your worked hours: ");
//         int hur = Convert.ToInt32(Console.ReadLine());
//         prtemp.hours = hur;
//         prtemp.CalculateSalary();
//     }
// }


// Question:2
// Create a base class Vehicle with a virtual method Start().
// Make Car and Bike classes that override Start() with different messages.
// Call Start() using a Vehicle object.


// class Vehicle
// {
//     public virtual void Start()
//     {
//         Console.WriteLine("Vehicle started");
//     }
// }

// class Car : Vehicle
// {
//     public override void Start()
//     {
//         Console.WriteLine("Car starts with key");
//     }
// }
// class Bike : Vehicle
// {
//     public override void Start()
//     {
//         Console.WriteLine("Bike starts with kick");
//     }
// }

// class Program
// {
//     static void Main()
//     {

//         Vehicle v = new Vehicle();

//         v.Start();
//         Car c = new Car();
//         c.Start();
//         Bike B = new Bike();
//         B.Start();
//     }



// }

// ------------------ Pillars Practice --------------------------
// ----------------- Encapsulation -------------------
// 1)
// class BankAccount
// {
//     private int Balance = 1000;
//     public int balance
//     {

//         get { return Balance; }
//     }

//     public void Deposite(int ammount)
//     {
//         Balance += ammount;
//         Console.WriteLine("Your New Balance is: " + Balance);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         BankAccount acc = new BankAccount();
//         acc.Deposite(500);
//     }
// }
//  2) Library 
// class Library
// {
//     private string Title = "Physics";
//     private string Author = "John";
//     private bool isAvaliable = true;
//     public string title
//     {
//         get { return Title; }
//     }
//     public string author
//     {
//         get { return Author; }
//     }
//     public bool Status
//     {
//         get { return isAvaliable; }
//     }


//     public void BorrowBook()
//     {
//         if (Status == true)
//         {
//             Console.WriteLine("Book borrow successfully ");
//             isAvaliable = false;
//         }
//         else
//         {
//             Console.WriteLine("Book already borrowed ");

//         }

//     }
//     public void ReturnBook()
//     {
//         if (!isAvaliable)
//         {
//             Console.WriteLine("Book returned ");
//             isAvaliable = true;


//         }

//     }

//     class Program
//     {
//         static void Main()
//         {
//             Library lib = new Library();
//             lib.BorrowBook();
//             lib.ReturnBook();
//         }
//     }
// }
// ----------------------- Inheritance ------------------

class Person
{
    public string Name = "abc";
    public int age = 90;

    public void Show()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + age);
    }
}

class Student : Person
{
    public string Course = "BSCS";
    public void Showw()
    {
        Console.WriteLine("Course: " + Course);
    }
}

class Teacher : Person
{
    public string Subject = "English";

    public void Teach()
    {
        Console.WriteLine("Teachers Subject is: " + Subject);
    }
}

class Program
{
    static void Main()
    {
        Student std = new Student();
        std.Show();
        std.Showw();

        Teacher tech = new Teacher();
        tech.Teach();


    }

}