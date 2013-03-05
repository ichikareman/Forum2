using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainObjects
{
    public class ThreadEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime DatePosted { get; set; }
        public string Tag { get; set; }

        public UserEntity User { get; set; }
        public ICollection<CommentEntity> Comments { get; set; }
    }
}
