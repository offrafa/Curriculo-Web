using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Curriculo_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curriculo_Web.Mapeamento
{
    public class TipoCursoMap : IEntityTypeConfiguration<TipoCurso>
    {
        public void Configure(EntityTypeBuilder<TipoCurso> builder)
        {
            builder.HasKey(tc => tc.TipoCursoId);

            builder.Property(tc => tc.Tipo).IsRequired();
            builder.HasIndex(tc => tc.Tipo).IsUnique();

            builder.HasMany(tc => tc.FormacoesAcademicas).WithOne(tc => tc.TipoCurso).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
