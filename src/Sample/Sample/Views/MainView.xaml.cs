namespace Sample.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
	}

    void OnMenuBarButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MenuBarView());
    }

    void OnPointerGestureButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PointerGestureView());
    }

    void OnDragAndDropButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WindowsDragAndDropCustomization());
    }
}