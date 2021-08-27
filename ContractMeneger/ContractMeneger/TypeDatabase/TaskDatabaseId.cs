using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
    
    public class TaskDatabaseId<TUniqueId> where TUniqueId : struct
    {

        public TaskDatabaseId() { }

        public TUniqueId Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
