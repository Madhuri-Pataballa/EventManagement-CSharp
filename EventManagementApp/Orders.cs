using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementApp
{
    class Orders
    {
        public enum ListOfServices
        {
            Marriage,
            Receptions,
            Birthdays,
            BabyShowers,
            OfficialMeetings,
            GetTogethers,
            OfficialGatherings
        }

        #region Properties

        public int OrderId { get; private set; }

        public int CustomerID { get; set; }

        public int ServiceId { get; private set; }

        public TypeOfServices ServiceType { get; set; }

        public ListOfServices SelectedServices { get; set; }

        public decimal CurrentTotal { get; set; }

        public decimal TotalOrderPrice { get; set; }

        #endregion

        #region Method
        /// <summary>
        /// price for the service Customer added
        /// </summary>
        /// <param name="amount">amount of the service selected</param>
        /// <returns></returns>
        /// 
        public decimal OrderPrice(decimal amount)
        {
            CurrentTotal = amount;
            return CurrentTotal;
        }

        /// <summary>
        /// Total price of the order customer selected
        /// </summary>
        /// <param name="Amount">Total amount to be paid</param>
        /// <returns></returns>
        public decimal TotalPrice(decimal Amount)
        {
            TotalOrderPrice = Amount + CurrentTotal;
            return TotalOrderPrice;
        }

        #endregion

    }
}
