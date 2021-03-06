﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSC.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudenteId { get; set; }
        public string Matricola { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime AnnoIscrizione { get; set; }
        public int Status { get; set; }
        public int CorsoId { get; set; }
        public Course Course { get; set; }
    }
}
