using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Drawing2D;

namespace projeto_teste1
{

    public partial class frm_index : Form
    {

        public frm_index()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Conexao con = new Conexao();

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Rectangle rect = panel1.ClientRectangle;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(255, 255, 250, 240), // cor clara no topo (tipo FloralWhite)
                Color.FromArgb(255, 255, 200, 100), // cor alaranjada embaixo
                LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            // borda laranja só embaixo
            using (Pen pen = new Pen(Color.Orange, 3))
            {
                e.Graphics.DrawLine(pen, 0, panel1.Height - 1, panel1.Width, panel1.Height - 1);
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
            Color corBorda = Color.Orange;
            int espessura = 2;
            ControlPaint.DrawBorder(e.Graphics, pnlFooter.ClientRectangle, corBorda, espessura, ButtonBorderStyle.Solid,
                                    corBorda, espessura, ButtonBorderStyle.Solid,
                                    corBorda, espessura, ButtonBorderStyle.Solid,
                                    corBorda, espessura, ButtonBorderStyle.Solid);
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int raio = 20; // define o quanto os cantos vão ser arredondados

            System.Drawing.Drawing2D.GraphicsPath caminho = new System.Drawing.Drawing2D.GraphicsPath();
            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(panel2.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(panel2.Width - raio, panel2.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, panel2.Height - raio, raio, raio, 90, 90);
            caminho.CloseAllFigures();

            panel2.Region = new Region(caminho);

            Pen caneta = new Pen(Color.White, 2); // cor e espessura da borda
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(caneta, caminho);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void frm_index_Paint(object sender, PaintEventArgs e)
        {
            int raio = 20; // define o quanto os cantos vão ser arredondados

            System.Drawing.Drawing2D.GraphicsPath caminho = new System.Drawing.Drawing2D.GraphicsPath();
            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(panel2.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(panel2.Width - raio, panel2.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, panel2.Height - raio, raio, raio, 90, 90);
            caminho.CloseAllFigures();

            panel2.Region = new Region(caminho);

            Pen caneta = new Pen(Color.White, 2); // cor e espessura da borda
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(caneta, caminho);
        }


        private void frm_index_Load(object sender, EventArgs e)
        {

        }


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
            using (Pen caneta = new Pen(Color.LightGray, 1)) // borda sutil
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

        private void label15_Click(object sender, EventArgs e)
        {
            frm_corpo index = new frm_corpo();
            index.Show();
            this.Hide();
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

        private void panel12_Paint(object sender, PaintEventArgs e)
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

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //origem
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //destino
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dataida
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //selecionar um valor
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            frm_corpo index = new frm_corpo();
            index.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Sessao.UsuarioID <= 0)
            {
                MessageBox.Show("Você precisa estar logado para buscar voos.");

                frm_cadastro cad = new frm_cadastro();
                cad.Show();

                this.Hide();
                return;
            }
            BuscarVoos();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BuscarVoos()
        {
            string origem = comboBox1.Text.Trim();
            string destino = comboBox2.Text.Trim();
            string data = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            try
            {
                con.AbrirConexao(); // FALTAVA ISSO

                string sql = @"
    SELECT id_voo, numero_voo, origem, destino, data_voo, hora_voo
    FROM voos
    WHERE (@origem = '' OR origem LIKE @origem)
      AND (@destino = '' OR destino LIKE @destino)
      AND data_voo >= @data
    ORDER BY data_voo ASC, hora_voo ASC";

                MySqlCommand cmd = new MySqlCommand(sql, con.AbrirConexao());


                cmd.Parameters.AddWithValue("@origem", "%" + origem + "%");
                cmd.Parameters.AddWithValue("@destino", "%" + destino + "%");
                cmd.Parameters.AddWithValue("@data", data);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum voo encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar voos: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idVoo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_voo"].Value);

                frm_compra compra = new frm_compra(idVoo);
                compra.Show();

                this.Hide();
            }


        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
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
      