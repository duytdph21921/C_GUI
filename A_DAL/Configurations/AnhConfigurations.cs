using A_DAL.DomaninClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    public class AnhConfigurations : IEntityTypeConfiguration<Anh>
    {
        public void Configure(EntityTypeBuilder<Anh> builder)
        {
            builder.ToTable("Anh");
            builder.HasKey(x => x.id);
            builder.Property(p => p.Ma).HasColumnName("Ma").
                HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.Ten).HasColumnName("Ten").  
                HasColumnType("Nvarchar(100)").IsRequired(); 
            builder.Property(p => p.Link).HasColumnName("link").
                HasColumnType("varchar(100)").IsRequired();
            //HasColumnName(PropertyBuilder, Chuỗi)	
            //Định cấu hình cột mà thuộc tính ánh xạ tới khi nhắm mục tiêu cơ sở dữ liệu quan hệ.
        }
    }
}
