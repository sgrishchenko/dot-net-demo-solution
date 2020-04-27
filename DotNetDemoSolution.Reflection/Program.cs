using System;
using System.Reflection;

namespace DotNetDemoSolution.Reflection
{
    class Program
    {
        static void Main()
        {
            int x;
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
                Console.WriteLine("Found: " + type.Name);
            Console.WriteLine();


            for (x = 0; x < types.Length; x++)
            {
                if (types[x].Name == "MyClass") break;
            }
            if (x == types.Length)
            {
                Console.WriteLine("Suitable class has not been found.");
                return;
            }
            else
            {
                Console.WriteLine("Class MyClass has been found.");
            }
            Console.WriteLine();

            Type t = types[x];
            MethodInfo[] methods;
            Console.WriteLine("Methods from class " + t.Name + ":");

            methods = t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            foreach (MethodInfo method in methods)
            {
                Console.Write("  " + method.ReturnType.Name + " " + method.Name + "(");
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    ParameterInfo parameter = parameters[i];
                    Console.Write(parameter.ParameterType.Name + " " + parameter.Name);
                    if (i != parameters.Length - 1) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine();

            Console.WriteLine("Constructors from class " + t.Name + ":");

            ConstructorInfo[] constructors = t.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.Write("  " + t.Name + "(");

                ParameterInfo[] parameters = constructor.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    ParameterInfo parameter = parameters[i];
                    Console.Write(parameter.ParameterType.Name + " " + parameter.Name);
                    if (i != parameters.Length - 1) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine();

            for (x = 0; x < constructors.Length; x++)
            {
                ParameterInfo[] parameters = constructors[x].GetParameters();
                if (parameters.Length == 2) break;
            }
            if (x == constructors.Length)
            {
                Console.WriteLine("Suitable constructor has not been found.");
                return;
            }
            else
            {
                Console.WriteLine("Constructor with two parameters has been found.");
            }
            Console.WriteLine();

            object[] constructorArgs = new object[2];
            constructorArgs[0] = 10;
            constructorArgs[1] = 20;
            object reflectObj = constructors[x].Invoke(constructorArgs);

            Console.WriteLine("Methods invocation from class " + t.Name + ":");

            methods = t.GetMethods();
            foreach (MethodInfo method in methods)
            {

                ParameterInfo[] parameters = method.GetParameters();
                if (method.Name == "Set" && parameters[0].ParameterType == typeof(int))
                {
                    object[] args = new object[2];
                    args[0] = 9;
                    args[1] = 18;
                    method.Invoke(reflectObj, args);
                }
                else if (method.Name == "Set" && parameters[0].ParameterType == typeof(double))
                {
                    object[] args = new object[2];
                    args[0] = 1.12;
                    args[1] = 23.4;
                    method.Invoke(reflectObj, args);
                }
                else if (method.Name == "Sum")
                {
                    int val = (int)method.Invoke(reflectObj, null);
                    Console.WriteLine("Sum equals " + val);
                }
                else if (method.Name == "IsBetween")
                {
                    object[] args = new object[1];
                    args[0] = 14;
                    if ((bool)method.Invoke(reflectObj, args))
                        Console.WriteLine("Value " + args[0] + " is between x and y");
                }
                else if (method.Name == "Show")
                {
                    method.Invoke(reflectObj, null);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Attributes from class " + t.Name + ":");

            object[] attributes = t.GetCustomAttributes(false);
            foreach (object attribute in attributes)
            {
                Console.WriteLine(attribute);
            }
            Console.WriteLine();


            Type remarkAttributeType = typeof(RemarkAttribute);
            RemarkAttribute remarkAttribute = (RemarkAttribute)Attribute.GetCustomAttribute(t, remarkAttributeType);
            Console.WriteLine("Remark: " + remarkAttribute.Remark + " (" + remarkAttribute.Supplement + ")");
        }
    }
}
