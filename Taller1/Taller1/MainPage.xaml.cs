using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Taller1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nom.Text))
            {
                DisplayAlert("Error", "Debe ingresar este campo.", "cerrar");
                nom.Focus();
                return;
            }

            if (string.IsNullOrEmpty(rt.Text))
            {
                DisplayAlert("Error", "Debe ingresar este campo.", "cerrar");
                rt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(em.Text))
            {
                DisplayAlert("Error", "Debe ingresar este campo.", "cerrar");
                em.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cont.Text))
            {
                DisplayAlert("Error", "Debe ingresar este campo.", "cerrar");
                cont.Focus();
                return;
            }

            if (string.IsNullOrEmpty(contdos.Text))
            {
                DisplayAlert("Error", "Debe ingresar este campo.", "cerrar");
                contdos.Focus();
                return;

            }
        }
    }
}
