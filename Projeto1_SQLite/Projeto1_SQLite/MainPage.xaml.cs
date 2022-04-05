using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto1_SQLite
{
    public partial class MainPage : ContentPage
    {
        Banco db = new Banco();

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            edtIdAluno.Text = String.Empty;
            edtNome.Text = String.Empty;
            edtCurso.Text = String.Empty;
        }

        private void btnAdicionar_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(edtNome.Text))
            {
                DisplayAlert("Atenção", "Por favor insira um nome", "OK");
                return;
            }

            Aluno a = new Aluno
            {
                Nome = edtNome.Text,
                Curso = edtCurso.Text
            };

            db.Adicionar(a);
            DisplayAlert("Cadastro", "Aluno inserido com sucesso", "OK");
            btnLimpar_Clicked(sender, e);
        }

        private void btnAtualizar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Clicked(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
