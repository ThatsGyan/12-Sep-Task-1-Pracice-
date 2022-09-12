namespace _12_Sep_Task_1_Pracice_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nullable type

            //use  "?" to create nullable

            bool? Major = null;

            if (Major == true)
            {
                Console.WriteLine("user is Major");
            }
            else if (Major == null)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("Currently you don't want to tell");
            }


            //string interpolation//

            //Console.WriteLine("Enter your first name");
            //string FName = Console.ReadLine();
            //Console.WriteLine("Enter your Last  name");
            //string LName = Console.ReadLine();
            //Console.WriteLine("Enter your Age  ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Your name is {FName}{LName} and the user age is {Age}");

            //tuple 
            //// tuple using create method
            ///
            var tuple1 = Tuple.Create("Gyan","rahul","mudit","mansi");//4 tuple
            var tuple2 = Tuple.Create(10, 11, 12, 13, 14, 15, 16,17);
            var tuple3 = Tuple.Create(13, "SQl", 14, "C#", 16);
            //accessing tuple data
            Console.WriteLine("Element of tuple 1 on 4th position is : "+ tuple1.Item4);
            Console.WriteLine("Element of tuple 3 on 3th position is : " + tuple3.Item3);

            //Creating tuple using Cunstructor of tuple class//

            Tuple<string > tuple4 = new Tuple<string>("Gyan");
        }
    }
}