using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace ContractMeneger
{
    [Keyless]
    [Table("ContractDatabase", Schema = "ContractDatabase")]
    public class ContractDatabase: ContractDatabaseId<int>
    {
        public int CustomerID { get; set; }

    }
}
