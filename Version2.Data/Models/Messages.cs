using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
 
namespace Version2.Data.Models
{
    public class Messages : Entity
    {
        public string MessageCode { get; set; }
        public string Message { get; set; }
    }
    public class CreateorEditMessagesDto
    {
        public int Id { get; set; }
        public string MessageCode { get; set; }
        public string Message { get; set; }
    }
    public class MessagesDto : Entity
    {

        public string MessageCode { get; set; }
        public string Message { get; set; }
    }
}
