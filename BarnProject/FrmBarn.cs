using BarnProject.Abstract;
using BarnProject.Concrete;
using BarnProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarnProject
{
    public partial class FrmBarn : Form
    {
        public FrmBarn()
        {
            InitializeComponent();
        }

        
        List<AnimalViewModel> animalViewModels = new List<AnimalViewModel>();
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        decimal cashAmount = 10000;
        private void FrmBarn_Load(object sender, EventArgs e)
        {
            Beef beef = new Beef();
            Chicken chicken = new Chicken();
            Cow cow = new Cow();
            List<Animal> animals = new List<Animal> {beef,chicken,cow};
            List<string> genders = new List<string> { "Male", "Female" };
            cmbAnimalSpecies.DataSource = animals;
            cmbAnimalSpecies.DisplayMember = "AnimalSpecies";

            cmbGender.DataSource = genders;

            lblCashAmount.Text = cashAmount.ToString() + " TL";

            timerProduction.Interval = 1000;
            timerProduction.Tick += timerProduction_Tick;
            timerProduction.Start();


            


        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Animal selectedAnimal = (Animal)cmbAnimalSpecies.SelectedItem;
            string name = selectedAnimal.AnimalSpecies;
            string gender = cmbGender.SelectedItem.ToString();
            int age = int.Parse(txtAnimalAge.Text);
            if(name=="Chicken")
            {
                if(cashAmount<new Chicken().AnimalPrice)
                {
                    MessageBox.Show("You Have Not Enough Money To Buy " + name + " Product");
                }
                else
                {

                    Chicken.chickenCount++;
                    Chicken chicken = new Chicken
                    {
                        AnimalAge = age,
                        AnimalGender = gender,

                    };
                    AnimalViewModel animalViewModel = new AnimalViewModel(chicken);
                    animalViewModels.Add(animalViewModel);
                    MessageBox.Show(name + " Has Been Added Successfully.");
                    cashAmount -= new Chicken().AnimalPrice;
                    lblCashAmount.Text = cashAmount.ToString() + " TL";
                }
                
            }
            else if (name=="Beef")
            {
                if (cashAmount < new Beef().AnimalPrice)
                {
                    MessageBox.Show("You Have Not Enough Money To Buy " + name + " Product");
                }
                else
                {
                    Beef.beefCount++;
                    Beef beef = new Beef
                    {
                        AnimalAge = age,
                        AnimalGender = gender,

                    };
                    AnimalViewModel animalViewModel = new AnimalViewModel(beef);
                    animalViewModels.Add(animalViewModel);
                    MessageBox.Show(name + " Has Been Added Successfully.");
                    cashAmount -= new Beef().AnimalPrice;
                    lblCashAmount.Text = cashAmount.ToString() + " TL";
                }
               
            }
            else if (name=="Cow")
            {
                if (cashAmount < new Cow().AnimalPrice)
                {
                    MessageBox.Show("You Have Not Enough Money To Buy " + name + " Product");
                }
                else
                {
                    Cow.cowCount++;
                    Cow cow = new Cow
                    {
                        AnimalAge = age,
                        AnimalGender = gender,

                    };
                    AnimalViewModel animalViewModel = new AnimalViewModel(cow);
                    animalViewModels.Add(animalViewModel);
                    MessageBox.Show(name + " Has Been Added Successfully.");
                    cashAmount -= new Cow().AnimalPrice;
                    lblCashAmount.Text = cashAmount.ToString() + " TL";
                }
                
            }
            dataGridViewAnimals.DataSource = null;
            dataGridViewAnimals.DataSource = animalViewModels;

        }

        private void dataGridViewAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RemoveDeadAnimals()
        {
            
            animalViewModels = animalViewModels
                .Where(a => a._animal.IsAlive())
                .ToList();

            
            dataGridViewAnimals.DataSource = null;
            dataGridViewAnimals.DataSource = animalViewModels;
        }

        int chickenProgress = 0;
        int beefProgress = 0;
        int cowProgress = 0;

        int meatCount = 0;
        int eggCount = 0;
        int milkCount = 0;

       
        private void timerProduction_Tick(object sender, EventArgs e)
        {
            foreach (var vm in animalViewModels)
            {
                vm._animal.AnimalAge += 1; 
            }

            foreach (var an in animalViewModels.ToList())
            {
                if(an._animal.IsAlive()==false)
                {
                    animalViewModels.Remove(an);
                    if(an._animal.AnimalSpecies=="Chicken")
                    {
                        chickenProgress = 0;
                        pbarChicken.Value = 0;
                    }
                    if (an._animal.AnimalSpecies == "Beef")
                    {
                       beefProgress = 0;
                        pbarBeef.Value = 0;
                    }
                    if (an._animal.AnimalSpecies == "Cow")
                    {
                        cowProgress = 0;
                        pbarCow.Value = 0;
                    }
                    dataGridViewAnimals.DataSource = null;
                    dataGridViewAnimals.DataSource = animalViewModels;
                }
            }
            var chicken = animalViewModels.FirstOrDefault(a => a.Type == "Chicken" && !a.IsProductCompleted);
                if(chicken!=null)
                {

                    
                    int maxValue = chicken.getAnimalProductTimeByMonth(new Chicken());
                    pbarChicken.Maximum = maxValue;
                    if (chickenProgress < maxValue)
                    {
                   
                        chickenProgress++;
                        pbarChicken.Value = chickenProgress;
                    }
                    else
                    {
                    chicken.IsProductCompleted = true;
                    
                        chickenProgress = 0;
                        pbarChicken.Value = 0;
                    }
                    


                }
            if (chickenProgress == pbarChicken.Maximum)
            {
                eggCount++;
                lblEggCount.Text = eggCount.ToString();
            }
            if (beefProgress == pbarBeef.Maximum)
            {
                meatCount++;
                lblMeatCount.Text = meatCount.ToString();
            }
            if (cowProgress == pbarCow.Maximum)
            {
                milkCount++;
                lblMilkCount.Text = milkCount.ToString();
            }






            var cow = animalViewModels.FirstOrDefault(a => a.Type == "Cow" && !a.IsProductCompleted);
                if (cow !=null)
                {

                int maxValue = cow.getAnimalProductTimeByMonth(new Cow());
                    pbarCow.Maximum = maxValue;
                    if (cowProgress < maxValue)
                    {
                    
                        cowProgress++;
                        pbarCow.Value = cowProgress;
                    }
                    else
                    {
                    cow.IsProductCompleted = true;
                    
                        cowProgress = 0;
                        pbarCow.Value = 0;
                    }
                   

                }
            





            var beef = animalViewModels.FirstOrDefault(a => a.Type == "Beef"&& !a.IsProductCompleted);
                if(beef !=null)
                {
                    
                    int maxValue = beef.getAnimalProductTimeByMonth(new Beef());
                    pbarBeef.Maximum = maxValue;

                    if (beefProgress < maxValue)
                    {
                    
                        beefProgress++;
                        pbarBeef.Value = beefProgress;
                    }
                    else
                    {
                    beef.IsProductCompleted = true;
                    
                        beefProgress = 0;
                        pbarBeef.Value = 0;
                    }
                   

                }
                
            

        }
        
        private void lblMeatCount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMeatSell_Click(object sender, EventArgs e)
        {
            int meatCount = int.Parse(lblMeatCount.Text);
        
            int meatSellCount = int.Parse(txtMeatSellCount.Text);
            if(int.Parse(lblMeatCount.Text)<meatSellCount)
            {
                MessageBox.Show("Stokta Satmak İstediğiniz Kadar Ürün Bulunmamaktadır.Lütfen Başka Bir Miktar Giriniz.");

            }
            else
            {
                MessageBox.Show(new Beef().Produce().ProductName + " Product Has Been Sold Successfully.");
                meatCount -= meatSellCount;
                lblMeatCount.Text = meatCount.ToString();
            }

            cashAmount += (new Beef().Produce().ProductPricePerUnit)*decimal.Parse(txtMeatSellCount.Text);
            lblCashAmount.Text = cashAmount.ToString() + " TL";
        }

        private void btnEggSell_Click(object sender, EventArgs e)
        {
            int eggCount = int.Parse(lblEggCount.Text);

            int eggSellCount = int.Parse(txtEggSellCount.Text);
            if (int.Parse(lblEggCount.Text) < eggSellCount)
            {
                MessageBox.Show("Stokta Satmak İstediğiniz Kadar Ürün Bulunmamaktadır.Lütfen Başka Bir Miktar Giriniz.");

            }
            else
            {
                MessageBox.Show(new Chicken().Produce().ProductName + " Product Has Been Sold Successfully.");
                eggCount -= eggSellCount;
                lblEggCount.Text = eggCount.ToString();
            }
            cashAmount += (new Chicken().Produce().ProductPricePerUnit) * decimal.Parse(txtEggSellCount.Text);
            lblCashAmount.Text = cashAmount.ToString() + " TL";
        }

        private void btnMilkSell_Click(object sender, EventArgs e)
        {
            int milkCount = int.Parse(lblMilkCount.Text);

            int milkSellCount = int.Parse(txtMilkSellCount.Text);
            if (int.Parse(lblMilkCount.Text) < milkSellCount)
            {
                MessageBox.Show("Stokta Satmak İstediğiniz Kadar Ürün Bulunmamaktadır.Lütfen Başka Bir Miktar Giriniz.");

            }
            else
            {
                MessageBox.Show(new Cow().Produce().ProductName + " Product Has Been Sold Successfully.");
                milkCount -= milkSellCount;
                lblMilkCount.Text = milkCount.ToString();
            }
            cashAmount += (new Cow().Produce().ProductPricePerUnit) * decimal.Parse(txtMilkSellCount.Text);
            lblCashAmount.Text = cashAmount.ToString() + " TL";
        }
    }
}
