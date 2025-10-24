using Avalonia.Controls;
using Avalonia.Interactivity;
using DirectorioTelefonico.Models;
using DirectorioTelefonico.Data;
using System.Data;

namespace DirectorioTelefonico.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Conectar eventos
            btnAgregar.Click += BtnAgregar_Click;
            btnListar.Click += BtnListar_Click;
            btnEliminar.Click += BtnEliminar_Click;

            // Cargar tabla inicialmente
            ActualizarTabla();
        }

        private void BtnAgregar_Click(object? sender, RoutedEventArgs e)
        {
            var emp = new Empleado
            {
                Documento = txtDocumento.Text ?? "",
                Nombre = txtNombre.Text ?? "",
                Apellidos = txtApellidos.Text ?? "",
                Telefono = txtTelefono.Text ?? "",
                Cargo = txtCargo.Text ?? "",
                Oficina = txtOficina.Text ?? ""
            };

            EmpleadoDAL.Agregar(emp);
            ActualizarTabla();
        }

        private void BtnListar_Click(object? sender, RoutedEventArgs e)
        {
            ActualizarTabla();
        }

        private void BtnEliminar_Click(object? sender, RoutedEventArgs e)
        {
            if (dgEmpleados.SelectedItem is DataRowView fila)
            {
                string documento = fila["documento"].ToString() ?? "";
                EmpleadoDAL.Eliminar(documento);
                ActualizarTabla();
            }
        }

        private void ActualizarTabla()
        {
            dgEmpleados.ItemsSource = EmpleadoDAL.Listar().DefaultView;
        }
    }
}
