using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Player;
using FirstFantasy.Interfaces;
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
using System.IO;
using FirstFantasy.Classes.Extra;

namespace FirstFantasy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool pray;
        bool play;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (CboxCharacter.Text == "Cleric")
            {
                Inventory.AddBag("Rod");
                Cleric c = new Cleric();
                c.Level = 1;
                clerigpng.Visibility = Visibility.Visible;
                LvlHeroe.Text = "Ur level is" + c.Level;
                Damageheroe.Text = "U have a power of" + Inventory.Rod() + "Damage Points";
                TxtInventory.Text = Inventory.ViewALL();
            }

            else if (CboxCharacter.Text == "Fighter")
            {
                Inventory.AddBag("Sword");
                Fighter c = new Fighter();
                c.Level = 1;
                Fightpng.Visibility = Visibility.Visible;
                LvlHeroe.Text = "Ur level is" + c.Level;
                Damageheroe.Text = "U have a power of" + Inventory.DamageSword() + "Damage Points";
                TxtInventory.Text = Inventory.ViewALL();

            }
            else if (CboxCharacter.Text == "Rouge")
            {
                Inventory.AddBag("Potion" + "\n" + "dagger");
                Rouge c = new Rouge();
                c.Level = 1;
                RouguePng.Visibility = Visibility.Visible;
                LvlHeroe.Text = "Ur level is" + c.Level;
                Damageheroe.Text = "U have a power of" + (Inventory.Dagger() + Inventory.DamagePotion()) + "Damage Points";
                TxtInventory.Text = Inventory.ViewALL();
            }
            else if (CboxCharacter.Text == "Wizard")
            {
                Inventory.AddBag("mana booster" + "\n" + "Old book");
                Wizard c = new Wizard();
                c.Level = 1;
                LvlHeroe.Text = "Ur level is" +  c.Level;
                Wizard.Visibility = Visibility.Visible;
                Damageheroe.Text = "U have a power of" + (Inventory.Manabooster() + Inventory.OldBook()) + "Damage Points";
                TxtInventory.Text = Inventory.ViewALL();
            }
            else
            {
                MessageBox.Show("Select One Class");
            }

            if (CboxCharacter.Text == "Fighter" || CboxCharacter.Text == "Cleric" || CboxCharacter.Text == "Rouge" || CboxCharacter.Text == "Wizard")
            {
                BtnCreate.Visibility = Visibility.Hidden;
                HeroeName.Visibility = Visibility.Hidden;
                LvlHeroe.Visibility = Visibility.Visible;
                Damageheroe.Visibility = Visibility.Visible;
                Nameheroe.Visibility = Visibility.Visible;
                Welcome.Visibility = Visibility.Hidden;
                CboxCharacter.Visibility = Visibility.Hidden;
                New.Visibility = Visibility.Visible;
                Play.Visibility = Visibility.Visible;
                TxtInventory.Visibility = Visibility.Visible;
                Delete.Visibility = Visibility.Visible;
                lblinve.Visibility = Visibility.Visible;
                Nameheroe.Text = HeroeName.Text;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Inventory.Delete();
            TxtInventory.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Register.Delete();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("You have successfully registered");
            Register.Addname(Username.Text);
            Register.Addname(Password.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string[] p = Register.cont();

            for (int i = 0; i < p.Length; i += 2)
            {
                if (Username.Text == p[i])
                {
                    pray = true;
                }
                else
                {
                    pray = false;
                }
            }

            for (int x = 1; x < p.Length; x += 2)
            {
                if (Password.Text == p[x])
                {
                    play = true;
                }
                else
                {
                    play = false;
                }
            }

            if (pray == true && play == true)
            {
                MessageBox.Show("Welcome" + "" + Username.Text + "\n" + "enjoy all our services");
                Horda.Visibility = Visibility.Hidden;
                Alis.Visibility = Visibility.Hidden;
                btndelete.Visibility = Visibility.Hidden;
                btnlogin.Visibility = Visibility.Hidden;
                btnregister.Visibility = Visibility.Hidden;
                Username.Visibility = Visibility.Hidden;
                Password.Visibility = Visibility.Hidden;
                Welcome.Visibility = Visibility.Visible;
                BtnCreate.Visibility = Visibility.Visible;
                CboxCharacter.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("invalid credentials");
            }
        }
    }
}
