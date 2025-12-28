using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_teste1
{
    public partial class frm_compra : Form
    {
        public frm_compra()
        {
            InitializeComponent();
        }

        int idVooSelecionado;

        public frm_compra(int idVoo)
        {
            InitializeComponent();
            idVooSelecionado = idVoo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_compra_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            Conexao con = new Conexao();

            try
            {
                // BUSCAR DADOS DO USUÁRIO
                string sqlUsuario = "SELECT nome, email, telefone, cpf FROM usuarios WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(sqlUsuario, con.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@id", Sessao.UsuarioID);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            textBox1.Text = dr["nome"].ToString();
                            textBox2.Text = dr["email"].ToString();
                            textBox3.Text = dr["telefone"].ToString();
                            textBox9.Text = dr["cpf"].ToString();
                        }
                    }
                }

                con.FecharConexao();


                // BUSCAR DADOS DO VOO
                string sqlVoo = @"SELECT numero_voo, origem, destino, data_voo, hora_voo 
                          FROM voos 
                          WHERE id_voo = @id";

                using (MySqlCommand cmd = new MySqlCommand(sqlVoo, con.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@id", idVooSelecionado);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            textBox4.Text = dr["numero_voo"].ToString();
                            textBox5.Text = dr["origem"].ToString();
                            textBox6.Text = dr["destino"].ToString();
                            textBox7.Text = Convert.ToDateTime(dr["data_voo"]).ToString("dd/MM/yyyy");
                            textBox8.Text = dr["hora_voo"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Orange, 3)) // 3 = espessura da borda
            {
                Panel panel = (Panel)sender;
                int y = panel.Height - 1; // parte inferior do painel
                e.Graphics.DrawLine(pen, 0, y, panel.Width, y);
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Orange, 3)) // 3 = espessura da borda
            {
                Panel panel = (Panel)sender;
                int y = panel.Height - 1; // parte inferior do painel
                e.Graphics.DrawLine(pen, 0, y, panel.Width, y);
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Orange, 3)) // 3 = espessura da borda
            {
                Panel panel = (Panel)sender;
                int y = panel.Height - 1; // parte inferior do painel
                e.Graphics.DrawLine(pen, 0, y, panel.Width, y);
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Orange, 3)) // mesma cor e espessura
            {
                // desenha no topo
                e.Graphics.DrawLine(pen, 0, 0, panel.Width, 0);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Orange, 3)) // mesma cor e espessura
            {
                // desenha no topo
                e.Graphics.DrawLine(pen, 0, 0, panel.Width, 0);
            }
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Orange, 3)) // mesma cor e espessura
            {
                // desenha no topo
                e.Graphics.DrawLine(pen, 0, 0, panel.Width, 0);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //use para confirmar os valores e criar um novo id na tabela com base nas informações
            if (Sessao.UsuarioID <= 0)
            {
                MessageBox.Show("Você precisa estar logado para confirmar a compra.");
                return;
            }

            try
            {
                Conexao con = new Conexao();
                con.AbrirConexao();

                string sql = @"
            INSERT INTO passagens (id, id_voo, confirmado)
            VALUES (@idUsuario, @idVoo, 1)
        ";

                MySqlCommand cmd = new MySqlCommand(sql, con.AbrirConexao());
                cmd.Parameters.AddWithValue("@idUsuario", Sessao.UsuarioID);
                cmd.Parameters.AddWithValue("@idVoo", idVooSelecionado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Passagem confirmada com sucesso!");

                con.FecharConexao();

                frm_index inicio = new frm_index();
                inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao confirmar a passagem: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Sessao.UsuarioID <= 0)
            {
                MessageBox.Show("Você precisa estar logado para acessar esta área.");

                frm_cadastro cad = new frm_cadastro();
                cad.Show();
                this.Hide();
            }
            else
            {
                frm_usuario index = new frm_usuario();
                index.Show();
                this.Hide();
            }

        }
    }
}
