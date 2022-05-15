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
        QuantumWorldLibrary.QuantumGlassBuilding QuantumGlassbld = new QuantumWorldLibrary.QuantumGlassBuilding();


        public BuildingsView()
        {

            InitializeComponent();
            CarbonFiberNameLabel.Text = $"{CarbonFiberbld.BuildingName}";
            CarbonFiberLevelLabel.Text = $"Lvl: {CarbonFiberbld.BuildingLevel}";
            CarbonFiberCostLabel.Text = $"CFI: {(CarbonFiberbld.BuildingCost.ElementAt(0).ResourceValue)-400} / " +
                                        $"QGI: {(CarbonFiberbld.BuildingCost.ElementAt(1).ResourceValue)-200} / " +
                                        $"HBI: {CarbonFiberbld.BuildingCost.ElementAt(2).ResourceValue} / " +
                                        $"SEI: {(CarbonFiberbld.BuildingCost.ElementAt(3).ResourceValue)-90}";

            QuantumGlassNameLabel.Text = $"{QuantumGlassbld.BuildingName}";
            QuantumGlassLevelLabel.Text = $"Lvl: {QuantumGlassbld.BuildingLevel}";
            QuantumGlassCostLabel.Text = $"CFI: {(QuantumGlassbld.BuildingCost.ElementAt(0).ResourceValue) - 350} / " +
                                         $"QGI: {(QuantumGlassbld.BuildingCost.ElementAt(1).ResourceValue) - 100} / " +
                                         $"HBI: {QuantumGlassbld.BuildingCost.ElementAt(2).ResourceValue} / " +
                                         $"SEI: {(QuantumGlassbld.BuildingCost.ElementAt(3).ResourceValue) - 85}";

        }



        public void CarbonFiberUpgradeButton_Click(object sender, EventArgs e)
        {
            CarbonFiberbld.BuildingLevel++;
            CarbonFiberbld.BuildingCost.ElementAt(0).ResourceValue *= (float)1.1;
            CarbonFiberbld.BuildingCost.ElementAt(1).ResourceValue *= (float)1.09;
            CarbonFiberbld.BuildingCost.ElementAt(2).ResourceValue *= (float)1.08;
            CarbonFiberbld.BuildingCost.ElementAt(3).ResourceValue *= (float)1.07;

            CarbonFiberLevelLabel.Text = $"Lvl: {CarbonFiberbld.BuildingLevel}";
            CarbonFiberCostLabel.Text = $"CFI: {(CarbonFiberbld.BuildingCost.ElementAt(0).ResourceValue) -400} / " +
                                        $"QGI: {(CarbonFiberbld.BuildingCost.ElementAt(1).ResourceValue) -200} / " +
                                        $"HBI: {CarbonFiberbld.BuildingCost.ElementAt(2).ResourceValue} / " +
                                        $"SEI: {(CarbonFiberbld.BuildingCost.ElementAt(3).ResourceValue)-90}";
        }

        public void QuantumGlassUpgradeButton_Click(object sender, EventArgs e)
        {
            QuantumGlassbld.BuildingLevel++;
            QuantumGlassbld.BuildingCost.ElementAt(0).ResourceValue *= (float)1.1;
            QuantumGlassbld.BuildingCost.ElementAt(1).ResourceValue *= (float)1.09;
            QuantumGlassbld.BuildingCost.ElementAt(2).ResourceValue *= (float)1.08;
            QuantumGlassbld.BuildingCost.ElementAt(3).ResourceValue *= (float)1.07;

            QuantumGlassLevelLabel.Text = $"Lvl: {QuantumGlassbld.BuildingLevel}";
            QuantumGlassCostLabel.Text = $"CFI: {(QuantumGlassbld.BuildingCost.ElementAt(0).ResourceValue) - 350} / " +
                                         $"QGI: {(QuantumGlassbld.BuildingCost.ElementAt(1).ResourceValue) - 100} / " +
                                         $"HBI: {QuantumGlassbld.BuildingCost.ElementAt(2).ResourceValue} / " +
                                         $"SEI: {(QuantumGlassbld.BuildingCost.ElementAt(3).ResourceValue) - 85}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuildingsView_Load(object sender, EventArgs e)
        {

        }

        private void CarbonFiberCostLabel_Click(object sender, EventArgs e)
        {

        }
    }



}
