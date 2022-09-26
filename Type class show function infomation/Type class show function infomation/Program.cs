using System;
using System.Reflection;

namespace Type_class_show_function_infomation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 4;
            Type intType = i.GetType();
            MethodInfo[] methodInfos = intType.GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.Out.WriteLine($"methodInfo.MemberType={methodInfo.MemberType}");
                Console.Out.WriteLine($"methodInfo.ReturnParameter={methodInfo.ReturnParameter}");
                Console.Out.WriteLine($"methodInfo.ReturnType={methodInfo.ReturnType}");
                Console.Out.WriteLine($"methodInfo.ReturnTypeCustomAttributes={methodInfo.ReturnTypeCustomAttributes}");
                Console.Out.WriteLine($"methodInfo.Attributes={methodInfo.Attributes}");
            }
        }
    }
}