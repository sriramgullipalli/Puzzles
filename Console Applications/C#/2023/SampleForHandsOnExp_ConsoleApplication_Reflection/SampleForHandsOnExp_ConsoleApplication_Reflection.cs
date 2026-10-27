using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Reflection
{
    class SampleForHandsOnExp_ConsoleApplication_Reflection
    {
        static void Main(string[] args)
        {
            //Type type = typeof(ReflectionClass);
            Type type = Type.GetType("SampleForHandsOnExp_ConsoleApplication_Reflection.ReflectionClass");            
            Console.WriteLine(type.FullName);

            PropertyInfo[] propertyInfo =  type.GetProperties();            
            Console.WriteLine(propertyInfo[0].Name);

            MethodInfo[] methodInfo = type.GetMethods();
            Console.WriteLine(methodInfo[0].Name);


            //LateBinding Code.
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type lateBindingType = assembly.GetType("SampleForHandsOnExp_ConsoleApplication_Reflection.LateBindingClass");
            MethodInfo getFullNameMethod = lateBindingType.GetMethod("GetFullName");
            Object lateBindingClassInstance =  Activator.CreateInstance(lateBindingType);
            string[] parameters = new string[2] { "Sri", "Ram" };
           Console.WriteLine((string)getFullNameMethod.Invoke(lateBindingClassInstance, parameters));

        }
    }

    class ReflectionClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void print()
        {
            Console.WriteLine("Hello");
        }
    }

}
