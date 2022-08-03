using System;

namespace overloading_conversion_operator
{
    public class MyClass2
    {
        private double _value;

        public MyClass2(double value)
        {
            _value = value;
        }

        public MyClass2() : this(0.0)
        {
        }

        public static explicit operator MyClass1(MyClass2 myClass2)
        {
            return new MyClass1(Convert.ToInt32(myClass2._value));
        }

        public override string ToString()
        {
            return $"{nameof(_value)}: {_value}";
        }
    }
}