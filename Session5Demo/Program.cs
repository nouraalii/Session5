using System;
using System.Security.AccessControl;

namespace Session5Demo
{
    internal class Program
    {
        #region Exception Handling and protective code
        //static void DoSumCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        X = int.Parse(Console.ReadLine()); //FormatException
        //        Y = int.Parse(Console.ReadLine()); //FormatException

        //        Z = X / Y; //DivideByZeroException
        //        int[] Arr = { 1, 2, 3 };
        //        Arr[99] = 100; //IndexOutOfRangeException
        //    }
        //    catch(Exception E)
        //    {
        //            Console.WriteLine(E.Message);
        //    }
        //    finally
        //    {
        //        //code
        //        //Console.WriteLine("Finally");
        //        //Disconnect | Dispose UnManaged Resource (File,DB)
        //    }
        //}

        //static void DoSumProtectiveCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        bool Flag;
        //        do
        //        {
        //            Console.WriteLine("Enter First Number");
        //            Flag = int.TryParse(Console.ReadLine(), out X);
        //        }
        //        while (Flag);


        //        do
        //        {
        //            Console.WriteLine("Enter Second Number");
        //            Flag = int.TryParse(Console.ReadLine(), out Y);
        //        }
        //        while (Flag || Y == 0);

        //        Z = X / Y;

        //        int[] Arr = { 1, 2, 3 };

        //        if (Arr is not null)
        //        {
        //            int Index;
        //            do
        //            {
        //                Console.WriteLine("Enter Index Number");
        //                Flag = int.TryParse(Console.ReadLine(), out Index);
        //            }
        //            while (Flag || (Index >= 0 && Index < Arr.Length));
        //        }

        //        Arr[99] = 100;
        //    }
        //    catch(Exception E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }
        //} 
        #endregion


        static void Main(string[] args)
        {
            #region Boxing  and unBoxing
            //Boxing  and unBoxing
            //Boxing : casting from datatype [valuetype] to datatype [Referencetype]
            //UnBoxing : casting from datatype [Referencetype] to datatype[valuetype]
            //object O1;
            //O1 : can refer to instance from 'object' or any instance from any datatype
            //O1 = /*(object)*/ 1; //casting from int[valuetype] to object [Referencetype]
            //O1 = /*(object)*/ 1.5; //casting from int[valuetype] to object [Referencetype]
            //O1 = 'A';
            //O1 = true;
            //O1 = new Datetime;

            //int X = 12;
            //object O1 = /*(object)*/ X;
            ////implicit casting 
            ////safe casting
            ////parent => child
            ////animal => Dog : Dog 

            //UnBoxing

            //object O1 = "Ahmed";
            //int X = (int)O1;
            ////Explicit Casting 
            ////Unable Casting : May Throe Exception 
            ////Child => Parent 
            ////Dog =>(Dog) Animal : Animal is Dog
            //Console.WriteLine(X); 
            #endregion


            #region Nullable Types
            //Nullable Types
            #region Nullable Value Types
            //Value Types
            //int X = 12;
            //Console.WriteLine(X);

            //int Age = 30;
            //Console.WriteLine(Age);

            //Age = null; //Incvalid : int : Don;t allow  null as valid  value

            //Nullabale Value Type : Allow  Null as Valid Value;
            //Nullabale<int> : age :-> Allow ints Value + Null as Valid Value
            //int? Age = 30;

            //Age = null;

            //Console.WriteLine(Age);

            //Nullable<Double> : Allow Double Value + Null as Valid Value
            //double? Salary = 20000; 
            ////Salary = null ;
            //Console.WriteLine(Salary);

            //int X = 12;


            ////Y : Nullable<int> ints Value + Null as Valid Value

            //int? Y =(int?)X;

            //Console.WriteLine(Y);


            //int? X = 12;

            //X = null;

            ////Y :int ints Value only 

            //int Y = (int)X;

            //Console.WriteLine(Y);


            //Protective Code 
            //int? X = 12;
            //X = null;

            //int Y;

            //if (X != null)
            //{
            //    Y = (int)X;
            //}
            //else 
            //{
            //    Y = 0;
            //}

            //========================================
            //if (X is not null)
            //{
            //    Y = (int)X;
            //}
            //else
            //{
            //    Y = 0;
            //}
            //=========================================

            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;
            //==========================================

            //Y = X.HasValue ? X.Value : 0;

            //Null Coalescing operator
            //??

            //Y = X ?? 0; //Y = X.HasValue ? X.Value : 0;
            //Console.WriteLine(Y); 
            #endregion


            #region Nullable Reference types
            ////Nullable Reference types (c# 10.0 Dotnet 6.0)
            ////Reference type : allow  Null as Valid

            //string Message01 = null ; //Required
            //string? Message02 = null ; //Optional


            //Console.WriteLine(Message01);
            //Console.WriteLine(Message02);  
            #endregion

            #endregion


            #region Null Propagition operator
            //Null Propagition operator
            //?

            //DateTime X = default;
            //Console.WriteLine(X);

            //int[] Arr = default; //Null
            //int[] Arr = {1,2,3};
            //Console.WriteLine(Arr);

            //NullReferenceException
            //for (int i = 0; (Arr is  not null)&& i < Arr.Length; i++) 
            //{
            //    Console.WriteLine(Arr[i]);
            //}

            //for (int i = 0; i < Arr?.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}

            //if (Arr is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        Console.WriteLine(Arr[i]);
            //    }
            //}

            //NullReferenceException

            //int Len = Arr is not null ? Arr.Length : 0;
            //int? Len = Arr?.Length;
            //int Len = Arr?.Length is not null ? Arr.Length : 0;
            //int Len = Arr?.Length ?? 0;
            //Console.WriteLine(Len); 
            #endregion

            #region Exception Handling and protective code
            ////Exception Handling and protective code

            ////Exception Handling : Runtime error

            ////Console.WriteLine("Hello before Exception");

            ////throw new Exception();

            ////Console.WriteLine("Hello After Exception");


            //DoSumCode();

            //Console.WriteLine("Hello After Exception");

            ////Exception:
            ////1.System Exception
            ////1.1. NullReferceneExeption
            ////1.2. FormatException
            ////1.3. IndexOutOfRangeException
            ////1.4. ArithmeticException
            ////1.4.1 DivideByZeroException
            ////1.4.2 OverFlowException


            ////2.Application Exception

            //DoSumProtectiveCode(); 
            #endregion

            //Class Library
            //TypeA typeA = new TypeA() // invalid typeA 
            //    typeA.X = 12; //Invalid X is Private
            //    typeA.Y = 12; //Invalid Y is Internal
            //    typeB.Z = 12; // Valid

            





        }
    }
}
