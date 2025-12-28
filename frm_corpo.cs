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
    public partial class frm_corpo : Form
    {
        public frm_corpo()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color corBorda = Color.Orange;
            int espessura = 2;
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, corBorda, espessura, ButtonBorderStyle.Solid,
                                    corBorda, espessura, ButtonBorderStyle.Solid,
                                    corBorda, espessura, ButtonBorderStyle.Solid,
                                    corBorda, espessura, ButtonBorderStyle.Solid);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            Color corBorda = Color.Orange;
            int espessura = 2;
            ControlPaint.DrawBorder(e.Graphics, pnlHeader.ClientRectangle, corBorda, espessura, ButtonBorderStyle.Solid,
                                    corBorda, espessura, ButtonBorderStyle.Solid,
                                    corBorda, espessura, ButtonBorderStyle.Solid,
                                    corBorda, espessura, ButtonBorderStyle.Solid);
        }

        private void frm_corpo_Load(object sender, EventArgs e)
        {

        }
        Conexao con = new Conexao();

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void label14_Click(object sender, EventArgs e)
        {
            frm_index index = new frm_index();
            index.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            frm_skyviagens index = new frm_skyviagens();
            index.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            frm_cadastro index = new frm_cadastro();
            index.Show();
            this.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
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

        private void panel6_Paint(object sender, PaintEventArgs e)
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

        private void panel5_Paint(object sender, PaintEventArgs e)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

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
