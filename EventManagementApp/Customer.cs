using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementApp
{
    /// <summary>
    /// This is Customer Class
    /// </summary>
    class Customer
    {
        #region Static

        private static int lastCustomerId = 100;

        #endregion

        #region Properties
        /// <summary>
        /// Providing customer details
        /// </summary>

        public int CustomerId { get; private set; }

        public string CustomerName { get; set; }

        public string EmailAddress { get; set; }

        public UInt64 PhoneNumber { get; set; }

        #endregion

        #region Constructor
        public Customer()
        {
            CustomerId = ++lastCustomerId;
        }
        #endregion 

    }


}
