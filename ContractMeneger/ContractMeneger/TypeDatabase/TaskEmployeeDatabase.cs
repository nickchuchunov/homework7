using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
    [Keyless]
    [Table("TaskEmployeeDatabase", Schema = "TaskEmployeeDatabase")]
    public class TaskEmployeeDatabase: TaskEmployeeDatabaseId<int>
    {
        
        public int EmployeId { get; set; }
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
    }
}
