namespace CarrionSem2// Asegúrate de que el namespace coincida con el de tu proyecto
{
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void OnRegistrarClicked(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para capturar los datos y enviarlos
            await DisplayAlert("Registro", "Formulario procesado.", "OK");
        }
    }
}