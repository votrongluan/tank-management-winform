﻿namespace Tank_Management
{
    partial class ModelGrid
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
            dgvListModels = new DataGridView();
            btnBackToDashboard = new Button();
            lblId = new Label();
            txtId = new TextBox();
            lblWeight = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDetail = new TextBox();
            txtName = new TextBox();
            cbAmmo = new ComboBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            nudWeight = new NumericUpDown();
            nudMaxSpeed = new NumericUpDown();
            nudMaxNoDriver = new NumericUpDown();
            nudPrice = new NumericUpDown();
            nudShootingRange = new NumericUpDown();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListModels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxNoDriver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudShootingRange).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListModels
            // 
            dgvListModels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListModels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvListModels.BackgroundColor = Color.White;
            dgvListModels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListModels.Location = new Point(398, 82);
            dgvListModels.Margin = new Padding(2);
            dgvListModels.Name = "dgvListModels";
            dgvListModels.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvListModels.RowTemplate.Height = 33;
            dgvListModels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListModels.Size = new Size(1063, 620);
            dgvListModels.TabIndex = 0;
            dgvListModels.CellDoubleClick += dgvListModels_CellDoubleClick;
            // 
            // btnBackToDashboard
            // 
            btnBackToDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBackToDashboard.BackColor = Color.FromArgb(255, 255, 192);
            btnBackToDashboard.Location = new Point(856, 641);
            btnBackToDashboard.Margin = new Padding(2);
            btnBackToDashboard.Name = "btnBackToDashboard";
            btnBackToDashboard.Size = new Size(208, 34);
            btnBackToDashboard.TabIndex = 3;
            btnBackToDashboard.Text = "Back to Dashboard";
            btnBackToDashboard.UseVisualStyleBackColor = false;
            btnBackToDashboard.Click += btnBackToDashboard_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(16, 126);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 25);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(182, 126);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(176, 31);
            txtId.TabIndex = 5;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(12, 172);
            lblWeight.Margin = new Padding(2, 0, 2, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(105, 25);
            lblWeight.TabIndex = 6;
            lblWeight.Text = "Weight(ton)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 220);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 7;
            label2.Text = "Max Speed(km/h)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 261);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 8;
            label3.Text = "Detail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 306);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 9;
            label4.Text = "Max No Driver";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 359);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 10;
            label5.Text = "Ammo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 405);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 11;
            label6.Text = "Price($)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 455);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 12;
            label7.Text = "Name";
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(182, 261);
            txtDetail.Margin = new Padding(2);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(180, 31);
            txtDetail.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(182, 451);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 31);
            txtName.TabIndex = 19;
            // 
            // cbAmmo
            // 
            cbAmmo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAmmo.FormattingEnabled = true;
            cbAmmo.Location = new Point(182, 351);
            cbAmmo.Margin = new Padding(2);
            cbAmmo.Name = "cbAmmo";
            cbAmmo.Size = new Size(180, 33);
            cbAmmo.TabIndex = 21;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 545);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 22;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(130, 545);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(250, 545);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReset.Location = new Point(0, 644);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset data";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 82);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Id, Name";
            txtSearch.Size = new Size(230, 31);
            txtSearch.TabIndex = 26;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(250, 82);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 34);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // nudWeight
            // 
            nudWeight.Location = new Point(182, 172);
            nudWeight.Margin = new Padding(2);
            nudWeight.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(180, 31);
            nudWeight.TabIndex = 28;
            // 
            // nudMaxSpeed
            // 
            nudMaxSpeed.Location = new Point(182, 218);
            nudMaxSpeed.Margin = new Padding(2);
            nudMaxSpeed.Name = "nudMaxSpeed";
            nudMaxSpeed.Size = new Size(180, 31);
            nudMaxSpeed.TabIndex = 29;
            // 
            // nudMaxNoDriver
            // 
            nudMaxNoDriver.Location = new Point(182, 305);
            nudMaxNoDriver.Margin = new Padding(2);
            nudMaxNoDriver.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudMaxNoDriver.Name = "nudMaxNoDriver";
            nudMaxNoDriver.Size = new Size(180, 31);
            nudMaxNoDriver.TabIndex = 30;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(182, 402);
            nudPrice.Margin = new Padding(2);
            nudPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(180, 31);
            nudPrice.TabIndex = 31;
            // 
            // nudShootingRange
            // 
            nudShootingRange.Location = new Point(182, 499);
            nudShootingRange.Margin = new Padding(2);
            nudShootingRange.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudShootingRange.Name = "nudShootingRange";
            nudShootingRange.Size = new Size(180, 31);
            nudShootingRange.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnBackToDashboard);
            panel1.Location = new Point(398, 82);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 678);
            panel1.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 501);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 13;
            label1.Text = "Shooting Range(m)";
            // 
            // ModelGrid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 775);
            Controls.Add(nudShootingRange);
            Controls.Add(nudPrice);
            Controls.Add(nudMaxNoDriver);
            Controls.Add(nudMaxSpeed);
            Controls.Add(nudWeight);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(cbAmmo);
            Controls.Add(txtName);
            Controls.Add(txtDetail);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblWeight);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(dgvListModels);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ModelGrid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Model Manager";
            ((System.ComponentModel.ISupportInitialize)dgvListModels).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxNoDriver).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudShootingRange).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvListModels;
        private Button button1;
        private Button btnBackToDashboard;
        private Label lblId;
        private TextBox txtId;
        private Label lblWeight;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDetail;
        private TextBox txtName;
        private ComboBox cbAmmo;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private TextBox txtSearch;
        private Button btnSearch;
        private NumericUpDown nudWeight;
        private NumericUpDown nudMaxSpeed;
        private NumericUpDown nudMaxNoDriver;
        private NumericUpDown nudPrice;
        private NumericUpDown nudShootingRange;
        private Panel panel1;
        private Label label1;
    }
}