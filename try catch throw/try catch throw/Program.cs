using System;

namespace try_catch_throw
{
    internal class Program
    {
        private static string[] eTypes = {"none", "simple", "index", "nested index", "filter"};

        public static void Main(string[] args)
        {
            foreach (string eType in eTypes)
            {
                try
                {
                    Console.Out.WriteLine("Main() try block reached.");
                    Console.Out.WriteLine($"ThrowException(\"{eType}\") called.");
                    ThrowException(eType);
                    Console.Out.WriteLine("Main() try block continues.");
                }
                catch (System.IndexOutOfRangeException e)when (eType == "filter")
                {
                    Console.Out.WriteLine(
                        "Main() FILTERD System.IndexOutOfRangeException catch block reached. Message:\n\n\"({e.Message}");
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.Out.WriteLine(
                        $"Main() SYstem.IndexOutOfRangeException catch block reached. Message:\n\"{e.Message}");
                }
                catch
                {
                    Console.Out.WriteLine("Main() general catch block reached.");
                }
                finally
                {
                    {
                        Console.Out.WriteLine("Main() finally block reached.");
                    }
                }

                Console.Out.WriteLine();
            }
        }

        static void ThrowException(string exceptionType)
        {
            Console.Out.WriteLine($"ThrowException(\"{exceptionType}\") reached");
            switch (exceptionType)
            {
                case "none":
                    Console.Out.WriteLine("Not throwing an excaption.");
                    break;
                case "simple":
                    Console.Out.WriteLine("Throwing System.Exception.");
                    throw new System.Exception();
                case "index":
                    Console.Out.WriteLine("Throwing System.IndexOutOfRangeException.");
                    eTypes[5] = "error";
                    break;
                case "nested index":
                    try
                    {
                        Console.Out.WriteLine("ThrowException(\"nested index\") try block reached.");
                        Console.Out.WriteLine("ThrowException(\"index\") called.");
                        ThrowException(("index"));
                    }
                    catch
                    {
                        Console.Out.WriteLine("ThrowException(\"nested index\") general catch block reached.");
                    }
                    finally
                    {
                        Console.Out.WriteLine("ThrowException(\"nested index\") finally catch block reached.");
                    }

                    break;
                case "filter":
                    try
                    {
                        Console.Out.WriteLine("ThrowException(\"filter\") try block reached.");
                        Console.Out.WriteLine("ThrowException(\"index\") called.");
                        ThrowException("index");
                    }
                    catch
                    {
                        Console.Out.WriteLine("ThrowException(\"filter\") general catch block reached.");
                    }

                    break;
            }
        }
    }
}