namespace CarrionSem2.Views.Admisiones
{
    public partial class InicioPage : ContentPage
    {
        public InicioPage()
        {
            InitializeComponent();
        }

        private async void OnEnviarClicked(object sender, EventArgs e)
        {
            var tipoIdentificacion = TipoIdentificacionPicker.SelectedItem?.ToString();
            var numeroIdentificacion = NumeroIdentificacionEntry.Text?.Trim();
            var apellidoPaterno = ApellidoPaternoEntry.Text?.Trim();
            var apellidoMaterno = ApellidoMaternoEntry.Text?.Trim();
            var nombres = NombresEntry.Text?.Trim();
            var telefono = TelefonoEntry.Text?.Trim();
            var correo = CorreoEntry.Text?.Trim();
            var confirmarCorreo = ConfirmarCorreoEntry.Text?.Trim();
            var carrera = CarreraPicker.SelectedItem?.ToString();
            var modalidad = ModalidadPicker.SelectedItem?.ToString();
            var campus = CampusPicker.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tipoIdentificacion))
            {
                await DisplayAlertAsync("Error", "Debes seleccionar el tipo de identificación.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(numeroIdentificacion) || !numeroIdentificacion.All(char.IsDigit))
            {
                await DisplayAlertAsync("Error", "La identificación debe contener solo números.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(apellidoPaterno) || string.IsNullOrWhiteSpace(apellidoMaterno))
            {
                await DisplayAlertAsync("Error", "Debes ingresar ambos apellidos.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombres))
            {
                await DisplayAlertAsync("Error", "Debes ingresar tus nombres completos.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length < 8 || !telefono.All(char.IsDigit))
            {
                await DisplayAlertAsync("Error", "El teléfono solo debe contener números y mínimo 8 dígitos.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@") || !correo.Contains("."))
            {
                await DisplayAlertAsync("Error", "Ingresa un correo electrónico válido.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(confirmarCorreo) || !string.Equals(correo, confirmarCorreo, StringComparison.OrdinalIgnoreCase))
            {
                await DisplayAlertAsync("Error", "Los correos no coinciden.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(carrera))
            {
                await DisplayAlertAsync("Error", "Debes seleccionar una carrera.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(modalidad))
            {
                await DisplayAlertAsync("Error", "Debes seleccionar una modalidad.", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(campus))
            {
                await DisplayAlertAsync("Error", "Debes seleccionar un campus.", "OK");
                return;
            }

            await DisplayAlertAsync("Registro exitoso", "Tu inscripción se ha enviado correctamente.", "OK");
        }
    }
}
