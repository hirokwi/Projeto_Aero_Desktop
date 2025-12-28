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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {
            frm_cadastro index = new frm_cadastro();
            index.Show();
            this.Hide();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        Conexao con = new Conexao();
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //botao que confirmar loginprivate void btnLogin_Click(object sender, EventArgs e)
            string email = textBox1.Text.Trim();
            string senha = textBox3.Text.Trim();

            try
            {
                MySqlConnection conexao = con.AbrirConexao();

                string sql = "SELECT id FROM usuarios WHERE email = @email AND senha = @senha";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    int usuarioID = Convert.ToInt32(resultado);

                    // SALVANDO O ID NA SESSÃO
                    Sessao.UsuarioID = usuarioID;

                    MessageBox.Show("Login realizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_cadastro index = new frm_cadastro();
                    index.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("E-mail ou senha incorretos!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.FecharConexao();
            }
        }




        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Orange, 3)) // 3 = espessura da borda
            {
                Panel panel = (Panel)sender;
                int y = panel.Height - 1; // parte inferior do painel
                e.Graphics.DrawLine(pen, 0, y, panel.Width, y);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
