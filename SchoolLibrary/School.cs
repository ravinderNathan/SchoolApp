using System;
using System.Text;

namespace SchoolLibrary
{
	public class School
	{
		public String Name { get; set; }
		public String Address	 { get; set; }
		public String City { get; set; }
		public String State { get; set; }
		public String PhoneNumber { get; set; }
		
		private String _twitterAddress;
		public string TwitterAddress
		{
			// Make sUsre starts with @
			get { return _twitterAddress; }
			set {
				if (value.StartsWith("@"))
				{
					_twitterAddress = value;
				}
				else
				{
					throw new Exception("The Twitter Address is Wrong, It should start with @");
				
				}
					
				}		
		}

		//ctor >> Constructor	
				  public School()
						{
							Name = "Sainik School";
						}
				public School(String Schoolname, String SchPhoneNumber)
				{
					Name = Schoolname;
					PhoneNumber = SchPhoneNumber;
				}

		public static float averageThreeScores(float a, float b, float c)
		{

			var result = (a + b + c) / 3;
			return result;
		}


		public static string averageThreeScores(string A, string b) => (A + b);

		public static int averageThreeScores(int a, int b, int c)
		{
			var result = (a + b + c) / 3;
			return result;

		}

		public override string ToString()
		{
			var sb =new StringBuilder();
			sb.AppendLine(this.Name);
			sb.AppendLine(this.Address);
			sb.AppendLine(", ");
			sb.AppendLine(this.City);
			sb.AppendLine(", ");
			sb.AppendLine(this.State);
			return sb.ToString();
		}


	}

}
