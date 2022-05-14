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
            CarbonFiberCostLabel.Text = $"Carbon Fiber: {(CarbonFiberbld.BuildingCost.ElementAt(0).ResourceValue)-400} / " +
                                        $"Quantum Glass: {(CarbonFiberbld.BuildingCost.ElementAt(1).ResourceValue)-200} / " +
                                        $"Higgs Boson: {CarbonFiberbld.BuildingCost.ElementAt(2).ResourceValue} / " +
                                        $"Required Energy: {(CarbonFiberbld.BuildingCost.ElementAt(3).ResourceValue)-90}";

        }



        public void CarbonFiberUpgradeButton_Click(object sender, EventArgs e)
        {
            CarbonFiberbld.BuildingLevel++;
            CarbonFiberbld.BuildingCost.ElementAt(0).ResourceValue *= (float)1.1;
            CarbonFiberbld.BuildingCost.ElementAt(1).ResourceValue *= (float)1.09;
            CarbonFiberbld.BuildingCost.ElementAt(2).ResourceValue *= (float)1.08;
            CarbonFiberbld.BuildingCost.ElementAt(3).ResourceValue *= (float)1.07;

            CarbonFiberLevelLabel.Text = $"Level: {CarbonFiberbld.BuildingLevel}";
            CarbonFiberCostLabel.Text = $"Carbon Fiber: {(CarbonFiberbld.BuildingCost.ElementAt(0).ResourceValue) -400} / " +
                                        $"Quantum Glass: {(CarbonFiberbld.BuildingCost.ElementAt(1).ResourceValue) -200} / " +
                                        $"Higgs Boson: {CarbonFiberbld.BuildingCost.ElementAt(2).ResourceValue} / " +
                                        $"Required Energy: {(CarbonFiberbld.BuildingCost.ElementAt(3).ResourceValue)-90}";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



}
