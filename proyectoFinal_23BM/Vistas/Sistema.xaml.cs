using proyectoFinal_23BM.entities;
using proyectoFinal_23BM.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace proyectoFinal_23BM.Vistas
{
    /// <summary>
    /// Lógica de interacción para Sistema.xaml
    /// </summary>
    public partial class Sistema : Window
    {
        public Sistema()
        {
            InitializeComponent();
            GetUsersTable();
        }

        UsuarioServis services = new UsuarioServis();
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Nombre = txtNombre.Text;
            usuario.UserName = txtUserName.Text;
            usuario.Password = txtPassword.Text;

            services.AddUser(usuario);

            txtNombre.Clear();
            txtUserName.Clear();
            txtPassword.Clear();

            MessageBox.Show("se agrego correctamente");
        }

        private void BtnEditar(object sender, RoutedEventArgs e)
        {

        }
        public void GetUsersTable()
        {
            UserTable.ItemsSource = services.GetUsuario();
        }
    }

    
}
