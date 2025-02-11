using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DreamGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=bd_dreamgame; Uid=root; Pwd=;";

            string query = "INSERT INTO tb_games (Titulo, Avaliação, Tamanho, Descrição, Valor, Desenvolvedor, Genero) " +
                "VALUES (@Titulo, @Avaliação, @Tamanho, @Descrição, @Valor, @Desenvolvedor, @Genero)";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {

                try
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Titulo", textBoxTitulo.Text);
                        comando.Parameters.AddWithValue("@Avaliação", comboBoxAvaliação.Text);
                        comando.Parameters.AddWithValue("@Tamanho", maskedTextBoxTamanho.Text);
                        comando.Parameters.AddWithValue("@Descrição", richTextBoxDescrição.Text);
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@Desenvolvedor", textBoxDesenvolvedor.Text);
                        comando.Parameters.AddWithValue("@Genero", comboBoxGenero.Text);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");


                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }


        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Text = "";
            comboBoxAvaliação.Text = "";
            maskedTextBoxTamanho.Text = "";
            richTextBoxDescrição.Text = "";
            maskedTextBoxValor.Text = "";
            textBoxDesenvolvedor.Text = "";
            comboBoxGenero.Text = "";
            textBoxTitulo.Focus();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

