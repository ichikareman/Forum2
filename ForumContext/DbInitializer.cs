using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Entity;
using DomainObjects;


namespace ForumContext
{
    public class DbInitializer: DropCreateDatabaseAlways<ForumContext>
    {
        protected override void Seed(ForumContext context)
        {
            var user = new UserEntity() {UserName = "kequ",Name = "kex",Password = "ererer", Id = 1};
            context.Entry(user).State = EntityState.Added;
            var thread = new List<ThreadEntity>()
                             {
                                 new ThreadEntity
                                     {
                                         Comments = new List<CommentEntity>(),
                                         DatePosted = DateTime.Now,
                                         Id = 1,
                                         Message = "hey",
                                         Subject = "little more smooth",
                                         Tag = "hey",
                                         User = user
                                     },
                                 new ThreadEntity
                                     {
                                         Comments = new List<CommentEntity>(),
                                         DatePosted = DateTime.Now,
                                         Id = 1,
                                         Message = "hey2",
                                         Subject = "little more smooth2",
                                         Tag = "hey2",
                                         User = user
                                     }
                             };

            foreach (var threadEntity in thread)
            {
                context.Entry(threadEntity).State = EntityState.Added;
            }
            


            context.SaveChanges();
            base.Seed(context);
        }

        public void InitializeDatabase(ForumContext context)
        {


        }
    }
}
