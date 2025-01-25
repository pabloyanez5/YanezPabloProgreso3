using System.Net.Http.Json; 
using MAUI_Aeropuertos.Models; 
using MAUI_Aeropuertos.Services; 

namespace MAUI_Aeropuertos.Views;

public partial class SearchPage : ContentPage
{
    private readonly DatabaseService _databaseService; 

    public SearchPage(DatabaseService databaseService)
    {
        InitializeComponent();
        _databaseService = databaseService;
    }

    private async void OnSearchClicked(object sender, EventArgs e)
    {
      
        string searchQuery = txtSearch.Text;
        if (string.IsNullOrWhiteSpace(searchQuery))
        {
            await DisplayAlert("Error", "Ingrese un país válido", "OK");
            return;
        }


        string url = $"https://freetestapi.com/api/v1/airports?search={searchQuery}&limit=1";
        try
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetFromJsonAsync<List<Airport>>(url);

            if (response != null && response.Count > 0)
            {
                var aeropuerto = response[0];
                lblResult.Text = $"Aeropuerto: {aeropuerto.Nombre}, País: {aeropuerto.Pais}";


                aeropuerto.PYanez = "PabloY";


                await _databaseService.SaveAeropuertoAsync(aeropuerto);
            }
            else
            {
                lblResult.Text = "No se encontraron resultados.";
            }
        }
        catch (Exception ex)
        {

            await DisplayAlert("Error", $"Hubo un problema con la consulta: {ex.Message}", "OK");
        }
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        txtSearch.Text = string.Empty;
        lblResult.Text = string.Empty;
    }
}
