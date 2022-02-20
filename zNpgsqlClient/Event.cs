using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zNpgsqlClient
{
    public class Event
    {
        public int Id { get; set; }
        public int Discount { get; set; }
        public int TypeForeignKey { get; set; }
        public Type Type { get; set; } = null!;
        public int ProductForeignKey { get; set; }
        public Product Product { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
