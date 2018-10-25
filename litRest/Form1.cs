using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace litRest
{
    public partial class Form1 : Form
    {
        
        SqlConnection conexion;
        public int asd = 0;
        public Form1()
        {
            InitializeComponent();
            //conexionSQL();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void conexionSQL()
        {
            try
            {
                conexion = new SqlConnection("server=DANIEL-PC; database=litrest; integrated security=true");
                conexion.Close();
                Console.WriteLine("Conexión establecida con base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMinimizar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnMinimizar.Visible = false;
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            btnInicio.Width = btnInicio.Height = 66;
            btnInicio.Location = new Point(btnInicio.Location.X-3, btnInicio.Location.Y-3);
            lblInicio.Location = new Point(lblInicio.Location.X, lblInicio.Location.Y + 3);
            lblInicio.Font = new Font(lblInicio.Font.Name, lblInicio.Font.SizeInPoints, FontStyle.Underline);
            lblInicio.Font = new Font(lblInicio.Font.Name, lblInicio.Font.SizeInPoints, FontStyle.Bold);
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.Width = btnInicio.Height = 60;
            btnInicio.Location = new Point(btnInicio.Location.X + 3, btnInicio.Location.Y + 3);
            lblInicio.Location = new Point(lblInicio.Location.X, lblInicio.Location.Y - 3);
            lblInicio.Font = new Font(lblInicio.Font.Name, lblInicio.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnEstadis_MouseEnter(object sender, EventArgs e)
        {
            btnEstadis.Width = btnEstadis.Height = 66;
            btnEstadis.Location = new Point(btnEstadis.Location.X - 3, btnEstadis.Location.Y - 3);
            lblEstadis.Location = new Point(lblEstadis.Location.X, lblEstadis.Location.Y + 3);
            lblEstadis.Font = new Font(lblEstadis.Font.Name, lblEstadis.Font.SizeInPoints, FontStyle.Underline);
            lblEstadis.Font = new Font(lblEstadis.Font.Name, lblEstadis.Font.SizeInPoints, FontStyle.Bold);
        }

        private void btnEstadis_MouseLeave(object sender, EventArgs e)
        {
            btnEstadis.Width = btnEstadis.Height = 60;
            btnEstadis.Location = new Point(btnEstadis.Location.X + 3, btnEstadis.Location.Y + 3);
            lblEstadis.Location = new Point(lblEstadis.Location.X, lblEstadis.Location.Y - 3);
            lblEstadis.Font = new Font(lblEstadis.Font.Name, lblEstadis.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnProdu_MouseEnter(object sender, EventArgs e)
        {
            btnProdu.Width = btnProdu.Height = 66;
            btnProdu.Location = new Point(btnProdu.Location.X - 3, btnProdu.Location.Y - 3);
            lblProdu.Location = new Point(lblProdu.Location.X, lblProdu.Location.Y + 3);
            lblProdu.Font = new Font(lblProdu.Font.Name, lblProdu.Font.SizeInPoints, FontStyle.Underline);
            lblProdu.Font = new Font(lblProdu.Font.Name, lblProdu.Font.SizeInPoints, FontStyle.Bold);
        }

        private void btnProdu_MouseLeave(object sender, EventArgs e)
        {
            btnProdu.Width = btnProdu.Height = 60;
            btnProdu.Location = new Point(btnProdu.Location.X + 3, btnProdu.Location.Y + 3);
            lblProdu.Location = new Point(lblProdu.Location.X, lblProdu.Location.Y - 3);
            lblProdu.Font = new Font(lblProdu.Font.Name, lblProdu.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            btnUser.Width = btnUser.Height = 66;
            btnUser.Location = new Point(btnUser.Location.X - 3, btnUser.Location.Y - 3);
            lblUser.Location = new Point(lblUser.Location.X, lblUser.Location.Y + 3);
            lblUser.Font = new Font(lblUser.Font.Name, lblUser.Font.SizeInPoints, FontStyle.Underline);
            lblUser.Font = new Font(lblUser.Font.Name, lblUser.Font.SizeInPoints, FontStyle.Bold);
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.Width = btnUser.Height = 60;
            btnUser.Location = new Point(btnUser.Location.X + 3, btnUser.Location.Y + 3);
            lblUser.Location = new Point(lblUser.Location.X, lblUser.Location.Y - 3);
            lblUser.Font = new Font(lblUser.Font.Name, lblUser.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnAjustes_MouseEnter(object sender, EventArgs e)
        {
            btnAjustes.Width = btnAjustes.Height = 66;
            btnAjustes.Location = new Point(btnAjustes.Location.X - 3, btnAjustes.Location.Y - 3);
            lblAjustes.Location = new Point(lblAjustes.Location.X, lblAjustes.Location.Y + 3);
            lblAjustes.Font = new Font(lblAjustes.Font.Name, lblAjustes.Font.SizeInPoints, FontStyle.Underline);
            lblAjustes.Font = new Font(lblAjustes.Font.Name, lblAjustes.Font.SizeInPoints, FontStyle.Bold);
        }

        private void btnAjustes_MouseLeave(object sender, EventArgs e)
        {
            btnAjustes.Width = btnAjustes.Height = 60;
            btnAjustes.Location = new Point(btnAjustes.Location.X + 3, btnAjustes.Location.Y + 3);
            lblAjustes.Location = new Point(lblAjustes.Location.X, lblAjustes.Location.Y - 3);
            lblAjustes.Font = new Font(lblAjustes.Font.Name, lblAjustes.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.Width = btnSalir.Height = 66;
            btnSalir.Location = new Point(btnSalir.Location.X - 3, btnSalir.Location.Y - 3);
            label1.Location = new Point(label1.Location.X, label1.Location.Y + 3);
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Underline);
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Bold);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.Width = btnSalir.Height = 60;
            btnSalir.Location = new Point(btnSalir.Location.X + 3, btnSalir.Location.Y + 3);
            label1.Location = new Point(label1.Location.X, label1.Location.Y - 3);
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Regular);
        }

        private void abrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //abrirFormInPanel(new home());
            home1.Visible = true;
        }
    }
}
