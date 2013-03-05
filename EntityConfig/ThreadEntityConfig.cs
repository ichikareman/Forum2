using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainObjects;
using System.Data.Entity.ModelConfiguration;

namespace EntityConfig
{
    public class ThreadEntityConfig : EntityTypeConfiguration<ThreadEntity>
    {
        public ThreadEntityConfig()
        {
            ToTable("tbl_thread");
            PropertConfig();
            RelationshipConfig();
        }

        private void PropertConfig()
        {
            Property(e => e.Id).HasColumnName("Id");
            Property(e => e.Subject).HasColumnName("Subject");
            Property(e => e.Message).HasColumnName("Message");
            Property(e => e.DatePosted).HasColumnName("DatePosted");
            Property(e => e.Tag).HasColumnName("Tag");
        }

        private void RelationshipConfig()
        {
            HasKey(e => e.Id);

            HasRequired(e => e.User).WithMany().Map(m => m.MapKey("UserId"));

            //HasMany(e => e.Comments).WithRequired().Map(m => m.MapKey());

            //HasRequired(e => e.User).;
                //.WithRequiredDependent().Map(m => m.MapKey("UserId"));
                //WithMany().Map(m => m.MapKey("UserId"));
            //HasMany(e => e.Comments).WithOptional().Map(m => m.MapKey("CommentId"));
            
        }
    }
}
