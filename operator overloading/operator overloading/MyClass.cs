using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace operator_overloading
{
    public class MyClass : ICloneable
    {
        private double _x;
        private double _y;

        public MyClass(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public MyClass() : this(0.0, 0.0)
        {
        }

        public object Clone()
        {
            return new MyClass(_x, _y);
        }

        static public MyClass operator +(MyClass myClass1, MyClass myClass2)
        {
            return new MyClass(myClass1._x + myClass2._x, myClass1._y + myClass2._y);
        }

        static public MyClass operator -(MyClass myClass1, MyClass myclass2)
        {
            return new MyClass(myClass1._x - myclass2._x, myClass1._y - myclass2._y);
        }

        static public bool operator <(MyClass myClass1, MyClass myClass2)
        {
            if (myClass1._x == myClass2._x)
            {
                if (myClass1._y < myClass2._y)
                {
                    return true;
                }
            }
            else if (myClass1._x < myClass2._x)
            {
                return true;
            }

            return false;
        }

        static public bool operator <=(MyClass myClass1, MyClass myClass2)
        {
            if (myClass1._x == myClass2._x)
            {
                if (myClass1._y <= myClass2._y)
                {
                    return true;
                }
            }
            else if (myClass1._x < myClass2._x)
            {
                return true;
            }

            return false;
        }

        static public bool operator >(MyClass myClass1, MyClass myClass2) => !(myClass1 <= myClass2);

        static public bool operator >=(MyClass myClass1, MyClass myClass2) => !(myClass1 < myClass2);

        static public bool operator ==(MyClass myClass1, MyClass myClass2)
        {
            if (myClass1._x == myClass2._x && myClass1._y == myClass2._y)
            {
                return true;
            }

            return false;
        }

        static public bool operator !=(MyClass myClass1, MyClass myClass2) => !(myClass1 == myClass2);

        public override string ToString()
        {
            return $"{nameof(_x)}: {_x}, {nameof(_y)}: {_y}";
        }
    }
}