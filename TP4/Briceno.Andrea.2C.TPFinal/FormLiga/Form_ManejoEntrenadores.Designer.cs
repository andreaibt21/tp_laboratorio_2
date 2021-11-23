
namespace FormLiga
{
    partial class Form_ManejoEntrenadores
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
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_CantidadDePokebolas = new System.Windows.Forms.Label();
            this.lbl_Pokemones = new System.Windows.Forms.Label();
            this.checkB_EsCampeon = new System.Windows.Forms.CheckBox();
            this.numUD_pokebolas = new System.Windows.Forms.NumericUpDown();
            this.cmb_pokemon = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cmb_Islas = new System.Windows.Forms.ComboBox();
            this.lbl_isla = new System.Windows.Forms.Label();
            this.cmb_TipoEdicion = new System.Windows.Forms.ComboBox();
            this.cmb_Entrenadores = new System.Windows.Forms.ComboBox();
            this.lbl_tipoEdicion = new System.Windows.Forms.Label();
            this.lbl_Entrenador = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dtg_pokemones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_pokebolas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pokemones)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_dni.Location = new System.Drawing.Point(28, 109);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(207, 23);
            this.txt_dni.TabIndex = 0;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_nombre.Location = new System.Drawing.Point(28, 164);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(207, 23);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_apellido.Location = new System.Drawing.Point(28, 221);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(207, 23);
            this.txt_apellido.TabIndex = 2;
            // 
            // txt_edad
            // 
            this.txt_edad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_edad.Location = new System.Drawing.Point(28, 276);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(207, 23);
            this.txt_edad.TabIndex = 3;
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dni.Location = new System.Drawing.Point(28, 83);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(43, 23);
            this.lbl_Dni.TabIndex = 4;
            this.lbl_Dni.Text = "DNI";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(28, 138);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(88, 23);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Apellido.Location = new System.Drawing.Point(28, 195);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(101, 23);
            this.lbl_Apellido.TabIndex = 6;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Edad.Location = new System.Drawing.Point(28, 250);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(61, 23);
            this.lbl_Edad.TabIndex = 7;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_CantidadDePokebolas
            // 
            this.lbl_CantidadDePokebolas.AutoSize = true;
            this.lbl_CantidadDePokebolas.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadDePokebolas.Location = new System.Drawing.Point(360, 114);
            this.lbl_CantidadDePokebolas.Name = "lbl_CantidadDePokebolas";
            this.lbl_CantidadDePokebolas.Size = new System.Drawing.Size(249, 23);
            this.lbl_CantidadDePokebolas.TabIndex = 8;
            this.lbl_CantidadDePokebolas.Text = "Cantidad de Pokebolas";
            // 
            // lbl_Pokemones
            // 
            this.lbl_Pokemones.AutoSize = true;
            this.lbl_Pokemones.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pokemones.Location = new System.Drawing.Point(485, 155);
            this.lbl_Pokemones.Name = "lbl_Pokemones";
            this.lbl_Pokemones.Size = new System.Drawing.Size(124, 23);
            this.lbl_Pokemones.TabIndex = 10;
            this.lbl_Pokemones.Text = "Pokemones";
            // 
            // checkB_EsCampeon
            // 
            this.checkB_EsCampeon.AutoSize = true;
            this.checkB_EsCampeon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkB_EsCampeon.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkB_EsCampeon.Location = new System.Drawing.Point(28, 324);
            this.checkB_EsCampeon.Name = "checkB_EsCampeon";
            this.checkB_EsCampeon.Size = new System.Drawing.Size(184, 27);
            this.checkB_EsCampeon.TabIndex = 11;
            this.checkB_EsCampeon.Text = "¿Eres campeón?";
            this.checkB_EsCampeon.UseVisualStyleBackColor = false;
            // 
            // numUD_pokebolas
            // 
            this.numUD_pokebolas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.numUD_pokebolas.Location = new System.Drawing.Point(643, 114);
            this.numUD_pokebolas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUD_pokebolas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_pokebolas.Name = "numUD_pokebolas";
            this.numUD_pokebolas.Size = new System.Drawing.Size(89, 23);
            this.numUD_pokebolas.TabIndex = 12;
            this.numUD_pokebolas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmb_pokemon
            // 
            this.cmb_pokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmb_pokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pokemon.FormattingEnabled = true;
            this.cmb_pokemon.Location = new System.Drawing.Point(643, 159);
            this.cmb_pokemon.Name = "cmb_pokemon";
            this.cmb_pokemon.Size = new System.Drawing.Size(147, 23);
            this.cmb_pokemon.TabIndex = 13;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.Location = new System.Drawing.Point(343, 512);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(212, 55);
            this.btn_Guardar.TabIndex = 16;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // cmb_Islas
            // 
            this.cmb_Islas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmb_Islas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Islas.FormattingEnabled = true;
            this.cmb_Islas.Location = new System.Drawing.Point(28, 399);
            this.cmb_Islas.Name = "cmb_Islas";
            this.cmb_Islas.Size = new System.Drawing.Size(207, 23);
            this.cmb_Islas.TabIndex = 17;
            // 
            // lbl_isla
            // 
            this.lbl_isla.AutoSize = true;
            this.lbl_isla.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_isla.Location = new System.Drawing.Point(35, 371);
            this.lbl_isla.Name = "lbl_isla";
            this.lbl_isla.Size = new System.Drawing.Size(49, 23);
            this.lbl_isla.TabIndex = 18;
            this.lbl_isla.Text = "Isla";
            // 
            // cmb_TipoEdicion
            // 
            this.cmb_TipoEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmb_TipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoEdicion.FormattingEnabled = true;
            this.cmb_TipoEdicion.Items.AddRange(new object[] {
            "Modificar ",
            "Eliminar"});
            this.cmb_TipoEdicion.Location = new System.Drawing.Point(31, 33);
            this.cmb_TipoEdicion.Name = "cmb_TipoEdicion";
            this.cmb_TipoEdicion.Size = new System.Drawing.Size(182, 23);
            this.cmb_TipoEdicion.TabIndex = 21;
            this.cmb_TipoEdicion.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoEdicion_SelectedIndexChanged);
            // 
            // cmb_Entrenadores
            // 
            this.cmb_Entrenadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmb_Entrenadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Entrenadores.FormattingEnabled = true;
            this.cmb_Entrenadores.Location = new System.Drawing.Point(414, 59);
            this.cmb_Entrenadores.Name = "cmb_Entrenadores";
            this.cmb_Entrenadores.Size = new System.Drawing.Size(239, 23);
            this.cmb_Entrenadores.TabIndex = 22;
            this.cmb_Entrenadores.SelectedIndexChanged += new System.EventHandler(this.cmb_Entrenadores_SelectedIndexChanged);
            // 
            // lbl_tipoEdicion
            // 
            this.lbl_tipoEdicion.AutoSize = true;
            this.lbl_tipoEdicion.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tipoEdicion.Location = new System.Drawing.Point(22, 7);
            this.lbl_tipoEdicion.Name = "lbl_tipoEdicion";
            this.lbl_tipoEdicion.Size = new System.Drawing.Size(276, 23);
            this.lbl_tipoEdicion.TabIndex = 23;
            this.lbl_tipoEdicion.Text = "Tipo de Edicion a realizar";
            // 
            // lbl_Entrenador
            // 
            this.lbl_Entrenador.AutoSize = true;
            this.lbl_Entrenador.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Entrenador.Location = new System.Drawing.Point(462, 29);
            this.lbl_Entrenador.Name = "lbl_Entrenador";
            this.lbl_Entrenador.Size = new System.Drawing.Size(135, 23);
            this.lbl_Entrenador.TabIndex = 24;
            this.lbl_Entrenador.Text = "Entrenador";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(533, 207);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 25);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.Location = new System.Drawing.Point(670, 207);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(100, 25);
            this.btnQuitar.TabIndex = 27;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modificar.Location = new System.Drawing.Point(343, 512);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(212, 55);
            this.btn_modificar.TabIndex = 28;
            this.btn_modificar.Text = "Guardar Modificacion";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.Location = new System.Drawing.Point(343, 512);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(212, 55);
            this.btn_Eliminar.TabIndex = 29;
            this.btn_Eliminar.Text = "Eliminar Entrenador de la liga";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // dtg_pokemones
            // 
            this.dtg_pokemones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_pokemones.Location = new System.Drawing.Point(279, 276);
            this.dtg_pokemones.Name = "dtg_pokemones";
            this.dtg_pokemones.RowTemplate.Height = 25;
            this.dtg_pokemones.Size = new System.Drawing.Size(525, 178);
            this.dtg_pokemones.TabIndex = 30;
            // 
            // Form_ManejoEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(816, 614);
            this.Controls.Add(this.dtg_pokemones);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbl_Entrenador);
            this.Controls.Add(this.lbl_tipoEdicion);
            this.Controls.Add(this.cmb_Entrenadores);
            this.Controls.Add(this.cmb_TipoEdicion);
            this.Controls.Add(this.lbl_isla);
            this.Controls.Add(this.cmb_Islas);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.cmb_pokemon);
            this.Controls.Add(this.numUD_pokebolas);
            this.Controls.Add(this.checkB_EsCampeon);
            this.Controls.Add(this.lbl_Pokemones);
            this.Controls.Add(this.lbl_CantidadDePokebolas);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_dni);
            this.Name = "Form_ManejoEntrenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_ManejoEntrenadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_pokebolas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pokemones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label lbl_CantidadDePokebolas;
        private System.Windows.Forms.Label lbl_Pokemones;
        private System.Windows.Forms.CheckBox checkB_EsCampeon;
        private System.Windows.Forms.NumericUpDown numUD_pokebolas;
        private System.Windows.Forms.ComboBox cmb_pokemon;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ComboBox cmb_Islas;
        private System.Windows.Forms.Label lbl_isla;
        private System.Windows.Forms.ComboBox cmb_TipoEdicion;
        private System.Windows.Forms.ComboBox cmb_Entrenadores;
        private System.Windows.Forms.Label lbl_tipoEdicion;
        private System.Windows.Forms.Label lbl_Entrenador;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dtg_pokemones;
    }
}