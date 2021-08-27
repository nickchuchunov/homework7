using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
   

    public class EmployeDatabaseId<TUniqueId> where TUniqueId : struct
    {

       public EmployeDatabaseId() { }
        public TUniqueId Id { get; set; }
        public bool IsDeleted { get; set; }


    }
}
