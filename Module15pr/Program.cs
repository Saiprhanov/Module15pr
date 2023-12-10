using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Module15_Practise
{
    public class Program
    {

        
        static void Main(string[] args)
        {
            ExploreType<MyClass>();
            CreateInstanceUsingReflection();
            ManipulateObject();
            InvokePrivateMethod();
        }



        
        static void ExploreType<T>()
        {
            Type type = typeof(T);
            Console.WriteLine($"Name of Class: {type.Name}");
            Console.WriteLine("Constructors:");
            foreach (var constructor in type.GetConstructors())
            {
                Console.WriteLine(constructor);
            }
            Console.WriteLine("Fields and properties:");
            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"{field.FieldType} {field.Name}");
            }

            foreach (var property in type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"{property.PropertyType} {property.Name}");
            }
            Console.WriteLine("Metods:");
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"{method.ReturnType} {method.Name}");
            }

            Console.WriteLine();
        }


        

        static void CreateInstanceUsingReflection()
        {
            Type type = typeof(MyClass);
            object instance = Activator.CreateInstance(type);

            Console.WriteLine("The MyClass instance was created using reflection.");
            Console.WriteLine();
        }
        static void ManipulateObject()
        {
            MyClass myObject = new MyClass();
            PropertyInfo publicProperty = myObject.GetType().GetProperty("PublicProperty");
            publicProperty.SetValue(myObject, 99);


            
            MethodInfo calculateSumMethod = myObject.GetType().GetMethod("CalculateSum");
            int result = (int)calculateSumMethod.Invoke(myObject, new object[] { 5, 7 });

            Console.WriteLine($"Changed value PublicProperty: {myObject.PublicProperty}");
            Console.WriteLine($"The result of calling the method CalculateSum: {result}");
            Console.WriteLine();
        }

        
        static void InvokePrivateMethod()
        {
            MyClass myObject = new MyClass();
            MethodInfo privateMethod = myObject.GetType().GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            privateMethod.Invoke(myObject, null);

            Console.WriteLine();
        }
    }
}
    }
}
