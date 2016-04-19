namespace prgArticulos
{
    partial class frmUsuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.Label();
            this.clave = new System.Windows.Forms.Label();
            this.perfil = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.carnet = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido1 = new System.Windows.Forms.Label();
            this.apellido2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.comboPerfil = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarU = new System.Windows.Forms.Button();
            this.btnBuscarE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(424, 46);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(321, 46);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(97, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(231, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(121, 46);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(27, 46);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(18, 26);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(61, 19);
            this.codigo.TabIndex = 1;
            this.codigo.Text = "Codigo:";
            // 
            // clave
            // 
            this.clave.AutoSize = true;
            this.clave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave.Location = new System.Drawing.Point(18, 57);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(53, 19);
            this.clave.TabIndex = 2;
            this.clave.Text = "Clave:";
            // 
            // perfil
            // 
            this.perfil.AutoSize = true;
            this.perfil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfil.Location = new System.Drawing.Point(18, 103);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(50, 19);
            this.perfil.TabIndex = 3;
            this.perfil.Text = "Perfil:";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(19, 138);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(60, 19);
            this.estado.TabIndex = 4;
            this.estado.Text = "Estado:";
            // 
            // carnet
            // 
            this.carnet.AutoSize = true;
            this.carnet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carnet.Location = new System.Drawing.Point(429, 30);
            this.carnet.Name = "carnet";
            this.carnet.Size = new System.Drawing.Size(60, 19);
            this.carnet.TabIndex = 5;
            this.carnet.Text = "Carnet:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(429, 71);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(68, 19);
            this.nombre.TabIndex = 6;
            this.nombre.Text = "Nombre:";
            // 
            // apellido1
            // 
            this.apellido1.AutoSize = true;
            this.apellido1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido1.Location = new System.Drawing.Point(422, 108);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(77, 19);
            this.apellido1.TabIndex = 7;
            this.apellido1.Text = "Apellido1:";
            // 
            // apellido2
            // 
            this.apellido2.AutoSize = true;
            this.apellido2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido2.Location = new System.Drawing.Point(420, 145);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(77, 19);
            this.apellido2.TabIndex = 8;
            this.apellido2.Text = "Apellido2:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(86, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(158, 23);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(86, 56);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(158, 23);
            this.txtClave.TabIndex = 10;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(86, 139);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(158, 23);
            this.txtEstado.TabIndex = 11;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(506, 30);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(158, 20);
            this.txtCarnet.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(506, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(506, 105);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(158, 20);
            this.txtApellido1.TabIndex = 14;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(509, 142);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(158, 20);
            this.txtApellido2.TabIndex = 15;
            // 
            // comboPerfil
            // 
            this.comboPerfil.FormattingEnabled = true;
            this.comboPerfil.Location = new System.Drawing.Point(86, 104);
            this.comboPerfil.Name = "comboPerfil";
            this.comboPerfil.Size = new System.Drawing.Size(158, 24);
            this.comboPerfil.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboPerfil);
            this.groupBox2.Controls.Add(this.perfil);
            this.groupBox2.Controls.Add(this.codigo);
            this.groupBox2.Controls.Add(this.clave);
            this.groupBox2.Controls.Add(this.estado);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.txtClave);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 175);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del Usuario";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(337, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 175);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Estudiante";
            // 
            // btnBuscarU
            // 
            this.btnBuscarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarU.Location = new System.Drawing.Point(291, 31);
            this.btnBuscarU.Name = "btnBuscarU";
            this.btnBuscarU.Size = new System.Drawing.Size(40, 23);
            this.btnBuscarU.TabIndex = 19;
            this.btnBuscarU.Text = "?";
            this.btnBuscarU.UseVisualStyleBackColor = true;
            // 
            // btnBuscarE
            // 
            this.btnBuscarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarE.Location = new System.Drawing.Point(707, 26);
            this.btnBuscarE.Name = "btnBuscarE";
            this.btnBuscarE.Size = new System.Drawing.Size(40, 23);
            this.btnBuscarE.TabIndex = 20;
            this.btnBuscarE.Text = "?";
            this.btnBuscarE.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 310);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscarE);
            this.Controls.Add(this.btnBuscarU);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.apellido2);
            this.Controls.Add(this.apellido1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.carnet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenimiento de los Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label clave;
        private System.Windows.Forms.Label perfil;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label carnet;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido1;
        private System.Windows.Forms.Label apellido2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.ComboBox comboPerfil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarU;
        private System.Windows.Forms.Button btnBuscarE;
    }
}