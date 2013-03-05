using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using DomainObjects;
using EntityConfig;

namespace ForumContext
{
    public class ForumContext: DbContext
    {
        IDbSet<ThreadEntity> ThreadEntities { get; set; }
        IDbSet<UserEntity> UserEntities { get; set; }
        IDbSet<CommentEntity> CommentEntities { get; set; }

        public ForumContext()
            : base("name=ForumContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserEntityConfig());
            modelBuilder.Configurations.Add(new ThreadEntityConfig());
            modelBuilder.Configurations.Add(new CommentEntityConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
