
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
            this.btn_inscripcion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Informes = new System.Windows.Forms.Button();
            this.btn_EditarEntrenadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_inscripcion
            // 
            this.btn_inscripcion.Location = new System.Drawing.Point(152, 57);
            this.btn_inscripcion.Name = "btn_inscripcion";
            this.btn_inscripcion.Size = new System.Drawing.Size(179, 102);
            this.btn_inscripcion.TabIndex = 0;
            this.btn_inscripcion.Text = "Inscribir Entrenadores";
            this.btn_inscripcion.UseVisualStyleBackColor = true;
            this.btn_inscripcion.Click += new System.EventHandler(this.btn_inscripcion_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(389, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 102);
            this.button3.TabIndex = 2;
            this.button3.Text = "Agregar pokemones";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Informes
            // 
            this.btn_Informes.Location = new System.Drawing.Point(389, 204);
            this.btn_Informes.Name = "btn_Informes";
            this.btn_Informes.Size = new System.Drawing.Size(179, 102);
            this.btn_Informes.TabIndex = 3;
            this.btn_Informes.Text = "Informes";
            this.btn_Informes.UseVisualStyleBackColor = true;
            this.btn_Informes.Click += new System.EventHandler(this.btn_Informes_Click);
            // 
            // btn_EditarEntrenadores
            // 
            this.btn_EditarEntrenadores.Location = new System.Drawing.Point(152, 204);
            this.btn_EditarEntrenadores.Name = "btn_EditarEntrenadores";
            this.btn_EditarEntrenadores.Size = new System.Drawing.Size(179, 102);
            this.btn_EditarEntrenadores.TabIndex = 5;
            this.btn_EditarEntrenadores.Text = "Editar Entrenadores";
            this.btn_EditarEntrenadores.UseVisualStyleBackColor = true;
            this.btn_EditarEntrenadores.Click += new System.EventHandler(this.btn_EditarEntrenadores_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 382);
            this.Controls.Add(this.btn_EditarEntrenadores);
            this.Controls.Add(this.btn_Informes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_inscripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baby Pokemon League";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inscripcion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Informes;
        private System.Windows.Forms.Button btn_EditarEntrenadores;
    }
}

