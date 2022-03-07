using System;
using System.Collections.Generic;

namespace BlazorServerApp.Models
{
    public partial class Operation
    {
        public int OperationId { get; set; }
        public string Name { get; set; }
        public int? OrderInWhichToPerform { get; set; }
        public int? DeviceId { get; set; }
        public Byte[] ImageData { get; set; }

        public virtual Device Device { get; set; }
    }
}
