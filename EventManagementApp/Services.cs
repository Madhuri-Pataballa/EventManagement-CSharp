using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementApp
{

    enum TypeOfServices
    {
        Personal,
        Professional
    }

    /// <summary>
    /// This is Services Class
    /// </summary>
    class Services
    {

        #region Properties

        public int ServiceId { get; private set; }

        public string ServiceName { get; private set; }

        public TypeOfServices ServiceType { get; set; } 

        #endregion
    }
}
