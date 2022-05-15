using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuantumWorldLibrary;

namespace QuantumWorldWinForm
{
    public partial class BuildingsView : UserControl
    {
        CarbonFiberBuilding CarbonFiberbld = new CarbonFiberBuilding();
        QuantumGlassBuilding QuantumGlassbld = new QuantumGlassBuilding();
        HiggsBosonBuilding HiggsBosonbld = new HiggsBosonBuilding();
        SolarEnergyBuilding SolarEnergybld = new SolarEnergyBuilding();
        RobotFactoryBuilding RobotFactorybld = new RobotFactoryBuilding();


        public BuildingsView()
        {

            InitializeComponent();
            CarbonFiberNameLabel.Text = $"{CarbonFiberbld.BuildingName}";
            CarbonFiberLevelLabel.Text = $"Lvl: {CarbonFiberbld.BuildingLevel}";
            CarbonFiberCostLabel.Text = $"CFI: {(CarbonFiberbld.BuildingCost.ElementAt(0).ResourceBaseStat) - 400} / " +
                                        $"QGI: {(CarbonFiberbld.BuildingCost.ElementAt(1).ResourceBaseStat) - 200} / " +
                                        $"HBI: 0 / " +
                                        //                              $"HBI: {CarbonFiberbld.BuildingCost.ElementAt(2).ResourceBaseStat} / " +
                                        $"SEI: {(CarbonFiberbld.BuildingCost.ElementAt(3).ResourceBaseStat) - 90}";

            QuantumGlassNameLabel.Text = $"{QuantumGlassbld.BuildingName}";
            QuantumGlassLevelLabel.Text = $"Lvl: {QuantumGlassbld.BuildingLevel}";
            QuantumGlassCostLabel.Text = $"CFI: {(QuantumGlassbld.BuildingCost.ElementAt(0).ResourceBaseStat) - 350} / " +
                                         $"QGI: {(QuantumGlassbld.BuildingCost.ElementAt(1).ResourceBaseStat) - 100} / " +
                                         $"HBI: 0 / " +
                                         //                               $"HBI: {QuantumGlassbld.BuildingCost.ElementAt(2).ResourceBaseStat} / " +
                                         $"SEI: {(QuantumGlassbld.BuildingCost.ElementAt(3).ResourceBaseStat) - 85}";

            HiggsBosonNameLabel.Text = $"{HiggsBosonbld.BuildingName}";
            HiggsBosonLevelLabel.Text = $"Lvl: {HiggsBosonbld.BuildingLevel}";
            HiggsBosonCostLabel.Text = $"CFI: {(HiggsBosonbld.BuildingCost.ElementAt(0).ResourceBaseStat) - 250} / " +
                                         $"QGI: {(HiggsBosonbld.BuildingCost.ElementAt(1).ResourceBaseStat) - 50} / " +
                                         $"HBI: 0 / " +
                                         //                                $"HBI: {HiggsBosonbld.BuildingCost.ElementAt(2).ResourceBaseStat} / " +
                                         $"SEI: {(HiggsBosonbld.BuildingCost.ElementAt(3).ResourceBaseStat) - 80}";

            SolarEnergyNameLabel.Text = $"{SolarEnergybld.BuildingName}";
            SolarEnergyLevelLabel.Text = $"Lvl: {SolarEnergybld.BuildingLevel}";
            SolarEnergyCostLabel.Text = $"CFI: {(SolarEnergybld.BuildingCost.ElementAt(0).ResourceBaseStat) - 400} / " +
                                         $"QGI: {(SolarEnergybld.BuildingCost.ElementAt(1).ResourceBaseStat) - 150} / " +
                                         $"HBI: 0 / " +
                                         //                                $"HBI: {SolarEnergybld.BuildingCost.ElementAt(2).ResourceBaseStat} / " +
                                         $"SEI: 0 / ";
                                         //                               $"SEI: {(SolarEnergybld.BuildingCost.ElementAt(3).ResourceBaseStat) - 100}";

            RobotFactoryNameLabel.Text = $"{RobotFactorybld.BuildingName}";
            RobotFactoryLevelLabel.Text = $"Lvl: {RobotFactorybld.BuildingLevel}";
            RobotFactoryCostLabel.Text = $"CFI: {(RobotFactorybld.BuildingCost.ElementAt(0).ResourceBaseStat) - 100} / " +
                                         $"QGI: {(RobotFactorybld.BuildingCost.ElementAt(1).ResourceBaseStat) - 100} / " +
                                         $"HBI: {(RobotFactorybld.BuildingCost.ElementAt(2).ResourceBaseStat) + 50} / " +
                                         $"SEI: 0 / ";
                                        //  $"SEI: {(RobotFactorybld.BuildingCost.ElementAt(3).ResourceBaseStat) - 100}";

        }



        public void CarbonFiberUpgradeButton_Click(object sender, EventArgs e)
        {
            CarbonFiberbld.BuildingLevel++;
            CarbonFiberbld.BuildingCost.ElementAt(0).ResourceBaseStat *= (float)1.1;
            CarbonFiberbld.BuildingCost.ElementAt(1).ResourceBaseStat *= (float)1.09;
            //   CarbonFiberbld.BuildingCost.ElementAt(2).ResourceBaseStat *= (float)1.08;
            CarbonFiberbld.BuildingCost.ElementAt(3).ResourceBaseStat *= (float)1.07;

            CarbonFiberLevelLabel.Text = $"Lvl: {CarbonFiberbld.BuildingLevel}";
            CarbonFiberCostLabel.Text = $"CFI: {(CarbonFiberbld.BuildingCost.ElementAt(0).ResourceBaseStat) - 400} / " +
                                        $"QGI: {(CarbonFiberbld.BuildingCost.ElementAt(1).ResourceBaseStat) - 200} / " +
                                        $"HBI: 0 / " +
         //                               $"HBI: {CarbonFiberbld.BuildingCost.ElementAt(2).ResourceBaseStat} / " +
                                        $"SEI: {(CarbonFiberbld.BuildingCost.ElementAt(3).ResourceBaseStat) - 90}";

        }

        public void QuantumGlassUpgradeButton_Click(object sender, EventArgs e)
        {
            QuantumGlassbld.BuildingLevel++;
            QuantumGlassbld.BuildingCost.ElementAt(0).ResourceBaseStat *= (float)1.11;
            QuantumGlassbld.BuildingCost.ElementAt(1).ResourceBaseStat *= (float)1.108;
         //   QuantumGlassbld.BuildingCost.ElementAt(2).ResourceBaseStat *= (float)1.09;
            QuantumGlassbld.BuildingCost.ElementAt(3).ResourceBaseStat *= (float)1.08;

            QuantumGlassLevelLabel.Text = $"Lvl: {QuantumGlassbld.BuildingLevel}";
            QuantumGlassCostLabel.Text = $"CFI: {(QuantumGlassbld.BuildingCost.ElementAt(0).ResourceBaseStat) - 350} / " +
                                         $"QGI: {(QuantumGlassbld.BuildingCost.ElementAt(1).ResourceBaseStat) - 100} / " +
                                         $"HBI: 0 / " +
         //                                $"HBI: {QuantumGlassbld.BuildingCost.ElementAt(2).ResourceBaseStat} / " +
                                         $"SEI: {(QuantumGlassbld.BuildingCost.ElementAt(3).ResourceBaseStat) - 85}";
        }

        public void HiggsBosonUpgradeButton_Click(object sender, EventArgs e)
        {
            HiggsBosonbld.BuildingLevel++;
            HiggsBosonbld.BuildingCost.ElementAt(0).ResourceBaseStat *= (float)1.12;
            HiggsBosonbld.BuildingCost.ElementAt(1).ResourceBaseStat *= (float)1.12;
         //   HiggsBosonbld.BuildingCost.ElementAt(2).ResourceBaseStat *= (float)1.1;
            HiggsBosonbld.BuildingCost.ElementAt(3).ResourceBaseStat *= (float)1.09;

            HiggsBosonLevelLabel.Text = $"Lvl: {HiggsBosonbld.BuildingLevel}";
            HiggsBosonCostLabel.Text = $"CFI: {(HiggsBosonbld.BuildingCost.ElementAt(0).ResourceBaseStat) - 250} / " +
                                         $"QGI: {(HiggsBosonbld.BuildingCost.ElementAt(1).ResourceBaseStat) - 50} / " +
                                         $"HBI: 0 / " +
         //                                $"HBI: {HiggsBosonbld.BuildingCost.ElementAt(2).ResourceBaseStat} / " +
                                         $"SEI: {(HiggsBosonbld.BuildingCost.ElementAt(3).ResourceBaseStat) - 80}";
        }

        public void SolarEnergyUpgradeButton_Click(object sender, EventArgs e)
        {
            SolarEnergybld.BuildingLevel++;
            SolarEnergybld.BuildingCost.ElementAt(0).ResourceBaseStat *= (float)1.15;
            SolarEnergybld.BuildingCost.ElementAt(1).ResourceBaseStat *= (float)1.15;
            //          SolarEnergybld.BuildingCost.ElementAt(2).ResourceBaseStat *= (float)1.1;
            //          SolarEnergybld.BuildingCost.ElementAt(3).ResourceBaseStat *= (float)1.09;

            SolarEnergyLevelLabel.Text = $"Lvl: {SolarEnergybld.BuildingLevel}";
            SolarEnergyCostLabel.Text = $"CFI: {(SolarEnergybld.BuildingCost.ElementAt(0).ResourceBaseStat) - 450} / " +
                                         $"QGI: {(SolarEnergybld.BuildingCost.ElementAt(1).ResourceBaseStat) - 150} / " +
                                         $"HBI: 0 / " +
                                         //                                $"HBI: {SolarEnergybld.BuildingCost.ElementAt(2).ResourceBaseStat} / " +
                                         $"SEI: 0";
         //                                $"SEI: {(SolarEnergybld.BuildingCost.ElementAt(3).ResourceBaseStat) - 100}";

        }

        public void RobotFactoryUpgradeButton_Click(object sender, EventArgs e)
        {
            RobotFactorybld.BuildingLevel++;
            RobotFactorybld.BuildingCost.ElementAt(0).ResourceBaseStat *= (float)1.15;
            RobotFactorybld.BuildingCost.ElementAt(1).ResourceBaseStat *= (float)1.15;
            RobotFactorybld.BuildingCost.ElementAt(2).ResourceBaseStat *= (float)1.15;
            //          SolarEnergybld.BuildingCost.ElementAt(3).ResourceValue *= (float)1.09;

            RobotFactoryLevelLabel.Text = $"Lvl: {RobotFactorybld.BuildingLevel}";
            RobotFactoryCostLabel.Text = $"CFI: {(RobotFactorybld.BuildingCost.ElementAt(0).ResourceBaseStat) - 100} / " +
                                         $"QGI: {(RobotFactorybld.BuildingCost.ElementAt(1).ResourceBaseStat) - 100} / " +
                                         $"HBI: {(RobotFactorybld.BuildingCost.ElementAt(2).ResourceBaseStat) + 50} / " +
                                         $"SEI: 0";
            //                             $"SEI: {(RobotFactorybld.BuildingCost.ElementAt(3).ResourceBaseStat) - 100}";
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

        private void CarbonFiberLevelLabel_Click(object sender, EventArgs e)
        {

        }

        private void QuantumGlassLevelLabel_Click(object sender, EventArgs e)
        {

        }

        private void HiggsBosonLevelLabel_Click(object sender, EventArgs e)
        {

        }

        private void SolarEnergyLevelLabel_Click(object sender, EventArgs e)
        {

        }
    }



}
