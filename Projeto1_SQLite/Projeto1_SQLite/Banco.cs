using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace Projeto1_SQLite
{
    public class Banco
    {
        SQLiteConnection db;

        public Banco()
        {
            db = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "escola.db"));

            db.CreateTable<Aluno>();
        }

        public void Adicionar(Aluno a)
        {
            db.Insert(a);
        }

        public void Atualizar(Aluno a)
        {
            db.Update(a);
        }

        public void Excluir(Aluno a)
        {
            db.Delete(a);
        }

        public Aluno Consultar(int idAluno)
        {
            return db.Table<Aluno>().Where(i => i.Id == idAluno).FirstOrDefault();
        }
    }
}
