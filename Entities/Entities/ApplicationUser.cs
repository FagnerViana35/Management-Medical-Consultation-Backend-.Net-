using Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ApplicationUser: IdentityUser
    {
        [Column("USR_NAME")]
        public string NAME { get; set; }

        [Column("USR_CPF")]
        public string? CPF { get; set; }

        [Column("USR_EMAIL")]
        public string? EMAIL { get; set; }

        [Column("USR_ESPECIALIDADE")]
        public string? ESPECIALIDADE { get; set; }

        [Column("USR_CRM")]
        public string? CRM { get; set; }

        [Column("USR_RULE")]
        public TypeUser? Rule { get; set; }


    }
}
