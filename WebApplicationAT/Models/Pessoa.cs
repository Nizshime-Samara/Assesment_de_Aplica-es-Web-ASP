using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;

namespace WebApplicationAT.Models
{
    [Table("Pessoa")]

    public class Pessoa
    {
        
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

    } }
