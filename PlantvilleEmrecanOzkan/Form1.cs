using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace PlantvilleEmrecanOzkan
{
    public partial class Form1 : Form
    {
        private Player player;
        private SeedsEmporium seedsEmporium;
        private Garden garden;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            // Set up the timer
            timer = new Timer();
            timer.Interval = 1000;  // Interval in milliseconds (1000 ms = 1 second)
            timer.Tick += Timer_Tick;  // Event handler for the timer tick
            timer.Start();  // Start the timer
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            ReloadDatas();
        }
        public int GetImageIndexBySeed(string seedName)
        {
            int imageIndex = -1;

            if (seedName is "Strawberry")
                imageIndex = 0;
            else if (seedName is "Pear")
                imageIndex = 1;
            else if (seedName is "Spinach")
                imageIndex = 2;
            return imageIndex;
        }
        public void ReloadUserDatas()
        {
            moneyLabel.Text = "$" + player.GetMoney().ToString();
            landPlotLabel.Text = player.GetLandPlots().ToString();
            ReloadInventory();
        }
        public void ReloadInventory()
        {
            inventoryListView.Items.Clear();
            foreach (Plant harvestedPlants in player.Inventory.GetHarvestedPlants())
            {
                int imageIndex = GetImageIndexBySeed(harvestedPlants.GetPlantedSeed().GetName());

                ListViewItem listViewItem = new ListViewItem(harvestedPlants.GetPlantedSeed().GetName(), imageIndex);
                listViewItem.SubItems.Add(harvestedPlants.GetPlantedSeed().GetHarvestPrice().ToString());

                inventoryListView.Items.Add(listViewItem);
            }
        }
        public void ReloadSeedEmporiumList()
        {
            foreach (Seed seed in seedsEmporium.Seeds)
            {
                int imageIndex = GetImageIndexBySeed(seed.GetName());

                ListViewItem listViewItem = new ListViewItem(seed.GetName(), imageIndex); // Create the ListViewItem
                listViewItem.SubItems.Add(seed.GetPrice().ToString()); // Add the price to the second column

                seedsEmporiumList.Items.Add(listViewItem);
            }
        }
        public void ReloadGardenList()
        {
            gardenListView.Items.Clear();
            foreach (Plant plant in garden.GetPlants())
            {
                int imageIndex = GetImageIndexBySeed(plant.GetPlantedSeed().GetName());

                ListViewItem listViewItem = new ListViewItem(plant.GetPlantedSeed().GetName(), imageIndex);
                if (plant.IsItTimeToHarvest())
                {
                    if (plant.IsItTimeToSpoil())
                    {
                        listViewItem.SubItems.Add("SPOILED!");
                    }
                    else
                    {
                        listViewItem.SubItems.Add("HARVEST!");
                    }
                }
                else
                {
                    listViewItem.SubItems.Add(plant.GetTotalLeftSeconds(plant.GetPlantedSeed().GetTimeToHarvest()).ToString());
                }
                if (plant.IsItTimeToSpoil())
                {
                    listViewItem.SubItems.Add("SPOILED!");
                }
                else
                {
                    listViewItem.SubItems.Add(plant.GetTotalLeftSeconds(plant.GetPlantedSeed().GetTimeToSpoil()).ToString());
                }
                gardenListView.Items.Add(listViewItem);
            }
        }
        public void ReloadDatas()
        {
            ReloadUserDatas();
            ReloadGardenList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string jsonPath = Path.Combine(Application.StartupPath, "Resources", "data.json");
            player = new Player();
            garden = new Garden();
            
            if (File.Exists(jsonPath))
            {
                using (StreamReader r = new StreamReader(jsonPath))
                {
                    string jsonData = r.ReadToEnd();
                    var gameData = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);

                    player = new Player();
                    garden = new Garden();
                    foreach (var kvp in gameData)
                    {
                        string key = kvp.Key;
                        object value = kvp.Value;

                        if (key == "money")
                        {
                            player.SetMoney(Convert.ToInt32(value));
                        }
                        else if(key == "landPlots")
                        {
                            player.SetLandPlots(Convert.ToInt32(value));
                        }
                        else if (key == "harvestedPlants")
                        {
                            if (gameData.TryGetValue("harvestedPlants", out object harvestedPlantsObj) && harvestedPlantsObj is IEnumerable<object> harvestedPlants)
                            {
                                foreach (var plant in harvestedPlants)
                                {
                                    var plantData = Newtonsoft.Json.Linq.JObject.FromObject(plant);
                                    Seed seed = new Seed();
                                    var plantedSeedName = plantData["PlantedSeed"]["Name"];
                                    var plantedSeedPrice = plantData["PlantedSeed"]["Price"];
                                    var plantedSeedHarvestPrice = plantData["PlantedSeed"]["HarvestPrice"];
                                    var plantedSeedTimeToHarvest = plantData["PlantedSeed"]["TimeToHarvest"];
                                    var plantedSeedTimeToSpoil = plantData["PlantedSeed"]["TimeToSpoil"];
                                    seed.SetName(plantedSeedName.ToString());
                                    seed.SetPrice(Convert.ToInt32(plantedSeedPrice));
                                    seed.SetHarvestPrice(Convert.ToInt32(plantedSeedHarvestPrice));
                                    seed.SetTimeToHarvest(Convert.ToInt32(plantedSeedTimeToHarvest));
                                    seed.SetTimeToSpoil(Convert.ToInt32(plantedSeedTimeToSpoil));

                                    DateTime parsedPlantedTime = DateTime.Parse(plantData["PlantedTime"].ToString());
                                    Plant plantObj = new Plant(seed);
                                    plantObj.SetPlantedTime(parsedPlantedTime);
                                    player.Inventory.AddHarvestedPlant(plantObj);
                                }
                            }
                        }
                        else if (key == "plants")
                        {
                            if (gameData.TryGetValue("plants", out object plantsObj) && plantsObj is IEnumerable<object> plants)
                            {
                                foreach (var plant in plants)
                                {
                                    var plantData = Newtonsoft.Json.Linq.JObject.FromObject(plant);
                                    Seed seed = new Seed();
                                    var plantedSeedName = plantData["PlantedSeed"]["Name"];
                                    var plantedSeedPrice = plantData["PlantedSeed"]["Price"];
                                    var plantedSeedHarvestPrice = plantData["PlantedSeed"]["HarvestPrice"];
                                    var plantedSeedTimeToHarvest = plantData["PlantedSeed"]["TimeToHarvest"];
                                    var plantedSeedTimeToSpoil = plantData["PlantedSeed"]["TimeToSpoil"];
                                    seed.SetName(plantedSeedName.ToString());
                                    seed.SetPrice(Convert.ToInt32(plantedSeedPrice));
                                    seed.SetHarvestPrice(Convert.ToInt32(plantedSeedHarvestPrice));
                                    seed.SetTimeToHarvest(Convert.ToInt32(plantedSeedTimeToHarvest));
                                    seed.SetTimeToSpoil(Convert.ToInt32(plantedSeedTimeToSpoil));

                                    DateTime parsedPlantedTime = DateTime.Parse(plantData["PlantedTime"].ToString());
                                    Plant plantObj = new Plant(seed);
                                    plantObj.SetPlantedTime(parsedPlantedTime);
                                    garden.AddPlant(plantObj);
                                }
                            }
                        }

                    }
                    
                }
            }
            
            seedsEmporium = new SeedsEmporium();
            ReloadSeedEmporiumList();
            ReloadGardenList();
        }
        private void seedsEmporiumList_DoubleClick(object sender, EventArgs e)
        {
            Seed seed = seedsEmporium.Seeds.ElementAt(seedsEmporiumList.SelectedItems[0].Index);
            if (player.BuySeed(seed))
            {
                if (player.PlantASeed(garden, seed))
                {
                    seedsEmporium.SellASeed(seed);
                    seedsEmporiumList.Items.Remove(seedsEmporiumList.SelectedItems[0]);
                    conversationLabel.Text = $"Great, you plant a {seed.GetName()}!";
                }
                else
                {
                    player.GetRefund(seed.GetPrice());
                    conversationLabel.Text = "No land plot in garden!";
                }
            }
            else
            {
                conversationLabel.Text = "No money, no seed!";
            }
        }
        private void gardenListView_DoubleClick(object sender, EventArgs e)
        {
            if (gardenListView.SelectedItems.Count > 0)
            {
                Plant plant = garden.GetPlants().ElementAt(gardenListView.SelectedItems[0].Index);
                if (plant.IsItTimeToSpoil())
                {
                    player.ThrowAPlant(plant, garden);
                    conversationLabel.Text = $"Ah, you throw a {plant.GetPlantedSeed().GetName()}!";
                }
                else if (plant.IsItTimeToHarvest())
                {
                    player.HarvestAPlant(plant, garden);
                    conversationLabel.Text = $"Great, you harvested a {plant.GetPlantedSeed().GetName()}!";
                }
                else
                {
                    conversationLabel.Text = "Wait, not yet!";
                }
            }
            else
            {
                conversationLabel.Text = "I'm tired, try again!";
            }
        }
        private void harvestAllButton_Click(object sender, EventArgs e)
        {
            player.HarvestAllPlants(garden);
            conversationLabel.Text = "You harvested all available plants!";
        }
        private void inventoryListView_DoubleClick(object sender, EventArgs e)
        {
            if (inventoryListView.SelectedItems.Count > 0)
            {
                Plant plant = player.Inventory.GetHarvestedPlants().ElementAt(inventoryListView.SelectedItems[0].Index);
                DialogResult dr = MessageBox.Show($"To sell something on market costs $10. Do yo want to sell a {plant.GetPlantedSeed().GetName()}?", "Do you want to sell?", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (player.SellAPlant(plant))
                        {
                            conversationLabel.Text = $"You sold a {plant.GetPlantedSeed().GetName()}!";
                        }
                        else
                        {
                            conversationLabel.Text = "No money, no market!";
                        }
                        break;
                    case DialogResult.No:
                        conversationLabel.Text = "You refused to sell!";
                        break;
                }
            }
            else
            {
                conversationLabel.Text = "I'm tired, try again!";
            }
        }
        private void sellEverythingButton_Click(object sender, EventArgs e)
        {
            if (player.Inventory.GetHarvestedPlants().Count != 0)
            {
                DialogResult dr = MessageBox.Show($"To sell everything on market costs $10. Do yo want to sell all your harvested plants?", "Do you want to sell?", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (player.SellAllPlants())
                        {
                            conversationLabel.Text = "You sold everything!";
                        }
                        else
                        {
                            conversationLabel.Text = "No money, no market!";
                        }
                        break;
                    case DialogResult.No:
                        conversationLabel.Text = "You refused to sell!";
                        break;
                }
            }
            else
            {
                conversationLabel.Text = "No plant, no market!";
            }
        }
        private void gardenListView_MouseHover(object sender, EventArgs e)
        {
            if (gardenListView.Items.Count == 0)
            {
                conversationLabel.Text = "No plant in the garden!";
            }
            else
            {
                conversationLabel.Text = "Harvest an item!";
            }
        }
        private void seedsEmporiumList_MouseHover(object sender, EventArgs e)
        {
            if (seedsEmporiumList.Items.Count == 0)
            {
                conversationLabel.Text = "No plant in the emporium!";
            }
            else
            {
                conversationLabel.Text = "Buy a seed to plant!";
            }
        }
        private void inventoryListView_MouseHover(object sender, EventArgs e)
        {
            if (inventoryListView.Items.Count == 0)
            {
                conversationLabel.Text = "No harvested plant here!";
            }
            else
            {
                conversationLabel.Text = "Sell something in market!";
            }
        }
        private void myWebsiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            myWebsiteLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.emrecan.co");
        }
        private void mediumLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mediumLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.emrecan.co");
        }
        private void addStrawberryToEmporiumButton_Click(object sender, EventArgs e)
        {
            seedsEmporium.AddSeed(new Strawberry());
            seedsEmporiumList.Items.Clear();
            ReloadSeedEmporiumList();
        }
        private void addPearToEmporiumButton_Click(object sender, EventArgs e)
        {
            seedsEmporium.AddSeed(new Pear());
            seedsEmporiumList.Items.Clear();
            ReloadSeedEmporiumList();
        }
        private void addSpinachToEmporiumButton_Click(object sender, EventArgs e)
        {
            seedsEmporium.AddSeed(new Spinach());
            seedsEmporiumList.Items.Clear();
            ReloadSeedEmporiumList();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                { "money", player.GetMoney() },
                { "landPlots", player.GetLandPlots() },
                { "harvestedPlants", player.Inventory.GetHarvestedPlants() },
                { "plants", garden.GetPlants() }

            };

            string jsonPath = Path.Combine(Application.StartupPath, "Resources", "data.json");

            string jsonData = JsonConvert.SerializeObject(dict);

            using (StreamWriter w = new StreamWriter(jsonPath))
            {
                w.Write(jsonData);
            }
        }
    }
}
