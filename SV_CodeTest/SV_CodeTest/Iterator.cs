namespace SV_CodeTest
{
    internal class Iterator : IAbstractIterator

    {
        private Children _collection;
        private int _current = 0;
        private int _step = 1;
        private int _count= 0;        

        // Constructor

        public Iterator(Children collection)
        {
            this._collection = collection;
        }

        // Gets first item

        public Child First()
        {
            _current = _step-1;
            return _collection[_current] as Child;
        }

        // Gets next item

        public Child Next()
        {
            _current += _step;
            _count += 1;
            _current = (_current >= _collection.Count) ? (_current - _collection.Count) : _current;  // rotation: clockwise
            
            if (!IsDone)
                return _collection[_current] as Child;
            else

                return null;
        }

        // Gets or sets stepsize

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        // Gets current iterator item

        public Child CurrentChild
        {
            get { return _collection[_current] as Child; }
        }

        // Gets whether iteration is complete

        public bool IsDone
        {
            get { return _count >= _collection.Count - 1; }
        }
    }
}