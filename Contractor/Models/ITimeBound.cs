namespace Contractor.Models
{
    using System;

    public interface ITimeBound
    {
        DateTime StartDate { get; set; }
        DateTime? EndDate { get; set; }
    }
}
