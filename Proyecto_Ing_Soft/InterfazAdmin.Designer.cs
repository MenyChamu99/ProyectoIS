namespace Proyecto_Ing_Soft
{
    partial class InterfazAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jefeDeDptoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nombre = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.TipoUsuario = new System.Windows.Forms.Label();
            this.cbTipousuario = new System.Windows.Forms.ComboBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.IdCarrera = new System.Windows.Forms.Label();
            this.NombreCarrera = new System.Windows.Forms.Label();
            this.txtIdCarrera = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.IdMateria = new System.Windows.Forms.Label();
            this.NombreM = new System.Windows.Forms.Label();
            this.IdCarreraM = new System.Windows.Forms.Label();
            this.Creditos = new System.Windows.Forms.Label();
            this.Horas = new System.Windows.Forms.Label();
            this.txtIdMateria = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnEliminarCarrera = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnBuscarM = new System.Windows.Forms.Button();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEditarCarrera = new System.Windows.Forms.Button();
            this.btnEditarMateria = new System.Windows.Forms.Button();
            this.lbIdUsuario = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUnidades = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.cbIdCarrera = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jefeDeDptoToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.materiasToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "&Agregar";
            // 
            // jefeDeDptoToolStripMenuItem
            // 
            this.jefeDeDptoToolStripMenuItem.Name = "jefeDeDptoToolStripMenuItem";
            this.jefeDeDptoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jefeDeDptoToolStripMenuItem.Text = "&Usuario";
            this.jefeDeDptoToolStripMenuItem.Click += new System.EventHandler(this.jefeDeDptoToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.docenteToolStripMenuItem.Text = "&Carrera";
            this.docenteToolStripMenuItem.Click += new System.EventHandler(this.docenteToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materiasToolStripMenuItem.Text = "&Materia";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.carreraToolStripMenuItem,
            this.materiaToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.editarToolStripMenuItem.Text = "&Buscar";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.usuarioToolStripMenuItem.Text = "&Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // carreraToolStripMenuItem
            // 
            this.carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            this.carreraToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.carreraToolStripMenuItem.Text = "&Carrera";
            this.carreraToolStripMenuItem.Click += new System.EventHandler(this.carreraToolStripMenuItem_Click);
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.materiaToolStripMenuItem.Text = "&Materia";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(503, 378);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(66, 18);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre:";
            this.Nombre.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(505, 432);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(64, 18);
            this.Usuario.TabIndex = 3;
            this.Usuario.Text = "Usuario:";
            this.Usuario.Visible = false;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(751, 323);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(89, 18);
            this.Contraseña.TabIndex = 4;
            this.Contraseña.Text = "Contraseña:";
            this.Contraseña.Visible = false;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.AutoSize = true;
            this.TipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoUsuario.Location = new System.Drawing.Point(747, 376);
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Size = new System.Drawing.Size(93, 18);
            this.TipoUsuario.TabIndex = 5;
            this.TipoUsuario.Text = "TipoUsuario:";
            this.TipoUsuario.Visible = false;
            // 
            // cbTipousuario
            // 
            this.cbTipousuario.FormattingEnabled = true;
            this.cbTipousuario.Items.AddRange(new object[] {
            "Jefe",
            "Docente"});
            this.cbTipousuario.Location = new System.Drawing.Point(846, 373);
            this.cbTipousuario.Name = "cbTipousuario";
            this.cbTipousuario.Size = new System.Drawing.Size(121, 21);
            this.cbTipousuario.TabIndex = 6;
            this.cbTipousuario.Text = "Selecciona el tipo";
            this.cbTipousuario.Visible = false;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(846, 321);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(121, 20);
            this.txtContra.TabIndex = 7;
            this.txtContra.Visible = false;
            this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(575, 434);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(119, 20);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Visible = false;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(575, 378);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(754, 423);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 32);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(595, 347);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // IdCarrera
            // 
            this.IdCarrera.AutoSize = true;
            this.IdCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCarrera.Location = new System.Drawing.Point(561, 353);
            this.IdCarrera.Name = "IdCarrera";
            this.IdCarrera.Size = new System.Drawing.Size(73, 18);
            this.IdCarrera.TabIndex = 15;
            this.IdCarrera.Text = "IdCarrera:";
            this.IdCarrera.Visible = false;
            // 
            // NombreCarrera
            // 
            this.NombreCarrera.AutoSize = true;
            this.NombreCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCarrera.Location = new System.Drawing.Point(774, 352);
            this.NombreCarrera.Name = "NombreCarrera";
            this.NombreCarrera.Size = new System.Drawing.Size(66, 18);
            this.NombreCarrera.TabIndex = 16;
            this.NombreCarrera.Text = "Nombre:";
            this.NombreCarrera.Visible = false;
            // 
            // txtIdCarrera
            // 
            this.txtIdCarrera.Location = new System.Drawing.Point(639, 353);
            this.txtIdCarrera.Name = "txtIdCarrera";
            this.txtIdCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtIdCarrera.TabIndex = 17;
            this.txtIdCarrera.Visible = false;
            this.txtIdCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCarrera_KeyPress);
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(846, 351);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(100, 20);
            this.txtNombreC.TabIndex = 18;
            this.txtNombreC.Visible = false;
            this.txtNombreC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreC_KeyPress);
            // 
            // IdMateria
            // 
            this.IdMateria.AutoSize = true;
            this.IdMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdMateria.Location = new System.Drawing.Point(497, 326);
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.Size = new System.Drawing.Size(72, 18);
            this.IdMateria.TabIndex = 19;
            this.IdMateria.Text = "IdMateria:";
            this.IdMateria.Visible = false;
            // 
            // NombreM
            // 
            this.NombreM.AutoSize = true;
            this.NombreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreM.Location = new System.Drawing.Point(503, 380);
            this.NombreM.Name = "NombreM";
            this.NombreM.Size = new System.Drawing.Size(66, 18);
            this.NombreM.TabIndex = 20;
            this.NombreM.Text = "Nombre:";
            this.NombreM.Visible = false;
            // 
            // IdCarreraM
            // 
            this.IdCarreraM.AutoSize = true;
            this.IdCarreraM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCarreraM.Location = new System.Drawing.Point(767, 323);
            this.IdCarreraM.Name = "IdCarreraM";
            this.IdCarreraM.Size = new System.Drawing.Size(73, 18);
            this.IdCarreraM.TabIndex = 21;
            this.IdCarreraM.Text = "IdCarrera:";
            this.IdCarreraM.Visible = false;
            // 
            // Creditos
            // 
            this.Creditos.AutoSize = true;
            this.Creditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creditos.Location = new System.Drawing.Point(767, 377);
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(68, 18);
            this.Creditos.TabIndex = 22;
            this.Creditos.Text = "Creditos:";
            this.Creditos.Visible = false;
            // 
            // Horas
            // 
            this.Horas.AutoSize = true;
            this.Horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horas.Location = new System.Drawing.Point(516, 433);
            this.Horas.Name = "Horas";
            this.Horas.Size = new System.Drawing.Size(53, 18);
            this.Horas.TabIndex = 23;
            this.Horas.Text = "Horas:";
            this.Horas.Visible = false;
            // 
            // txtIdMateria
            // 
            this.txtIdMateria.Location = new System.Drawing.Point(575, 325);
            this.txtIdMateria.Name = "txtIdMateria";
            this.txtIdMateria.Size = new System.Drawing.Size(117, 20);
            this.txtIdMateria.TabIndex = 24;
            this.txtIdMateria.Visible = false;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(575, 379);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(117, 20);
            this.txtNombreM.TabIndex = 25;
            this.txtNombreM.Visible = false;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(575, 434);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(117, 20);
            this.txtHoras.TabIndex = 26;
            this.txtHoras.Visible = false;
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoras_KeyPress);
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(846, 374);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(121, 20);
            this.txtCreditos.TabIndex = 28;
            this.txtCreditos.Visible = false;
            this.txtCreditos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditos_KeyPress);
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.Location = new System.Drawing.Point(754, 423);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(102, 32);
            this.btnAgregarM.TabIndex = 29;
            this.btnAgregarM.Text = "Agregar Materia";
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Visible = false;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Location = new System.Drawing.Point(757, 422);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(97, 32);
            this.btnAgregarC.TabIndex = 30;
            this.btnAgregarC.Text = "Agregar Carrera";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Visible = false;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(757, 427);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(96, 23);
            this.btnEliminarMateria.TabIndex = 31;
            this.btnEliminarMateria.Text = "Eliminar Materia";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Visible = false;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnEliminarCarrera
            // 
            this.btnEliminarCarrera.Location = new System.Drawing.Point(754, 427);
            this.btnEliminarCarrera.Name = "btnEliminarCarrera";
            this.btnEliminarCarrera.Size = new System.Drawing.Size(106, 23);
            this.btnEliminarCarrera.TabIndex = 32;
            this.btnEliminarCarrera.Text = "Eliminar Carrera";
            this.btnEliminarCarrera.UseVisualStyleBackColor = true;
            this.btnEliminarCarrera.Visible = false;
            this.btnEliminarCarrera.Click += new System.EventHandler(this.btnEliminarCarrera_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(754, 428);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarUsuario.TabIndex = 33;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Visible = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnBuscarM
            // 
            this.btnBuscarM.Location = new System.Drawing.Point(595, 347);
            this.btnBuscarM.Name = "btnBuscarM";
            this.btnBuscarM.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarM.TabIndex = 34;
            this.btnBuscarM.Text = "Buscar";
            this.btnBuscarM.UseVisualStyleBackColor = true;
            this.btnBuscarM.Visible = false;
            this.btnBuscarM.Click += new System.EventHandler(this.btnBuscarM_Click);
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(639, 380);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarC.TabIndex = 35;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Visible = false;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(865, 428);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(92, 23);
            this.btnEditarUsuario.TabIndex = 36;
            this.btnEditarUsuario.Text = "Editar Usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Visible = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnEditarCarrera
            // 
            this.btnEditarCarrera.Location = new System.Drawing.Point(862, 428);
            this.btnEditarCarrera.Name = "btnEditarCarrera";
            this.btnEditarCarrera.Size = new System.Drawing.Size(99, 23);
            this.btnEditarCarrera.TabIndex = 37;
            this.btnEditarCarrera.Text = "Editar Carrera";
            this.btnEditarCarrera.UseVisualStyleBackColor = true;
            this.btnEditarCarrera.Visible = false;
            this.btnEditarCarrera.Click += new System.EventHandler(this.btnEditarCarrera_Click);
            // 
            // btnEditarMateria
            // 
            this.btnEditarMateria.Location = new System.Drawing.Point(862, 428);
            this.btnEditarMateria.Name = "btnEditarMateria";
            this.btnEditarMateria.Size = new System.Drawing.Size(93, 23);
            this.btnEditarMateria.TabIndex = 38;
            this.btnEditarMateria.Text = "Editar Materia";
            this.btnEditarMateria.UseVisualStyleBackColor = true;
            this.btnEditarMateria.Visible = false;
            this.btnEditarMateria.Click += new System.EventHandler(this.btnEditarMateria_Click);
            // 
            // lbIdUsuario
            // 
            this.lbIdUsuario.AutoSize = true;
            this.lbIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdUsuario.Location = new System.Drawing.Point(497, 326);
            this.lbIdUsuario.Name = "lbIdUsuario";
            this.lbIdUsuario.Size = new System.Drawing.Size(79, 18);
            this.lbIdUsuario.TabIndex = 39;
            this.lbIdUsuario.Text = "Id Usuario:";
            this.lbIdUsuario.Visible = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(573, 325);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(119, 20);
            this.txtIdUsuario.TabIndex = 40;
            this.txtIdUsuario.Visible = false;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            this.txtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUsuario_KeyPress);
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(479, 469);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.Size = new System.Drawing.Size(500, 222);
            this.DgvUsuarios.TabIndex = 41;
            this.DgvUsuarios.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(-3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1373, 55);
            this.label1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(-3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1373, 23);
            this.label2.TabIndex = 43;
            // 
            // lbUnidades
            // 
            this.lbUnidades.AutoSize = true;
            this.lbUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnidades.Location = new System.Drawing.Point(986, 323);
            this.lbUnidades.Name = "lbUnidades";
            this.lbUnidades.Size = new System.Drawing.Size(95, 18);
            this.lbUnidades.TabIndex = 44;
            this.lbUnidades.Text = "N° Unidades:";
            this.lbUnidades.Visible = false;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(1080, 323);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 20);
            this.txtUnidades.TabIndex = 45;
            this.txtUnidades.Visible = false;
            this.txtUnidades.TextChanged += new System.EventHandler(this.txtUnidades_TextChanged);
            this.txtUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidades_KeyPress);
            // 
            // cbIdCarrera
            // 
            this.cbIdCarrera.FormattingEnabled = true;
            this.cbIdCarrera.Location = new System.Drawing.Point(846, 320);
            this.cbIdCarrera.Name = "cbIdCarrera";
            this.cbIdCarrera.Size = new System.Drawing.Size(121, 21);
            this.cbIdCarrera.TabIndex = 46;
            this.cbIdCarrera.Visible = false;
            // 
            // InterfazAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.cbIdCarrera);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.lbUnidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.lbIdUsuario);
            this.Controls.Add(this.btnEditarMateria);
            this.Controls.Add(this.btnEditarCarrera);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnBuscarC);
            this.Controls.Add(this.btnBuscarM);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEliminarCarrera);
            this.Controls.Add(this.btnEliminarMateria);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.btnAgregarM);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.txtIdMateria);
            this.Controls.Add(this.Horas);
            this.Controls.Add(this.Creditos);
            this.Controls.Add(this.IdCarreraM);
            this.Controls.Add(this.NombreM);
            this.Controls.Add(this.IdMateria);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.txtIdCarrera);
            this.Controls.Add(this.NombreCarrera);
            this.Controls.Add(this.IdCarrera);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.cbTipousuario);
            this.Controls.Add(this.TipoUsuario);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "InterfazAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jefeDeDptoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label TipoUsuario;
        private System.Windows.Forms.ComboBox cbTipousuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label IdCarrera;
        private System.Windows.Forms.Label NombreCarrera;
        private System.Windows.Forms.TextBox txtIdCarrera;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label IdMateria;
        private System.Windows.Forms.Label NombreM;
        private System.Windows.Forms.Label IdCarreraM;
        private System.Windows.Forms.Label Creditos;
        private System.Windows.Forms.Label Horas;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnEliminarCarrera;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnBuscarM;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEditarCarrera;
        private System.Windows.Forms.Button btnEditarMateria;
        private System.Windows.Forms.Label lbIdUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUnidades;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.ComboBox cbIdCarrera;
    }
}