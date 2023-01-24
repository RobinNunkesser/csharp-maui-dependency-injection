namespace DependencyInjection;

public partial class MainPage : ContentPage
{
    readonly MainViewModel _viewModel;

    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = _viewModel = viewModel;
    }
}
