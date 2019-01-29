﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Dados.Entidades
{
    [Table("USUARIOS", Schema = "MIGRATION_TESTE")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("USUA_ID")]
        public decimal Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("USUA_NOME")]
        public string Nome { get; set; }

        [MaxLength(200)]
        [Column("USUA_SOBRENOME")]
        public string Sobrenome { get; set; }

        [Column("USUA_DT_NASCIMENTO")]
        public DateTime DataNascimento { get; set; }
    }
}
