using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
    
    public class ContractDatabaseId <TUniqueId> where TUniqueId : struct

    {

       public ContractDatabaseId() { }
        public TUniqueId Id { get; set; }
        public bool IsDeleted { get; set; }


    }
}
