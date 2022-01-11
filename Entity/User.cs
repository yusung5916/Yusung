using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        [Key]
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public string PassBase { get; set; }
    }
}
