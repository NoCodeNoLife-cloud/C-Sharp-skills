namespace overloading_conversion_operator
{
    public class MyClass1
    {
        private int _value;

        public MyClass1(int value)
        {
            _value = value;
        }

        public MyClass1() : this(0)
        {
        }
        
        public static explicit operator MyClass2(MyClass1 myClass1)
        {
            return new MyClass2(myClass1._value);
        }

        public override string ToString()
        {
            return $"{nameof(_value)}: {_value}";
        }
    }
}