using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainObjects;

namespace ForumServices
{
    public interface IForumService
    {
        ThreadEntity GetThread(int threadId);
        IEnumerable<ThreadEntity> GetAll();
    }
}
