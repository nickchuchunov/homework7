using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace ContractMeneger

{
    [Keyless]
    [Table("CustomerDatabase", Schema = "CustomerDatabase")]
    public class CustomerDatabase: CustomerDatabaseId<int>
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Telephone { get; set; }
    }
}
