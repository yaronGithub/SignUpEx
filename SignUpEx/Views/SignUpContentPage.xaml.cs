namespace SignUpEx;

public partial class SignUpContentPage : ContentPage
{
	public SignUpContentPage()
	{
		InitializeComponent();
		this.BindingContext = new SignUpViewModel();
	}
}