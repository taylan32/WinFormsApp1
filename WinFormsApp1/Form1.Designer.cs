namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			meetingList = new ListBox();
			meetingAddBtn = new Button();
			titleLbl = new Label();
			meetingDescriptionLbl = new Label();
			titleTxt = new TextBox();
			descriptionTxt = new TextBox();
			meetingCodeLabelLbl = new Label();
			meetingCodeLbl = new Label();
			addAvailableTimeBtn = new Button();
			nameForAvailableTimeTxt = new TextBox();
			nameLblForAvailableTime = new Label();
			monthCalendar1 = new MonthCalendar();
			label1 = new Label();
			selectedDateLbl = new Label();
			label2 = new Label();
			meetingCodeTxt = new TextBox();
			label3 = new Label();
			monthCalendar2 = new MonthCalendar();
			SuspendLayout();
			// 
			// meetingList
			// 
			meetingList.FormattingEnabled = true;
			meetingList.ItemHeight = 25;
			meetingList.Location = new Point(46, 505);
			meetingList.Name = "meetingList";
			meetingList.Size = new Size(1207, 154);
			meetingList.TabIndex = 0;
			// 
			// meetingAddBtn
			// 
			meetingAddBtn.Location = new Point(537, 49);
			meetingAddBtn.Name = "meetingAddBtn";
			meetingAddBtn.Size = new Size(185, 34);
			meetingAddBtn.TabIndex = 1;
			meetingAddBtn.Text = "Yeni Toplantı Oluştur";
			meetingAddBtn.UseVisualStyleBackColor = true;
			meetingAddBtn.Click += meetingAddBtn_Click;
			// 
			// titleLbl
			// 
			titleLbl.AutoSize = true;
			titleLbl.Location = new Point(46, 55);
			titleLbl.Name = "titleLbl";
			titleLbl.Size = new Size(56, 25);
			titleLbl.TabIndex = 2;
			titleLbl.Text = "Başlık";
			// 
			// meetingDescriptionLbl
			// 
			meetingDescriptionLbl.AutoSize = true;
			meetingDescriptionLbl.Location = new Point(46, 102);
			meetingDescriptionLbl.Name = "meetingDescriptionLbl";
			meetingDescriptionLbl.Size = new Size(83, 25);
			meetingDescriptionLbl.TabIndex = 3;
			meetingDescriptionLbl.Text = "Açıklama";
			// 
			// titleTxt
			// 
			titleTxt.Location = new Point(187, 52);
			titleTxt.Name = "titleTxt";
			titleTxt.Size = new Size(292, 31);
			titleTxt.TabIndex = 4;
			// 
			// descriptionTxt
			// 
			descriptionTxt.Location = new Point(187, 102);
			descriptionTxt.Multiline = true;
			descriptionTxt.Name = "descriptionTxt";
			descriptionTxt.Size = new Size(292, 114);
			descriptionTxt.TabIndex = 5;
			// 
			// meetingCodeLabelLbl
			// 
			meetingCodeLabelLbl.AutoSize = true;
			meetingCodeLabelLbl.Location = new Point(46, 9);
			meetingCodeLabelLbl.Name = "meetingCodeLabelLbl";
			meetingCodeLabelLbl.Size = new Size(121, 25);
			meetingCodeLabelLbl.TabIndex = 6;
			meetingCodeLabelLbl.Text = "Toplantı Kodu";
			// 
			// meetingCodeLbl
			// 
			meetingCodeLbl.AutoSize = true;
			meetingCodeLbl.Location = new Point(187, 9);
			meetingCodeLbl.Name = "meetingCodeLbl";
			meetingCodeLbl.Size = new Size(59, 25);
			meetingCodeLbl.TabIndex = 7;
			meetingCodeLbl.Text = "label2";
			meetingCodeLbl.Visible = false;
			// 
			// addAvailableTimeBtn
			// 
			addAvailableTimeBtn.Location = new Point(1027, 443);
			addAvailableTimeBtn.Name = "addAvailableTimeBtn";
			addAvailableTimeBtn.Size = new Size(185, 34);
			addAvailableTimeBtn.TabIndex = 8;
			addAvailableTimeBtn.Text = "Uygun Zaman Ekle";
			addAvailableTimeBtn.UseVisualStyleBackColor = true;
			addAvailableTimeBtn.Click += addAvailableTimeBtn_Click;
			// 
			// nameForAvailableTimeTxt
			// 
			nameForAvailableTimeTxt.Location = new Point(1062, 46);
			nameForAvailableTimeTxt.Name = "nameForAvailableTimeTxt";
			nameForAvailableTimeTxt.Size = new Size(150, 31);
			nameForAvailableTimeTxt.TabIndex = 9;
			// 
			// nameLblForAvailableTime
			// 
			nameLblForAvailableTime.AutoSize = true;
			nameLblForAvailableTime.Location = new Point(973, 49);
			nameLblForAvailableTime.Name = "nameLblForAvailableTime";
			nameLblForAvailableTime.Size = new Size(45, 25);
			nameLblForAvailableTime.TabIndex = 10;
			nameLblForAvailableTime.Text = "İsim";
			// 
			// monthCalendar1
			// 
			monthCalendar1.Location = new Point(973, 83);
			monthCalendar1.Name = "monthCalendar1";
			monthCalendar1.TabIndex = 11;
			monthCalendar1.DateChanged += monthCalendar1_DateChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(973, 361);
			label1.Name = "label1";
			label1.Size = new Size(107, 25);
			label1.TabIndex = 12;
			label1.Text = "Seçilen Tarih";
			// 
			// selectedDateLbl
			// 
			selectedDateLbl.AutoSize = true;
			selectedDateLbl.Location = new Point(1125, 361);
			selectedDateLbl.Name = "selectedDateLbl";
			selectedDateLbl.Size = new Size(59, 25);
			selectedDateLbl.TabIndex = 13;
			selectedDateLbl.Text = "label2";
			selectedDateLbl.Visible = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(973, 402);
			label2.Name = "label2";
			label2.Size = new Size(121, 25);
			label2.TabIndex = 14;
			label2.Text = "Toplantı Kodu";
			// 
			// meetingCodeTxt
			// 
			meetingCodeTxt.Location = new Point(1113, 396);
			meetingCodeTxt.Name = "meetingCodeTxt";
			meetingCodeTxt.Size = new Size(150, 31);
			meetingCodeTxt.TabIndex = 15;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(46, 259);
			label3.Name = "label3";
			label3.Size = new Size(48, 25);
			label3.TabIndex = 16;
			label3.Text = "Tarih";
			// 
			// monthCalendar2
			// 
			monthCalendar2.Location = new Point(187, 228);
			monthCalendar2.Name = "monthCalendar2";
			monthCalendar2.TabIndex = 17;
			monthCalendar2.DateChanged += monthCalendar2_DateChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1294, 707);
			Controls.Add(monthCalendar2);
			Controls.Add(label3);
			Controls.Add(meetingCodeTxt);
			Controls.Add(label2);
			Controls.Add(selectedDateLbl);
			Controls.Add(label1);
			Controls.Add(monthCalendar1);
			Controls.Add(nameLblForAvailableTime);
			Controls.Add(nameForAvailableTimeTxt);
			Controls.Add(addAvailableTimeBtn);
			Controls.Add(meetingCodeLbl);
			Controls.Add(meetingCodeLabelLbl);
			Controls.Add(descriptionTxt);
			Controls.Add(titleTxt);
			Controls.Add(meetingDescriptionLbl);
			Controls.Add(titleLbl);
			Controls.Add(meetingAddBtn);
			Controls.Add(meetingList);
			Name = "Form1";
			Text = "Toplantı";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox meetingList;
		private Button meetingAddBtn;
		private Label titleLbl;
		private Label meetingDescriptionLbl;
		private TextBox titleTxt;
		private TextBox descriptionTxt;
		private Label meetingCodeLabelLbl;
		private Label meetingCodeLbl;
		private Button addAvailableTimeBtn;
		private TextBox nameForAvailableTimeTxt;
		private Label nameLblForAvailableTime;
		private MonthCalendar monthCalendar1;
		private Label label1;
		private Label selectedDateLbl;
		private Label label2;
		private TextBox meetingCodeTxt;
		private Label label3;
		private MonthCalendar monthCalendar2;
	}
}