using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestModuleDataControl.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string EffectiveDateFormat
        {
            get { return EffectiveDate.ToString("dd/MM/yyyy"); }
        }
        public string Status { get; set; }
        public string InstrumentCode { get; set; }
       
        public double InterestRate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int StatusID { get; set; }
        

        public DateTime RecordDate { get; set; }

        
    }

}
