using System;

namespace MethodeHiding_Practice
{
    static class Program
    {

        static void Main()
        {
            FEmployee fp = new FEmployee();
            fp.Fname = "Full";
            fp.Lname = "time";
            //Hide the inherited member
            fp.PrintFulllname();

            FEmployee fp1 = new FEmployee();
            fp1.Fname = "Full";
            fp1.Lname = "time";
            //Invoke the hiden inherited member using type casting
            ((Employee)fp).PrintFulllname();

            //Invoke the hiden inherited member using parent class referance variable
            Employee fp2 = new FEmployee();
            fp2.Fname = "Full";
            fp2.Lname = "time";
            fp2.PrintFulllname();

            PEmployee pp = new PEmployee();
            pp.Fname = "Part";
            pp.Lname = "time";
            pp.PrintFulllname();

        }



    }
    //Parent Class
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public void PrintFulllname()
        {
            Console.WriteLine(Fname + Lname);
        }
    }

    //child
    public class FEmployee : Employee
    {
        //This methode hide inherited parent class print methode.
        public new void PrintFulllname()
        {
            Console.WriteLine(Fname + Lname +" - Hide Methode");
        }

        //invoke hiden inherited member using base keyword
        //public new void PrintFulllname()
        //{
        //    base.PrintFulllname();
        //}

        public float YearlySal { get; set; }

    }

    //child
    public class PEmployee : Employee
    {
        public float HourlySal { get; set; }


    }
}
