namespace Contractor.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class AuditableList<T> : IAuditableList<T> where T : class, ITimeBound
    {
        protected IList<T> InnerList;

        public AuditableList()
        {
            InnerList = new List<T>();
        }

        public T Current()
        {
            return AsOn(DateTime.Now.Date);
        }

        public T AsOn(DateTime date)
        {
            return InnerList.SingleOrDefault(entry => entry.StartDate <= date && (entry.EndDate == null || entry.EndDate >= date));
        }

        public IReadOnlyCollection<T> History()
        {
            return ((List<T>)InnerList).AsReadOnly();
        }

        public int Count { get { return InnerList.Count; } }

        public IEnumerator<T> GetEnumerator()
        {
            return InnerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            InnerList.Add(item);
            InnerList = InnerList.OrderBy(x => x.StartDate).ToList();
        }

        public void AddAsCurrent(T item)
        {
            var current = Current();
            if (current != null)
            {
                current.EndDate =  DateTime.Now.Date.Subtract(new TimeSpan(1, 0, 0, 0));
            }

            item.StartDate = DateTime.Now.Date;
            item.EndDate = null;
            Add(item);
        }

    }
}
