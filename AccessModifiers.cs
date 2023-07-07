using System;
using static AccessModifiers.Program.MyClass;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets check access modifiers");
            Console.ReadLine();

            MyClass myObject = new MyClass();

            Console.WriteLine(myObject.publicField);         // Accessible everywhere
            Console.WriteLine(myObject.internalField);       // Accessible within the same assembly
            myObject.PublicMethod();                          // Accessible everywhere
            myObject.InternalMethod();                        // Accessible within the same assembly

            AnotherClass anotherObject = new AnotherClass();

            anotherObject.AccessProtectedFields();            // Access protected fields from derived class
            anotherObject.AccessProtectedMethods();

            Console.ReadLine();

            Console.WriteLine("Enum Values");
            int x = (int)Days.Mon;
            int y = (int)Days.Sat;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }

        public class MyClass
        {
            public int publicField = 10;
            private string privateField = "Hello";
            protected bool protectedField = true;
            internal double internalField = 3.14;
            protected internal char protectedInternalField = 'A';
            public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

            public void PublicMethod()
            {
                Console.WriteLine("This is a public method.");
            }

            private void PrivateMethod()
            {
                Console.WriteLine("This is a private method.");
            }

            protected void ProtectedMethod()
            {
                Console.WriteLine("This is a protected method.");
            }

            internal void InternalMethod()
            {
                Console.WriteLine("This is an internal method.");
            }

            protected internal void ProtectedInternalMethod()
            {
                Console.WriteLine("This is a protected internal method.");
            }
        }

        public class AnotherClass : MyClass
        {
            public void AccessProtectedFields()
            {
                Console.WriteLine(protectedField);              // Accessible from derived class
                Console.WriteLine(protectedInternalField);      // Accessible from derived class
            }

            public void AccessProtectedMethods()
            {
                ProtectedMethod();                              // Accessible from derived class
                ProtectedInternalMethod();                      // Accessible from derived class

            }
        }
    }
}