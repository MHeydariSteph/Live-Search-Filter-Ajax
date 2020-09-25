using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Live_Search_Filter_Ajax.Modals;


namespace Live_Search_Filter_Ajax.Modals
{
    public class ApplicationDBContnextClass : DbContext
    {
        public ApplicationDBContnextClass(DbContextOptions<ApplicationDBContnextClass> options):base(options)
        {


        }
        public DbSet<DispClass> Dispute { get; set; }
    }
}
