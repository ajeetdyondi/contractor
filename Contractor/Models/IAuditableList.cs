namespace Contractor.Models
{
    using System;
    using System.Collections.Generic;

    public interface IAuditableList<T> : IEnumerable<T> where T : class, ITimeBound
    {
        int Count { get; }

        void Add(T item);
        void AddAsCurrent(T item);

        T Current();
        T AsOn(DateTime date);
        IReadOnlyCollection<T> History();
    }
}
