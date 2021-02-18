namespace Table
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.freeTimeListBox = new System.Windows.Forms.ListBox();
            this.deleteSubjectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.freeTimeButton = new System.Windows.Forms.Button();
            this.freeTimeBox = new System.Windows.Forms.ComboBox();
            this.deleteBox = new System.Windows.Forms.ComboBox();
            this.endSubjectBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.startSubjectBox = new System.Windows.Forms.ComboBox();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.subjectNameBox = new System.Windows.Forms.TextBox();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.cleerFreeTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // freeTimeListBox
            // 
            this.freeTimeListBox.BackColor = System.Drawing.Color.AliceBlue;
            this.freeTimeListBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.freeTimeListBox.ForeColor = System.Drawing.Color.Black;
            this.freeTimeListBox.FormattingEnabled = true;
            this.freeTimeListBox.ItemHeight = 21;
            this.freeTimeListBox.Location = new System.Drawing.Point(788, 12);
            this.freeTimeListBox.Name = "freeTimeListBox";
            this.freeTimeListBox.Size = new System.Drawing.Size(219, 193);
            this.freeTimeListBox.TabIndex = 0;
            this.freeTimeListBox.SelectedIndexChanged += new System.EventHandler(this.freeTimeListBox_SelectedIndexChanged);
            // 
            // deleteSubjectButton
            // 
            this.deleteSubjectButton.BackColor = System.Drawing.Color.LightGray;
            this.deleteSubjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSubjectButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.deleteSubjectButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteSubjectButton.Location = new System.Drawing.Point(1189, 254);
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(88, 33);
            this.deleteSubjectButton.TabIndex = 5;
            this.deleteSubjectButton.Text = "Delete";
            this.deleteSubjectButton.UseVisualStyleBackColor = false;
            this.deleteSubjectButton.Click += new System.EventHandler(this.deleteSubjectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1013, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subject Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1055, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1050, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(672, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Free Time One Day";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1060, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Delete Subject";
            // 
            // freeTimeButton
            // 
            this.freeTimeButton.BackColor = System.Drawing.Color.LightGray;
            this.freeTimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freeTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.freeTimeButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.freeTimeButton.ForeColor = System.Drawing.Color.Black;
            this.freeTimeButton.Location = new System.Drawing.Point(844, 264);
            this.freeTimeButton.Name = "freeTimeButton";
            this.freeTimeButton.Size = new System.Drawing.Size(127, 35);
            this.freeTimeButton.TabIndex = 15;
            this.freeTimeButton.Text = "FreeTime";
            this.freeTimeButton.UseVisualStyleBackColor = false;
            this.freeTimeButton.Click += new System.EventHandler(this.freeTimeButton_Click);
            // 
            // freeTimeBox
            // 
            this.freeTimeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.freeTimeBox.FormattingEnabled = true;
            this.freeTimeBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.freeTimeBox.Location = new System.Drawing.Point(816, 227);
            this.freeTimeBox.Name = "freeTimeBox";
            this.freeTimeBox.Size = new System.Drawing.Size(177, 24);
            this.freeTimeBox.TabIndex = 17;
            this.freeTimeBox.SelectedIndexChanged += new System.EventHandler(this.freeTimeBox_SelectedIndexChanged);
            // 
            // deleteBox
            // 
            this.deleteBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBox.FormattingEnabled = true;
            this.deleteBox.Location = new System.Drawing.Point(1168, 224);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(137, 24);
            this.deleteBox.TabIndex = 19;
            this.deleteBox.SelectedIndexChanged += new System.EventHandler(this.deleteBox_SelectedIndexChanged);
            // 
            // endSubjectBox
            // 
            this.endSubjectBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endSubjectBox.FormattingEnabled = true;
            this.endSubjectBox.Items.AddRange(new object[] {
            "8.45",
            "9.45",
            "10.45",
            "11.45",
            "12.45",
            "13.45",
            "14.45",
            "15.45"});
            this.endSubjectBox.Location = new System.Drawing.Point(1235, 97);
            this.endSubjectBox.Name = "endSubjectBox";
            this.endSubjectBox.Size = new System.Drawing.Size(70, 24);
            this.endSubjectBox.TabIndex = 20;
            this.endSubjectBox.SelectedIndexChanged += new System.EventHandler(this.endSubjectBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(1197, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "End";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(633, 193);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "  Saturday";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "  Sunday";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "  Monday";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "  Tuesday";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "  Wednesday";
            this.Column5.Name = "Column5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(681, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "The free time";
            // 
            // startSubjectBox
            // 
            this.startSubjectBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startSubjectBox.FormattingEnabled = true;
            this.startSubjectBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.startSubjectBox.Location = new System.Drawing.Point(1119, 97);
            this.startSubjectBox.Name = "startSubjectBox";
            this.startSubjectBox.Size = new System.Drawing.Size(72, 24);
            this.startSubjectBox.TabIndex = 25;
            this.startSubjectBox.SelectedIndexChanged += new System.EventHandler(this.startSubjectBox_SelectedIndexChanged);
            // 
            // dayBox
            // 
            this.dayBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.dayBox.Location = new System.Drawing.Point(1119, 57);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(186, 24);
            this.dayBox.TabIndex = 26;
            this.dayBox.SelectedIndexChanged += new System.EventHandler(this.dayBox_SelectedIndexChanged);
            // 
            // subjectNameBox
            // 
            this.subjectNameBox.Location = new System.Drawing.Point(1119, 14);
            this.subjectNameBox.Name = "subjectNameBox";
            this.subjectNameBox.Size = new System.Drawing.Size(186, 24);
            this.subjectNameBox.TabIndex = 27;
            this.subjectNameBox.TextChanged += new System.EventHandler(this.subjectNameBox_TextChanged);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.BackColor = System.Drawing.Color.LightGray;
            this.addSubjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSubjectButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.addSubjectButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addSubjectButton.Location = new System.Drawing.Point(1119, 137);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(186, 29);
            this.addSubjectButton.TabIndex = 28;
            this.addSubjectButton.Text = "Add";
            this.addSubjectButton.UseVisualStyleBackColor = false;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // cleerFreeTime
            // 
            this.cleerFreeTime.BackColor = System.Drawing.Color.LightGray;
            this.cleerFreeTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleerFreeTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cleerFreeTime.Location = new System.Drawing.Point(869, 305);
            this.cleerFreeTime.Name = "cleerFreeTime";
            this.cleerFreeTime.Size = new System.Drawing.Size(75, 23);
            this.cleerFreeTime.TabIndex = 29;
            this.cleerFreeTime.Text = "cleer";
            this.cleerFreeTime.UseVisualStyleBackColor = false;
            this.cleerFreeTime.Click += new System.EventHandler(this.cleerFreeTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1338, 367);
            this.Controls.Add(this.cleerFreeTime);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.subjectNameBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.startSubjectBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endSubjectBox);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.freeTimeBox);
            this.Controls.Add(this.freeTimeButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteSubjectButton);
            this.Controls.Add(this.freeTimeListBox);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Student subjects table";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox freeTimeListBox;
        private System.Windows.Forms.Button deleteSubjectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button freeTimeButton;
        private System.Windows.Forms.ComboBox freeTimeBox;
        private System.Windows.Forms.ComboBox deleteBox;
        private System.Windows.Forms.ComboBox endSubjectBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox startSubjectBox;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.TextBox subjectNameBox;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button cleerFreeTime;

    }
}

