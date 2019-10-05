namespace WindowsFormsAppClassesColleccions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnyoEstreno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxTemas = new System.Windows.Forms.ListBox();
            this.buttonAnyadir = new System.Windows.Forms.Button();
            this.buttonEliminarSeleccionada = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxAnyoEstreno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxDirector);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pelicula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(110, 33);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(367, 22);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(110, 61);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(367, 22);
            this.textBoxDirector.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Director";
            // 
            // textBoxAnyoEstreno
            // 
            this.textBoxAnyoEstreno.Location = new System.Drawing.Point(110, 89);
            this.textBoxAnyoEstreno.Name = "textBoxAnyoEstreno";
            this.textBoxAnyoEstreno.Size = new System.Drawing.Size(367, 22);
            this.textBoxAnyoEstreno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año estreno";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxTemas);
            this.groupBox2.Location = new System.Drawing.Point(7, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 317);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temas";
            // 
            // listBoxTemas
            // 
            this.listBoxTemas.FormattingEnabled = true;
            this.listBoxTemas.ItemHeight = 16;
            this.listBoxTemas.Items.AddRange(new object[] {
            "Ciencia ficción",
            "Western",
            "Dibujos animados",
            "Acción",
            "Terror",
            "Fantasía",
            "Romántica",
            "Drama",
            "Comedia",
            "Aventuras",
            "Suspense"});
            this.listBoxTemas.Location = new System.Drawing.Point(15, 33);
            this.listBoxTemas.Name = "listBoxTemas";
            this.listBoxTemas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTemas.Size = new System.Drawing.Size(449, 276);
            this.listBoxTemas.TabIndex = 0;
            // 
            // buttonAnyadir
            // 
            this.buttonAnyadir.Location = new System.Drawing.Point(520, 36);
            this.buttonAnyadir.Name = "buttonAnyadir";
            this.buttonAnyadir.Size = new System.Drawing.Size(105, 41);
            this.buttonAnyadir.TabIndex = 1;
            this.buttonAnyadir.Text = "Añadir";
            this.buttonAnyadir.UseVisualStyleBackColor = true;
            this.buttonAnyadir.Click += new System.EventHandler(this.buttonAnyadir_Click);
            // 
            // buttonEliminarSeleccionada
            // 
            this.buttonEliminarSeleccionada.Location = new System.Drawing.Point(631, 36);
            this.buttonEliminarSeleccionada.Name = "buttonEliminarSeleccionada";
            this.buttonEliminarSeleccionada.Size = new System.Drawing.Size(299, 41);
            this.buttonEliminarSeleccionada.TabIndex = 2;
            this.buttonEliminarSeleccionada.Text = "Eliminar seleccionada";
            this.buttonEliminarSeleccionada.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxPeliculas);
            this.groupBox3.Location = new System.Drawing.Point(505, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 387);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Películas";
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.ItemHeight = 16;
            this.listBoxPeliculas.Location = new System.Drawing.Point(7, 25);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(412, 356);
            this.listBoxPeliculas.TabIndex = 0;
            this.listBoxPeliculas.SelectedIndexChanged += new System.EventHandler(this.listBoxPeliculas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 482);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonEliminarSeleccionada);
            this.Controls.Add(this.buttonAnyadir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxTemas;
        private System.Windows.Forms.TextBox textBoxAnyoEstreno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAnyadir;
        private System.Windows.Forms.Button buttonEliminarSeleccionada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxPeliculas;
    }
}

