using MauiTest.CustomModels;

namespace MauiTest;

public partial class PersonPage : ContentPage
{
	private bool _edited = true;

	public User User { get; set; }

	public PersonPage(User? user)
	{
		InitializeComponent();

		if (user == null)
		{
			User = new User();
			_edited = false;
		}
		else
		{
			User = user;
		}
		BindingContext = User;
	}

    private async void SaveUser(object sender, EventArgs e)
    {
		await Navigation.PopToRootAsync();

		if(_edited == false && Application.Current?.MainPage is NavigationPage navigationPage)
		{
			var navigationStack = navigationPage.Navigation.NavigationStack;
			var pageCount = navigationStack.Count;
			if (navigationStack[pageCount - 1] is MainPage mainPage)
			{
				mainPage.AddUser(User);
			}
		}
    }
}