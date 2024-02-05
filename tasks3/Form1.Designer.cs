namespace CarManagementApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            cmbColor = new ComboBox();
            nudYear = new NumericUpDown();
            txtLicensePlate = new TextBox();
            txtVIN = new TextBox();
            listBoxCars = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            toolTip1 = new ToolTip(components);
            groupBoxSearch = new GroupBox();
            btnSearch = new Button();
            cmbSearchModel = new ComboBox();
            lblSearchModel = new Label();
            cmbSearchBrand = new ComboBox();
            lblSearchBrand = new Label();
            cmbBrand = new ComboBox();
            cmbModel = new ComboBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            groupBoxSearch.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Red", "Blue", "Green", "Yellow", "Black", "White", "Silver", "Other" });
            cmbColor.Location = new Point(123, 81);
            cmbColor.Margin = new Padding(4, 3, 4, 3);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(152, 23);
            cmbColor.TabIndex = 2;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(123, 112);
            nudYear.Margin = new Padding(4, 3, 4, 3);
            nudYear.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(153, 23);
            nudYear.TabIndex = 3;
            nudYear.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Location = new Point(123, 142);
            txtLicensePlate.Margin = new Padding(4, 3, 4, 3);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(152, 23);
            txtLicensePlate.TabIndex = 4;
            // 
            // txtVIN
            // 
            txtVIN.Location = new Point(123, 172);
            txtVIN.Margin = new Padding(4, 3, 4, 3);
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(152, 23);
            txtVIN.TabIndex = 5;
            // 
            // listBoxCars
            // 
            listBoxCars.FormattingEnabled = true;
            listBoxCars.ItemHeight = 15;
            listBoxCars.Location = new Point(331, 12);
            listBoxCars.Margin = new Padding(4, 3, 4, 3);
            listBoxCars.Name = "listBoxCars";
            listBoxCars.Size = new Size(268, 289);
            listBoxCars.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSpringGreen;
            btnAdd.Location = new Point(9, 217);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Salmon;
            btnRemove.Location = new Point(188, 217);
            btnRemove.Margin = new Padding(4, 3, 4, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(88, 27);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F);
            label1.Location = new Point(9, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 9;
            label1.Text = "Brand:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 10;
            label2.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 84);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 114);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 12;
            label4.Text = "Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 145);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 13;
            label5.Text = "License Plate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 175);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 14;
            label6.Text = "VIN:";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(btnSearch);
            groupBoxSearch.Controls.Add(cmbSearchModel);
            groupBoxSearch.Controls.Add(lblSearchModel);
            groupBoxSearch.Controls.Add(cmbSearchBrand);
            groupBoxSearch.Controls.Add(lblSearchBrand);
            groupBoxSearch.Location = new Point(13, 304);
            groupBoxSearch.Margin = new Padding(4, 3, 4, 3);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Padding = new Padding(4, 3, 4, 3);
            groupBoxSearch.Size = new Size(586, 126);
            groupBoxSearch.TabIndex = 16;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.InactiveCaption;
            btnSearch.Location = new Point(250, 51);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 27);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbSearchModel
            // 
            cmbSearchModel.FormattingEnabled = true;
            cmbSearchModel.Location = new Point(82, 69);
            cmbSearchModel.Margin = new Padding(4, 3, 4, 3);
            cmbSearchModel.Name = "cmbSearchModel";
            cmbSearchModel.Size = new Size(140, 23);
            cmbSearchModel.TabIndex = 3;
            // 
            // lblSearchModel
            // 
            lblSearchModel.AutoSize = true;
            lblSearchModel.Location = new Point(28, 73);
            lblSearchModel.Margin = new Padding(4, 0, 4, 0);
            lblSearchModel.Name = "lblSearchModel";
            lblSearchModel.Size = new Size(44, 15);
            lblSearchModel.TabIndex = 2;
            lblSearchModel.Text = "Model:";
            // 
            // cmbSearchBrand
            // 
            cmbSearchBrand.FormattingEnabled = true;
            cmbSearchBrand.Location = new Point(82, 29);
            cmbSearchBrand.Margin = new Padding(4, 3, 4, 3);
            cmbSearchBrand.Name = "cmbSearchBrand";
            cmbSearchBrand.Size = new Size(140, 23);
            cmbSearchBrand.TabIndex = 1;
            // 
            // lblSearchBrand
            // 
            lblSearchBrand.AutoSize = true;
            lblSearchBrand.Location = new Point(28, 32);
            lblSearchBrand.Margin = new Padding(4, 0, 4, 0);
            lblSearchBrand.Name = "lblSearchBrand";
            lblSearchBrand.Size = new Size(41, 15);
            lblSearchBrand.TabIndex = 0;
            lblSearchBrand.Text = "Brand:";
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(123, 15);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(152, 23);
            cmbBrand.TabIndex = 17;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(123, 45);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(152, 23);
            cmbModel.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbModel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbBrand);
            groupBox1.Controls.Add(cmbColor);
            groupBox1.Controls.Add(nudYear);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtLicensePlate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtVIN);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 289);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Car";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 442);
            Controls.Add(groupBoxSearch);
            Controls.Add(listBoxCars);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Car Management App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox cmbSearchModel;
        private System.Windows.Forms.Label lblSearchModel;
        private System.Windows.Forms.ComboBox cmbSearchBrand;
        private System.Windows.Forms.Label lblSearchBrand;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbModel;
        private GroupBox groupBox1;
    }
}
