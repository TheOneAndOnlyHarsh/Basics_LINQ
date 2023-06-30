using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Basics_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };


            // this is how we use linq
            var numQuery =
            from num in numbers
            where (num % 2) == 0
            select num;

            foreach (int num in numQuery)
            {
             //   Console.WriteLine("{0,1} ", num);
            }

            // Linq using string:
            List<String> list = new List<String> {"Anish" , "Bijoy" , "Harsh" ,"Ram"};

            var liststr = from i in list
                          //where clouse
                          where(i.Length==3)
                          //select query
                          select i;

            foreach (String i in liststr)
            {
              //  Console.Write(i);

            }

            //using where method insted of a key:

            List<String> names = new List<String>();

            names.Add("Harsh");
            names.Add("Vinod");

            names.Add("Shashank");

            names.Add("Ajeet");

            //here where method is used which takes two params one is the name of the single list
            //other is index

            var modiStr = names.Where((name, index) => name.Length<index);

          //  Console.WriteLine("Short String: ");
            foreach(var name in modiStr)
            {

             //   Console.WriteLine($" the word {name} is shorter then its values");
            }
*/
            // using string and numbers togther:
            // int[] num2 = { 4, 5, 6 }; --> this will thwor an excp,

            /*int[] num2 = { 0, 1, 2 };
            string[] str = { "two" , "one" ,"zero"};

            var values = from i in num2
                         select str[i];

            foreach (var d in values) {

                Console.WriteLine(d);
            


            }*/


            // partitions

            /* List<string> list = new List<string> { "harsh" , "rahul" , "sumit" };

             //.take method will print valus til the length 
             var newlist =list.Take(1);

             foreach (var item in newlist) 
             {
                 Console.WriteLine(item);


             }*/

            //Using generic in list

            /* List<Geo> geo = new List<Geo> {
                 new Geo { Latitude=111,Longitude=222,Unit="jjj"},
                 new Geo { Latitude = 112, Longitude = 223, Unit = "nnn" },
                 new Geo { Latitude = 113, Longitude = 224, Unit = "kkk" }
             };

             var first2 = from a in geo
                          from Unit in a.Unit
                          where a.Longitude==223
                          select a;*/


            //looping for print list data in console.
            /* foreach (var s in geo)
             {
                 Console.WriteLine(s.Latitude);
             }*/

            /*  foreach(var i in first2)
               {

                   Console.WriteLine(i);
               }*/



            // working with takeWhile:

            /*int[]  numbers  = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            var newList = numbers.TakeWhile(n => n <  8);

            foreach (var n in newList)
            {
                Console.WriteLine(n);
            }*/


            /* List <String> str1 = new List <String> { "harsh" , "amit" , "vijay"};

             List<String> str2 = new List<String> { "harsh", "amit", "vijay" };

             List<String> str3 = new List<String> { "harsh", "amit", "noname" };
             // using sequenceEqual method:
           //  bool match = str1.SequenceEqual(str2);
                 bool match2 = str3.SequenceEqual(str1);
             //
           //  Console.WriteLine($"the two strings are same: {match}");

             Console.WriteLine(match2); */




            /*int[] vector = { 4, 5, 6, 7 };
            int[] vector2 = { 8, 9, 9, 0 };

            //using for . product:
            var product = vector.Zip(vector2, (a, b) => a * b).Sum();

            Console.WriteLine(product);*/



            // compareing two lists:

            /*int[] numbers = { 4, 5, 7 };
            int[] numbers2 = { 2, 3, 7 };

            var pairs = from a in numbers
                        from b in numbers2
            // if we remove where then it will print all possible combos.
                        where a == b
                        select (a, b);

            foreach ( var pair in pairs )
            {

                Console.WriteLine($"{ pair} {pair.b} {pair.b}"  );
            }*/



            // lazy query execution:

            int[] num = { 1,8,8,2,8 };

            int i = 0;
            var a = (from x in num
                     select i++).ToList();

            foreach (var x in a) { 

                Console.WriteLine($"x={x} and i {i}" );
            
            }
            foreach (var x in a)
            {

                Console.WriteLine($"x={x} and i {i}");

            }
        }
    }
}