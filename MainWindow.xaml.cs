using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Player;
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
                Inventory z = new Inventory();
                z.Item = "Rod";
                z.Lvl = "1";
                z.Type = "Thrall's rod";
                DataInventory.Items.Add(z);
                Inventory p = new Inventory();
                p.Name = Nameheroe.Text;
                p.Lvl = "1";
                p.Raze = "Cleric";
                DataCharacters.Items.Add(p);
                Cleric c = new Cleric();
                c.Level = 1;
                clerigpng.Visibility = Visibility.Visible;
                LvlHeroe.Text = "Ur level is" + c.Level;
                Damageheroe.Text = "U have a power of" + Weapon.DamageRod() + "Damage Points";
            }

            else if (CboxCharacter.Text == "Fighter")
            {
                Inventory z = new Inventory();
                z.Item = "Sword";
                z.Lvl = "1";
                z.Type = "This is a classic sword";
                DataInventory.Items.Add(z);
                Inventory p = new Inventory();
                p.Name = Nameheroe.Text;
                p.Lvl = "1";
                p.Raze = "Fighter";
                DataCharacters.Items.Add(p);
                Fighter c = new Fighter();
                c.Level = 1;
                Fightpng.Visibility = Visibility.Visible;
                LvlHeroe.Text = "Ur level is" + c.Level;
                Damageheroe.Text = "U have a power of" + Weapon.DamageSword() + "Damage Points";

            }
            else if (CboxCharacter.Text == "Rouge")
            {
                Inventory z = new Inventory();
                Inventory x = new Inventory();
                z.Item = "Dagger";
                z.Lvl = "1";
                z.Type = "Poisonous blade";
                x.Item = "Potion";
                x.Lvl = "1";
                x.Type = "Energy Posion";
                DataInventory.Items.Add(z);
                DataInventory.Items.Add(x);
                Inventory p = new Inventory();
                string h = Nameheroe.Text;
                p.Name = h;
                p.Lvl = "1";
                p.Raze = "Rouge";
                DataCharacters.Items.Add(p);
                Rouge c = new Rouge();
                c.Level = 1;
                RouguePng.Visibility = Visibility.Visible;
                LvlHeroe.Text = "Ur level is" + c.Level;
                Damageheroe.Text = "U have a power of" + (Weapon.DamageDagger() + Weapon.DamagePotion()) + "Damage Points";

            }
            else if (CboxCharacter.Text == "Wizard")
            {
                Inventory z = new Inventory();
                Inventory x = new Inventory();
                z.Item = "Mana Booster";
                z.Lvl = "1";
                z.Type = "Fountain of life";
                x.Item = "Old Book";
                x.Lvl = "1";
                x.Type = "Dark magic";
                DataInventory.Items.Add(z);
                DataInventory.Items.Add(x);
                Inventory p = new Inventory();
                p.Name = Nameheroe.Text;
                p.Lvl = "1";
                p.Raze = "Wizard";
                DataCharacters.Items.Add(p);
                Wizard c = new Wizard();
                c.Level = 1;
                LvlHeroe.Text = "Ur level is" +  c.Level;
                Wizard.Visibility = Visibility.Visible;
                Damageheroe.Text = "U have a power of" + (Weapon.DamageManabooster() + Weapon.DamageOldBook()) + "Damage Points";

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
                DataInventory.Visibility = Visibility.Visible;
                lblinventory.Visibility = Visibility.Visible;
                DataCharacters.Visibility = Visibility.Hidden;
                Nameheroe.Text = HeroeName.Text;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Register.Delete();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have successfully registered");
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
                HeroeName.Visibility = Visibility.Visible;
                Exit.Visibility = Visibility.Visible;
                DataCharacters.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("invalid credentials");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Horda.Visibility = Visibility.Visible;
            Alis.Visibility = Visibility.Visible;
            btndelete.Visibility = Visibility.Visible;
            btnlogin.Visibility = Visibility.Visible;
            btnregister.Visibility = Visibility.Visible;
            Username.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Visible;
            BtnCreate.Visibility = Visibility.Hidden;
            CboxCharacter.Visibility = Visibility.Hidden;
            HeroeName.Visibility = Visibility.Hidden;
            LvlHeroe.Visibility = Visibility.Hidden;
            Damageheroe.Visibility = Visibility.Hidden;
            Nameheroe.Visibility = Visibility.Hidden;
            Welcome.Visibility = Visibility.Hidden;
            New.Visibility = Visibility.Hidden;
            clerigpng.Visibility = Visibility.Hidden;
            Fightpng.Visibility = Visibility.Hidden;
            RouguePng.Visibility = Visibility.Hidden;
            Wizard.Visibility = Visibility.Hidden;
            DataInventory.Visibility = Visibility.Hidden;
            lblinventory.Visibility = Visibility.Hidden;
            Exit.Visibility = Visibility.Hidden;
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            DataCharacters.Visibility = Visibility.Visible;
            BtnCreate.Visibility = Visibility.Visible;
            CboxCharacter.Visibility = Visibility.Visible;
            HeroeName.Visibility = Visibility.Visible;
            Welcome.Visibility = Visibility.Visible;
            Wizard.Visibility = Visibility.Hidden;
            RouguePng.Visibility = Visibility.Hidden;
            Fightpng.Visibility = Visibility.Hidden;
            lblclerci.Visibility = Visibility.Hidden;
            Nameheroe.Visibility = Visibility.Hidden;
            lblinventory.Visibility = Visibility.Hidden;
            Damageheroe.Visibility = Visibility.Hidden;
            LvlHeroe.Visibility = Visibility.Hidden;
            DataInventory.Visibility = Visibility.Hidden;
            New.Visibility = Visibility.Hidden;
            DataInventory.Items.Clear();
        }
    }
}
