namespace litRest
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAjustes = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblProdu = new System.Windows.Forms.Label();
            this.lblEstadis = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.login1 = new litRest.login();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.btnEstadis = new System.Windows.Forms.PictureBox();
            this.btnProdu = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.PictureBox();
            this.btnAjustes = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnOcultar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.home1 = new litRest.home();
            this.menuVertical.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstadis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuVertical.Controls.Add(this.btnInicio);
            this.menuVertical.Controls.Add(this.btnEstadis);
            this.menuVertical.Controls.Add(this.btnProdu);
            this.menuVertical.Controls.Add(this.btnUser);
            this.menuVertical.Controls.Add(this.btnAjustes);
            this.menuVertical.Controls.Add(this.btnMinimizar);
            this.menuVertical.Controls.Add(this.btnMaximizar);
            this.menuVertical.Controls.Add(this.btnOcultar);
            this.menuVertical.Controls.Add(this.btnSalir);
            this.menuVertical.Controls.Add(this.label1);
            this.menuVertical.Controls.Add(this.lblAjustes);
            this.menuVertical.Controls.Add(this.lblUser);
            this.menuVertical.Controls.Add(this.lblProdu);
            this.menuVertical.Controls.Add(this.lblEstadis);
            this.menuVertical.Controls.Add(this.lblInicio);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuVertical.Location = new System.Drawing.Point(1220, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(80, 700);
            this.menuVertical.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(22, 663);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // lblAjustes
            // 
            this.lblAjustes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAjustes.AutoSize = true;
            this.lblAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAjustes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAjustes.Location = new System.Drawing.Point(9, 524);
            this.lblAjustes.Name = "lblAjustes";
            this.lblAjustes.Size = new System.Drawing.Size(61, 20);
            this.lblAjustes.TabIndex = 2;
            this.lblAjustes.Text = "Ajustes";
            this.lblAjustes.MouseEnter += new System.EventHandler(this.btnAjustes_MouseEnter);
            this.lblAjustes.MouseLeave += new System.EventHandler(this.btnAjustes_MouseLeave);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUser.AutoSize = true;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUser.Location = new System.Drawing.Point(6, 429);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 20);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuarios";
            this.lblUser.MouseEnter += new System.EventHandler(this.btnUser_MouseEnter);
            this.lblUser.MouseLeave += new System.EventHandler(this.btnUser_MouseLeave);
            // 
            // lblProdu
            // 
            this.lblProdu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProdu.AutoSize = true;
            this.lblProdu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProdu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProdu.Location = new System.Drawing.Point(-2, 332);
            this.lblProdu.Name = "lblProdu";
            this.lblProdu.Size = new System.Drawing.Size(84, 20);
            this.lblProdu.TabIndex = 6;
            this.lblProdu.Text = "Productos";
            this.lblProdu.MouseEnter += new System.EventHandler(this.btnProdu_MouseEnter);
            this.lblProdu.MouseLeave += new System.EventHandler(this.btnProdu_MouseLeave);
            // 
            // lblEstadis
            // 
            this.lblEstadis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEstadis.AutoSize = true;
            this.lblEstadis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEstadis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstadis.Location = new System.Drawing.Point(-4, 237);
            this.lblEstadis.Name = "lblEstadis";
            this.lblEstadis.Size = new System.Drawing.Size(90, 20);
            this.lblEstadis.TabIndex = 7;
            this.lblEstadis.Text = "Estadisticas";
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInicio.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInicio.Location = new System.Drawing.Point(18, 139);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(45, 20);
            this.lblInicio.TabIndex = 8;
            this.lblInicio.Text = "Inicio";
            this.lblInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barraTitulo.Controls.Add(this.lblPosicion);
            this.barraTitulo.Controls.Add(this.label2);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1220, 40);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Ubuntu", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPosicion.Location = new System.Drawing.Point(3, 1);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(142, 44);
            this.lblPosicion.TabIndex = 1;
            this.lblPosicion.Text = "Inicio >";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(1076, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "LitRest℠";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Controls.Add(this.home1);
            this.panelContenedor.Controls.Add(this.login1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1220, 660);
            this.panelContenedor.TabIndex = 2;
            // 
            // login1
            // 
            this.login1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.login1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.Location = new System.Drawing.Point(195, 172);
            this.login1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1025, 488);
            this.login1.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Image = global::litRest.Properties.Resources.home;
            this.btnInicio.Location = new System.Drawing.Point(10, 84);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(60, 60);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 4;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            // 
            // btnEstadis
            // 
            this.btnEstadis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEstadis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadis.Image = global::litRest.Properties.Resources.bar_chart;
            this.btnEstadis.Location = new System.Drawing.Point(10, 180);
            this.btnEstadis.Name = "btnEstadis";
            this.btnEstadis.Size = new System.Drawing.Size(60, 60);
            this.btnEstadis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEstadis.TabIndex = 2;
            this.btnEstadis.TabStop = false;
            this.btnEstadis.MouseEnter += new System.EventHandler(this.btnEstadis_MouseEnter);
            this.btnEstadis.MouseLeave += new System.EventHandler(this.btnEstadis_MouseLeave);
            // 
            // btnProdu
            // 
            this.btnProdu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnProdu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdu.Image = global::litRest.Properties.Resources.box;
            this.btnProdu.Location = new System.Drawing.Point(10, 276);
            this.btnProdu.Name = "btnProdu";
            this.btnProdu.Size = new System.Drawing.Size(60, 60);
            this.btnProdu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProdu.TabIndex = 3;
            this.btnProdu.TabStop = false;
            this.btnProdu.MouseEnter += new System.EventHandler(this.btnProdu_MouseEnter);
            this.btnProdu.MouseLeave += new System.EventHandler(this.btnProdu_MouseLeave);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Image = global::litRest.Properties.Resources.stick_man;
            this.btnUser.Location = new System.Drawing.Point(10, 372);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(60, 60);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUser.TabIndex = 2;
            this.btnUser.TabStop = false;
            this.btnUser.MouseEnter += new System.EventHandler(this.btnUser_MouseEnter);
            this.btnUser.MouseLeave += new System.EventHandler(this.btnUser_MouseLeave);
            // 
            // btnAjustes
            // 
            this.btnAjustes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.Image = global::litRest.Properties.Resources.levels;
            this.btnAjustes.Location = new System.Drawing.Point(10, 468);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(60, 60);
            this.btnAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAjustes.TabIndex = 1;
            this.btnAjustes.TabStop = false;
            this.btnAjustes.MouseEnter += new System.EventHandler(this.btnAjustes_MouseEnter);
            this.btnAjustes.MouseLeave += new System.EventHandler(this.btnAjustes_MouseLeave);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::litRest.Properties.Resources.minimize_1_;
            this.btnMinimizar.Location = new System.Drawing.Point(45, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Visible = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::litRest.Properties.Resources.maximize;
            this.btnMaximizar.Location = new System.Drawing.Point(45, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultar.Image = global::litRest.Properties.Resources.minimize;
            this.btnOcultar.Location = new System.Drawing.Point(5, 5);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(30, 30);
            this.btnOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcultar.TabIndex = 0;
            this.btnOcultar.TabStop = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(10, 605);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 60);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1220, 660);
            this.home1.TabIndex = 1;
            this.home1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstadis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnOcultar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnAjustes;
        private System.Windows.Forms.PictureBox btnProdu;
        private System.Windows.Forms.PictureBox btnUser;
        private System.Windows.Forms.Label lblAjustes;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.PictureBox btnEstadis;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblProdu;
        private System.Windows.Forms.Label lblEstadis;
        private System.Windows.Forms.Label lblInicio;
        private login login1;
        private System.Windows.Forms.Panel panelContenedor;
        public System.Windows.Forms.Label lblPosicion;
        private home home1;
    }
}

