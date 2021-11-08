
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
            this.list_Pokemones = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_pokebolas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(31, 97);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(207, 23);
            this.txt_dni.TabIndex = 0;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(31, 152);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(207, 23);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(31, 209);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(207, 23);
            this.txt_apellido.TabIndex = 2;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(31, 264);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(207, 23);
            this.txt_edad.TabIndex = 3;
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(38, 76);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_Dni.TabIndex = 4;
            this.lbl_Dni.Text = "DNI";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(38, 131);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(38, 184);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_Apellido.TabIndex = 6;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(39, 242);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_Edad.TabIndex = 7;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_CantidadDePokebolas
            // 
            this.lbl_CantidadDePokebolas.AutoSize = true;
            this.lbl_CantidadDePokebolas.Location = new System.Drawing.Point(570, 123);
            this.lbl_CantidadDePokebolas.Name = "lbl_CantidadDePokebolas";
            this.lbl_CantidadDePokebolas.Size = new System.Drawing.Size(121, 15);
            this.lbl_CantidadDePokebolas.TabIndex = 8;
            this.lbl_CantidadDePokebolas.Text = "Cantida de Pokebolas";
            // 
            // lbl_Pokemones
            // 
            this.lbl_Pokemones.AutoSize = true;
            this.lbl_Pokemones.Location = new System.Drawing.Point(328, 160);
            this.lbl_Pokemones.Name = "lbl_Pokemones";
            this.lbl_Pokemones.Size = new System.Drawing.Size(69, 15);
            this.lbl_Pokemones.TabIndex = 10;
            this.lbl_Pokemones.Text = "Pokemones";
            // 
            // checkB_EsCampeon
            // 
            this.checkB_EsCampeon.AutoSize = true;
            this.checkB_EsCampeon.Location = new System.Drawing.Point(662, 79);
            this.checkB_EsCampeon.Name = "checkB_EsCampeon";
            this.checkB_EsCampeon.Size = new System.Drawing.Size(110, 19);
            this.checkB_EsCampeon.TabIndex = 11;
            this.checkB_EsCampeon.Text = "¿Eres campeón?";
            this.checkB_EsCampeon.UseVisualStyleBackColor = true;
            // 
            // numUD_pokebolas
            // 
            this.numUD_pokebolas.Location = new System.Drawing.Point(725, 121);
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
            this.numUD_pokebolas.Size = new System.Drawing.Size(46, 23);
            this.numUD_pokebolas.TabIndex = 12;
            this.numUD_pokebolas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmb_pokemon
            // 
            this.cmb_pokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pokemon.FormattingEnabled = true;
            this.cmb_pokemon.Location = new System.Drawing.Point(417, 163);
            this.cmb_pokemon.Name = "cmb_pokemon";
            this.cmb_pokemon.Size = new System.Drawing.Size(147, 23);
            this.cmb_pokemon.TabIndex = 13;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(317, 346);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(180, 25);
            this.btn_Guardar.TabIndex = 16;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // cmb_Islas
            // 
            this.cmb_Islas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Islas.FormattingEnabled = true;
            this.cmb_Islas.Location = new System.Drawing.Point(417, 120);
            this.cmb_Islas.Name = "cmb_Islas";
            this.cmb_Islas.Size = new System.Drawing.Size(121, 23);
            this.cmb_Islas.TabIndex = 17;
            // 
            // lbl_isla
            // 
            this.lbl_isla.AutoSize = true;
            this.lbl_isla.Location = new System.Drawing.Point(328, 129);
            this.lbl_isla.Name = "lbl_isla";
            this.lbl_isla.Size = new System.Drawing.Size(24, 15);
            this.lbl_isla.TabIndex = 18;
            this.lbl_isla.Text = "Isla";
            // 
            // cmb_TipoEdicion
            // 
            this.cmb_TipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoEdicion.FormattingEnabled = true;
            this.cmb_TipoEdicion.Items.AddRange(new object[] {
            "Modificar ",
            "Eliminar"});
            this.cmb_TipoEdicion.Location = new System.Drawing.Point(174, 33);
            this.cmb_TipoEdicion.Name = "cmb_TipoEdicion";
            this.cmb_TipoEdicion.Size = new System.Drawing.Size(182, 23);
            this.cmb_TipoEdicion.TabIndex = 21;
            this.cmb_TipoEdicion.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoEdicion_SelectedIndexChanged);
            // 
            // cmb_Entrenadores
            // 
            this.cmb_Entrenadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Entrenadores.FormattingEnabled = true;
            this.cmb_Entrenadores.Location = new System.Drawing.Point(388, 77);
            this.cmb_Entrenadores.Name = "cmb_Entrenadores";
            this.cmb_Entrenadores.Size = new System.Drawing.Size(239, 23);
            this.cmb_Entrenadores.TabIndex = 22;
            this.cmb_Entrenadores.SelectedIndexChanged += new System.EventHandler(this.cmb_Entrenadores_SelectedIndexChanged);
            // 
            // lbl_tipoEdicion
            // 
            this.lbl_tipoEdicion.AutoSize = true;
            this.lbl_tipoEdicion.Location = new System.Drawing.Point(31, 36);
            this.lbl_tipoEdicion.Name = "lbl_tipoEdicion";
            this.lbl_tipoEdicion.Size = new System.Drawing.Size(137, 15);
            this.lbl_tipoEdicion.TabIndex = 23;
            this.lbl_tipoEdicion.Text = "Tipo de Edicion a realizar";
            // 
            // lbl_Entrenador
            // 
            this.lbl_Entrenador.AutoSize = true;
            this.lbl_Entrenador.Location = new System.Drawing.Point(317, 80);
            this.lbl_Entrenador.Name = "lbl_Entrenador";
            this.lbl_Entrenador.Size = new System.Drawing.Size(65, 15);
            this.lbl_Entrenador.TabIndex = 24;
            this.lbl_Entrenador.Text = "Entrenador";
            // 
            // list_Pokemones
            // 
            this.list_Pokemones.FormattingEnabled = true;
            this.list_Pokemones.ItemHeight = 15;
            this.list_Pokemones.Location = new System.Drawing.Point(274, 204);
            this.list_Pokemones.Name = "list_Pokemones";
            this.list_Pokemones.Size = new System.Drawing.Size(530, 109);
            this.list_Pokemones.TabIndex = 25;
            this.list_Pokemones.SelectedIndexChanged += new System.EventHandler(this.list_Pokemones_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(597, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 25);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(689, 161);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(68, 25);
            this.btnQuitar.TabIndex = 27;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(317, 346);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(180, 25);
            this.btn_modificar.TabIndex = 28;
            this.btn_modificar.Text = "Guardar Modificacion";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(317, 346);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(180, 25);
            this.btn_Eliminar.TabIndex = 29;
            this.btn_Eliminar.Text = "Eliminar Entrenador de la liga";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Form_ManejoEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 383);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.list_Pokemones);
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
        private System.Windows.Forms.ListBox list_Pokemones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}