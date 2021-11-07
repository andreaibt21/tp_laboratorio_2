
namespace FormLiga
{
    partial class Form_AgregarPokemon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AgregarPokemon));
            this.cmb_Entrenadores = new System.Windows.Forms.ComboBox();
            this.cmb_Pokemones = new System.Windows.Forms.ComboBox();
            this.img_Pokemones = new System.Windows.Forms.ImageList(this.components);
            this.pcBox_Pokemones = new System.Windows.Forms.PictureBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_CantidadDePokebolas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox_Pokemones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Entrenadores
            // 
            this.cmb_Entrenadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Entrenadores.FormattingEnabled = true;
            this.cmb_Entrenadores.Location = new System.Drawing.Point(121, 45);
            this.cmb_Entrenadores.Name = "cmb_Entrenadores";
            this.cmb_Entrenadores.Size = new System.Drawing.Size(214, 23);
            this.cmb_Entrenadores.TabIndex = 0;
            this.cmb_Entrenadores.SelectedIndexChanged += new System.EventHandler(this.cmb_Entrenadores_SelectedIndexChanged);
            // 
            // cmb_Pokemones
            // 
            this.cmb_Pokemones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Pokemones.FormattingEnabled = true;
            this.cmb_Pokemones.Location = new System.Drawing.Point(211, 117);
            this.cmb_Pokemones.Name = "cmb_Pokemones";
            this.cmb_Pokemones.Size = new System.Drawing.Size(124, 23);
            this.cmb_Pokemones.TabIndex = 1;
            // 
            // img_Pokemones
            // 
            this.img_Pokemones.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.img_Pokemones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Pokemones.ImageStream")));
            this.img_Pokemones.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Pokemones.Images.SetKeyName(0, "172.png");
            this.img_Pokemones.Images.SetKeyName(1, "173.png");
            this.img_Pokemones.Images.SetKeyName(2, "174.png");
            this.img_Pokemones.Images.SetKeyName(3, "175.png");
            this.img_Pokemones.Images.SetKeyName(4, "236.png");
            this.img_Pokemones.Images.SetKeyName(5, "238.png");
            this.img_Pokemones.Images.SetKeyName(6, "239.png");
            this.img_Pokemones.Images.SetKeyName(7, "240.png");
            this.img_Pokemones.Images.SetKeyName(8, "298.png");
            this.img_Pokemones.Images.SetKeyName(9, "360.png");
            this.img_Pokemones.Images.SetKeyName(10, "406.png");
            this.img_Pokemones.Images.SetKeyName(11, "433.png");
            this.img_Pokemones.Images.SetKeyName(12, "438.png");
            this.img_Pokemones.Images.SetKeyName(13, "439.png");
            this.img_Pokemones.Images.SetKeyName(14, "440.png");
            this.img_Pokemones.Images.SetKeyName(15, "446.png");
            this.img_Pokemones.Images.SetKeyName(16, "447.png");
            this.img_Pokemones.Images.SetKeyName(17, "458.png");
            // 
            // pcBox_Pokemones
            // 
            this.pcBox_Pokemones.Location = new System.Drawing.Point(137, 102);
            this.pcBox_Pokemones.Name = "pcBox_Pokemones";
            this.pcBox_Pokemones.Size = new System.Drawing.Size(45, 50);
            this.pcBox_Pokemones.TabIndex = 2;
            this.pcBox_Pokemones.TabStop = false;
            this.pcBox_Pokemones.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(162, 179);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(129, 30);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_CantidadDePokebolas
            // 
            this.lbl_CantidadDePokebolas.AutoSize = true;
            this.lbl_CantidadDePokebolas.Location = new System.Drawing.Point(137, 81);
            this.lbl_CantidadDePokebolas.Name = "lbl_CantidadDePokebolas";
            this.lbl_CantidadDePokebolas.Size = new System.Drawing.Size(0, 15);
            this.lbl_CantidadDePokebolas.TabIndex = 4;
            // 
            // Form_AgregarPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 221);
            this.Controls.Add(this.lbl_CantidadDePokebolas);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.pcBox_Pokemones);
            this.Controls.Add(this.cmb_Pokemones);
            this.Controls.Add(this.cmb_Entrenadores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AgregarPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú  de Agregar Pokemones";
            this.Load += new System.EventHandler(this.Form_AgregarPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBox_Pokemones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Entrenadores;
        private System.Windows.Forms.ComboBox cmb_Pokemones;
        private System.Windows.Forms.ImageList img_Pokemones;
        private System.Windows.Forms.PictureBox pcBox_Pokemones;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_CantidadDePokebolas;
    }
}