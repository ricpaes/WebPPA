using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApi.Models;

namespace WebApi
{
    public partial class bhubContext : DbContext
    {
        public bhubContext()
        {
        }

        public bhubContext(DbContextOptions<bhubContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Modelodocumento> Modelodocumentos { get; set; } = null!;
        public virtual DbSet<Pessoa> Pessoas { get; set; } = null!;
        public virtual DbSet<Setor> Setors { get; set; } = null!;
        public virtual DbSet<Systemuser> Systemusers { get; set; } = null!;
        public virtual DbSet<Tipoacao> Tipoacaos { get; set; } = null!;
        public virtual DbSet<Tipolinhaproduto> Tipolinhaprodutos { get; set; } = null!;
        public virtual DbSet<Tipoparametromodelo> Tipoparametromodelos { get; set; } = null!;
        public virtual DbSet<Tiposaida> Tiposaida { get; set; } = null!;
        public virtual DbSet<Workflow> Workflows { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=bhub;Username=postgres;Password=postgres;CommandTimeout=120;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Modelodocumento>(entity =>
            {
                entity.HasKey(e => e.ModgId)
                    .HasName("MODELOGUIA_pkey");

                entity.ToTable("MODELODOCUMENTO");

                entity.HasComment("Modelos de documentos, guias, notas fiscais, emails, etc");

                entity.Property(e => e.ModgId)
                    .ValueGeneratedNever()
                    .HasColumnName("MODG_ID");

                entity.Property(e => e.ModgLogdatahora).HasColumnName("MODG_LOGDATAHORA");

                entity.Property(e => e.ModgStatus)
                    .HasColumnType("char")
                    .HasColumnName("MODG_STATUS");

                entity.Property(e => e.ModgTexto)
                    .HasMaxLength(4000)
                    .HasColumnName("MODG_TEXTO");

                entity.Property(e => e.ModgTitulo).HasColumnName("MODG_TITULO");

                entity.Property(e => e.ModgUser).HasColumnName("MODG_USER");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => e.PesIs)
                    .HasName("PESSOA_pkey");

                entity.ToTable("PESSOA");

                entity.Property(e => e.PesIs)
                    .ValueGeneratedNever()
                    .HasColumnName("PES_IS");

                entity.Property(e => e.PesCpf).HasColumnName("PES_CPF");

                entity.Property(e => e.PesEmail).HasColumnName("PES_EMAIL");

                entity.Property(e => e.PesLogdatahora).HasColumnName("PES_LOGDATAHORA");

                entity.Property(e => e.PesNome).HasColumnName("PES_NOME");

                entity.Property(e => e.PesStatus)
                    .HasColumnType("char")
                    .HasColumnName("PES_STATUS");

                entity.Property(e => e.PesUser).HasColumnName("PES_USER");

                entity.Property(e => e.SetId).HasColumnName("SET_ID");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Pessoas)
                    .HasForeignKey(d => d.SetId)
                    .HasConstraintName("FK_PESSOA_SETOR");
            });

            modelBuilder.Entity<Setor>(entity =>
            {
                entity.HasKey(e => e.SetId)
                    .HasName("SETOR_pkey");

                entity.ToTable("SETOR");

                entity.Property(e => e.SetId)
                    .ValueGeneratedNever()
                    .HasColumnName("SET_ID");

                entity.Property(e => e.SetLogdatahora).HasColumnName("SET_LOGDATAHORA");

                entity.Property(e => e.SetNome).HasColumnName("SET_NOME");

                entity.Property(e => e.SetResponsavel).HasColumnName("SET_RESPONSAVEL");

                entity.Property(e => e.SetStatus)
                    .HasColumnType("char")
                    .HasColumnName("SET_STATUS");

                entity.Property(e => e.SetUser).HasColumnName("SET_USER");
            });

            modelBuilder.Entity<Systemuser>(entity =>
            {
                entity.HasKey(e => e.SusrId)
                    .HasName("SYSTEMUSER_pkey");

                entity.ToTable("SYSTEMUSER");

                entity.Property(e => e.SusrId).HasColumnName("SUSR_ID");

                entity.Property(e => e.SusrLogdatahora).HasColumnName("SUSR_LOGDATAHORA");

                entity.Property(e => e.SusrLogin)
                    .HasMaxLength(50)
                    .HasColumnName("SUSR_LOGIN");

                entity.Property(e => e.SusrNome)
                    .HasMaxLength(100)
                    .HasColumnName("SUSR_NOME");

                entity.Property(e => e.SusrSenha)
                    .HasMaxLength(50)
                    .HasColumnName("SUSR_SENHA");

                entity.Property(e => e.SusrStatus)
                    .HasColumnType("char")
                    .HasColumnName("SUSR_STATUS");
            });

            modelBuilder.Entity<Tipoacao>(entity =>
            {
                entity.HasKey(e => e.TpaId)
                    .HasName("TIPOACAO_pkey");

                entity.ToTable("TIPOACAO");

                entity.Property(e => e.TpaId)
                    .ValueGeneratedNever()
                    .HasColumnName("TPA_ID");

                entity.Property(e => e.TpaDescricao).HasColumnName("TPA_DESCRICAO");

                entity.Property(e => e.TpaLogdatahora).HasColumnName("TPA_LOGDATAHORA");

                entity.Property(e => e.TpaStatus)
                    .HasColumnType("char")
                    .HasColumnName("TPA_STATUS");

                entity.Property(e => e.TpaUser).HasColumnName("TPA_USER");
            });

            modelBuilder.Entity<Tipolinhaproduto>(entity =>
            {
                entity.HasKey(e => e.TlpId)
                    .HasName("TIPOLINHAPRODUTO_pkey");

                entity.ToTable("TIPOLINHAPRODUTO");

                entity.Property(e => e.TlpId)
                    .ValueGeneratedNever()
                    .HasColumnName("TLP_ID");

                entity.Property(e => e.TlpDescricao).HasColumnName("TLP_DESCRICAO");

                entity.Property(e => e.TlpLogdatahora).HasColumnName("TLP_LOGDATAHORA");

                entity.Property(e => e.TlpStatus)
                    .HasColumnType("char")
                    .HasColumnName("TLP_STATUS");

                entity.Property(e => e.TlpUser).HasColumnName("TLP_USER");
            });

            modelBuilder.Entity<Tipoparametromodelo>(entity =>
            {
                entity.HasKey(e => e.TppmId)
                    .HasName("TIPOPARAMETROMODELO_pkey");

                entity.ToTable("TIPOPARAMETROMODELO");

                entity.HasComment("tabela com lista de parâmetros que podem ser usados nos modelos de email, guia e outros.");

                entity.Property(e => e.TppmId)
                    .ValueGeneratedNever()
                    .HasColumnName("TPPM_ID");

                entity.Property(e => e.TppmColuna).HasColumnName("TPPM_COLUNA");

                entity.Property(e => e.TppmLogdatahora).HasColumnName("TPPM_LOGDATAHORA");

                entity.Property(e => e.TppmNome).HasColumnName("TPPM_NOME");

                entity.Property(e => e.TppmStatus)
                    .HasColumnType("char")
                    .HasColumnName("TPPM_STATUS");

                entity.Property(e => e.TppmTabela).HasColumnName("TPPM_TABELA");

                entity.Property(e => e.TppmUser).HasColumnName("TPPM_USER");
            });

            modelBuilder.Entity<Tiposaida>(entity =>
            {
                entity.HasKey(e => e.TpsId)
                    .HasName("TIPOSAIDA_pkey");

                entity.ToTable("TIPOSAIDA");

                entity.Property(e => e.TpsId)
                    .ValueGeneratedNever()
                    .HasColumnName("TPS_ID");

                entity.Property(e => e.TpsDescricao).HasColumnName("TPS_DESCRICAO");

                entity.Property(e => e.TpsLogdatahora).HasColumnName("TPS_LOGDATAHORA");

                entity.Property(e => e.TpsStatus)
                    .HasColumnType("char")
                    .HasColumnName("TPS_STATUS");

                entity.Property(e => e.TpsUser).HasColumnName("TPS_USER");
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.HasKey(e => e.WrkId)
                    .HasName("WORKFLOW_pkey");

                entity.ToTable("WORKFLOW");

                entity.HasComment("Tabela com os terefas que de devem ser realizadas para cada linha de produto e ação");

                entity.Property(e => e.WrkId)
                    .ValueGeneratedNever()
                    .HasColumnName("WRK_ID");

                entity.Property(e => e.ModgId).HasColumnName("MODG_ID");

                entity.Property(e => e.TlpId).HasColumnName("TLP_ID");

                entity.Property(e => e.TpaId).HasColumnName("TPA_ID");

                entity.Property(e => e.TpsId).HasColumnName("TPS_ID");

                entity.Property(e => e.WrkAguardaraprovacao).HasColumnName("WRK_AGUARDARAPROVACAO");

                entity.Property(e => e.WrkDatafim).HasColumnName("WRK_DATAFIM");

                entity.Property(e => e.WrkDatainicio).HasColumnName("WRK_DATAINICIO");

                entity.Property(e => e.WrkDescricao).HasColumnName("WRK_DESCRICAO");

                entity.Property(e => e.WrkDestino).HasColumnName("WRK_DESTINO");

                entity.Property(e => e.WrkLogdatahora).HasColumnName("WRK_LOGDATAHORA");

                entity.Property(e => e.WrkPossuimodelo).HasColumnName("WRK_POSSUIMODELO");

                entity.Property(e => e.WrkSequencia).HasColumnName("WRK_SEQUENCIA");

                entity.Property(e => e.WrkStatus)
                    .HasColumnType("char")
                    .HasColumnName("WRK_STATUS");

                entity.Property(e => e.WrkUser).HasColumnName("WRK_USER");

                entity.HasOne(d => d.Modg)
                    .WithMany(p => p.Workflows)
                    .HasForeignKey(d => d.ModgId)
                    .HasConstraintName("FK_WORKFLOW_MODG_ID");

                entity.HasOne(d => d.Tlp)
                    .WithMany(p => p.Workflows)
                    .HasForeignKey(d => d.TlpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WORKFLOW_TLP_ID");

                entity.HasOne(d => d.Tpa)
                    .WithMany(p => p.Workflows)
                    .HasForeignKey(d => d.TpaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WORKFLOW_TPA_ID");

                entity.HasOne(d => d.Tps)
                    .WithMany(p => p.Workflows)
                    .HasForeignKey(d => d.TpsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WORKFLOW_TPS_ID");

                entity.HasOne(d => d.WrkDestinoNavigation)
                    .WithMany(p => p.Workflows)
                    .HasForeignKey(d => d.WrkDestino)
                    .HasConstraintName("FK_WORKFLOW_SET_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
