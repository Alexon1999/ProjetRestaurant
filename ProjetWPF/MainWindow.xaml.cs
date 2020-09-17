using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RestaurantMetier;

namespace ProjetWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Carte> lesCartes;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lesCartes = new List<Carte>();
            Carte cartePrintemps = new Carte(1, "Carte de printemps");
            Carte carteHiver = new Carte(2, "Carte d'hiver");

            RestaurantMetier.Menu menuBio = new RestaurantMetier.Menu(1, "Menu Bio");
            RestaurantMetier.Menu menuVIP = new RestaurantMetier.Menu(1, "Menu VIP");
            RestaurantMetier.Menu menuGourmand = new RestaurantMetier.Menu(1, "Menu gourmand");

            Plat entree1 = new Plat(1, "Salade verte", 0, "Images/Salade.jpg");
            Plat entree2 = new Plat(2, "Escargots de bourgogne", 0, "Images/Escargot.jpg");
            Plat entree3 = new Plat(3, "Terrine de canard", 0, "Images/Terrine.jpg");
            Plat plat1 = new Plat(4, "Pièce du boucher", 0, "Images/Boucher.jpg");
            Plat plat2 = new Plat(5, "Poisson aux citrons", 0, "Images/Poisson.jpg");
            Plat plat3 = new Plat(6, "Pizza", 0, "Images/Pizza.jpg");
            Plat dessert1 = new Plat(7, "Tarte aux pommes", 0, "Images/Tarte.jpg");
            Plat dessert2 = new Plat(8, "Sorbet vanille", 0, "Images/Sorbet.jpg");
            Plat dessert3 = new Plat(9, "Gâteau chocolat", 0, "Images/Gateau.jpg");
            Plat dessert4 = new Plat(10, "Crème caramel", 0, "Images/Creme.jpg");

            menuBio.AjouterPlat(entree1); menuBio.AjouterPlat(plat2); menuBio.AjouterPlat(dessert2);

            menuVIP.AjouterPlat(entree1); menuVIP.AjouterPlat(entree2); menuVIP.AjouterPlat(plat1);
            menuVIP.AjouterPlat(dessert1); menuVIP.AjouterPlat(dessert4);

            menuGourmand.AjouterPlat(entree3); menuGourmand.AjouterPlat(plat3); menuGourmand.AjouterPlat(dessert3);

            carteHiver.AjouterMenu(menuGourmand); carteHiver.AjouterMenu(menuVIP);
            cartePrintemps.AjouterMenu(menuBio);

            lesCartes.Add(cartePrintemps);lesCartes.Add(carteHiver);

            lstCartes.ItemsSource = lesCartes;

        }

        private void lstCartes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Carte selectedCarte = lstCartes.SelectedItem as Carte;

            if (selectedCarte != null)
            {
                lstMenus.ItemsSource = selectedCarte.LesMenus;
            }
            else
            {
                lstMenus.ItemsSource = null;
                // lstMenus.Items.Refresh();

            }

        }

        private void lstMenus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RestaurantMetier.Menu selectedMenu = lstMenus.SelectedItem as RestaurantMetier.Menu;

            if(selectedMenu != null)
            {
                lstPlats.ItemsSource = selectedMenu.LesPlats;
                txtNotesMenu.Text = (lstMenus.SelectedItem as RestaurantMetier.Menu).CalculerNote().ToString();

            }
            else
            {
                lstPlats.ItemsSource = null;
                //lstPlats.Items.Refresh()
            }
        }

        private void btnNotezlePlat_Click(object sender, RoutedEventArgs e)
        {

            if (lstMenus.SelectedItem == null)
            {
                MessageBox.Show("Selectionnez un menu", "probleme de selection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (lstPlats.SelectedItem == null)
                {
                    MessageBox.Show("Selectionnez un plat", "probleme de selection", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (txtNote.Text == "")
                    {
                        MessageBox.Show("Donnez une note", "probleme de selection", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        Plat selectedPlat = lstPlats.SelectedItem as Plat;
                        // selectedPlat.NoterUnPlat(int.Parse(txtNote.Text));
                        selectedPlat.NoterUnPlat(Convert.ToInt16(txtNote.Text));

                        txtNotesMenu.Text = (lstMenus.SelectedItem as RestaurantMetier.Menu).CalculerNote().ToString();
                        lstPlats.Items.Refresh();
                    }
                }
            }     
                        sliderNote.Value = 0;
        }

        private void sliderNote_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // convertir doble en int
            // txtNote.Text = Convert.ToInt16(sldNote.Value).ToString();


            //slider value donne un double
            int sliderVal = (int) sliderNote.Value;
            txtNote.Text = sliderVal.ToString();
        }
    }
}
