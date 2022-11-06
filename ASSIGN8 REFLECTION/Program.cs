using System;
using System.Reflection;

namespace Assignment8
{
    public class program
    {
        static void Main(string[] args)
        {

            Type T = Type.GetType("Assignment8.Customers");

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
            }
            Console.WriteLine("-------Loading assembly dynamically and involving a method-------");
            try
            {
                string dllfile = @"D:\classLibrary\ClassLibrary3.dll";
                var assembly = Assembly.LoadFile(dllfile);

                var Type = assembly.GetType("ClassLibrary3.HelloWorld");

                var obj = Activator.CreateInstance(Type);

                var method = Type.GetMethod("Hello");
                var r = method.Invoke(obj, new object[] { " everyone" });
                Console.WriteLine(r);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    internal class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customers(int id, string name)
        {
            this.Id = id;
            this.Name = name;

        }
        public Customers()
        {
            this.Id = -1;
            this.Name = String.Empty;
        }
        public void print()
        {
            Console.WriteLine($"ID={Id}");
        }
        public void printname()
        {
            Console.WriteLine($"Name ={Name}");
            Console.ReadLine();
        }

    }



}
