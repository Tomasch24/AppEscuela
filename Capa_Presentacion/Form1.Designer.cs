namespace Capa_Presentacion
{
    partial class Form1
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
            lblID = new Label();
            lblName = new Label();
            lblApellido = new Label();
            lblTipo = new Label();
            lblExtra = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtApellido = new TextBox();
            txtTipo = new TextBox();
            txtExtra = new TextBox();
            btnBuscarx = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(251, 87);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 25);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(251, 124);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(247, 160);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(251, 195);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(47, 25);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo";
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.Location = new Point(251, 235);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(50, 25);
            lblExtra.TabIndex = 4;
            lblExtra.Text = "Extra";
            // 
            // txtID
            // 
            txtID.Location = new Point(335, 81);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(335, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(335, 154);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 7;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(335, 195);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(150, 31);
            txtTipo.TabIndex = 8;
            // 
            // txtExtra
            // 
            txtExtra.Location = new Point(335, 232);
            txtExtra.Name = "txtExtra";
            txtExtra.Size = new Size(150, 31);
            txtExtra.TabIndex = 9;
            txtExtra.TextChanged += txtExtra_TextChanged;
            // 
            // btnBuscarx
            // 
            btnBuscarx.Location = new Point(351, 326);
            btnBuscarx.Name = "btnBuscarx";
            btnBuscarx.Size = new Size(112, 34);
            btnBuscarx.TabIndex = 10;
            btnBuscarx.Text = "BUSCAR";
            btnBuscarx.UseVisualStyleBackColor = true;
            btnBuscarx.Click += btnBuscarx_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarx);
            Controls.Add(txtExtra);
            Controls.Add(txtTipo);
            Controls.Add(txtApellido);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblExtra);
            Controls.Add(lblTipo);
            Controls.Add(lblApellido);
            Controls.Add(lblName);
            Controls.Add(lblID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblName;
        private Label lblApellido;
        private Label lblTipo;
        private Label lblExtra;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtApellido;
        private TextBox txtTipo;
        private TextBox txtExtra;
        private Button btnBuscarx;
    }
}
