﻿namespace Medic
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpCtrls = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientCode = new System.Windows.Forms.Label();
            this.PatientStatus = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPatientStatus = new System.Windows.Forms.TextBox();
            this.txtPatientCode = new System.Windows.Forms.TextBox();
            this.bttSearch = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttEdit = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.actualizationPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCtrls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualizationPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCtrls
            // 
            this.grpCtrls.Controls.Add(this.dataGridView1);
            this.grpCtrls.Location = new System.Drawing.Point(21, 18);
            this.grpCtrls.Name = "grpCtrls";
            this.grpCtrls.Size = new System.Drawing.Size(370, 206);
            this.grpCtrls.TabIndex = 0;
            this.grpCtrls.TabStop = false;
            this.grpCtrls.Text = "groupBox1";
            this.grpCtrls.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.patientCodeDataGridViewTextBoxColumn,
            this.patientStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.actualizationPatientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(333, 111);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPatientCode);
            this.groupBox2.Controls.Add(this.txtPatientStatus);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.PatientStatus);
            this.groupBox2.Controls.Add(this.PatientCode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(434, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            // PatientCode
            // 
            this.PatientCode.AutoSize = true;
            this.PatientCode.Location = new System.Drawing.Point(16, 68);
            this.PatientCode.Name = "PatientCode";
            this.PatientCode.Size = new System.Drawing.Size(65, 13);
            this.PatientCode.TabIndex = 1;
            this.PatientCode.Text = "PatientCode";
            this.PatientCode.Click += new System.EventHandler(this.label2_Click);
            // 
            // PatientStatus
            // 
            this.PatientStatus.AutoSize = true;
            this.PatientStatus.Location = new System.Drawing.Point(16, 103);
            this.PatientStatus.Name = "PatientStatus";
            this.PatientStatus.Size = new System.Drawing.Size(70, 13);
            this.PatientStatus.TabIndex = 2;
            this.PatientStatus.Text = "PatientStatus";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actualizationPatientBindingSource, "ID", true));
            this.txtId.Location = new System.Drawing.Point(78, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtPatientStatus
            // 
            this.txtPatientStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actualizationPatientBindingSource, "PatientStatus", true));
            this.txtPatientStatus.Location = new System.Drawing.Point(78, 100);
            this.txtPatientStatus.Name = "txtPatientStatus";
            this.txtPatientStatus.Size = new System.Drawing.Size(100, 20);
            this.txtPatientStatus.TabIndex = 6;
            // 
            // txtPatientCode
            // 
            this.txtPatientCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actualizationPatientBindingSource, "PatientCode", true));
            this.txtPatientCode.Location = new System.Drawing.Point(78, 65);
            this.txtPatientCode.Name = "txtPatientCode";
            this.txtPatientCode.Size = new System.Drawing.Size(100, 20);
            this.txtPatientCode.TabIndex = 9;
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(316, 307);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(75, 23);
            this.bttSearch.TabIndex = 2;
            this.bttSearch.Text = "Buscar";
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(398, 307);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 3;
            this.bttAdd.Text = "Agregar";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(479, 307);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 4;
            this.bttEdit.Text = "Editar";
            this.bttEdit.UseVisualStyleBackColor = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(560, 307);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 5;
            this.bttDelete.Text = "Eliminar";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(641, 307);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 6;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(722, 307);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 7;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // actualizationPatientBindingSource
            // 
            this.actualizationPatientBindingSource.DataSource = typeof(Medic.ActualizationPatient);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientCodeDataGridViewTextBoxColumn
            // 
            this.patientCodeDataGridViewTextBoxColumn.DataPropertyName = "PatientCode";
            this.patientCodeDataGridViewTextBoxColumn.HeaderText = "PatientCode";
            this.patientCodeDataGridViewTextBoxColumn.Name = "patientCodeDataGridViewTextBoxColumn";
            // 
            // patientStatusDataGridViewTextBoxColumn
            // 
            this.patientStatusDataGridViewTextBoxColumn.DataPropertyName = "PatientStatus";
            this.patientStatusDataGridViewTextBoxColumn.HeaderText = "PatientStatus";
            this.patientStatusDataGridViewTextBoxColumn.Name = "patientStatusDataGridViewTextBoxColumn";
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCtrls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualizationPatientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCtrls;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource actualizationPatientBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PatientStatus;
        private System.Windows.Forms.Label PatientCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientCode;
        private System.Windows.Forms.TextBox txtPatientStatus;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientStatusDataGridViewTextBoxColumn;
    }
}

