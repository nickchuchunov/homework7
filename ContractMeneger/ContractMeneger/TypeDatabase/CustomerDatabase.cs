using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace ContractMeneger

{
    
    
    [Table("CustomerDatabase")]
    public sealed class CustomerDatabase: CustomerDatabaseId<int>
    {
        
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Telephone { get; set; }
    }
}
