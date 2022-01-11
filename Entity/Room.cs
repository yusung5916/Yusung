using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Room
    {
        [Key]
        public Guid RoomId { get; set; }
        public string RoomName { get; set; }
        public ICollection<User> User { get; set; }
        public ICollection<Message> Message { get; set; }
    }
}
