namespace MAUI_Aeropuertos.Views;
using MAUI_Aeropuertos.Models;
using MAUI_Aeropuertos.Services;

public partial class ListPage : ContentPage
{
    private readonly DatabaseService _databaseService;

    public ListPage(DatabaseService databaseService)
    {
        InitializeComponent();
        _databaseService = databaseService;
        LoadAeropuertos();
    }

    private async void LoadAeropuertos()
    {
        var aeropuertos = await _databaseService.GetAeropuertosAsync();
        lstAeropuertos.ItemsSource = aeropuertos;
    }
}
