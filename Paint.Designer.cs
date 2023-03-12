
namespace Ejercicio11
{
    partial class Paint
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBox_TamañoPincel = new System.Windows.Forms.TextBox();
            this.Button_ElegirColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_ColorFondo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TextBox_TamañoForma = new System.Windows.Forms.TextBox();
            this.button_Circulo = new System.Windows.Forms.Button();
            this.button_Rectangulo = new System.Windows.Forms.Button();
            this.button_Cuadrado = new System.Windows.Forms.Button();
            this.pnl_Lienzo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Lienzo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(177, 359);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBox_TamañoPincel);
            this.groupBox3.Controls.Add(this.Button_ElegirColor);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Anchura y Color";
            // 
            // TextBox_TamañoPincel
            // 
            this.TextBox_TamañoPincel.Location = new System.Drawing.Point(6, 20);
            this.TextBox_TamañoPincel.Name = "TextBox_TamañoPincel";
            this.TextBox_TamañoPincel.Size = new System.Drawing.Size(150, 20);
            this.TextBox_TamañoPincel.TabIndex = 1;
            this.TextBox_TamañoPincel.Text = "5";
            // 
            // Button_ElegirColor
            // 
            this.Button_ElegirColor.BackColor = System.Drawing.Color.Red;
            this.Button_ElegirColor.Location = new System.Drawing.Point(6, 46);
            this.Button_ElegirColor.Name = "Button_ElegirColor";
            this.Button_ElegirColor.Size = new System.Drawing.Size(150, 23);
            this.Button_ElegirColor.TabIndex = 1;
            this.Button_ElegirColor.Text = "Ajustar";
            this.Button_ElegirColor.UseVisualStyleBackColor = false;
            this.Button_ElegirColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_ColorFondo);
            this.groupBox2.Location = new System.Drawing.Point(3, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color de Fondo";
            // 
            // Button_ColorFondo
            // 
            this.Button_ColorFondo.BackColor = System.Drawing.Color.Gold;
            this.Button_ColorFondo.Location = new System.Drawing.Point(6, 19);
            this.Button_ColorFondo.Name = "Button_ColorFondo";
            this.Button_ColorFondo.Size = new System.Drawing.Size(151, 23);
            this.Button_ColorFondo.TabIndex = 1;
            this.Button_ColorFondo.Text = "Ajustar";
            this.Button_ColorFondo.UseVisualStyleBackColor = false;
            this.Button_ColorFondo.Click += new System.EventHandler(this.btn_CanvasColor_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button_Circulo);
            this.groupBox1.Controls.Add(this.button_Rectangulo);
            this.groupBox1.Controls.Add(this.button_Cuadrado);
            this.groupBox1.Location = new System.Drawing.Point(3, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dibujar Formas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TextBox_TamañoForma);
            this.groupBox4.Location = new System.Drawing.Point(7, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 59);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tamaño Forma";
            // 
            // TextBox_TamañoForma
            // 
            this.TextBox_TamañoForma.Location = new System.Drawing.Point(7, 20);
            this.TextBox_TamañoForma.Name = "TextBox_TamañoForma";
            this.TextBox_TamañoForma.Size = new System.Drawing.Size(136, 20);
            this.TextBox_TamañoForma.TabIndex = 0;
            this.TextBox_TamañoForma.Text = "5";
            // 
            // button_Circulo
            // 
            this.button_Circulo.Location = new System.Drawing.Point(6, 78);
            this.button_Circulo.Name = "button_Circulo";
            this.button_Circulo.Size = new System.Drawing.Size(150, 23);
            this.button_Circulo.TabIndex = 2;
            this.button_Circulo.Text = "Circulo";
            this.button_Circulo.UseVisualStyleBackColor = true;
            this.button_Circulo.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // button_Rectangulo
            // 
            this.button_Rectangulo.Location = new System.Drawing.Point(7, 49);
            this.button_Rectangulo.Name = "button_Rectangulo";
            this.button_Rectangulo.Size = new System.Drawing.Size(150, 23);
            this.button_Rectangulo.TabIndex = 1;
            this.button_Rectangulo.Text = "Rectangulo";
            this.button_Rectangulo.UseVisualStyleBackColor = true;
            this.button_Rectangulo.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // button_Cuadrado
            // 
            this.button_Cuadrado.Location = new System.Drawing.Point(7, 20);
            this.button_Cuadrado.Name = "button_Cuadrado";
            this.button_Cuadrado.Size = new System.Drawing.Size(150, 23);
            this.button_Cuadrado.TabIndex = 0;
            this.button_Cuadrado.Text = "Cuadrado";
            this.button_Cuadrado.UseVisualStyleBackColor = true;
            this.button_Cuadrado.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // pnl_Lienzo
            // 
            this.pnl_Lienzo.Location = new System.Drawing.Point(211, 35);
            this.pnl_Lienzo.Name = "pnl_Lienzo";
            this.pnl_Lienzo.Size = new System.Drawing.Size(479, 403);
            this.pnl_Lienzo.TabIndex = 3;
            this.pnl_Lienzo.TabStop = false;
            this.pnl_Lienzo.Click += new System.EventHandler(this.button1_Click);
            this.pnl_Lienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseDown);
            this.pnl_Lienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            this.pnl_Lienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.newToolStripMenuItem.Text = "Menu";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Lienzo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.Text = "Paint";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Lienzo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_ColorFondo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Button_ElegirColor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TextBox_TamañoForma;
        private System.Windows.Forms.Button button_Circulo;
        private System.Windows.Forms.Button button_Rectangulo;
        private System.Windows.Forms.Button button_Cuadrado;
        private System.Windows.Forms.PictureBox pnl_Lienzo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox_TamañoPincel;
    }
}

