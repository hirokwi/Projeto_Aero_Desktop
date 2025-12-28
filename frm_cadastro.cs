using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_teste1
{
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int raio = 20; // borda suave
            GraphicsPath caminho = new GraphicsPath();
            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(p.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(p.Width - raio, p.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, p.Height - raio, raio, raio, 90, 90);
            caminho.CloseAllFigures();

            p.Region = new Region(caminho);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel3_Paint(sender, e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel3_Paint(sender, e);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel3_Paint(sender, e);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void frm_cadastro_Load(object sender, EventArgs e)
        {
            if (Sessao.UsuarioID > 0)
            {
                panel7.Visible = false;
                panel7.Enabled = false;
            }
            else
            {
                panel7.Visible = true;
                panel7.Enabled = true;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e) //esse confirma a senha USE ESSE TEXT BOX
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int raio = 20; // borda suave

            // caminho arredondado
            GraphicsPath caminho = new GraphicsPath();
            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(p.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(p.Width - raio, p.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, p.Height - raio, raio, raio, 90, 90);
            caminho.CloseAllFigures();

            // define a área do panel com bordas arredondadas
            p.Region = new Region(caminho);

            // desenha sombra leve (embaixo e à direita)
            using (SolidBrush sombra = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
            {
                g.FillRectangle(sombra, 5, p.Height - 5, p.Width - 5, 5); // sombra inferior
                g.FillRectangle(sombra, p.Width - 5, 5, 5, p.Height - 5); // sombra direita
            }

            // desenha fundo
            using (SolidBrush fundo = new SolidBrush(p.BackColor))
            {
                g.FillPath(fundo, caminho);
            }
        }








        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            int raio = 40;
            Panel p = sender as Panel;

            System.Drawing.Drawing2D.GraphicsPath caminho = new System.Drawing.Drawing2D.GraphicsPath();
            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(p.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(p.Width - raio, p.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, p.Height - raio, raio, raio, 90, 90);
            caminho.CloseAllFigures();

            p.Region = new Region(caminho);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            int raio = 20;
            Panel p = sender as Panel;

            System.Drawing.Drawing2D.GraphicsPath caminho = new System.Drawing.Drawing2D.GraphicsPath();
            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(p.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(p.Width - raio, p.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, p.Height - raio, raio, raio, 90, 90);
            caminho.CloseAllFigures();

            p.Region = new Region(caminho);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen caneta = new Pen(Color.LightGray, 1))
            {
                e.Graphics.DrawPath(caneta, caminho);
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            int raio = 20;
            Panel p = sender as Panel;

            System.Drawing.Drawing2D.GraphicsPath caminho = new System.Drawing.Drawing2D.GraphicsPath();
            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(p.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(p.Width - raio, p.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, p.Height - raio, raio, raio, 90, 90);
            caminho.CloseAllFigures();

            p.Region = new Region(caminho);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen caneta = new Pen(Color.LightGray, 1))
            {
                e.Graphics.DrawPath(caneta, caminho);
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            int raio = 20;
            Panel p = sender as Panel;

            System.Drawing.Drawing2D.GraphicsPath caminho = new System.Drawing.Drawing2D.GraphicsPath();
            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(p.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(p.Width - raio, p.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, p.Height - raio, raio, raio, 90, 90);
            caminho.CloseAllFigures();

            p.Region = new Region(caminho);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen caneta = new Pen(Color.LightGray, 1))
            {
                e.Graphics.DrawPath(caneta, caminho);
            }
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            int raio = 20;
            Panel p = sender as Panel;

            System.Drawing.Drawing2D.GraphicsPath caminho = new System.Drawing.Drawing2D.GraphicsPath();
            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(p.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(p.Width - raio, p.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, p.Height - raio, raio, raio, 90, 90);
            caminho.CloseAllFigures();

            p.Region = new Region(caminho);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen caneta = new Pen(Color.LightGray, 1))
            {
                e.Graphics.DrawPath(caneta, caminho);
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            frm_index index = new frm_index();
            index.Show();
            this.Hide();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            frm_corpo index = new frm_corpo();
            index.Show();
            this.Hide();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            frm_skyviagens index = new frm_skyviagens();
            index.Show();
            this.Hide();
        }
        Conexao con = new Conexao();

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //esse é o email USE ESSE TEXT BOX
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)// esse é a senha USE ESSE TEXT BOX
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e) //use como botao para enviar os dados!!!
        {
            string email = textBox1.Text.Trim();
            string senhaTexto = textBox3.Text.Trim();
            string confirma = textBox2.Text.Trim();
            string cpf = textBox4.Text.Trim();
            string rg = textBox5.Text.Trim();
            string telefone = textBox6.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senhaTexto) || string.IsNullOrEmpty(confirma) ||
                string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(rg) || string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senhaTexto != confirma)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MySqlConnection conexao = con.AbrirConexao();

                string verificaEmail = "SELECT COUNT(*) FROM usuarios WHERE email = @email";
                MySqlCommand cmdVerifica = new MySqlCommand(verificaEmail, conexao);
                cmdVerifica.Parameters.AddWithValue("@email", email);
                long existe = (long)cmdVerifica.ExecuteScalar();

                if (existe > 0)
                {
                    MessageBox.Show("Este e-mail já está cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nomeCompleto = Microsoft.VisualBasic.Interaction.InputBox(
                    "Digite seu nome completo:", "Nome Completo", "");

                if (string.IsNullOrWhiteSpace(nomeCompleto))
                {
                    MessageBox.Show("O nome completo é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "INSERT INTO usuarios (email, senha, cpf, rg, telefone, nome) " +
                             "VALUES (@email, @senha, @cpf, @rg, @telefone, @nome)";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senhaTexto);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@nome", nomeCompleto);

                cmd.ExecuteNonQuery();

                // 🔥 PEGAR ID DO USUÁRIO RECÉM INSERIDO
                MySqlCommand cmdId = new MySqlCommand("SELECT LAST_INSERT_ID();", conexao);
                int idGerado = Convert.ToInt32(cmdId.ExecuteScalar());

                // 🔥 SALVAR NA SESSÃO
                Sessao.UsuarioID = idGerado;

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔥 LIMPAR CAMPOS
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

                // 🔥 FECHAR O PANEL DE CADASTRO
                panel7.Visible = false;   // <-- altere para o nome do seu panel
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.FecharConexao();
            }


        }

        private void label24_Click(object sender, EventArgs e)
        {
            frm_login index = new frm_login();
            index.Show();
            this.Hide();
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Orange, 3)) // 3 = espessura da borda
            {
                Panel panel = (Panel)sender;
                int y = panel.Height - 1; // parte inferior do painel
                e.Graphics.DrawLine(pen, 0, y, panel.Width, y);
            }
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Orange, 3)) // 3 = espessura da borda
            {
                Panel panel = (Panel)sender;
                int y = panel.Height - 1; // parte inferior do painel
                e.Graphics.DrawLine(pen, 0, y, panel.Width, y);
            }
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Orange, 3)) // mesma cor e espessura
            {
                // desenha no topo
                e.Graphics.DrawLine(pen, 0, 0, panel.Width, 0);
            }
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Orange, 3)) // mesma cor e espessura
            {
                // desenha no topo
                e.Graphics.DrawLine(pen, 0, 0, panel.Width, 0);
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Orange, 3)) // mesma cor e espessura
            {
                // desenha no topo
                e.Graphics.DrawLine(pen, 0, 0, panel.Width, 0);
            }
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Orange, 3)) // 3 = espessura da borda
            {
                Panel panel = (Panel)sender;
                int y = panel.Height - 1; // parte inferior do painel
                e.Graphics.DrawLine(pen, 0, y, panel.Width, y);
            }
        }

        private void label7_Click(object sender, EventArgs e)
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

