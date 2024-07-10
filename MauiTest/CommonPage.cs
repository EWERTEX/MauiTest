namespace MauiTest;

public class CommonPage : ContentPage
{
    public CommonPage()
    {
        Title = "Common";
        Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };
        Label label = new Label { Text = "Lorem Ipsum is simply dummy text of the printing..." };
        //  ������� � ������� �������� �����
        backButton.Clicked += async (o, e) => await Navigation.PopAsync();
        Content = new StackLayout { Children = { label, backButton } };
    }
}