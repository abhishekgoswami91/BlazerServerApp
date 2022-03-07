using System;
using System.Collections.Generic;

namespace BlazorServerApp.Models
{
    public partial class Device
    {
        public Device()
        {
            Operation = new HashSet<Operation>();
        }

        public int DeviceId { get; set; }
        public string Name { get; set; }
        public int? DeviceType { get; set; }

        public virtual ICollection<Operation> Operation { get; set; }
    }
}
