namespace Medic
{
    partial class AssignedMedics
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
            this.bttSave = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttEdit = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastNamePatient = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCtrls = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assignedMedicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professionalLicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.grpCtrls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedMedicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(713, 361);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 15;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(632, 361);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 14;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(551, 361);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 13;
            this.bttDelete.Text = "Eliminar";
            this.bttDelete.UseVisualStyleBackColor = true;
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(470, 361);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 12;
            this.bttEdit.Text = "Editar";
            this.bttEdit.UseVisualStyleBackColor = true;
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(389, 361);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 11;
            this.bttAdd.Text = "Agregar";
            this.bttAdd.UseVisualStyleBackColor = true;
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(307, 361);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(75, 23);
            this.bttSearch.TabIndex = 10;
            this.bttSearch.Text = "Buscar";
            this.bttSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.txtLastNamePatient);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(425, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 212);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(78, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastNamePatient
            // 
            this.txtLastNamePatient.Location = new System.Drawing.Point(78, 100);
            this.txtLastNamePatient.Name = "txtLastNamePatient";
            this.txtLastNamePatient.Size = new System.Drawing.Size(100, 20);
            this.txtLastNamePatient.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(78, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.Location = new System.Drawing.Point(16, 103);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(70, 13);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "PatientStatus";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(16, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(65, 13);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "PatientCode";
            this.txtName.Click += new System.EventHandler(this.PatientCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // grpCtrls
            // 
            this.grpCtrls.Controls.Add(this.dataGridView1);
            this.grpCtrls.Location = new System.Drawing.Point(12, 72);
            this.grpCtrls.Name = "grpCtrls";
            this.grpCtrls.Size = new System.Drawing.Size(370, 206);
            this.grpCtrls.TabIndex = 8;
            this.grpCtrls.TabStop = false;
            this.grpCtrls.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.professionalLicenseDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assignedMedicBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(333, 111);
            this.dataGridView1.TabIndex = 0;
            // 
            // assignedMedicBindingSource
            // 
            this.assignedMedicBindingSource.DataSource = typeof(Medic.AssignedMedic);
            // 
            // professionalLicenseDataGridViewTextBoxColumn
            // 
            this.professionalLicenseDataGridViewTextBoxColumn.DataPropertyName = "ProfessionalLicense";
            this.professionalLicenseDataGridViewTextBoxColumn.HeaderText = "ProfessionalLicense";
            this.professionalLicenseDataGridViewTextBoxColumn.Name = "professionalLicenseDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // AssignedMedics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttEdit);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.bttSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCtrls);
            this.Name = "AssignedMedics";
            this.Text = "AssignedMedics";
            this.Load += new System.EventHandler(this.AssignedMedics_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpCtrls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedMedicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastNamePatient;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label txtLastName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCtrls;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionalLicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource assignedMedicBindingSource;
    }
}