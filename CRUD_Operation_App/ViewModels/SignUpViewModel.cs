using System.ComponentModel.DataAnnotations;

namespace CRUD_Operation_App.ViewModels
{
	public class SignUpViewModel
	{
		[Required(ErrorMessage ="UserName is Required")]
		[MinLength(5, ErrorMessage = "Minimum 5 karekter daxil edebilersiz")]
		[MaxLength(25, ErrorMessage = "Maxsimum 25 karater daxil ede bilersiz")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "First Name is Required")]

		public string FName { get; set; }
		[Required(ErrorMessage = "Last Name is Required")]

		public string LName { get; set; }


		[Required(ErrorMessage = "Email is Required")]
		[EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

		[Required(ErrorMessage ="Password is Required")]
		[MinLength(5,ErrorMessage ="Minimum Password Length is 5")]
		[DataType(DataType.Password)]
		public string Password { get; set; }


		[Required(ErrorMessage = "Confirm Password is Required")]
		[Compare(nameof(Password),ErrorMessage = " Confirm Password Does not match Password")]
		[DataType(DataType.Password)]
		public string ConfirmPassword { get; set;  }
		public bool IsAgree { get; set; }
	}
}
