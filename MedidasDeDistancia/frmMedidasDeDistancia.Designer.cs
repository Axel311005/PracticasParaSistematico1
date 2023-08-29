namespace MedidasDeDistancia
{
    partial class frmMedidasDeDistancia
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboDe = new ComboBox();
            cboA = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtResultado = new TextBox();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(401, 27);
            label1.Name = "label1";
            label1.Size = new Size(229, 45);
            label1.TabIndex = 0;
            label1.Text = "Conversiones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(202, 146);
            label2.Name = "label2";
            label2.Size = new Size(56, 37);
            label2.TabIndex = 1;
            label2.Text = "De:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(726, 146);
            label3.Name = "label3";
            label3.Size = new Size(40, 37);
            label3.TabIndex = 2;
            label3.Text = "A:";
            // 
            // cboDe
            // 
            cboDe.FormattingEnabled = true;
            cboDe.Items.AddRange(new object[] { "Kilometros", "Metros", "Millas", "Centimetros" });
            cboDe.Location = new Point(90, 227);
            cboDe.Name = "cboDe";
            cboDe.Size = new Size(242, 40);
            cboDe.TabIndex = 3;
            cboDe.Text = "Seleccione";
            cboDe.SelectedIndexChanged += cboDe_SelectedIndexChanged;
            // 
            // cboA
            // 
            cboA.FormattingEnabled = true;
            cboA.Items.AddRange(new object[] { "Kilometros", "Metros", "Millas", "Centimetros" });
            cboA.Location = new Point(612, 227);
            cboA.Name = "cboA";
            cboA.Size = new Size(242, 40);
            cboA.TabIndex = 4;
            cboA.Text = "Seleccione";
            cboA.SelectedIndexChanged += cboA_SelectedIndexChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(422, 307);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(39, 534);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 46);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(233, 534);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 46);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(376, 401);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(254, 39);
            txtResultado.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(390, 164);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(200, 39);
            txtCantidad.TabIndex = 9;
            // 
            // frmMedidasDeDistancia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(997, 604);
            Controls.Add(txtCantidad);
            Controls.Add(txtResultado);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(cboA);
            Controls.Add(cboDe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMedidasDeDistancia";
            Text = "frmMedidasDeDistancia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboDe;
        private ComboBox cboA;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtResultado;
        private TextBox txtCantidad;
    }
}