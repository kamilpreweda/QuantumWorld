using QuantumWorldLibrary;

namespace QuantumWorldWinForm
{
    public partial class QuantumWorldForm : Form
    {
        
        public QuantumWorldForm()
        {
            InitializeComponent();

            CarbonFiberResource carbonFiber = new CarbonFiberResource();
            QuantumGlassResource quantumGlass = new QuantumGlassResource();
            HiggsBosonResource higgsBoson = new HiggsBosonResource();
            SolarEnergyResource solarEnergy = new SolarEnergyResource();



            CarbonFiberLabel.Text = $"Carbon Fiber: {carbonFiber.ResourceValue}";
            QuantumGlassLabel.Text = $"Quantum Glass: {quantumGlass.ResourceValue}";
            HiggsBosonLabel.Text = $"Higgs Boson: {higgsBoson.ResourceValue}";
            SolarEnergyLabel.Text = $"Solar Energy: {solarEnergy.ResourceValue}";


            hideAllViews();
            overviewView1.Show();
            overviewView1.BringToFront();
   

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void OverviewButton_Click(object sender, EventArgs e)
        {
            hideAllViews();
            overviewView1.Show();
            overviewView1.BringToFront();
        }

        private void BuildingsButton_Click(object sender, EventArgs e)
        {
            hideAllViews();
            buildingsView1.Show();
            buildingsView1.BringToFront();
            
        }

        private void DocksButton_Click(object sender, EventArgs e)
        {
            hideAllViews();
            docksView1.Show();
            docksView1.BringToFront();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            hideAllViews();
            logoutView1.Show();
            logoutView1.BringToFront();
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            hideAllViews();
            mapView1.Show();
            mapView1.BringToFront();
        }

        private void ResearchButton_Click(object sender, EventArgs e)
        {
            hideAllViews();
            researchView1.Show();
            researchView1.BringToFront();
        }

        private void ResourcesButton_Click(object sender, EventArgs e)
        {
            hideAllViews();
            resourcesView1.Show();
            resourcesView1.BringToFront();
        }

        private void hideAllViews()
        {
            overviewView1.Hide();
            buildingsView1.Hide();
            docksView1.Hide();
            logoutView1.Hide();
            mapView1.Hide();
            overviewView1.Hide();
            researchView1.Hide();
            resourcesView1.Hide();
        }


        private void Sample_data()
        {
            
        }
    }
}