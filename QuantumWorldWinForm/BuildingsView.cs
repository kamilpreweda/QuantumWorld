using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantumWorldWinForm
{
    public partial class BuildingsView : UserControl
    {
        QuantumWorldLibrary.CarbonFiberBuilding CarbonFiberbld = new QuantumWorldLibrary.CarbonFiberBuilding();


        public BuildingsView()
        {

            InitializeComponent();
            CarbonFiberLevelLabel.Text = $"Level: {CarbonFiberbld.BuildingLevel}";

        }



        public void CarbonFiberUpgradeButton_Click(object sender, EventArgs e)
        {
            CarbonFiberbld.BuildingLevel++;
            CarbonFiberbld.BuildingCost.First().ResourceValue *= 2;
            CarbonFiberLevelLabel.Text = $"Level: {CarbonFiberbld.BuildingLevel}";
            CarbonFiberCostLabel.Text = $"Cost: {CarbonFiberbld.BuildingCost.First().ResourceValue}";
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



}
