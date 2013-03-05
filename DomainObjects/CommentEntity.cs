using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainObjects
{
    public class CommentEntity
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime DatePosted { get; set; }
        public UserEntity User { get; set; }
        
        public int ThreadId { get; set; }
    }
}
