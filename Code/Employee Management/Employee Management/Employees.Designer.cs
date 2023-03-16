namespace Employee_Management
{
    partial class Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblusername = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.deptTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDBDataSet1 = new Employee_Management.EmployeeDBDataSet1();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.joinDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.employeeDBDataSet = new Employee_Management.EmployeeDBDataSet();
            this.employeeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTblTableAdapter = new Employee_Management.EmployeeDBDataSetTableAdapters.EmployeeTblTableAdapter();
            this.deptTableTableAdapter = new Employee_Management.EmployeeDBDataSet1TableAdapters.DeptTableTableAdapter();
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deptTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(8, 22);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(99, 15);
            this.lblusername.TabIndex = 35;
            this.lblusername.Text = "Employee Name";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.White;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textName.Location = new System.Drawing.Point(12, 40);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(183, 21);
            this.textName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Employee Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Employee Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Join Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 16);
            this.panel2.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Employee Salary(Per Day)";
            // 
            // textSalary
            // 
            this.textSalary.BackColor = System.Drawing.Color.White;
            this.textSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textSalary.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textSalary.Location = new System.Drawing.Point(12, 294);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(183, 21);
            this.textSalary.TabIndex = 45;
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GendercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GendercomboBox.Location = new System.Drawing.Point(12, 92);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(183, 21);
            this.GendercomboBox.TabIndex = 47;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(12, 144);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(183, 21);
            this.departmentComboBox.TabIndex = 48;
            // 
            // deptTableBindingSource
            // 
            this.deptTableBindingSource.DataMember = "DeptTable";
            this.deptTableBindingSource.DataSource = this.employeeDBDataSet1;
            // 
            // employeeDBDataSet1
            // 
            this.employeeDBDataSet1.DataSetName = "EmployeeDBDataSet1";
            this.employeeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CalendarForeColor = System.Drawing.Color.DimGray;
            this.birthDatePicker.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.birthDatePicker.CalendarTitleBackColor = System.Drawing.Color.LightGray;
            this.birthDatePicker.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.birthDatePicker.CustomFormat = "yyyy-MM-dd";
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker.Location = new System.Drawing.Point(12, 193);
            this.birthDatePicker.MaxDate = new System.DateTime(2023, 2, 16, 5, 58, 31, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(183, 20);
            this.birthDatePicker.TabIndex = 50;
            this.birthDatePicker.Value = new System.DateTime(2023, 2, 13, 0, 0, 0, 0);
            // 
            // joinDatePicker
            // 
            this.joinDatePicker.CalendarForeColor = System.Drawing.Color.DimGray;
            this.joinDatePicker.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.joinDatePicker.CalendarTitleBackColor = System.Drawing.Color.LightGray;
            this.joinDatePicker.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.joinDatePicker.CustomFormat = "yyyy-MM-dd";
            this.joinDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.joinDatePicker.Location = new System.Drawing.Point(12, 241);
            this.joinDatePicker.MaxDate = new System.DateTime(2023, 2, 16, 0, 0, 0, 0);
            this.joinDatePicker.Name = "joinDatePicker";
            this.joinDatePicker.Size = new System.Drawing.Size(183, 20);
            this.joinDatePicker.TabIndex = 51;
            this.joinDatePicker.Value = new System.DateTime(2023, 2, 13, 0, 0, 0, 0);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(110, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 24);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 24);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.birthDatePicker);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.lblusername);
            this.panel3.Controls.Add(this.joinDatePicker);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textSalary);
            this.panel3.Controls.Add(this.departmentComboBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.GendercomboBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 512);
            this.panel3.TabIndex = 72;
            // 
            // employeeDBDataSet
            // 
            this.employeeDBDataSet.DataSetName = "EmployeeDBDataSet";
            this.employeeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTblBindingSource
            // 
            this.employeeTblBindingSource.DataMember = "EmployeeTbl";
            this.employeeTblBindingSource.DataSource = this.employeeDBDataSet;
            // 
            // employeeTblTableAdapter
            // 
            this.employeeTblTableAdapter.ClearBeforeFill = true;
            // 
            // deptTableTableAdapter
            // 
            this.deptTableTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeList
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.EmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeList.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeList.DefaultCellStyle = dataGridViewCellStyle18;
            this.EmployeeList.GridColor = System.Drawing.Color.DimGray;
            this.EmployeeList.Location = new System.Drawing.Point(222, 12);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeList.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.EmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeList.Size = new System.Drawing.Size(798, 317);
            this.EmployeeList.TabIndex = 66;
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 528);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deptTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.ComboBox GendercomboBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.DateTimePicker joinDatePicker;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private EmployeeDBDataSet employeeDBDataSet;
        private System.Windows.Forms.BindingSource employeeTblBindingSource;
        private EmployeeDBDataSetTableAdapters.EmployeeTblTableAdapter employeeTblTableAdapter;
        private EmployeeDBDataSet1 employeeDBDataSet1;
        private System.Windows.Forms.BindingSource deptTableBindingSource;
        private EmployeeDBDataSet1TableAdapters.DeptTableTableAdapter deptTableTableAdapter;
        private System.Windows.Forms.DataGridView EmployeeList;
    }
}