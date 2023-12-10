namespace WinFormsApp1
{

	public partial class Form1 : Form
	{
		public class Meeting
		{
			public int Id { get; set; }
			public string Title { get; set; }
			public String Date { get; set; }
			public string Description { get; set; }
			public string Code { get; set; }
			public Meeting()
			{

			}
			public Meeting(int ýd, string title, DateTime date, string description, string code)
			{
				Id = ýd;
				Title = title;
				Date = Date;
				Description = description;
				Code = code;
			}

		}
		string meetingDate;
		public class User
		{
			public string Name { get; set; }

			public User(string name)
			{
				Name = name;
			}
		}

		public class MeetingCode
		{
			public int MeetingId { get; set; }
			public string Code { get; set; }
		}

		public class AvailableTime
		{
			public string Name { get; set; }
			public string Date { get; set; }
			public string MeetingCode { get; set; }
			public AvailableTime(string name, string date, string meetingCode)
			{
				Name = name;
				Date = date;
				MeetingCode = meetingCode;
			}

		}

		public Form1()
		{
			InitializeComponent();
			users.Add(new User("Ali"));
			users.Add(new User("Ayþe"));
			users.Add(new User("Mehmet"));
			users.Add(new User("Merve"));
		}


		// read from file
		List<Meeting> meets = new List<Meeting>();
		List<User> users = new List<User>();
		List<MeetingCode> meetingCodes = new List<MeetingCode>();
		List<AvailableTime> availableTimes = new List<AvailableTime>();



		private void meetingAddBtn_Click(object sender, EventArgs e)
		{
			string meetingCode = generateMeetingCode();
			Meeting meeting = new Meeting()
			{
				Id = 1,
				Description = descriptionTxt.Text,
				Date = meetingDate,
				Title = titleTxt.Text,
				Code = meetingCode
			};
			titleTxt.Clear();
			descriptionTxt.Clear();
			meets.Add(meeting);

			meetingCodes.Add(new MeetingCode { Code = meetingCode, MeetingId = meeting.Id });

			meetingCodeLbl.Text = meetingCode;
			meetingCodeLbl.Visible = true;
			meetingList.Items.Add($"Baþlýk: {meeting.Title}, Tarih:{meeting.Date}, Toplantý Kodu: {meeting.Code}, Açýklama: {meeting.Description}");
		}

		private string generateMeetingCode()
		{
			Random random = new Random();
			int code = random.Next(100000, 999999);
			return code.ToString();
		}

		private void addAvailableTimeBtn_Click(object sender, EventArgs e)
		{
			string name = nameForAvailableTimeTxt.Text;


		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			selectedDateLbl.Text = e.Start.ToShortDateString();
			selectedDateLbl.Visible = true;
			string meetingCode = meetingCodeTxt.Text;
			string name = nameForAvailableTimeTxt.Text;
			AvailableTime availableTime = new AvailableTime(name, e.Start.ToShortDateString().ToString(), meetingCode);
			availableTimes.Add(availableTime);
			writeToFile("./availableTimes.txt", availableTimes.ToString());

		}

		private void writeToFile(string path, string text)
		{
			using (StreamWriter writer = new StreamWriter(path))
			{
				writer.WriteLine(text);
			}
		}

		private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
		{
			meetingDate = e.Start.ToLongDateString().ToString();
		}
	}
}