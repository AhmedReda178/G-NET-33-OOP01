using System.Runtime.Intrinsics.X86;
using System.Security.Principal;

namespace AssignmentOOP01
{
    #region Part01


    #region Q01
    #region Class Example

    //class PersonClass
    //{
    //    public int Age;
    //}
    #endregion

    #region StructExample
    //struct PersonStruct
    //{
    //    public int Age;
    //}
    #endregion
    #endregion

    #region Q02
    //class BankAccount
    //{
    //    private double balance; 

    //    public void Deposit(double amount)
    //    {
    //        balance += amount;
    //    }

    //    public double GetBalance()
    //    {
    //        return balance;
    //    }
    //}
    #endregion


    #endregion

    #region Patr02

    #region Enum
    //public enum TicketType
    //{
    //    Standard,
    //    VIP,
    //    IMAX
    //}
    #endregion

    #region Struct
    //public struct Seat
    //{
    //    public char Row;
    //    public int Number;

    //    public Seat(char row, int number)
    //    {
    //        Row = row;
    //        Number = number;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Row}{Number}";
    //    }
    //}
    #endregion

    #region Class
    //public class Ticket
    //{
    //    public string MovieName;
    //    public TicketType Type;
    //    public Seat Seat;
    //    private double Price;

    //    // constructor
    //    public Ticket(string movieName, TicketType type, Seat seat, double price)
    //    {
    //        MovieName = movieName;
    //        Type = type;
    //        Seat = seat;
    //        Price = price;
    //    }

    //    // Default constructor 
    //    public Ticket(string movieName)
    //        : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
    //    {
    //    }

    //    // Calculate total with tax
    //    public double CalcTotal(double taxPercent)
    //    {
    //        return Price + (Price * taxPercent / 100);
    //    }

    //    // Apply discount
    //    public void ApplyDiscount(ref double discountAmount)
    //    {
    //        if (discountAmount > 0 && discountAmount <= Price)
    //        {
    //            Price -= discountAmount;
    //            discountAmount = 0;
    //        }
    //    }

    //    // Print ticket
    //    public void PrintTicket(double taxPercent)
    //    {
    //        Console.WriteLine("===== Ticket Info =====");
    //        Console.WriteLine($"Movie : {MovieName}");
    //        Console.WriteLine($"Type  : {Type}");
    //        Console.WriteLine($"Seat  : {Seat}");
    //        Console.WriteLine($"Price : {Price:F2}");
    //        Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent):F2}");
    //    }
    //}
    #endregion

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Q01
            //Q1 : Explain with code example how class and struct behave differently 

            //Answer :
            /* Class is a reference type and struct is a value type.
             * When you create an instance of a class, it is stored on the heap and a reference to that memory location is created.
             * When you create an instance of a struct, it is stored on the stack and the value is directly stored in the variable.
             * */
            #region ClassExample

            //PersonClass c1 = new PersonClass();
            //c1.Age = 20;

            //PersonClass c2 = c1;
            //c2.Age = 30;

            //Console.WriteLine("Class:");
            //Console.WriteLine($"c1.Age = {c1.Age}");
            //Console.WriteLine($"c2.Age = {c2.Age}");

            #endregion

            #region StructExample
            //PersonStruct s1 = new PersonStruct();
            //s1.Age = 20;

            //PersonStruct s2 = s1;
            //s2.Age = 30;

            //Console.WriteLine("Struct:");
            //Console.WriteLine($"s1.Age = {s1.Age}");
            //Console.WriteLine($"s2.Age = {s2.Age}");
            #endregion

            #endregion

            #region Q02
            //Q2 : Explain the difference between public and private access modifiers with an example.
            //Answer :
            /*
             Access modifiers are keywords used to control the visibility and accessibility of class members (variables and methods).
            public: The member can be accessed from anywhere in the program, including other classes.
            private: The member can only be accessed within the same class and cannot be accessed from outside.
            The purpose of private is to protect the data and achieve the concept of Encapsulation (data hiding).
             */

            //Code Example:

            //BankAccount acc = new BankAccount();
            //acc.Deposit(1000);
            //Console.WriteLine(acc.GetBalance());
            #endregion

            #region Q03
            //Q3: Describe the steps to create and use a class library in Visual Studio.
            //Answer: 
            /*
             To create and use a Class Library in Visual Studio, follow these steps:

                Open Visual Studio.

                Click Create a new project.

                Choose Class Library (.NET) as the project type.

                Enter the project name and click Create.

                Add the required classes and methods and make them public.

                Build the project.

                Create another project (e.g., Console Application).

                Right-click on Dependencies (or References).

                Select Add Project Reference.

                Choose the Class Library project and click OK.

                Write using LibraryName; in the code.

                Use the classes and methods from the library inside the project.
             
             */
            #endregion

            #region Q04
            //Q4 : What is a class library? Why do we use class libraries?
            // Answer: 
            /*
             * 
              * A Class Library is a collection of classes and methods compiled into a DLL file. It does not run independently; instead, it is used by another application.
              * We use class libraries for the following reasons:
              
              *  Code reusability.

              *  Reducing code duplication.

              *  Better project organization and modular design.

              *  Easier maintenance and updates.

              *  Sharing the same functionality across multiple applications.
              
             */
            #endregion


            #endregion

            #region Part02
            #region Question
            /*
             Movie Ticket Booking System : 

                    User Story: You're building a simple Movie Ticket Booking System for a cinema. The system manages ticket types, seat locations, pricing, and payments. Build it as a Console Application that reads data from the user and prints the booking summary.

                    what you need to build :
                    1.	Each ticket has a type that can only be one of: Standard, VIP, or IMAX. How would you represent this?
                    2.	You need a type to represent a seat location (Row as a char like 'A', 'B', and Number as an int). Should this be a class or a struct? Create it.
                    3.	Create a Ticket class with: 
                    a.	MovieName (public), 
                    b.	Type (public)
                    c.	Seat (public)
                    d.	Price (private). 
                    Sometimes a ticket is created with all info, sometimes with just the movie	 name (default type Standard, seat A1, price 50). Handle both without repeating initialization logic.

                    4.	Add three methods to the Ticket class:
                    a.	CalcTotal() — receives a taxPercent (double), calculates the total after tax and returns it. The original price must stay unchanged.
                    b.	ApplyDiscount() — receives a discountAmount (double) . If discount is valid (> 0 and ≤ Price), deducts it from Price and sets discountAmount to 0 (consumed). Otherwise, the discount stays unchanged.
                    c.	PrintTicket() — prints the full ticket info.

             
             */
            #endregion

            #region Answer
             
            //Console.Write("Enter Movie Name: ");
            //string movie = Console.ReadLine();

            //Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX): ");
            //TicketType type = (TicketType)int.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Row (A, B, C...): ");
            //char row = char.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Enter Price: ");
            //double price = double.Parse(Console.ReadLine());

            //Console.Write("Enter Discount Amount: ");
            //double discount = double.Parse(Console.ReadLine());

            //Seat seat = new Seat(row, number);
            //Ticket ticket = new Ticket(movie, type, seat, price);

            //ticket.PrintTicket(14);

            //Console.WriteLine("\n===== After Discount =====");
            //Console.WriteLine($"Discount Before : {discount:F2}");

            //ticket.ApplyDiscount(ref discount);

            //Console.WriteLine($"Discount After  : {discount:F2}");

            //ticket.PrintTicket(14);
            
            #endregion

            #endregion


        }
    }
}
