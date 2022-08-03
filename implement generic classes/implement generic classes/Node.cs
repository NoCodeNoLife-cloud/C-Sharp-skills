namespace implement_generic_classes
{
    public class Node<T>
    {
        private T _x;
        private T _y;

        public T X
        {
            get => _x;
            set => _x = value;
        }

        public T Y
        {
            get => _y;
            set => _y = value;
        }

        public Node(T x, T y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        /// use default value
        /// </summary>
        public Node() : this(default(T), default(T))
        {
        }

        public override string ToString()
        {
            return $"{nameof(_x)}: {_x}, {nameof(_y)}: {_y}";
        }
    }
}