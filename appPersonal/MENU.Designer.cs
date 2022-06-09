namespace appPersonal
{
    partial class MENU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo = new System.Windows.Forms.Label();
            this.butAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butCargos = new System.Windows.Forms.Button();
            this.butMensualidad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(284, 24);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(267, 23);
            this.titulo.TabIndex = 3;
            this.titulo.Text = "CONTROL DEL PERSONAL";
            // 
            // butAgregar
            // 
            this.butAgregar.BackColor = System.Drawing.Color.LawnGreen;
            this.butAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butAgregar.Location = new System.Drawing.Point(180, 110);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(151, 76);
            this.butAgregar.TabIndex = 4;
            this.butAgregar.Text = "AGREGAR Y VER PERSONAL";
            this.butAgregar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "app Comercial";
            // 
            // butCargos
            // 
            this.butCargos.BackColor = System.Drawing.Color.Chartreuse;
            this.butCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCargos.Location = new System.Drawing.Point(370, 110);
            this.butCargos.Name = "butCargos";
            this.butCargos.Size = new System.Drawing.Size(133, 76);
            this.butCargos.TabIndex = 6;
            this.butCargos.Text = "PERSONAL Y CARGOS ";
            this.butCargos.UseVisualStyleBackColor = false;
            // 
            // butMensualidad
            // 
            this.butMensualidad.BackColor = System.Drawing.Color.Chartreuse;
            this.butMensualidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMensualidad.Location = new System.Drawing.Point(548, 110);
            this.butMensualidad.Name = "butMensualidad";
            this.butMensualidad.Size = new System.Drawing.Size(146, 76);
            this.butMensualidad.TabIndex = 7;
            this.butMensualidad.Text = "MENSUALIDAD DE TRABAJADORES";
            this.butMensualidad.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appPersonal.Properties.Resources.logoñ;
            this.pictureBox1.Location = new System.Drawing.Point(33, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Red;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalir.Location = new System.Drawing.Point(22, 12);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(74, 23);
            this.buttonSalir.TabIndex = 9;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 232);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butMensualidad);
            this.Controls.Add(this.butCargos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.titulo);
            this.Name = "MENU";
            this.Text = "MENU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCargos;
        private System.Windows.Forms.Button butMensualidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSalir;
    }
}