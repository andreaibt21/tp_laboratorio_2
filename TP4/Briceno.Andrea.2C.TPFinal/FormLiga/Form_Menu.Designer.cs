
namespace FormLiga
{
    partial class Form_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.btn_inscripcion = new System.Windows.Forms.Button();
            this.btn_Informes = new System.Windows.Forms.Button();
            this.btn_EditarEntrenadores = new System.Windows.Forms.Button();
            this.pic_pokebola = new System.Windows.Forms.PictureBox();
            this.pic_titulo = new System.Windows.Forms.PictureBox();
            this.pic_Bienvenidos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pokebola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bienvenidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inscripcion
            // 
            this.btn_inscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_inscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_inscripcion.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inscripcion.Location = new System.Drawing.Point(110, 63);
            this.btn_inscripcion.Name = "btn_inscripcion";
            this.btn_inscripcion.Size = new System.Drawing.Size(317, 102);
            this.btn_inscripcion.TabIndex = 0;
            this.btn_inscripcion.Text = "Inscribir Entrenadores";
            this.btn_inscripcion.UseVisualStyleBackColor = false;
            this.btn_inscripcion.Visible = false;
            this.btn_inscripcion.Click += new System.EventHandler(this.btn_inscripcion_Click);
            // 
            // btn_Informes
            // 
            this.btn_Informes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Informes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Informes.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Informes.Location = new System.Drawing.Point(110, 326);
            this.btn_Informes.Name = "btn_Informes";
            this.btn_Informes.Size = new System.Drawing.Size(317, 102);
            this.btn_Informes.TabIndex = 3;
            this.btn_Informes.Text = "Informes";
            this.btn_Informes.UseVisualStyleBackColor = false;
            this.btn_Informes.Visible = false;
            this.btn_Informes.Click += new System.EventHandler(this.btn_Informes_Click);
            // 
            // btn_EditarEntrenadores
            // 
            this.btn_EditarEntrenadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_EditarEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditarEntrenadores.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_EditarEntrenadores.Location = new System.Drawing.Point(110, 187);
            this.btn_EditarEntrenadores.Name = "btn_EditarEntrenadores";
            this.btn_EditarEntrenadores.Size = new System.Drawing.Size(317, 102);
            this.btn_EditarEntrenadores.TabIndex = 5;
            this.btn_EditarEntrenadores.Text = "Editar Entrenadores";
            this.btn_EditarEntrenadores.UseVisualStyleBackColor = false;
            this.btn_EditarEntrenadores.Visible = false;
            this.btn_EditarEntrenadores.Click += new System.EventHandler(this.btn_EditarEntrenadores_Click);
            // 
            // pic_pokebola
            // 
            this.pic_pokebola.Image = ((System.Drawing.Image)(resources.GetObject("pic_pokebola.Image")));
            this.pic_pokebola.Location = new System.Drawing.Point(103, 63);
            this.pic_pokebola.Name = "pic_pokebola";
            this.pic_pokebola.Size = new System.Drawing.Size(327, 295);
            this.pic_pokebola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pokebola.TabIndex = 8;
            this.pic_pokebola.TabStop = false;
            // 
            // pic_titulo
            // 
            this.pic_titulo.Image = ((System.Drawing.Image)(resources.GetObject("pic_titulo.Image")));
            this.pic_titulo.Location = new System.Drawing.Point(25, 8);
            this.pic_titulo.Name = "pic_titulo";
            this.pic_titulo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 120);
            this.pic_titulo.Size = new System.Drawing.Size(483, 49);
            this.pic_titulo.TabIndex = 9;
            this.pic_titulo.TabStop = false;
            // 
            // pic_Bienvenidos
            // 
            this.pic_Bienvenidos.Image = ((System.Drawing.Image)(resources.GetObject("pic_Bienvenidos.Image")));
            this.pic_Bienvenidos.Location = new System.Drawing.Point(34, 337);
            this.pic_Bienvenidos.Name = "pic_Bienvenidos";
            this.pic_Bienvenidos.Padding = new System.Windows.Forms.Padding(120, 0, 0, 0);
            this.pic_Bienvenidos.Size = new System.Drawing.Size(483, 107);
            this.pic_Bienvenidos.TabIndex = 10;
            this.pic_Bienvenidos.TabStop = false;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(539, 456);
            this.Controls.Add(this.pic_Bienvenidos);
            this.Controls.Add(this.pic_titulo);
            this.Controls.Add(this.pic_pokebola);
            this.Controls.Add(this.btn_EditarEntrenadores);
            this.Controls.Add(this.btn_Informes);
            this.Controls.Add(this.btn_inscripcion);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liga de pokemones bebes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pokebola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Bienvenidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inscripcion;
        private System.Windows.Forms.Button btn_Informes;
        private System.Windows.Forms.Button btn_EditarEntrenadores;
        private System.Windows.Forms.PictureBox pic_pokebola;
        private System.Windows.Forms.PictureBox pic_titulo;
        private System.Windows.Forms.PictureBox pic_Bienvenidos;
    }
}

