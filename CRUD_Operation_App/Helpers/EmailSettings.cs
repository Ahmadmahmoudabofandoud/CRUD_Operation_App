using CRUD.DAL.Models;
using System.Net;
using System.Net.Mail;

namespace CRUD_Operation_App.Helpers
{
	public static class EmailSettings
	{
		public static void SendEmail(Email email)
		{
			var client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true;
			client.Credentials = new NetworkCredential("ahmedfandoud077@gmail.com", "ypaudbofjfhggswr");
			client.Send("ahmedfandoud077@gmail.com",email.Recipients,email.Subject,email.Body);
		}
	}
}
