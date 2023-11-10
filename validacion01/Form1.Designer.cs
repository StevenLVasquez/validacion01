namespace validacion01
{
    partial class frmvalidacion
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
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtemail = new TextBox();
            txtdireccion = new TextBox();
            lblnombre = new Label();
            lblapellido = new Label();
            lblemail = new Label();
            lbldireccion = new Label();
            btnvalidar = new Button();
            label1 = new Label();
            lbltitulo = new Label();
            btnhabilitar = new Button();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(142, 104);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(322, 23);
            txtnombre.TabIndex = 0;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(142, 152);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(322, 23);
            txtapellido.TabIndex = 1;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(142, 203);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(322, 23);
            txtemail.TabIndex = 2;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(142, 267);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(322, 23);
            txtdireccion.TabIndex = 3;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnombre.Location = new Point(53, 106);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(73, 21);
            lblnombre.TabIndex = 4;
            lblnombre.Text = "Nombre";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblapellido.Location = new Point(53, 154);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(75, 21);
            lblapellido.TabIndex = 5;
            lblapellido.Text = "Apellido";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblemail.Location = new Point(53, 203);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(53, 21);
            lblemail.TabIndex = 6;
            lblemail.Text = "Email";
            // 
            // lbldireccion
            // 
            lbldireccion.AutoSize = true;
            lbldireccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldireccion.Location = new Point(53, 267);
            lbldireccion.Name = "lbldireccion";
            lbldireccion.Size = new Size(83, 21);
            lbldireccion.TabIndex = 7;
            lbldireccion.Text = "Direccion";
            // 
            // btnvalidar
            // 
            btnvalidar.BackColor = Color.IndianRed;
            btnvalidar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnvalidar.ForeColor = SystemColors.ButtonHighlight;
            btnvalidar.Location = new Point(142, 351);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(101, 45);
            btnvalidar.TabIndex = 8;
            btnvalidar.Text = "Validar";
            btnvalidar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.Location = new Point(228, 32);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(387, 45);
            lbltitulo.TabIndex = 9;
            lbltitulo.Text = "VALIDACION DE DATOS ";
            // 
            // btnhabilitar
            // 
            btnhabilitar.BackColor = Color.Tomato;
            btnhabilitar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnhabilitar.ForeColor = SystemColors.ControlLight;
            btnhabilitar.Location = new Point(301, 351);
            btnhabilitar.Name = "btnhabilitar";
            btnhabilitar.Size = new Size(101, 45);
            btnhabilitar.TabIndex = 10;
            btnhabilitar.Text = "HABILITAR";
            btnhabilitar.UseVisualStyleBackColor = false;
            // 
            // frmvalidacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnhabilitar);
            Controls.Add(lbltitulo);
            Controls.Add(label1);
            Controls.Add(btnvalidar);
            Controls.Add(lbldireccion);
            Controls.Add(lblemail);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Controls.Add(txtdireccion);
            Controls.Add(txtemail);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Name = "frmvalidacion";
            Text = "Validacion de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtemail;
        private TextBox txtdireccion;
        private Label lblnombre;
        private Label lblapellido;
        private Label lblemail;
        private Label lbldireccion;
        private Button btnvalidar;
        private Label label1;
        private Label lbltitulo;
        private Button btnhabilitar;
    }
}