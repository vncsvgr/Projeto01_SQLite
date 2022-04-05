using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Projeto1_SQLite
{
    public class Aluno
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }

    }
}
