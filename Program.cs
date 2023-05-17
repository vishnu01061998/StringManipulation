using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.ExceptionServices;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String firstname, middlename, lastname, fullname;

            //Console.WriteLine("please enter firstname");
            //firstname = Console.ReadLine();

            //Console.WriteLine("please enter middlename");
            //middlename = Console.ReadLine();

            //Console.WriteLine("please enter lastname");
            //lastname = Console.ReadLine();

            //fullname = firstname +" " + middlename + " " + lastname;



            //Console.WriteLine(fullname);



            // calculate length of string 

            //Console.WriteLine("please enter any string");
            //var str = Console.ReadLine();

            //int Counter = 0;

            //foreach (var item in str)
            //{
            //    Counter++;
            //}
            //Console.WriteLine(Counter);



            // calculate the vowels from the string

            Console.WriteLine("please enter any string");
            var str = Console.ReadLine();

            int VowelsCounter = 0;
            foreach (var item in str)
            {
                if (item =='a' || item =='e' || item == 'i'|| item =='o'|| item =='u'||
                    item =='A' || item =='E' || item =='I' || item =='O'|| item =='U')
                {
                    VowelsCounter++;
                }
                
            }
            Console.WriteLine("Number of Vowels = "+VowelsCounter);

        }             


    }
}