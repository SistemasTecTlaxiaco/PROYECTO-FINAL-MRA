namespace appPersonal
{
    partial class LOGIN_principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.texContraseña = new System.Windows.Forms.TextBox();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butAcepatr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "app Comercial";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(287, 35);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(267, 23);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "CONTROL DEL PERSONAL";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(227, 151);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(179, 16);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "NOMBRE DE LA EMPRESA:";
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Location = new System.Drawing.Point(330, 211);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(76, 13);
            this.contraseña.TabIndex = 4;
            this.contraseña.Text = "COTRASEÑA:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(412, 151);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(273, 20);
            this.textNombre.TabIndex = 5;
            // 
            // texContraseña
            // 
            this.texContraseña.Location = new System.Drawing.Point(412, 204);
            this.texContraseña.Name = "texContraseña";
            this.texContraseña.Size = new System.Drawing.Size(273, 20);
            this.texContraseña.TabIndex = 6;
            // 
            // butAceptar
            // 
            this.butAceptar.BackColor = System.Drawing.SystemColors.Info;
            this.butAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAceptar.Location = new System.Drawing.Point(412, 270);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(97, 29);
            this.butAceptar.TabIndex = 7;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = false;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butAcepatr
            // 
            this.butAcepatr.BackColor = System.Drawing.SystemColors.Info;
            this.butAcepatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAcepatr.Location = new System.Drawing.Point(601, 269);
            this.butAcepatr.Name = "butAcepatr";
            this.butAcepatr.Size = new System.Drawing.Size(84, 30);
            this.butAcepatr.TabIndex = 8;
            this.butAcepatr.Text = "Cancelar";
            this.butAcepatr.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appPersonal.Properties.Resources.logoñ;
            this.pictureBox1.Location = new System.Drawing.Point(38, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LOGIN_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(729, 328);
            this.Controls.Add(this.butAcepatr);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.texContraseña);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LOGIN_principal";
            this.Text = "LOGIN_principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox texContraseña;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butAcepatr;
    }
}