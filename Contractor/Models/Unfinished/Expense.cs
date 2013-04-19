namespace Contractor.Models
{
    using System;
    
    public class Expense
    {
        public string Id { get; set; }
        public ExpenseCategory Category { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public DateTime PaidOn { get; set; }
        public PaymentMethod PaidBy { get; set; }
        public ReimbursementMethod ReimbursedBy { get; set; }
    }
}
