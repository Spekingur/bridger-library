using System;

namespace LibraryApp.Models.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class LoanViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime LoanDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime ReturnDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Returned { get; set; }
    }
}