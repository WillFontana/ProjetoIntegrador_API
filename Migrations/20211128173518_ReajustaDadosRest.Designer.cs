﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoIntegrador.Data;

namespace ProjetoIntegrador.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20211128173518_ReajustaDadosRest")]
    partial class ReajustaDadosRest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("ProjetoIntegrador.Enumns.Escolaridade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Escolaridades");
                });

            modelBuilder.Entity("ProjetoIntegrador.Enumns.Grau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Graus");
                });

            modelBuilder.Entity("ProjetoIntegrador.JoinEntities.MateriasPorProfessor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("MateriasPorProfessors");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<int>("EscolaridadeId")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Senha")
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("EscolaridadeId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Aula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<string>("DataFinal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DataInicio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<bool>("Remarque")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("MateriaId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Aulas");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Pendencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Pendencias");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Crn")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<int>("GrauId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.HasKey("Id");

                    b.HasIndex("Crn")
                        .IsUnique();

                    b.HasIndex("GrauId");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Crn")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Crn")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProjetoIntegrador.JoinEntities.MateriasPorProfessor", b =>
                {
                    b.HasOne("ProjetoIntegrador.Models.Materia", "Materia")
                        .WithMany("ProfessoresQueEnsinam")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoIntegrador.Models.Professor", "Professor")
                        .WithMany("MateriasDadas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Aluno", b =>
                {
                    b.HasOne("ProjetoIntegrador.Enumns.Escolaridade", "Escolaridade")
                        .WithMany("Alunos")
                        .HasForeignKey("EscolaridadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escolaridade");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Aula", b =>
                {
                    b.HasOne("ProjetoIntegrador.Models.Aluno", "Aluno")
                        .WithMany("Aulas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoIntegrador.Models.Materia", "Materia")
                        .WithMany("Aulas")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoIntegrador.Models.Professor", "Professor")
                        .WithMany("Aulas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Materia");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Pendencia", b =>
                {
                    b.HasOne("ProjetoIntegrador.Models.Aluno", "Aluno")
                        .WithMany("Pendencias")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoIntegrador.Models.Professor", "Professor")
                        .WithMany("Pendencias")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Professor", b =>
                {
                    b.HasOne("ProjetoIntegrador.Enumns.Grau", "Grau")
                        .WithMany("Professores")
                        .HasForeignKey("GrauId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grau");
                });

            modelBuilder.Entity("ProjetoIntegrador.Enumns.Escolaridade", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("ProjetoIntegrador.Enumns.Grau", b =>
                {
                    b.Navigation("Professores");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Aluno", b =>
                {
                    b.Navigation("Aulas");

                    b.Navigation("Pendencias");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Materia", b =>
                {
                    b.Navigation("Aulas");

                    b.Navigation("ProfessoresQueEnsinam");
                });

            modelBuilder.Entity("ProjetoIntegrador.Models.Professor", b =>
                {
                    b.Navigation("Aulas");

                    b.Navigation("MateriasDadas");

                    b.Navigation("Pendencias");
                });
#pragma warning restore 612, 618
        }
    }
}
