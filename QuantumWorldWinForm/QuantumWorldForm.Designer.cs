namespace QuantumWorldWinForm
{
    partial class QuantumWorldForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.MapButton = new System.Windows.Forms.Button();
            this.DocksButton = new System.Windows.Forms.Button();
            this.ResearchButton = new System.Windows.Forms.Button();
            this.ResourcesButton = new System.Windows.Forms.Button();
            this.BuildingsButton = new System.Windows.Forms.Button();
            this.OverviewButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SolarEnergyLabel = new System.Windows.Forms.Label();
            this.HiggsBosonLabel = new System.Windows.Forms.Label();
            this.QuantumGlassLabel = new System.Windows.Forms.Label();
            this.CarbonFiberLabel = new System.Windows.Forms.Label();
            this.overviewView1 = new QuantumWorldWinForm.OverviewView();
            this.buildingsView1 = new QuantumWorldWinForm.BuildingsView();
            this.resourcesView1 = new QuantumWorldWinForm.ResourcesView();
            this.researchView1 = new QuantumWorldWinForm.ResearchView();
            this.docksView1 = new QuantumWorldWinForm.DocksView();
            this.mapView1 = new QuantumWorldWinForm.MapView();
            this.logoutView1 = new QuantumWorldWinForm.LogoutView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.MapButton);
            this.panel1.Controls.Add(this.DocksButton);
            this.panel1.Controls.Add(this.ResearchButton);
            this.panel1.Controls.Add(this.ResourcesButton);
            this.panel1.Controls.Add(this.BuildingsButton);
            this.panel1.Controls.Add(this.OverviewButton);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 350);
            this.panel1.TabIndex = 0;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(13, 307);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(93, 31);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MapButton
            // 
            this.MapButton.Location = new System.Drawing.Point(13, 258);
            this.MapButton.Name = "MapButton";
            this.MapButton.Size = new System.Drawing.Size(93, 31);
            this.MapButton.TabIndex = 6;
            this.MapButton.Text = "Map";
            this.MapButton.UseVisualStyleBackColor = true;
            this.MapButton.Click += new System.EventHandler(this.MapButton_Click);
            // 
            // DocksButton
            // 
            this.DocksButton.Location = new System.Drawing.Point(13, 208);
            this.DocksButton.Name = "DocksButton";
            this.DocksButton.Size = new System.Drawing.Size(93, 31);
            this.DocksButton.TabIndex = 5;
            this.DocksButton.Text = "Docks";
            this.DocksButton.UseVisualStyleBackColor = true;
            this.DocksButton.Click += new System.EventHandler(this.DocksButton_Click);
            // 
            // ResearchButton
            // 
            this.ResearchButton.Location = new System.Drawing.Point(13, 158);
            this.ResearchButton.Name = "ResearchButton";
            this.ResearchButton.Size = new System.Drawing.Size(93, 31);
            this.ResearchButton.TabIndex = 4;
            this.ResearchButton.Text = "Research";
            this.ResearchButton.UseVisualStyleBackColor = true;
            this.ResearchButton.Click += new System.EventHandler(this.ResearchButton_Click);
            // 
            // ResourcesButton
            // 
            this.ResourcesButton.Location = new System.Drawing.Point(13, 108);
            this.ResourcesButton.Name = "ResourcesButton";
            this.ResourcesButton.Size = new System.Drawing.Size(93, 31);
            this.ResourcesButton.TabIndex = 3;
            this.ResourcesButton.Text = "Resources";
            this.ResourcesButton.UseVisualStyleBackColor = true;
            this.ResourcesButton.Click += new System.EventHandler(this.ResourcesButton_Click);
            // 
            // BuildingsButton
            // 
            this.BuildingsButton.Location = new System.Drawing.Point(13, 59);
            this.BuildingsButton.Name = "BuildingsButton";
            this.BuildingsButton.Size = new System.Drawing.Size(93, 31);
            this.BuildingsButton.TabIndex = 2;
            this.BuildingsButton.Text = "Buildings";
            this.BuildingsButton.UseVisualStyleBackColor = true;
            this.BuildingsButton.Click += new System.EventHandler(this.BuildingsButton_Click);
            // 
            // OverviewButton
            // 
            this.OverviewButton.Location = new System.Drawing.Point(13, 13);
            this.OverviewButton.Name = "OverviewButton";
            this.OverviewButton.Size = new System.Drawing.Size(93, 31);
            this.OverviewButton.TabIndex = 1;
            this.OverviewButton.Text = "Overview";
            this.OverviewButton.UseVisualStyleBackColor = true;
            this.OverviewButton.Click += new System.EventHandler(this.OverviewButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SolarEnergyLabel);
            this.panel2.Controls.Add(this.HiggsBosonLabel);
            this.panel2.Controls.Add(this.QuantumGlassLabel);
            this.panel2.Controls.Add(this.CarbonFiberLabel);
            this.panel2.Location = new System.Drawing.Point(136, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 50);
            this.panel2.TabIndex = 1;
            // 
            // SolarEnergyLabel
            // 
            this.SolarEnergyLabel.AutoSize = true;
            this.SolarEnergyLabel.Location = new System.Drawing.Point(550, 21);
            this.SolarEnergyLabel.Name = "SolarEnergyLabel";
            this.SolarEnergyLabel.Size = new System.Drawing.Size(72, 15);
            this.SolarEnergyLabel.TabIndex = 3;
            this.SolarEnergyLabel.Text = "SolarEnergy:";
            // 
            // HiggsBosonLabel
            // 
            this.HiggsBosonLabel.AutoSize = true;
            this.HiggsBosonLabel.Location = new System.Drawing.Point(364, 21);
            this.HiggsBosonLabel.Name = "HiggsBosonLabel";
            this.HiggsBosonLabel.Size = new System.Drawing.Size(74, 15);
            this.HiggsBosonLabel.TabIndex = 2;
            this.HiggsBosonLabel.Text = "HiggsBoson:";
            // 
            // QuantumGlassLabel
            // 
            this.QuantumGlassLabel.AutoSize = true;
            this.QuantumGlassLabel.Location = new System.Drawing.Point(176, 21);
            this.QuantumGlassLabel.Name = "QuantumGlassLabel";
            this.QuantumGlassLabel.Size = new System.Drawing.Size(88, 15);
            this.QuantumGlassLabel.TabIndex = 1;
            this.QuantumGlassLabel.Text = "QuantumGlass:";
            this.QuantumGlassLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarbonFiberLabel
            // 
            this.CarbonFiberLabel.AutoSize = true;
            this.CarbonFiberLabel.Location = new System.Drawing.Point(23, 21);
            this.CarbonFiberLabel.Name = "CarbonFiberLabel";
            this.CarbonFiberLabel.Size = new System.Drawing.Size(75, 15);
            this.CarbonFiberLabel.TabIndex = 0;
            this.CarbonFiberLabel.Text = "CarbonFiber:";
            // 
            // overviewView1
            // 
            this.overviewView1.Location = new System.Drawing.Point(136, 84);
            this.overviewView1.Name = "overviewView1";
            this.overviewView1.Size = new System.Drawing.Size(750, 350);
            this.overviewView1.TabIndex = 2;
            // 
            // buildingsView1
            // 
            this.buildingsView1.Location = new System.Drawing.Point(136, 84);
            this.buildingsView1.Name = "buildingsView1";
            this.buildingsView1.Size = new System.Drawing.Size(750, 350);
            this.buildingsView1.TabIndex = 3;
            // 
            // resourcesView1
            // 
            this.resourcesView1.Location = new System.Drawing.Point(136, 84);
            this.resourcesView1.Name = "resourcesView1";
            this.resourcesView1.Size = new System.Drawing.Size(750, 350);
            this.resourcesView1.TabIndex = 4;
            // 
            // researchView1
            // 
            this.researchView1.Location = new System.Drawing.Point(136, 84);
            this.researchView1.Name = "researchView1";
            this.researchView1.Size = new System.Drawing.Size(750, 350);
            this.researchView1.TabIndex = 5;
            // 
            // docksView1
            // 
            this.docksView1.Location = new System.Drawing.Point(136, 84);
            this.docksView1.Name = "docksView1";
            this.docksView1.Size = new System.Drawing.Size(750, 350);
            this.docksView1.TabIndex = 6;
            // 
            // mapView1
            // 
            this.mapView1.Location = new System.Drawing.Point(136, 84);
            this.mapView1.Name = "mapView1";
            this.mapView1.Size = new System.Drawing.Size(750, 350);
            this.mapView1.TabIndex = 7;
            // 
            // logoutView1
            // 
            this.logoutView1.Location = new System.Drawing.Point(136, 84);
            this.logoutView1.Name = "logoutView1";
            this.logoutView1.Size = new System.Drawing.Size(750, 350);
            this.logoutView1.TabIndex = 8;
            // 
            // QuantumWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.logoutView1);
            this.Controls.Add(this.mapView1);
            this.Controls.Add(this.docksView1);
            this.Controls.Add(this.researchView1);
            this.Controls.Add(this.resourcesView1);
            this.Controls.Add(this.buildingsView1);
            this.Controls.Add(this.overviewView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuantumWorldForm";
            this.Text = "Quantum World";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button LogoutButton;
        private Button MapButton;
        private Button DocksButton;
        private Button ResearchButton;
        private Button ResourcesButton;
        private Button BuildingsButton;
        private Button OverviewButton;
        private Panel panel2;
        private Label SolarEnergyLabel;
        private Label HiggsBosonLabel;
        private Label QuantumGlassLabel;
        private Label CarbonFiberLabel;
        private OverviewView overviewView1;
        private BuildingsView buildingsView1;
        private ResourcesView resourcesView1;
        private ResearchView researchView1;
        private DocksView docksView1;
        private MapView mapView1;
        private LogoutView logoutView1;
    }
}