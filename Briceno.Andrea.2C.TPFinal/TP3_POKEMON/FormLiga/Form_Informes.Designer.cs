
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Informes));
            this.Dtg_Entrenadores = new System.Windows.Forms.DataGridView();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.lbl_seleccion = new System.Windows.Forms.Label();
            this.cmb_filtro2 = new System.Windows.Forms.ComboBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.checkB_EsCampeon = new System.Windows.Forms.CheckBox();
            this.lbl_EstadisticaTitulo = new System.Windows.Forms.Label();
            this.lbl_estadistica1 = new System.Windows.Forms.Label();
            this.lbl_estadistica1_1 = new System.Windows.Forms.Label();
            this.cmb_Pokemon = new System.Windows.Forms.ComboBox();
            this.lbl_estadisticas2 = new System.Windows.Forms.Label();
            this.cmb_isla = new System.Windows.Forms.ComboBox();
            this.lbl_isla2 = new System.Windows.Forms.Label();
            this.lbl_isla = new System.Windows.Forms.Label();
            this.pic_pichu = new System.Windows.Forms.PictureBox();
            this.pic_Cargando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Entrenadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pichu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cargando)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtg_Entrenadores
            // 
            this.Dtg_Entrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Entrenadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dtg_Entrenadores.Location = new System.Drawing.Point(139, 454);
            this.Dtg_Entrenadores.Name = "Dtg_Entrenadores";
            this.Dtg_Entrenadores.RowTemplate.Height = 25;
            this.Dtg_Entrenadores.Size = new System.Drawing.Size(506, 151);
            this.Dtg_Entrenadores.TabIndex = 0;
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "Por isla",
            "Por tipo de pokemon",
            "Por entrenadores campeones"});
            this.cmb_filtro.Location = new System.Drawing.Point(139, 417);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(206, 23);
            this.cmb_filtro.TabIndex = 2;
            this.cmb_filtro.SelectedIndexChanged += new System.EventHandler(this.cmb_filtro_SelectedIndexChanged);
            // 
            // lbl_seleccion
            // 
            this.lbl_seleccion.AutoSize = true;
            this.lbl_seleccion.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_seleccion.Location = new System.Drawing.Point(104, 391);
            this.lbl_seleccion.Name = "lbl_seleccion";
            this.lbl_seleccion.Size = new System.Drawing.Size(385, 23);
            this.lbl_seleccion.TabIndex = 5;
            this.lbl_seleccion.Text = "SELECCIONE LOS TIPOS DE FILTRO A USAR";
            // 
            // cmb_filtro2
            // 
            this.cmb_filtro2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmb_filtro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro2.FormattingEnabled = true;
            this.cmb_filtro2.Location = new System.Drawing.Point(362, 417);
            this.cmb_filtro2.Name = "cmb_filtro2";
            this.cmb_filtro2.Size = new System.Drawing.Size(186, 23);
            this.cmb_filtro2.TabIndex = 6;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_mostrar.Location = new System.Drawing.Point(570, 415);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 7;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exportar.Location = new System.Drawing.Point(529, 626);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(75, 23);
            this.btn_Exportar.TabIndex = 8;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = false;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // checkB_EsCampeon
            // 
            this.checkB_EsCampeon.AutoSize = true;
            this.checkB_EsCampeon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkB_EsCampeon.Location = new System.Drawing.Point(362, 419);
            this.checkB_EsCampeon.Name = "checkB_EsCampeon";
            this.checkB_EsCampeon.Size = new System.Drawing.Size(90, 19);
            this.checkB_EsCampeon.TabIndex = 12;
            this.checkB_EsCampeon.Text = "Es campeón";
            this.checkB_EsCampeon.UseVisualStyleBackColor = false;
            // 
            // lbl_EstadisticaTitulo
            // 
            this.lbl_EstadisticaTitulo.AutoSize = true;
            this.lbl_EstadisticaTitulo.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EstadisticaTitulo.Location = new System.Drawing.Point(104, 22);
            this.lbl_EstadisticaTitulo.Name = "lbl_EstadisticaTitulo";
            this.lbl_EstadisticaTitulo.Size = new System.Drawing.Size(241, 23);
            this.lbl_EstadisticaTitulo.TabIndex = 13;
            this.lbl_EstadisticaTitulo.Text = "ESTADISTICAS DE LA LIGA";
            // 
            // lbl_estadistica1
            // 
            this.lbl_estadistica1.AutoSize = true;
            this.lbl_estadistica1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadistica1.Location = new System.Drawing.Point(49, 73);
            this.lbl_estadistica1.Name = "lbl_estadistica1";
            this.lbl_estadistica1.Size = new System.Drawing.Size(157, 20);
            this.lbl_estadistica1.TabIndex = 14;
            this.lbl_estadistica1.Text = "Porcentaje del pokemon";
            // 
            // lbl_estadistica1_1
            // 
            this.lbl_estadistica1_1.AutoSize = true;
            this.lbl_estadistica1_1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadistica1_1.Location = new System.Drawing.Point(317, 73);
            this.lbl_estadistica1_1.Name = "lbl_estadistica1_1";
            this.lbl_estadistica1_1.Size = new System.Drawing.Size(73, 20);
            this.lbl_estadistica1_1.TabIndex = 15;
            this.lbl_estadistica1_1.Text = "Porcentaje";
            // 
            // cmb_Pokemon
            // 
            this.cmb_Pokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmb_Pokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Pokemon.FormattingEnabled = true;
            this.cmb_Pokemon.Location = new System.Drawing.Point(215, 71);
            this.cmb_Pokemon.Name = "cmb_Pokemon";
            this.cmb_Pokemon.Size = new System.Drawing.Size(93, 23);
            this.cmb_Pokemon.TabIndex = 16;
            this.cmb_Pokemon.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_estadisticas2
            // 
            this.lbl_estadisticas2.AutoSize = true;
            this.lbl_estadisticas2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadisticas2.Location = new System.Drawing.Point(58, 140);
            this.lbl_estadisticas2.Name = "lbl_estadisticas2";
            this.lbl_estadisticas2.Size = new System.Drawing.Size(80, 20);
            this.lbl_estadisticas2.TabIndex = 17;
            this.lbl_estadisticas2.Text = "Estadisticas";
            // 
            // cmb_isla
            // 
            this.cmb_isla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmb_isla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_isla.FormattingEnabled = true;
            this.cmb_isla.Location = new System.Drawing.Point(215, 100);
            this.cmb_isla.Name = "cmb_isla";
            this.cmb_isla.Size = new System.Drawing.Size(93, 23);
            this.cmb_isla.TabIndex = 22;
            this.cmb_isla.SelectedIndexChanged += new System.EventHandler(this.cmb_isla_SelectedIndexChanged);
            // 
            // lbl_isla2
            // 
            this.lbl_isla2.AutoSize = true;
            this.lbl_isla2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_isla2.Location = new System.Drawing.Point(316, 102);
            this.lbl_isla2.Name = "lbl_isla2";
            this.lbl_isla2.Size = new System.Drawing.Size(73, 20);
            this.lbl_isla2.TabIndex = 21;
            this.lbl_isla2.Text = "Porcentaje";
            // 
            // lbl_isla
            // 
            this.lbl_isla.AutoSize = true;
            this.lbl_isla.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_isla.Location = new System.Drawing.Point(49, 102);
            this.lbl_isla.Name = "lbl_isla";
            this.lbl_isla.Size = new System.Drawing.Size(164, 20);
            this.lbl_isla.TabIndex = 20;
            this.lbl_isla.Text = "Porcentaje del entrenador";
            // 
            // pic_pichu
            // 
            this.pic_pichu.Image = ((System.Drawing.Image)(resources.GetObject("pic_pichu.Image")));
            this.pic_pichu.Location = new System.Drawing.Point(40, 60);
            this.pic_pichu.Name = "pic_pichu";
            this.pic_pichu.Padding = new System.Windows.Forms.Padding(180, 100, 0, 0);
            this.pic_pichu.Size = new System.Drawing.Size(690, 657);
            this.pic_pichu.TabIndex = 23;
            this.pic_pichu.TabStop = false;
            // 
            // pic_Cargando
            // 
            this.pic_Cargando.Image = ((System.Drawing.Image)(resources.GetObject("pic_Cargando.Image")));
            this.pic_Cargando.Location = new System.Drawing.Point(215, 501);
            this.pic_Cargando.Name = "pic_Cargando";
            this.pic_Cargando.Size = new System.Drawing.Size(305, 56);
            this.pic_Cargando.TabIndex = 24;
            this.pic_Cargando.TabStop = false;
            // 
            // Form_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(756, 681);
            this.Controls.Add(this.pic_Cargando);
            this.Controls.Add(this.pic_pichu);
            this.Controls.Add(this.cmb_isla);
            this.Controls.Add(this.lbl_isla2);
            this.Controls.Add(this.lbl_isla);
            this.Controls.Add(this.lbl_estadisticas2);
            this.Controls.Add(this.cmb_Pokemon);
            this.Controls.Add(this.lbl_estadistica1_1);
            this.Controls.Add(this.lbl_estadistica1);
            this.Controls.Add(this.lbl_EstadisticaTitulo);
            this.Controls.Add(this.checkB_EsCampeon);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Informes_FormClosing);
            this.Load += new System.EventHandler(this.Form_Informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Entrenadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pichu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cargando)).EndInit();
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
        private System.Windows.Forms.CheckBox checkB_EsCampeon;
        private System.Windows.Forms.Label lbl_EstadisticaTitulo;
        private System.Windows.Forms.Label lbl_estadistica1;
        private System.Windows.Forms.Label lbl_estadistica1_1;
        private System.Windows.Forms.ComboBox cmb_Pokemon;
        private System.Windows.Forms.Label lbl_estadisticas2;
        private System.Windows.Forms.ComboBox cmb_isla;
        private System.Windows.Forms.Label lbl_isla2;
        private System.Windows.Forms.Label lbl_isla;
        private System.Windows.Forms.PictureBox pic_pichu;
        private System.Windows.Forms.PictureBox pic_Cargando;
    }
}