using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TechnicalError
    {
        public int Id { get; set; }
        public string ErrorName { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime ErrorDate { get; set; }
        public string CreateUser { get; set; }
        public TechnicalStatus StatusId { get; set; }

    }

    //status tipleri tutulması için;
    public enum TechnicalStatus
    {
        Open=1,
        Process=2,
        Closed=3,
       
    }
}
