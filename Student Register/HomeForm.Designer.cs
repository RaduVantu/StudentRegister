
namespace Student_Register
{
    partial class HomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.StudentsButton = new System.Windows.Forms.Button();
            this.AddStuButton = new System.Windows.Forms.Button();
            this.TeachersButton = new System.Windows.Forms.Button();
            this.TimetableslButton = new System.Windows.Forms.Button();
            this.ContactsButton = new System.Windows.Forms.Button();
            this.StudentSearchBarTb = new System.Windows.Forms.TextBox();
            this.TeacherSearchBarTb = new System.Windows.Forms.TextBox();
            this.ExitAppBtn = new System.Windows.Forms.Button();
            this.SubmitStuSearchButton = new System.Windows.Forms.Button();
            this.ShowAllStuButton = new System.Windows.Forms.Button();
            this.StudentSearchResultsGV = new System.Windows.Forms.DataGridView();
            this.StudentIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoBColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherSearchResultsGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLbl = new System.Windows.Forms.Label();
            this.TeacherLbl = new System.Windows.Forms.Label();
            this.SubmitTeacherSearchButton = new System.Windows.Forms.Button();
            this.ShowAllTeachersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentSearchResultsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherSearchResultsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsButton
            // 
            this.StudentsButton.BackColor = System.Drawing.Color.DarkBlue;
            this.StudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.StudentsButton.Location = new System.Drawing.Point(12, 33);
            this.StudentsButton.MaximumSize = new System.Drawing.Size(250, 100);
            this.StudentsButton.MinimumSize = new System.Drawing.Size(250, 100);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(250, 100);
            this.StudentsButton.TabIndex = 0;
            this.StudentsButton.Text = "Students";
            this.StudentsButton.UseVisualStyleBackColor = false;
            this.StudentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
            // 
            // AddStuButton
            // 
            this.AddStuButton.BackColor = System.Drawing.Color.DarkBlue;
            this.AddStuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStuButton.ForeColor = System.Drawing.Color.Gold;
            this.AddStuButton.Location = new System.Drawing.Point(280, 473);
            this.AddStuButton.MaximumSize = new System.Drawing.Size(300, 65);
            this.AddStuButton.MinimumSize = new System.Drawing.Size(400, 65);
            this.AddStuButton.Name = "AddStuButton";
            this.AddStuButton.Size = new System.Drawing.Size(400, 65);
            this.AddStuButton.TabIndex = 1;
            this.AddStuButton.Text = "+ Add New Student";
            this.AddStuButton.UseVisualStyleBackColor = false;
            this.AddStuButton.Click += new System.EventHandler(this.AddStuButton_Click);
            // 
            // TeachersButton
            // 
            this.TeachersButton.BackColor = System.Drawing.Color.DarkBlue;
            this.TeachersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeachersButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TeachersButton.Location = new System.Drawing.Point(12, 168);
            this.TeachersButton.MaximumSize = new System.Drawing.Size(250, 100);
            this.TeachersButton.MinimumSize = new System.Drawing.Size(250, 100);
            this.TeachersButton.Name = "TeachersButton";
            this.TeachersButton.Size = new System.Drawing.Size(250, 100);
            this.TeachersButton.TabIndex = 2;
            this.TeachersButton.Text = "Teachers";
            this.TeachersButton.UseVisualStyleBackColor = false;
            this.TeachersButton.Click += new System.EventHandler(this.TeachersButton_Click);
            // 
            // TimetableslButton
            // 
            this.TimetableslButton.BackColor = System.Drawing.Color.DarkBlue;
            this.TimetableslButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimetableslButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TimetableslButton.Location = new System.Drawing.Point(12, 303);
            this.TimetableslButton.MaximumSize = new System.Drawing.Size(250, 100);
            this.TimetableslButton.MinimumSize = new System.Drawing.Size(250, 100);
            this.TimetableslButton.Name = "TimetableslButton";
            this.TimetableslButton.Size = new System.Drawing.Size(250, 100);
            this.TimetableslButton.TabIndex = 3;
            this.TimetableslButton.Text = "Timetables";
            this.TimetableslButton.UseVisualStyleBackColor = false;
            this.TimetableslButton.Click += new System.EventHandler(this.TimetablesButton_Click);
            // 
            // ContactsButton
            // 
            this.ContactsButton.BackColor = System.Drawing.Color.DarkBlue;
            this.ContactsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ContactsButton.Location = new System.Drawing.Point(12, 438);
            this.ContactsButton.MaximumSize = new System.Drawing.Size(250, 100);
            this.ContactsButton.MinimumSize = new System.Drawing.Size(250, 100);
            this.ContactsButton.Name = "ContactsButton";
            this.ContactsButton.Size = new System.Drawing.Size(250, 100);
            this.ContactsButton.TabIndex = 4;
            this.ContactsButton.Text = "Contacts";
            this.ContactsButton.UseVisualStyleBackColor = false;
            this.ContactsButton.Click += new System.EventHandler(this.ContactsButton_Click);
            // 
            // StudentSearchBarTb
            // 
            this.StudentSearchBarTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentSearchBarTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSearchBarTb.Location = new System.Drawing.Point(280, 93);
            this.StudentSearchBarTb.Name = "StudentSearchBarTb";
            this.StudentSearchBarTb.Size = new System.Drawing.Size(526, 44);
            this.StudentSearchBarTb.TabIndex = 5;
            this.StudentSearchBarTb.Tag = "";
            this.StudentSearchBarTb.Visible = false;
            this.StudentSearchBarTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentSearchBarTb_KeyPress);
            // 
            // TeacherSearchBarTb
            // 
            this.TeacherSearchBarTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeacherSearchBarTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherSearchBarTb.Location = new System.Drawing.Point(280, 92);
            this.TeacherSearchBarTb.Name = "TeacherSearchBarTb";
            this.TeacherSearchBarTb.Size = new System.Drawing.Size(526, 44);
            this.TeacherSearchBarTb.TabIndex = 16;
            this.TeacherSearchBarTb.Tag = "";
            this.TeacherSearchBarTb.Visible = false;
            this.TeacherSearchBarTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeacherSearchBarTb_KeyPress);
            // 
            // ExitAppBtn
            // 
            this.ExitAppBtn.BackColor = System.Drawing.Color.Red;
            this.ExitAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitAppBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitAppBtn.Location = new System.Drawing.Point(1018, 487);
            this.ExitAppBtn.Name = "ExitAppBtn";
            this.ExitAppBtn.Size = new System.Drawing.Size(147, 51);
            this.ExitAppBtn.TabIndex = 10;
            this.ExitAppBtn.Text = "Close";
            this.ExitAppBtn.UseVisualStyleBackColor = false;
            this.ExitAppBtn.Click += new System.EventHandler(this.ExitAppBtn_Click);
            // 
            // SubmitStuSearchButton
            // 
            this.SubmitStuSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitStuSearchButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SubmitStuSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitStuSearchButton.Location = new System.Drawing.Point(819, 93);
            this.SubmitStuSearchButton.Name = "SubmitStuSearchButton";
            this.SubmitStuSearchButton.Size = new System.Drawing.Size(132, 44);
            this.SubmitStuSearchButton.TabIndex = 8;
            this.SubmitStuSearchButton.Text = "Search";
            this.SubmitStuSearchButton.UseVisualStyleBackColor = false;
            this.SubmitStuSearchButton.Visible = false;
            this.SubmitStuSearchButton.Click += new System.EventHandler(this.SubmitStuSearchButton_Click);
            // 
            // ShowAllStuButton
            // 
            this.ShowAllStuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllStuButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ShowAllStuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllStuButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowAllStuButton.Location = new System.Drawing.Point(957, 93);
            this.ShowAllStuButton.Name = "ShowAllStuButton";
            this.ShowAllStuButton.Size = new System.Drawing.Size(170, 44);
            this.ShowAllStuButton.TabIndex = 11;
            this.ShowAllStuButton.Text = "Show All";
            this.ShowAllStuButton.UseVisualStyleBackColor = false;
            this.ShowAllStuButton.Visible = false;
            this.ShowAllStuButton.Click += new System.EventHandler(this.ShowAllStuButton_Click);
            // 
            // StudentSearchResultsGV
            // 
            this.StudentSearchResultsGV.AllowUserToAddRows = false;
            this.StudentSearchResultsGV.AllowUserToDeleteRows = false;
            this.StudentSearchResultsGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.StudentSearchResultsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentSearchResultsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentSearchResultsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentSearchResultsGV.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentSearchResultsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentSearchResultsGV.ColumnHeadersHeight = 25;
            this.StudentSearchResultsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudentSearchResultsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentIdCol,
            this.TitleColumn,
            this.SurnameColumn,
            this.FirstNameColumn,
            this.DoBColumn,
            this.CourseColumn,
            this.AcademicYearColumn});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentSearchResultsGV.DefaultCellStyle = dataGridViewCellStyle10;
            this.StudentSearchResultsGV.EnableHeadersVisualStyles = false;
            this.StudentSearchResultsGV.GridColor = System.Drawing.Color.White;
            this.StudentSearchResultsGV.Location = new System.Drawing.Point(280, 156);
            this.StudentSearchResultsGV.Margin = new System.Windows.Forms.Padding(4);
            this.StudentSearchResultsGV.MaximumSize = new System.Drawing.Size(885, 310);
            this.StudentSearchResultsGV.MinimumSize = new System.Drawing.Size(885, 310);
            this.StudentSearchResultsGV.MultiSelect = false;
            this.StudentSearchResultsGV.Name = "StudentSearchResultsGV";
            this.StudentSearchResultsGV.ReadOnly = true;
            this.StudentSearchResultsGV.RowHeadersVisible = false;
            this.StudentSearchResultsGV.RowHeadersWidth = 62;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.StudentSearchResultsGV.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.StudentSearchResultsGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentSearchResultsGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentSearchResultsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentSearchResultsGV.ShowEditingIcon = false;
            this.StudentSearchResultsGV.Size = new System.Drawing.Size(885, 310);
            this.StudentSearchResultsGV.TabIndex = 12;
            this.StudentSearchResultsGV.Visible = false;
            this.StudentSearchResultsGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentSearchResultsGV_CellDoubleClick);
            this.StudentSearchResultsGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentSearchResultsGV_KeyPress);
            // 
            // StudentIdCol
            // 
            this.StudentIdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StudentIdCol.DataPropertyName = "StudentId";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentIdCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentIdCol.HeaderText = "Student ID";
            this.StudentIdCol.MinimumWidth = 8;
            this.StudentIdCol.Name = "StudentIdCol";
            this.StudentIdCol.ReadOnly = true;
            this.StudentIdCol.Width = 130;
            // 
            // TitleColumn
            // 
            this.TitleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TitleColumn.DataPropertyName = "Title";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TitleColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.MinimumWidth = 8;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            this.TitleColumn.Width = 81;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.DataPropertyName = "Surname";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SurnameColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.SurnameColumn.HeaderText = "Surname";
            this.SurnameColumn.MinimumWidth = 8;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.DataPropertyName = "FirstName";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FirstNameColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.FirstNameColumn.HeaderText = "First Name";
            this.FirstNameColumn.MinimumWidth = 8;
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.ReadOnly = true;
            // 
            // DoBColumn
            // 
            this.DoBColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DoBColumn.DataPropertyName = "DoB";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DoBColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.DoBColumn.HeaderText = "DoB";
            this.DoBColumn.MinimumWidth = 8;
            this.DoBColumn.Name = "DoBColumn";
            this.DoBColumn.ReadOnly = true;
            this.DoBColumn.Width = 81;
            // 
            // CourseColumn
            // 
            this.CourseColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CourseColumn.DataPropertyName = "Course";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CourseColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.CourseColumn.HeaderText = "Course";
            this.CourseColumn.MinimumWidth = 8;
            this.CourseColumn.Name = "CourseColumn";
            this.CourseColumn.ReadOnly = true;
            this.CourseColumn.Width = 104;
            // 
            // AcademicYearColumn
            // 
            this.AcademicYearColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AcademicYearColumn.DataPropertyName = "AcademicYear";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AcademicYearColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.AcademicYearColumn.HeaderText = "Year";
            this.AcademicYearColumn.MinimumWidth = 8;
            this.AcademicYearColumn.Name = "AcademicYearColumn";
            this.AcademicYearColumn.ReadOnly = true;
            this.AcademicYearColumn.Width = 84;
            // 
            // TeacherSearchResultsGV
            // 
            this.TeacherSearchResultsGV.AllowUserToAddRows = false;
            this.TeacherSearchResultsGV.AllowUserToDeleteRows = false;
            this.TeacherSearchResultsGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.TeacherSearchResultsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.TeacherSearchResultsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeacherSearchResultsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherSearchResultsGV.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherSearchResultsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.TeacherSearchResultsGV.ColumnHeadersHeight = 25;
            this.TeacherSearchResultsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TeacherSearchResultsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherSearchResultsGV.DefaultCellStyle = dataGridViewCellStyle14;
            this.TeacherSearchResultsGV.EnableHeadersVisualStyles = false;
            this.TeacherSearchResultsGV.GridColor = System.Drawing.Color.White;
            this.TeacherSearchResultsGV.Location = new System.Drawing.Point(280, 156);
            this.TeacherSearchResultsGV.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherSearchResultsGV.MaximumSize = new System.Drawing.Size(885, 310);
            this.TeacherSearchResultsGV.MinimumSize = new System.Drawing.Size(885, 310);
            this.TeacherSearchResultsGV.MultiSelect = false;
            this.TeacherSearchResultsGV.Name = "TeacherSearchResultsGV";
            this.TeacherSearchResultsGV.ReadOnly = true;
            this.TeacherSearchResultsGV.RowHeadersVisible = false;
            this.TeacherSearchResultsGV.RowHeadersWidth = 62;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherSearchResultsGV.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.TeacherSearchResultsGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherSearchResultsGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherSearchResultsGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TeacherSearchResultsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeacherSearchResultsGV.ShowEditingIcon = false;
            this.TeacherSearchResultsGV.Size = new System.Drawing.Size(885, 310);
            this.TeacherSearchResultsGV.TabIndex = 13;
            this.TeacherSearchResultsGV.Visible = false;
            this.TeacherSearchResultsGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherSearchResultsGV_CellDoubleClick);
            this.TeacherSearchResultsGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeacherSearchResultsGV_KeyPress);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "TeacherCode";
            this.Column1.HeaderText = "Teacher Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 132;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Title";
            this.Column2.HeaderText = "Title";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 81;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Surname";
            this.Column3.HeaderText = "Surname";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 118;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "FirstName";
            this.Column4.HeaderText = "First Name";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 133;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Courses";
            this.Column5.HeaderText = "Course(s)";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Specialization";
            this.Column6.HeaderText = "Specialization";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // StudentLbl
            // 
            this.StudentLbl.AutoSize = true;
            this.StudentLbl.BackColor = System.Drawing.Color.Transparent;
            this.StudentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLbl.Location = new System.Drawing.Point(280, 33);
            this.StudentLbl.Name = "StudentLbl";
            this.StudentLbl.Size = new System.Drawing.Size(251, 37);
            this.StudentLbl.TabIndex = 14;
            this.StudentLbl.Text = "Search Student";
            // 
            // TeacherLbl
            // 
            this.TeacherLbl.AutoSize = true;
            this.TeacherLbl.BackColor = System.Drawing.Color.Transparent;
            this.TeacherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherLbl.Location = new System.Drawing.Point(280, 33);
            this.TeacherLbl.Name = "TeacherLbl";
            this.TeacherLbl.Size = new System.Drawing.Size(258, 37);
            this.TeacherLbl.TabIndex = 15;
            this.TeacherLbl.Text = "Search Teacher";
            // 
            // SubmitTeacherSearchButton
            // 
            this.SubmitTeacherSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitTeacherSearchButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SubmitTeacherSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitTeacherSearchButton.Location = new System.Drawing.Point(819, 92);
            this.SubmitTeacherSearchButton.Name = "SubmitTeacherSearchButton";
            this.SubmitTeacherSearchButton.Size = new System.Drawing.Size(132, 44);
            this.SubmitTeacherSearchButton.TabIndex = 17;
            this.SubmitTeacherSearchButton.Text = "Search";
            this.SubmitTeacherSearchButton.UseVisualStyleBackColor = false;
            this.SubmitTeacherSearchButton.Visible = false;
            this.SubmitTeacherSearchButton.Click += new System.EventHandler(this.SubmitTeacherSearchButton_Click);
            // 
            // ShowAllTeachersButton
            // 
            this.ShowAllTeachersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllTeachersButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ShowAllTeachersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllTeachersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowAllTeachersButton.Location = new System.Drawing.Point(957, 93);
            this.ShowAllTeachersButton.Name = "ShowAllTeachersButton";
            this.ShowAllTeachersButton.Size = new System.Drawing.Size(170, 44);
            this.ShowAllTeachersButton.TabIndex = 18;
            this.ShowAllTeachersButton.Text = "Show All";
            this.ShowAllTeachersButton.UseVisualStyleBackColor = false;
            this.ShowAllTeachersButton.Visible = false;
            this.ShowAllTeachersButton.Click += new System.EventHandler(this.ShowAllTeachersButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Student_Register.Properties.Resources.HomeFormBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 550);
            this.ControlBox = false;
            this.Controls.Add(this.ShowAllTeachersButton);
            this.Controls.Add(this.SubmitTeacherSearchButton);
            this.Controls.Add(this.TeacherSearchBarTb);
            this.Controls.Add(this.TeacherLbl);
            this.Controls.Add(this.StudentLbl);
            this.Controls.Add(this.TeacherSearchResultsGV);
            this.Controls.Add(this.StudentSearchResultsGV);
            this.Controls.Add(this.ShowAllStuButton);
            this.Controls.Add(this.ExitAppBtn);
            this.Controls.Add(this.SubmitStuSearchButton);
            this.Controls.Add(this.StudentSearchBarTb);
            this.Controls.Add(this.ContactsButton);
            this.Controls.Add(this.TimetableslButton);
            this.Controls.Add(this.TeachersButton);
            this.Controls.Add(this.AddStuButton);
            this.Controls.Add(this.StudentsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1207, 606);
            this.MinimumSize = new System.Drawing.Size(1207, 606);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Science College Register";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentSearchResultsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherSearchResultsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentsButton;
        private System.Windows.Forms.Button AddStuButton;
        private System.Windows.Forms.Button TeachersButton;
        private System.Windows.Forms.Button TimetableslButton;
        private System.Windows.Forms.Button ContactsButton;
        private System.Windows.Forms.TextBox StudentSearchBarTb;
        private System.Windows.Forms.Button ExitAppBtn;
        private System.Windows.Forms.Button SubmitStuSearchButton;
        private System.Windows.Forms.Button ShowAllStuButton;
        private System.Windows.Forms.DataGridView StudentSearchResultsGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoBColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYearColumn;
        private System.Windows.Forms.DataGridView TeacherSearchResultsGV;
        private System.Windows.Forms.Label StudentLbl;
        private System.Windows.Forms.Label TeacherLbl;
        private System.Windows.Forms.TextBox TeacherSearchBarTb;
        private System.Windows.Forms.Button SubmitTeacherSearchButton;
        private System.Windows.Forms.Button ShowAllTeachersButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

