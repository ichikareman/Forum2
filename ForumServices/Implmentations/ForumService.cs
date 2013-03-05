using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainObjects;
using ForumContext;

namespace ForumServices.Implmentations
{
    public class ForumService: IForumService
    {
        private ForumContext.ForumContext _context;

        public ForumService()
        {
            _context = new ForumContext.ForumContext();
        }

        public DomainObjects.ThreadEntity GetThread(int threadId)
        {
            return _context.Set<ThreadEntity>().FirstOrDefault(e => e.Id == threadId);
        }

        public IEnumerable<DomainObjects.ThreadEntity> GetAll()
        {
            return _context.Set<ThreadEntity>().AsEnumerable();
        }
    }
}
