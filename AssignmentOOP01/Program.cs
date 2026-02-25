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
        }
    }
}
