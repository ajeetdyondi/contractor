// -----------------------------------------------------------------------
// <copyright file="Shares.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Contractor.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Share
    {
        public virtual int Id { get; private set; }
        public virtual Person Holder { get; set; }
        public virtual int Quantity { get; set; }
        public virtual DateTime HeldFrom { get; set; }
        public virtual DateTime HeldTo { get; set; }
        public virtual DateTime LastUpdated { get; private set; }
    }
}
