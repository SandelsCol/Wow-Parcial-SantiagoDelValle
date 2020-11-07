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
        string facts;
        int money = 15;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (Ralliance.IsChecked == true)
            {
                facts = "Alliance";
            }

            if (Rhord.IsChecked == true)
            {
                facts = "Horde";
            }

            if (CboxCharacter.Text == "Cleric" && (Ralliance.IsChecked == true || Rhord.IsChecked == true))
            {
                Inventory z = new Inventory
                {
                    Item = "Rod",
                    Lvl = "1",
                    Type = "Thrall's rod",
                };
                DataInventory.Items.Add(z);
                Inventory p = new Inventory();
                string text = HeroeName.Text;
                p.Name = text;
                p.Lvl = "1";
                p.Raze = "Cleric";
                p.Fact = facts;
                DataCharacters.Items.Add(p);
                Cleric c = new Cleric
                {
                    Level = 1
                };
                if (facts == "Alliance")
                {
                    pnaliance.Visibility = Visibility.Visible;
                }
                else if (facts == "Horde")
                {
                    pnhorde.Visibility = Visibility.Visible;
                }
                clerigpng.Visibility = Visibility.Visible;
                LvlHeroe.Text = "Ur level is" + c.Level;
            }

            else if (CboxCharacter.Text == "Fighter" && (Ralliance.IsChecked == true || Rhord.IsChecked == true))
            {
                Inventory z = new Inventory
                {
                    Item = "Sword",
                    Lvl = "1",
                    Type = "This is a classic sword",
                };
                DataInventory.Items.Add(z);
                Inventory p = new Inventory();
                string text = HeroeName.Text;
                p.Name = text;
                p.Lvl = "1";
                p.Raze = "Fighter";
                p.Fact = facts;
                DataCharacters.Items.Add(p);
                Fighter c = new Fighter
                {
                    Level = 1
                };
                Fightpng.Visibility = Visibility.Visible;
                LvlHeroe.Text = "Ur level is" + c.Level;
                if (facts == "Alliance")
                {
                    pnaliance.Visibility = Visibility.Visible;
                }
                else if (facts == "Horde")
                {
                    pnhorde.Visibility = Visibility.Visible;
                }

            }
            else if (CboxCharacter.Text == "Rouge" && (Ralliance.IsChecked == true || Rhord.IsChecked == true))
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
                string text = HeroeName.Text;
                p.Name = text;
                p.Lvl = "1";
                p.Raze = "Rouge";
                p.Fact = facts;
                DataCharacters.Items.Add(p);
                Rouge c = new Rouge
                {
                    Level = 1
                };
                RouguePng.Visibility = Visibility.Visible;
                LvlHeroe.Text = "Ur level is" + c.Level;
                if (facts == "Alliance")
                {
                    pnaliance.Visibility = Visibility.Visible;
                }
                else if (facts == "Horde")
                {
                    pnhorde.Visibility = Visibility.Visible;
                }

            }
            else if (CboxCharacter.Text == "Wizard" && (Ralliance.IsChecked == true || Rhord.IsChecked == true))
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
                string text = HeroeName.Text;
                p.Name = text;
                p.Lvl = "1";
                p.Raze = "Wizard";
                p.Fact = facts;
                DataCharacters.Items.Add(p);
                Wizard c = new Wizard
                {
                    Level = 1
                };
                LvlHeroe.Text = "Ur level is" + c.Level;
                Wizard.Visibility = Visibility.Visible;
                if (facts == "Alliance")
                {
                    pnaliance.Visibility = Visibility.Visible;
                }
                else if (facts == "Horde")
                {
                    pnhorde.Visibility = Visibility.Visible;
                }
            }
            else
            {
                MessageBox.Show("Select One Class");
            }

            if (CboxCharacter.Text == "Fighter" || CboxCharacter.Text == "Cleric" || CboxCharacter.Text == "Rouge" || CboxCharacter.Text == "Wizard" && (Ralliance.IsChecked == true || Rhord.IsChecked == true))
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
                Ralliance.Visibility = Visibility.Hidden;
                Rhord.Visibility = Visibility.Hidden;
                Deletecharacter.Visibility = Visibility.Hidden;
                btnattack.Visibility = Visibility.Visible;
                btnshop.Visibility = Visibility.Visible;
                Nameheroe.Text = HeroeName.Text;
                Damageheroe.Text = "";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Register.Delete();
            MessageBox.Show("U just deleted all existing accounts");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have successfully registered");
            Register.Addname(Username.Text);
            Register.Addname(Password.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string[] p = Register.Cont();

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
                Ralliance.Visibility = Visibility.Visible;
                Rhord.Visibility = Visibility.Visible;
                pnhorde.Visibility = Visibility.Hidden;
                pnaliance.Visibility = Visibility.Hidden;
                Deletecharacter.Visibility = Visibility.Visible;
                btnattack.Visibility = Visibility.Hidden;
                DataCharacters.Items.Clear();
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
            DataCharacters.Visibility = Visibility.Hidden;
            Ralliance.Visibility = Visibility.Hidden;
            Rhord.Visibility = Visibility.Hidden;
            pnhorde.Visibility = Visibility.Hidden;
            pnaliance.Visibility = Visibility.Hidden;
            Deletecharacter.Visibility = Visibility.Hidden;
            btnattack.Visibility = Visibility.Hidden;
            Btnback.Visibility = Visibility.Hidden;
            txtmoney.Visibility = Visibility.Hidden;
            PNGdailystore.Visibility = Visibility.Hidden;
            PNGdemonicrod.Visibility = Visibility.Hidden;
            PNGgold.Visibility = Visibility.Hidden;
            PNGHealpotion.Visibility = Visibility.Hidden;
            PNGinfernalsword.Visibility = Visibility.Hidden;
            PNGthrall.Visibility = Visibility.Hidden;
            PNGmagicboots.Visibility = Visibility.Hidden;
            checkdemonicrod.Visibility = Visibility.Hidden;
            checkhealpotion.Visibility = Visibility.Hidden;
            checkmagicboots.Visibility = Visibility.Hidden;
            chekfiresword.Visibility = Visibility.Hidden;
            sword1.Visibility = Visibility.Hidden;
            sword2.Visibility = Visibility.Hidden;
            BtnBuy.Visibility = Visibility.Hidden;
            DataInventory.Visibility = Visibility.Hidden;
            money = 15;
            DataInventory.Items.Clear();
            DataCharacters.Items.Clear();
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
            clerigpng.Visibility = Visibility.Hidden;
            Ralliance.Visibility = Visibility.Visible;
            Rhord.Visibility = Visibility.Visible;
            pnhorde.Visibility = Visibility.Hidden;
            pnaliance.Visibility = Visibility.Hidden;
            Deletecharacter.Visibility = Visibility.Visible;
            btnattack.Visibility = Visibility.Hidden;
            btnshop.Visibility = Visibility.Hidden;
            money = 15;
            DataInventory.Items.Clear();
        }

        private void Deletecharacter_Click(object sender, RoutedEventArgs e)
        {
            DataCharacters.Items.Clear();
        }

        private void Btnattack_Click(object sender, RoutedEventArgs e)
        {
            if (CboxCharacter.Text == "Cleric")
            {
                Damageheroe.Text = "U have a damage of" + (Weapon.DamageRod()) + "points";
            }
            else if(CboxCharacter.Text == "Fighter")
            {
                Damageheroe.Text = "U have a damage of" + (Weapon.DamageSword()) + "points";
            }
            else if(CboxCharacter.Text == "Rouge")
            {
                Damageheroe.Text = "U have a damage of" + (Weapon.DamageDagger() + Weapon.DamagePotion()) + "points";
            }
            else if (CboxCharacter.Text == "Wizard")
            {
                Damageheroe.Text = "U have a damage of" +  (Weapon.DamageManabooster() + Weapon.DamageOldBook()) + "points";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (money > 0)
            {
                if (checkdemonicrod.IsChecked == true)
                {
                    Inventory p = new Inventory
                    {
                        Item = "Demonic Rod",
                        Lvl = "1",
                        Type = "a curse of the legion"
                    };

                    if (money > 10)
                    {
                        money -= 10;
                        DataInventory.Items.Add(p);
                    }
                    else
                    {
                        MessageBox.Show("U need 10 gold bullion for Demonic Rod");
                    }
                }

                if (checkmagicboots.IsChecked == true)
                {
                    Inventory p = new Inventory
                    {
                        Item = "Magic Boots",
                        Lvl = "1",
                        Type = "A splendid surprise"
                    };

                    if (money > 3)
                    {
                        money -= 3;
                        DataInventory.Items.Add(p);
                    }
                    else
                    {
                        MessageBox.Show("U need 3 gold bullion for Demonic Magic boots");
                    }
                }

                if (checkhealpotion.IsChecked == true)
                {
                    Inventory p = new Inventory
                    {
                        Item = "Heal Potion",
                        Lvl = "1",
                        Type = "Basic potion of life"
                    };

                    if (money > 2)
                    {
                        money -= 2;
                        DataInventory.Items.Add(p);
                    }
                    else
                    {
                        MessageBox.Show("U need 2 gold bullion for Heal Potion");
                    }
                }

                if (chekfiresword.IsChecked == true)
                {
                    Inventory p = new Inventory
                    {
                        Item = "Infernal Sword",
                        Lvl = "1",
                        Type = "The purest flames"
                    };

                    if (money > 7)
                    {
                        money -= 7;
                        DataInventory.Items.Add(p);
                    }

                    else
                    {
                        MessageBox.Show("U need 7 gold bullion for Infernal Sword");
                    }
                }

                txtmoney.Text = "U have" + money + "gold bullion";
            }
        }        

        private void Btnshop_Click(object sender, RoutedEventArgs e)
        {
            txtmoney.Text = "U have" + money + "gold bullion";
            Btnback.Visibility = Visibility.Visible;
            txtmoney.Visibility = Visibility.Visible;
            PNGdailystore.Visibility = Visibility.Visible;
            PNGdemonicrod.Visibility = Visibility.Visible;
            PNGgold.Visibility = Visibility.Visible;
            PNGHealpotion.Visibility = Visibility.Visible;
            PNGinfernalsword.Visibility = Visibility.Visible;
            PNGthrall.Visibility = Visibility.Visible;
            PNGmagicboots.Visibility = Visibility.Visible;
            checkdemonicrod.Visibility = Visibility.Visible;
            checkhealpotion.Visibility = Visibility.Visible;
            checkmagicboots.Visibility = Visibility.Visible;
            chekfiresword.Visibility = Visibility.Visible;
            sword1.Visibility = Visibility.Visible;
            sword2.Visibility = Visibility.Visible;
            BtnBuy.Visibility = Visibility.Visible;
            DataInventory.Visibility = Visibility.Visible;
            btnshop.Visibility = Visibility.Hidden;
            HeroeName.Visibility = Visibility.Hidden;
            LvlHeroe.Visibility = Visibility.Hidden;
            Damageheroe.Visibility = Visibility.Hidden;
            New.Visibility = Visibility.Hidden;
            clerigpng.Visibility = Visibility.Hidden;
            Fightpng.Visibility = Visibility.Hidden;
            RouguePng.Visibility = Visibility.Hidden;
            Wizard.Visibility = Visibility.Hidden;
            lblinventory.Visibility = Visibility.Hidden;
            Exit.Visibility = Visibility.Visible;
            btnattack.Visibility = Visibility.Hidden;
            Nameheroe.Visibility = Visibility.Hidden;
            pnaliance.Visibility = Visibility.Hidden;
            pnhorde.Visibility = Visibility.Hidden;
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            Btnback.Visibility = Visibility.Hidden;
            txtmoney.Visibility = Visibility.Hidden;
            PNGdailystore.Visibility = Visibility.Hidden;
            PNGdemonicrod.Visibility = Visibility.Hidden;
            PNGgold.Visibility = Visibility.Hidden;
            PNGHealpotion.Visibility = Visibility.Hidden;
            PNGinfernalsword.Visibility = Visibility.Hidden;
            PNGthrall.Visibility = Visibility.Hidden;
            PNGmagicboots.Visibility = Visibility.Hidden;
            checkdemonicrod.Visibility = Visibility.Hidden;
            checkhealpotion.Visibility = Visibility.Hidden;
            checkmagicboots.Visibility = Visibility.Hidden;
            chekfiresword.Visibility = Visibility.Hidden;
            sword1.Visibility = Visibility.Hidden;
            sword2.Visibility = Visibility.Hidden;
            BtnBuy.Visibility = Visibility.Hidden;
            btnshop.Visibility = Visibility.Visible;
            LvlHeroe.Visibility = Visibility.Visible;
            Damageheroe.Visibility = Visibility.Visible;
            Nameheroe.Visibility = Visibility.Visible;
            New.Visibility = Visibility.Visible;
            btnattack.Visibility = Visibility.Visible;
            btnshop.Visibility = Visibility.Visible;
            lblinventory.Visibility = Visibility.Visible;

            if (CboxCharacter.Text == "Fighter")
            {
                Fightpng.Visibility = Visibility.Visible;

            }else if (CboxCharacter.Text == "Cleric")
            {
                clerigpng.Visibility = Visibility.Visible;

            }else if (CboxCharacter.Text == "Rouge")
            {
                RouguePng.Visibility = Visibility.Visible;

            }else if (CboxCharacter.Text == "Wizard")
            {
                Wizard.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("End of the program");
            }

            if (facts == "Alliance")
            {
                pnaliance.Visibility = Visibility.Visible;
            }
            else if (facts == "Horde")
            {
                pnhorde.Visibility = Visibility.Visible;
            }
        }
    }
}
