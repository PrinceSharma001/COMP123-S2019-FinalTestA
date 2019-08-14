using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
/*
 * STUDENT NAME:
 * STUDENT NO.:
 * DESCRIPTION: Tis is the hero Generator form
 */
namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event Handler for Back Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex !=0)
            {
                MainTabControl.SelectedIndex --;
            }

        }

        /// <summary>
        /// This is the Event Handler for NExt Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count-1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void HeroLastNameabel_Click(object sender, EventArgs e)
        {

        }

        private void FightingLabel_Click(object sender, EventArgs e)
        {

        }

        private void EnduranceDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void HeroGenerator_Load(object sender, EventArgs e)
        {

        }

        private void GenerateAbiltiesButton_Click(object sender, EventArgs e)
        {
            Random name = new Random();
            FightingDataLabel.Text = name.Next(1, 15).ToString();
            AgilityDataLabel.Text = name.Next(1, 15).ToString();
            StrengthDataLabel.Text = name.Next(1, 15).ToString();
            EnduranceDataLabel.Text = name.Next(1, 15).ToString();
            ReasonDataLabel.Text = name.Next(1, 15).ToString();
            IntuitionDataLabel.Text = name.Next(1, 15).ToString();
            PsycheDataLabel.Text = name.Next(1, 15).ToString();
            PopularityDataLabel.Text = name.Next(1, 15).ToString();


        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            string[] lines;
            lines = File.ReadAllLines("../../Data/firstNames.txt");
            Random ran = new Random();
            int index = ran.Next(lines.Length);
            FirstNameDataLabel.Text = lines[index];

            string[] line;
            line = File.ReadAllLines("../../Data/lastNames.txt");
            Random rand = new Random();
            int indexs = ran.Next(line.Length);
            LastNameDataLabel.Text = line[indexs];




        }

        private void GenerateRandomPowersButton_Click(object sender, EventArgs e)
        {
            string[] power;
            power = File.ReadAllLines("../../Data/powers.txt");
            Random randi = new Random();
            int Lst = randi.Next(power.Length);

            RandomPowerData01Label.Text = power[Lst];
            RandomPowerData2Label.Text = power[Lst];
            RandomPowerData3Label.Text = power[Lst];
            RandomPowerData4Label.Text = power[Lst];

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //configure save file dialog box
            ProductSaveFileDialog.FileName = "Powers.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt | All Files (*.*)|*.*";

            //Open Svae File Dialog
            var ShowDialog = ProductSaveFileDialog.ShowDialog();

            if (ShowDialog != DialogResult.Cancel)
            {
                //open Sterem Writer to write
                using (StreamWriter outputString = new StreamWriter(
                    File.Open("Powers.txt", FileMode.Create)))
                {
                    //Write strings to File
                    outputString.WriteLine(Program.Power.Fighting);
                    outputString.WriteLine(Program.Power.Agility);
                    outputString.WriteLine(Program.Power.Strength);
                    outputString.WriteLine(Program.Power.Endurance);
                    outputString.WriteLine(Program.Power.Reason);
                    outputString.WriteLine(Program.Power.Inutuition);
                    outputString.WriteLine(Program.Power.Popularity);

                    // close 
                    outputString.Close();
                    outputString.Dispose();
                }

                MessageBox.Show("File Saved Succesfully!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductSaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
             PowerOpenFileDialog
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
