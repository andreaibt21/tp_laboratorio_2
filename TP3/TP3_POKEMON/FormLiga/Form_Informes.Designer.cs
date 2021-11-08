
namespace FormLiga
{
    partial class Form_Informes
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
            this.Dtg_Entrenadores = new System.Windows.Forms.DataGridView();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.lbl_seleccion = new System.Windows.Forms.Label();
            this.cmb_filtro2 = new System.Windows.Forms.ComboBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_Exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Entrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtg_Entrenadores
            // 
            this.Dtg_Entrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Entrenadores.Location = new System.Drawing.Point(31, 167);
            this.Dtg_Entrenadores.Name = "Dtg_Entrenadores";
            this.Dtg_Entrenadores.RowTemplate.Height = 25;
            this.Dtg_Entrenadores.Size = new System.Drawing.Size(506, 119);
            this.Dtg_Entrenadores.TabIndex = 0;
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "Por isla",
            "Por entrenadores con mas pokemones",
            "Por tipo de pokemon"});
            this.cmb_filtro.Location = new System.Drawing.Point(31, 46);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(262, 23);
            this.cmb_filtro.TabIndex = 2;
            this.cmb_filtro.SelectedIndexChanged += new System.EventHandler(this.cmb_filtro_SelectedIndexChanged);
            // 
            // lbl_seleccion
            // 
            this.lbl_seleccion.AutoSize = true;
            this.lbl_seleccion.Location = new System.Drawing.Point(31, 19);
            this.lbl_seleccion.Name = "lbl_seleccion";
            this.lbl_seleccion.Size = new System.Drawing.Size(188, 15);
            this.lbl_seleccion.TabIndex = 5;
            this.lbl_seleccion.Text = "Seleccione los tipos de filtro a usar";
            // 
            // cmb_filtro2
            // 
            this.cmb_filtro2.FormattingEnabled = true;
            this.cmb_filtro2.Location = new System.Drawing.Point(310, 46);
            this.cmb_filtro2.Name = "cmb_filtro2";
            this.cmb_filtro2.Size = new System.Drawing.Size(186, 23);
            this.cmb_filtro2.TabIndex = 6;
            this.cmb_filtro2.SelectedIndexChanged += new System.EventHandler(this.cmb_filtro2_SelectedIndexChanged);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(421, 112);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 7;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Location = new System.Drawing.Point(421, 324);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(75, 23);
            this.btn_Exportar.TabIndex = 8;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // Form_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 385);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.cmb_filtro2);
            this.Controls.Add(this.lbl_seleccion);
            this.Controls.Add(this.cmb_filtro);
            this.Controls.Add(this.Dtg_Entrenadores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Informes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de informes";
            this.Load += new System.EventHandler(this.Form_Informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Entrenadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtg_Entrenadores;
        private System.Windows.Forms.ComboBox cmb_filtro;
        private System.Windows.Forms.Label lbl_seleccion;
        private System.Windows.Forms.ComboBox cmb_filtro2;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_Exportar;
    }
}