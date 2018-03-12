using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dermatology
{
    class Doctors
    {
        public string FullName { get; set; }
        public List<byte> WorkDays = new List<byte>();
        public DateTime StartTime  { get; set; }
        public DateTime EndTime { get; set; }

        public Doctors(string FullName)
        {
            this.FullName = FullName;
        }
    }
}
