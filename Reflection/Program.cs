using System;
using System.Reflection;

namespace ReflectionIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st approach 
            Type typeInfoInteger = typeof(int);
            Console.WriteLine(typeInfoInteger);

            //2nd approach
            var stringsample = "Hello World";
            Type typeInfostring = stringsample.GetType();
            Console.WriteLine(typeInfostring);

            //3rd approach
            Type typeInfoBoolean = Type.GetType("System.Boolean");
            Console.WriteLine(typeInfoBoolean);

            Type typeInfoOnString = typeof(string);
            Console.WriteLine($"\nName: {typeInfoOnString.Name}.");
            Console.WriteLine($"Namespace: {typeInfoOnString.Namespace}.");
            Console.WriteLine($"Base Type: {typeInfoOnString.BaseType}.");
            Console.WriteLine($"Is Class: {typeInfoOnString.IsClass}.");

            Type typeInfoMyString = typeof(string);

            Assembly stringAssembly = typeInfoMyString.Assembly;
            AssemblyName stringAssemblyName = stringAssembly.GetName();

            Console.WriteLine($"\nAssemble name: {stringAssemblyName.Name}");
            Console.WriteLine($"Assemble version: {stringAssemblyName.Version}");

            Type typeInfoOnProgram = typeof(Program);

            Assembly programAssembly = typeInfoOnProgram.Assembly;
            AssemblyName programAssemblyName = programAssembly.GetName();

            Console.WriteLine($"Assembly name: {programAssemblyName.Name}");
            Console.WriteLine($"Assembly version: {programAssemblyName.Version}");

            //Additional application of reflection
            MethodInfo[] stringMethods = typeInfoMyString.GetMethods();
            Console.WriteLine($"{typeInfoMyString.Name} has these methods:");

            //interate the array and print the methods
            foreach (var methodInfo in stringMethods)
            {
                ParameterInfo[] parameterInfos = methodInfo.GetParameters();
                string parameters = ParameterInfosToString(parameterInfos);
                Console.WriteLine($"{methodInfo.Name}({parameters}) -> returns {methodInfo.ReturnType}.");
            }
        }
        static string ParameterInfosToString(ParameterInfo[] parameterInfos)
        {
            string parameters = "";
            for (int i = 0; i < parameterInfos.Length - 1; i++)
            {
                parameters += $"{parameterInfos[i].ParameterType.Name} {parameterInfos[i].Name}, ";
            }
            if (parameterInfos.Length > 0)
            {
                int lastIndex = parameterInfos.Length - 1;
                parameters += $"{parameterInfos[lastIndex].ParameterType.Name} {parameterInfos[lastIndex].Name}";
            }
            return parameters;
        }
    }
}