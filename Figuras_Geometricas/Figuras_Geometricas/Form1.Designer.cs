namespace Figuras_Geometricas
{
    partial class Figuras
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Figuras));
            this.lbFiguras = new System.Windows.Forms.ListBox();
            this.lbNumlados = new System.Windows.Forms.Label();
            this.lbLado1 = new System.Windows.Forms.Label();
            this.lbBase = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbLado2 = new System.Windows.Forms.Label();
            this.lbLado3 = new System.Windows.Forms.Label();
            this.lbApotema = new System.Windows.Forms.Label();
            this.txbNumLados = new System.Windows.Forms.TextBox();
            this.txbLado3 = new System.Windows.Forms.TextBox();
            this.txbLado2 = new System.Windows.Forms.TextBox();
            this.txbLado1 = new System.Windows.Forms.TextBox();
            this.txbBase = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.txbApotema = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lbMostrarFigura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFiguras
            // 
            this.lbFiguras.BackColor = System.Drawing.Color.GhostWhite;
            this.lbFiguras.FormattingEnabled = true;
            this.lbFiguras.Location = new System.Drawing.Point(-1, 329);
            this.lbFiguras.Name = "lbFiguras";
            this.lbFiguras.Size = new System.Drawing.Size(398, 134);
            this.lbFiguras.TabIndex = 15;
            // 
            // lbNumlados
            // 
            this.lbNumlados.AutoSize = true;
            this.lbNumlados.Location = new System.Drawing.Point(50, 42);
            this.lbNumlados.Name = "lbNumlados";
            this.lbNumlados.Size = new System.Drawing.Size(94, 13);
            this.lbNumlados.TabIndex = 16;
            this.lbNumlados.Text = "Numero de Lados ";
            // 
            // lbLado1
            // 
            this.lbLado1.AutoSize = true;
            this.lbLado1.Location = new System.Drawing.Point(50, 197);
            this.lbLado1.Name = "lbLado1";
            this.lbLado1.Size = new System.Drawing.Size(60, 13);
            this.lbLado1.TabIndex = 17;
            this.lbLado1.Text = "Lado No. 1";
            this.lbLado1.Visible = false;
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Location = new System.Drawing.Point(50, 105);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(31, 13);
            this.lbBase.TabIndex = 18;
            this.lbBase.Text = "Base";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(50, 74);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(34, 13);
            this.lbAltura.TabIndex = 19;
            this.lbAltura.Text = "Altura";
            // 
            // lbLado2
            // 
            this.lbLado2.AutoSize = true;
            this.lbLado2.Location = new System.Drawing.Point(50, 226);
            this.lbLado2.Name = "lbLado2";
            this.lbLado2.Size = new System.Drawing.Size(60, 13);
            this.lbLado2.TabIndex = 20;
            this.lbLado2.Text = "Lado No. 2";
            this.lbLado2.Visible = false;
            // 
            // lbLado3
            // 
            this.lbLado3.AutoSize = true;
            this.lbLado3.Location = new System.Drawing.Point(50, 256);
            this.lbLado3.Name = "lbLado3";
            this.lbLado3.Size = new System.Drawing.Size(60, 13);
            this.lbLado3.TabIndex = 21;
            this.lbLado3.Text = "Lado No. 3";
            this.lbLado3.Visible = false;
            // 
            // lbApotema
            // 
            this.lbApotema.AutoSize = true;
            this.lbApotema.Location = new System.Drawing.Point(50, 282);
            this.lbApotema.Name = "lbApotema";
            this.lbApotema.Size = new System.Drawing.Size(49, 13);
            this.lbApotema.TabIndex = 22;
            this.lbApotema.Text = "Apotema";
            this.lbApotema.Visible = false;
            // 
            // txbNumLados
            // 
            this.txbNumLados.Location = new System.Drawing.Point(253, 35);
            this.txbNumLados.Name = "txbNumLados";
            this.txbNumLados.Size = new System.Drawing.Size(100, 20);
            this.txbNumLados.TabIndex = 23;
            this.txbNumLados.Text = "0";
            this.txbNumLados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbNumLados.TextChanged += new System.EventHandler(this.txbNumLados_TextChanged);
            // 
            // txbLado3
            // 
            this.txbLado3.Location = new System.Drawing.Point(253, 249);
            this.txbLado3.Name = "txbLado3";
            this.txbLado3.Size = new System.Drawing.Size(100, 20);
            this.txbLado3.TabIndex = 25;
            this.txbLado3.Text = "0.0";
            this.txbLado3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbLado3.Visible = false;
            // 
            // txbLado2
            // 
            this.txbLado2.Location = new System.Drawing.Point(253, 219);
            this.txbLado2.Name = "txbLado2";
            this.txbLado2.Size = new System.Drawing.Size(100, 20);
            this.txbLado2.TabIndex = 27;
            this.txbLado2.Text = "0.0";
            this.txbLado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbLado2.Visible = false;
            // 
            // txbLado1
            // 
            this.txbLado1.Location = new System.Drawing.Point(253, 190);
            this.txbLado1.Name = "txbLado1";
            this.txbLado1.Size = new System.Drawing.Size(100, 20);
            this.txbLado1.TabIndex = 28;
            this.txbLado1.Text = "0.0";
            this.txbLado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbLado1.Visible = false;
            // 
            // txbBase
            // 
            this.txbBase.Location = new System.Drawing.Point(253, 98);
            this.txbBase.Name = "txbBase";
            this.txbBase.Size = new System.Drawing.Size(100, 20);
            this.txbBase.TabIndex = 29;
            this.txbBase.Text = "0.0";
            this.txbBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(253, 71);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 30;
            this.txbAltura.Text = "0.0";
            this.txbAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbApotema
            // 
            this.txbApotema.Location = new System.Drawing.Point(253, 275);
            this.txbApotema.Name = "txbApotema";
            this.txbApotema.Size = new System.Drawing.Size(100, 20);
            this.txbApotema.TabIndex = 31;
            this.txbApotema.Text = "0.0";
            this.txbApotema.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbApotema.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(154, 300);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(154, 128);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 33;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lbMostrarFigura
            // 
            this.lbMostrarFigura.AutoSize = true;
            this.lbMostrarFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarFigura.Location = new System.Drawing.Point(150, 162);
            this.lbMostrarFigura.Name = "lbMostrarFigura";
            this.lbMostrarFigura.Size = new System.Drawing.Size(0, 20);
            this.lbMostrarFigura.TabIndex = 34;
            this.lbMostrarFigura.Visible = false;
            // 
            // Figuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Figuras_Geometricas.Properties.Resources.figuras_geomtricas_que_vuelan_19738636;
            this.ClientSize = new System.Drawing.Size(396, 463);
            this.Controls.Add(this.lbMostrarFigura);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbApotema);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbBase);
            this.Controls.Add(this.txbLado1);
            this.Controls.Add(this.txbLado2);
            this.Controls.Add(this.txbLado3);
            this.Controls.Add(this.txbNumLados);
            this.Controls.Add(this.lbApotema);
            this.Controls.Add(this.lbLado3);
            this.Controls.Add(this.lbLado2);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbBase);
            this.Controls.Add(this.lbLado1);
            this.Controls.Add(this.lbNumlados);
            this.Controls.Add(this.lbFiguras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Figuras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figuras Geometricas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFiguras;
        private System.Windows.Forms.Label lbNumlados;
        private System.Windows.Forms.Label lbLado1;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbLado2;
        private System.Windows.Forms.Label lbLado3;
        private System.Windows.Forms.Label lbApotema;
        private System.Windows.Forms.TextBox txbNumLados;
        private System.Windows.Forms.TextBox txbLado3;
        private System.Windows.Forms.TextBox txbLado2;
        private System.Windows.Forms.TextBox txbLado1;
        private System.Windows.Forms.TextBox txbBase;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.TextBox txbApotema;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lbMostrarFigura;
    }
}

