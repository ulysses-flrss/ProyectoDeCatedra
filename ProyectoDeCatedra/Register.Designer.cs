namespace ProyectoDeCatedra
{
    partial class Register
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rdbEmpleador = new System.Windows.Forms.RadioButton();
            this.rdbCandidato = new System.Windows.Forms.RadioButton();
            this.btnSiCuenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(320, 340);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(162, 39);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Crear Cuenta";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(52, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(48, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(48, 123);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(85, 17);
            this.lblNacionalidad.TabIndex = 4;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidad.Location = new System.Drawing.Point(52, 143);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(253, 25);
            this.txtNacionalidad.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(47, 202);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(117, 17);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(51, 222);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(253, 25);
            this.txtCorreo.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(451, 123);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(89, 17);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Genero (H/M)";
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(455, 143);
            this.txtGenero.MaxLength = 1;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(85, 25);
            this.txtGenero.TabIndex = 7;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(453, 52);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(130, 17);
            this.lblFechaNacimiento.TabIndex = 9;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dFechaNacimiento
            // 
            this.dFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dFechaNacimiento.Location = new System.Drawing.Point(456, 72);
            this.dFechaNacimiento.Name = "dFechaNacimiento";
            this.dFechaNacimiento.Size = new System.Drawing.Size(252, 25);
            this.dFechaNacimiento.TabIndex = 10;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(613, 123);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 17);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Télefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(570, 143);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(138, 25);
            this.txtTelefono.TabIndex = 11;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(450, 202);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 17);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(454, 222);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 25);
            this.txtPassword.TabIndex = 13;
            // 
            // rdbEmpleador
            // 
            this.rdbEmpleador.AutoSize = true;
            this.rdbEmpleador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEmpleador.Location = new System.Drawing.Point(17, 22);
            this.rdbEmpleador.Name = "rdbEmpleador";
            this.rdbEmpleador.Size = new System.Drawing.Size(90, 21);
            this.rdbEmpleador.TabIndex = 15;
            this.rdbEmpleador.TabStop = true;
            this.rdbEmpleador.Text = "Empleador";
            this.rdbEmpleador.UseVisualStyleBackColor = true;
            // 
            // rdbCandidato
            // 
            this.rdbCandidato.AutoSize = true;
            this.rdbCandidato.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCandidato.Location = new System.Drawing.Point(162, 22);
            this.rdbCandidato.Name = "rdbCandidato";
            this.rdbCandidato.Size = new System.Drawing.Size(86, 21);
            this.rdbCandidato.TabIndex = 16;
            this.rdbCandidato.TabStop = true;
            this.rdbCandidato.Text = "Candidato";
            this.rdbCandidato.UseVisualStyleBackColor = true;
            // 
            // btnSiCuenta
            // 
            this.btnSiCuenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiCuenta.Location = new System.Drawing.Point(344, 385);
            this.btnSiCuenta.Name = "btnSiCuenta";
            this.btnSiCuenta.Size = new System.Drawing.Size(115, 27);
            this.btnSiCuenta.TabIndex = 17;
            this.btnSiCuenta.Text = "Ya Tengo Cuenta";
            this.btnSiCuenta.UseVisualStyleBackColor = true;
            this.btnSiCuenta.Click += new System.EventHandler(this.btnSiCuenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbEmpleador);
            this.groupBox1.Controls.Add(this.rdbCandidato);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(276, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 58);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Usuario";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSiCuenta);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.dFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegister);
            this.Name = "Register";
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rdbEmpleador;
        private System.Windows.Forms.RadioButton rdbCandidato;
        private System.Windows.Forms.Button btnSiCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}