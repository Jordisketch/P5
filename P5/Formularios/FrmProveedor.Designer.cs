namespace P5.Formularios
{
    partial class FrmProveedor
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
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.p520231DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.p5_2023_1DataSet = new P5.P5_2023_1DataSet();
            this.p520231DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.LblCedulaProveedor = new System.Windows.Forms.Label();
            this.TxtCedulaProveedor = new System.Windows.Forms.TextBox();
            this.LblEmailProveedor = new System.Windows.Forms.Label();
            this.TxtEmailProveedor = new System.Windows.Forms.TextBox();
            this.LblNotasProveedor = new System.Windows.Forms.Label();
            this.TxtNotasProveedor = new System.Windows.Forms.TextBox();
            this.LblActivoProveedor = new System.Windows.Forms.Label();
            this.RadioActivoProveedorSi = new System.Windows.Forms.RadioButton();
            this.ComboTipoProveedor = new System.Windows.Forms.ComboBox();
            this.RadioActivoProveedorNo = new System.Windows.Forms.RadioButton();
            this.LblTipoProveedor = new System.Windows.Forms.Label();
            this.LblDirecccion = new System.Windows.Forms.Label();
            this.TxtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnLimpiarFormulario = new System.Windows.Forms.Button();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.p520231DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5_2023_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p520231DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.Location = new System.Drawing.Point(488, 249);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(130, 34);
            this.btnAgregarProveedor.TabIndex = 0;
            this.btnAgregarProveedor.Text = "Agregar proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.guardarClick);
            // 
            // p520231DataSetBindingSource1
            // 
            this.p520231DataSetBindingSource1.DataSource = this.p5_2023_1DataSet;
            this.p520231DataSetBindingSource1.Position = 0;
            // 
            // p5_2023_1DataSet
            // 
            this.p5_2023_1DataSet.DataSetName = "P5_2023_1DataSet";
            this.p5_2023_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p520231DataSetBindingSource
            // 
            this.p520231DataSetBindingSource.DataSource = this.p5_2023_1DataSet;
            this.p520231DataSetBindingSource.Position = 0;
            // 
            // ProveedorNombre
            // 
            this.ProveedorNombre.DataPropertyName = "ProveedorNombre";
            this.ProveedorNombre.HeaderText = "Nombre";
            this.ProveedorNombre.Name = "ProveedorNombre";
            this.ProveedorNombre.ReadOnly = true;
            // 
            // ProveedorCedula
            // 
            this.ProveedorCedula.HeaderText = "Cedula";
            this.ProveedorCedula.Name = "ProveedorCedula";
            this.ProveedorCedula.ReadOnly = true;
            // 
            // ProveedorEmail
            // 
            this.ProveedorEmail.HeaderText = "Email";
            this.ProveedorEmail.Name = "ProveedorEmail";
            this.ProveedorEmail.ReadOnly = true;
            // 
            // ProveedorDireccion
            // 
            this.ProveedorDireccion.HeaderText = "Direcicon";
            this.ProveedorDireccion.Name = "ProveedorDireccion";
            this.ProveedorDireccion.ReadOnly = true;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(12, 241);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.Location = new System.Drawing.Point(12, 257);
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreProveedor.TabIndex = 2;
            // 
            // LblCedulaProveedor
            // 
            this.LblCedulaProveedor.AutoSize = true;
            this.LblCedulaProveedor.Location = new System.Drawing.Point(160, 241);
            this.LblCedulaProveedor.Name = "LblCedulaProveedor";
            this.LblCedulaProveedor.Size = new System.Drawing.Size(40, 13);
            this.LblCedulaProveedor.TabIndex = 3;
            this.LblCedulaProveedor.Text = "Cedula";
            // 
            // TxtCedulaProveedor
            // 
            this.TxtCedulaProveedor.Location = new System.Drawing.Point(163, 257);
            this.TxtCedulaProveedor.Name = "TxtCedulaProveedor";
            this.TxtCedulaProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtCedulaProveedor.TabIndex = 4;
            // 
            // LblEmailProveedor
            // 
            this.LblEmailProveedor.AutoSize = true;
            this.LblEmailProveedor.Location = new System.Drawing.Point(317, 241);
            this.LblEmailProveedor.Name = "LblEmailProveedor";
            this.LblEmailProveedor.Size = new System.Drawing.Size(32, 13);
            this.LblEmailProveedor.TabIndex = 5;
            this.LblEmailProveedor.Text = "Email";
            // 
            // TxtEmailProveedor
            // 
            this.TxtEmailProveedor.Location = new System.Drawing.Point(320, 257);
            this.TxtEmailProveedor.Name = "TxtEmailProveedor";
            this.TxtEmailProveedor.Size = new System.Drawing.Size(121, 20);
            this.TxtEmailProveedor.TabIndex = 6;
            // 
            // LblNotasProveedor
            // 
            this.LblNotasProveedor.AutoSize = true;
            this.LblNotasProveedor.Location = new System.Drawing.Point(12, 316);
            this.LblNotasProveedor.Name = "LblNotasProveedor";
            this.LblNotasProveedor.Size = new System.Drawing.Size(35, 13);
            this.LblNotasProveedor.TabIndex = 7;
            this.LblNotasProveedor.Text = "Notas";
            // 
            // TxtNotasProveedor
            // 
            this.TxtNotasProveedor.Location = new System.Drawing.Point(12, 332);
            this.TxtNotasProveedor.Name = "TxtNotasProveedor";
            this.TxtNotasProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtNotasProveedor.TabIndex = 8;
            // 
            // LblActivoProveedor
            // 
            this.LblActivoProveedor.AutoSize = true;
            this.LblActivoProveedor.Location = new System.Drawing.Point(181, 314);
            this.LblActivoProveedor.Name = "LblActivoProveedor";
            this.LblActivoProveedor.Size = new System.Drawing.Size(37, 13);
            this.LblActivoProveedor.TabIndex = 9;
            this.LblActivoProveedor.Text = "Activo";
            // 
            // RadioActivoProveedorSi
            // 
            this.RadioActivoProveedorSi.AutoSize = true;
            this.RadioActivoProveedorSi.Location = new System.Drawing.Point(187, 339);
            this.RadioActivoProveedorSi.Name = "RadioActivoProveedorSi";
            this.RadioActivoProveedorSi.Size = new System.Drawing.Size(34, 17);
            this.RadioActivoProveedorSi.TabIndex = 10;
            this.RadioActivoProveedorSi.Text = "Si";
            this.RadioActivoProveedorSi.UseVisualStyleBackColor = true;
            // 
            // ComboTipoProveedor
            // 
            this.ComboTipoProveedor.FormattingEnabled = true;
            this.ComboTipoProveedor.Location = new System.Drawing.Point(320, 335);
            this.ComboTipoProveedor.Name = "ComboTipoProveedor";
            this.ComboTipoProveedor.Size = new System.Drawing.Size(121, 21);
            this.ComboTipoProveedor.TabIndex = 11;
            // 
            // RadioActivoProveedorNo
            // 
            this.RadioActivoProveedorNo.AutoSize = true;
            this.RadioActivoProveedorNo.Checked = true;
            this.RadioActivoProveedorNo.Location = new System.Drawing.Point(187, 362);
            this.RadioActivoProveedorNo.Name = "RadioActivoProveedorNo";
            this.RadioActivoProveedorNo.Size = new System.Drawing.Size(39, 17);
            this.RadioActivoProveedorNo.TabIndex = 12;
            this.RadioActivoProveedorNo.TabStop = true;
            this.RadioActivoProveedorNo.Text = "No";
            this.RadioActivoProveedorNo.UseVisualStyleBackColor = true;
            // 
            // LblTipoProveedor
            // 
            this.LblTipoProveedor.AutoSize = true;
            this.LblTipoProveedor.Location = new System.Drawing.Point(317, 316);
            this.LblTipoProveedor.Name = "LblTipoProveedor";
            this.LblTipoProveedor.Size = new System.Drawing.Size(80, 13);
            this.LblTipoProveedor.TabIndex = 13;
            this.LblTipoProveedor.Text = "Tipo Proveedor";
            // 
            // LblDirecccion
            // 
            this.LblDirecccion.AutoSize = true;
            this.LblDirecccion.Location = new System.Drawing.Point(12, 384);
            this.LblDirecccion.Name = "LblDirecccion";
            this.LblDirecccion.Size = new System.Drawing.Size(52, 13);
            this.LblDirecccion.TabIndex = 14;
            this.LblDirecccion.Text = "Direccion";
            // 
            // TxtDireccionProveedor
            // 
            this.TxtDireccionProveedor.Location = new System.Drawing.Point(12, 400);
            this.TxtDireccionProveedor.Name = "TxtDireccionProveedor";
            this.TxtDireccionProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtDireccionProveedor.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProveedor,
            this.CedulaProveedor,
            this.EmailProveedor,
            this.DireccionProveedor});
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 215);
            this.dataGridView1.TabIndex = 16;
            // 
            // BtnLimpiarFormulario
            // 
            this.BtnLimpiarFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLimpiarFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiarFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarFormulario.Location = new System.Drawing.Point(488, 333);
            this.BtnLimpiarFormulario.Name = "BtnLimpiarFormulario";
            this.BtnLimpiarFormulario.Size = new System.Drawing.Size(130, 33);
            this.BtnLimpiarFormulario.TabIndex = 17;
            this.BtnLimpiarFormulario.Text = "Limpiar formulario";
            this.BtnLimpiarFormulario.UseVisualStyleBackColor = false;
            this.BtnLimpiarFormulario.Click += new System.EventHandler(this.LimpiarFormulario);
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.HeaderText = "Nombre";
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.Width = 300;
            // 
            // CedulaProveedor
            // 
            this.CedulaProveedor.HeaderText = "Cedula";
            this.CedulaProveedor.Name = "CedulaProveedor";
            // 
            // EmailProveedor
            // 
            this.EmailProveedor.HeaderText = "Email";
            this.EmailProveedor.Name = "EmailProveedor";
            // 
            // DireccionProveedor
            // 
            this.DireccionProveedor.HeaderText = "Direccion";
            this.DireccionProveedor.Name = "DireccionProveedor";
            this.DireccionProveedor.Width = 250;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.BtnLimpiarFormulario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtDireccionProveedor);
            this.Controls.Add(this.LblDirecccion);
            this.Controls.Add(this.LblTipoProveedor);
            this.Controls.Add(this.RadioActivoProveedorNo);
            this.Controls.Add(this.ComboTipoProveedor);
            this.Controls.Add(this.RadioActivoProveedorSi);
            this.Controls.Add(this.LblActivoProveedor);
            this.Controls.Add(this.TxtNotasProveedor);
            this.Controls.Add(this.LblNotasProveedor);
            this.Controls.Add(this.TxtEmailProveedor);
            this.Controls.Add(this.LblEmailProveedor);
            this.Controls.Add(this.TxtCedulaProveedor);
            this.Controls.Add(this.LblCedulaProveedor);
            this.Controls.Add(this.TxtNombreProveedor);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p520231DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5_2023_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p520231DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.BindingSource p520231DataSetBindingSource;
        private P5_2023_1DataSet p5_2023_1DataSet;
        private System.Windows.Forms.BindingSource p520231DataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorDireccion;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.Label LblCedulaProveedor;
        private System.Windows.Forms.TextBox TxtCedulaProveedor;
        private System.Windows.Forms.Label LblEmailProveedor;
        private System.Windows.Forms.TextBox TxtEmailProveedor;
        private System.Windows.Forms.Label LblNotasProveedor;
        private System.Windows.Forms.TextBox TxtNotasProveedor;
        private System.Windows.Forms.Label LblActivoProveedor;
        private System.Windows.Forms.RadioButton RadioActivoProveedorSi;
        private System.Windows.Forms.ComboBox ComboTipoProveedor;
        private System.Windows.Forms.RadioButton RadioActivoProveedorNo;
        private System.Windows.Forms.Label LblTipoProveedor;
        private System.Windows.Forms.Label LblDirecccion;
        private System.Windows.Forms.TextBox TxtDireccionProveedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnLimpiarFormulario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionProveedor;
    }
}