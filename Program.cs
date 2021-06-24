using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//prams keyword is used to store multiple values
//it is used as paramter 
//it takes variable as number of arguments
//it is useful when programmers have no idea about how many number of parameters can be used
//if we are using any other parameter like int ,string then param should be the last parameter with it
//you cant make any other parameter after param 
namespace Params__C_sharp
{
    class Program
    {

        //create 1 static method of int type
        public static int Add(params int[] n) //params to store multiple values having array of integer type 
        {
            //create a variable and initialize to 0
         int   sum = 0;
            //access the array using foreach loop
            foreach(var i in n)
            {
                sum = sum + i;   //10+20+30+40+50,70,60,80,90
            }
            //return variable of method i.e. sum
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.Add(10,20,30,40,50,70,60,80,90));     //all these values got stored in n and then using foreach loop we accessed it by putting data in sum
            Console.ReadLine();

        }
    }
}
