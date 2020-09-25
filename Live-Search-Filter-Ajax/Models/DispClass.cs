using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Live_Search_Filter_Ajax.Modals
{
    public class DispClass
    {
        [Key]
        public int DispId { get; set; }
        public string Customer_No { get; set; }
        public string SaleMan { get; set; }
        public string NIC_Code { get; set; }
        public string DisputeCode { get; set; }
        public string Division { get; set; }
    }
}
