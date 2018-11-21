using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_CodeTest
{
    /// <summary>

    /// The 'ConcreteAggregate' class

    /// </summary>
    public class Children : IAbstractCollection

    {
        private ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets item count

        public int Count
        {
            get { return _items.Count; }
        }

        public ArrayList RemoveOut(Child child)
        {
            _items.Remove(child);
            return _items;
        }
        public int IndexOf(Child child)
        {
            return _items.IndexOf(child);
        }
        public Child winner()
        {
            return (Child)_items[0];
        }
        public int Add(Child child)
        {
            return _items.Add(child);
        }
        public Child GetChild(int idx)
        {
           return (Child)_items[idx];
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
