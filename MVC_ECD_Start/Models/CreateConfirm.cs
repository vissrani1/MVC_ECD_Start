using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ECD_Start.Models
{
    public class CreateConfirm
    {
        public string Heading { get; set; }
        public CollegeData Education { get; set; }
        public bool WasSuccessful { get; set; }

    }
}
