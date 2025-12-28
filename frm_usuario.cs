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
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void CarregarUsuario()
        {
            if (Sessao.UsuarioID <= 0)
            {
                MessageBox.Show("Você precisa estar logado.");
                return;
            }

            Conexao con = new Conexao();

            try
            {
                string sql = "SELECT nome, email, telefone, cpf, senha FROM usuarios WHERE id = @id";

                using (MySql.Data.MySqlClient.MySqlCommand cmd =
                       new MySql.Data.MySqlClient.MySqlCommand(sql, con.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@id", Sessao.UsuarioID);

                    using (MySql.Data.MySqlClient.MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            textBox1.Text = dr["nome"].ToString();
                            textBox2.Text = dr["email"].ToString();
                            textBox3.Text = dr["telefone"].ToString();
                            textBox4.Text = dr["cpf"].ToString();
                            textBox5.Text = dr["senha"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do usuário: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            CarregarUsuario();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            frm_cadastro index = new frm_cadastro();
            index.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            frm_skyviagens index = new frm_skyviagens();
            index.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            frm_corpo index = new frm_corpo();
            index.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            frm_index index = new frm_index();
            index.Show();
            this.Hide();
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

        private void panel13_Paint(object sender, PaintEventArgs e)
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

        private void panel10_Paint(object sender, PaintEventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //esse botao para editar

            if (Sessao.UsuarioID <= 0)
            {
                MessageBox.Show("Você precisa estar logado.");
                return;
            }

            string nome = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string tel = textBox3.Text.Trim();
            string cpf = textBox4.Text.Trim();
            string senha = textBox5.Text.Trim();

            Conexao con = new Conexao();

            try
            {
                string sql = @"UPDATE usuarios 
                       SET nome=@n, email=@e, telefone=@t, cpf=@c, senha=@s
                       WHERE id=@id";

                using (MySql.Data.MySqlClient.MySqlCommand cmd =
                       new MySql.Data.MySqlClient.MySqlCommand(sql, con.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@n", nome);
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@t", tel);
                    cmd.Parameters.AddWithValue("@c", cpf);
                    cmd.Parameters.AddWithValue("@s", senha);
                    cmd.Parameters.AddWithValue("@id", Sessao.UsuarioID);

                    int r = cmd.ExecuteNonQuery();

                    if (r > 0)
                    {
                        MessageBox.Show("Dados atualizados com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Nada foi alterado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
        }
    }
}
