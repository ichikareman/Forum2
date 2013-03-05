using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using DomainObjects;


namespace EntityConfig
{
    public class UserEntityConfig : EntityTypeConfiguration<UserEntity>
    {
        public UserEntityConfig()
        {
            ToTable("tbl_user");
            PropertyConfig();
            RelationshipConfig();
        }

        private void PropertyConfig()
        {
            Property(e => e.Id).HasColumnName("Id");
            Property(e => e.UserName).HasColumnName("UserName");
            Property(e => e.Name).HasColumnName("Name");
            Property(e => e.Password).HasColumnName("Password");
        }

        private void RelationshipConfig()
        {
            HasKey(e => e.Id);
        }
    }
}
