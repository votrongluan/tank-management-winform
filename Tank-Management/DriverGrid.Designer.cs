﻿namespace Tank_Management
{
    partial class DriverGrid
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
            btnResetTankDgv = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label4 = new Label();
            btnBack = new Button();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgvDriver = new DataGridView();
            label1 = new Label();
            txtIdCard = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            cbxUnit = new ComboBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDriver).BeginInit();
            SuspendLayout();
            // 
            // btnResetTankDgv
            // 
            btnResetTankDgv.Location = new Point(40, 823);
            btnResetTankDgv.Name = "btnResetTankDgv";
            btnResetTankDgv.Size = new Size(220, 46);
            btnResetTankDgv.TabIndex = 24;
            btnResetTankDgv.Text = "Reset tank data";
            btnResetTankDgv.UseVisualStyleBackColor = true;
            btnResetTankDgv.Click += btnResetTankDgv_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1559, 125);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(156, 128);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Find by id, model or manufactory";
            txtSearch.Size = new Size(1385, 39);
            txtSearch.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 131);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 21;
            label4.Text = "Search";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 255, 192);
            btnBack.Location = new Point(1417, 824);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(292, 46);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(1347, 241);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(362, 39);
            txtId.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1228, 306);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 16;
            label3.Text = "Id card";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(1228, 244);
            label2.Name = "label2";
            label2.Size = new Size(34, 32);
            label2.TabIndex = 15;
            label2.Text = "Id";
            // 
            // dgvDriver
            // 
            dgvDriver.BackgroundColor = Color.White;
            dgvDriver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDriver.Location = new Point(40, 205);
            dgvDriver.Name = "dgvDriver";
            dgvDriver.ReadOnly = true;
            dgvDriver.RowHeadersWidth = 82;
            dgvDriver.RowTemplate.Height = 41;
            dgvDriver.Size = new Size(1141, 578);
            dgvDriver.TabIndex = 14;
            dgvDriver.CellDoubleClick += dgvDriver_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(764, 19);
            label1.Name = "label1";
            label1.Size = new Size(360, 71);
            label1.TabIndex = 13;
            label1.Text = "Mange Driver";
            // 
            // txtIdCard
            // 
            txtIdCard.Location = new Point(1347, 306);
            txtIdCard.Name = "txtIdCard";
            txtIdCard.Size = new Size(362, 39);
            txtIdCard.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1228, 368);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 26;
            label5.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(1347, 368);
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 39);
            txtName.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1228, 433);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 28;
            label6.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(1347, 426);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(362, 39);
            txtPhone.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1224, 499);
            label7.Name = "label7";
            label7.Size = new Size(58, 32);
            label7.TabIndex = 30;
            label7.Text = "Unit";
            // 
            // cbxUnit
            // 
            cbxUnit.FormattingEnabled = true;
            cbxUnit.Location = new Point(1347, 499);
            cbxUnit.Name = "cbxUnit";
            cbxUnit.Size = new Size(362, 40);
            cbxUnit.TabIndex = 31;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1559, 579);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 46);
            btnCreate.TabIndex = 32;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(1228, 579);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(1228, 671);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1559, 671);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 35;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // DriverGrid
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 908);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(cbxUnit);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtIdCard);
            Controls.Add(btnResetTankDgv);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDriver);
            Controls.Add(label1);
            Name = "DriverGrid";
            Text = "DriverGrid";
            ((System.ComponentModel.ISupportInitialize)dgvDriver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResetTankDgv;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label4;
        private Button btnBack;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private DataGridView dgvDriver;
        private Label label1;
        private TextBox txtIdCard;
        private Label label5;
        private TextBox txtName;
        private Label label6;
        private TextBox txtPhone;
        private Label label7;
        private ComboBox cbxUnit;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
    }
}