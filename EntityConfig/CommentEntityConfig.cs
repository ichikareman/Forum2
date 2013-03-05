using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainObjects;
using System.Data.Entity.ModelConfiguration;

namespace EntityConfig
{
    public class CommentEntityConfig : EntityTypeConfiguration<CommentEntity>
    {
        public CommentEntityConfig()
        {
            ToTable("tbl_comment");
            PropertyConfig();
            RelationshipConfig();
        }

        private void PropertyConfig()
        {
            Property(e => e.Id).HasColumnName("Id");
            Property(e => e.Message).HasColumnName("Message");
            Property(e => e.DatePosted).HasColumnName("DatePosted");
            Property(e => e.ThreadId).IsRequired();
        }

        private void RelationshipConfig()
        {
            HasKey(e => e.Id);
            HasRequired(e => e.User).WithMany().Map(m => m.MapKey("UserId"));
        }
    }
}
