namespace Contractor.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a contract schedule. A contract can have many schedules (or extensions from the original tenure).
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Gets the auto-generated id
        /// </summary>
        /// <remarks>
        /// Read-only property
        /// </remarks>
        public virtual ushort Id { get; protected set; }

        /// <summary>
        /// Gets or sets the date on which this schedule was agreed or signed
        /// </summary>
        public virtual DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the person assigned to this piece of work
        /// </summary>
        public virtual Person Contractor { get; set; }

        /// <summary>
        /// Gets or sets the role or job title of the contractor
        /// </summary>
        public virtual string Role { get; set; }  // Job Title

        

        /// <summary>
        /// Gets or sets the daily rate paid for the contractor (if there is one defined)
        /// </summary>
        public virtual double DailyRate { get; set; }

        /// <summary>
        /// Gets or sets the hourly rate paid for the contractor (if there is one defined)
        /// </summary>
        public virtual double HourlyRate { get; set; }

        /// <summary>
        /// Gets or sets the start date for this piece of work schedule
        /// </summary>
        public virtual DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date for this piece of work schedule
        /// </summary>
        public virtual DateTime EndDate { get; set; }

        /// <summary>
        /// Gets the timestamp indicating when this entity was created or last updated
        /// </summary>
        /// <remarks>
        /// Read-only property
        /// </remarks>
        public virtual DateTime LastUpdated { get; protected set; }
		
        public RateType RateType { get; set; }
        public double HoursPerDay { get; set; }
    
        public virtual Contract Contract { get; set; }
        public virtual ICollection<TimesheetEntry> TimesheetEntries { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }

    }
}
