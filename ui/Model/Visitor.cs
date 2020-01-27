using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ui.Model
{
    class Visitor
    {
        public string Name { get; set; }
        public String ID { get; set; }
        public string PatientName { get; set; }
        public String PatientRoom { get; set; }
        public Visitor(String nName, String nId, String nPatientName, String nPatientRoom)
        {
            Name = nName;
            ID = nId;
            PatientName = nPatientName;
            PatientRoom = nPatientRoom;

        }


    }
}
