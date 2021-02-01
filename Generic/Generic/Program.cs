using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNewList = new List<int>();




            NewClass newClass = new NewClass();
            newClass.Property = 20;
            newClass.Property2 = 40;
            newClass.Property3 = 60;


            myNewList.Add(20);
            myNewList.Add(40);
            myNewList.Add(60);

            foreach (var NewClass in myNewList)
            {
                Console.WriteLine(newClass.Property);
                Console.WriteLine(newClass.Property2);
                Console.WriteLine(newClass.Property3);
                Console.WriteLine();
            }




            Newclass<int> newclass = new Newclass<int>();
            newclass.PropertyA = 30;
            newclass.GenericProperty = 60;

            foreach (var NewClass in myNewList)
            {
                Console.WriteLine(newclass.PropertyA);
                Console.WriteLine(newclass.GenericProperty);
                Console.WriteLine();
            }


            Newclass<int> newclass2 = new Newclass<int>();
            newclass.PropertyA = 2;
            newclass.GenericProperty = 5;


            foreach (var NewClass in myNewList)
            {
                Console.WriteLine(newclass.PropertyA);
                Console.WriteLine(newclass.GenericProperty);
                Console.WriteLine();
            }



        }
    }
}

public class NewClass
{
    public int Property { get; set; }
    public int Property2 { get; set; }
    public int Property3 { get; set; }


}

public class Newclass<T>
{
    public int PropertyA { get; set; }
    public T GenericProperty { get; set; }
}
        
    


