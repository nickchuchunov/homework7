using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public class TaskEmployee
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int EmployeId { get; set; }
        public DateTime StartData {get; set;}
        public DateTime EndData { get; set; }
        public TaskEmployee() { }

    }
}
