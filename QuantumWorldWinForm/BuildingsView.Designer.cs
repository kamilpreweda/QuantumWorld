namespace QuantumWorldWinForm
{
    partial class BuildingsView
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuildingsViewLabel = new System.Windows.Forms.Label();
            this.CarbonFiberLevelLabel = new System.Windows.Forms.Label();
            this.CarbonFiberUpgradeButton = new System.Windows.Forms.Button();
            this.CarbonFiberNameLabel = new System.Windows.Forms.Label();
            this.CarbonFiberCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuildingsViewLabel
            // 
            this.BuildingsViewLabel.AutoSize = true;
            this.BuildingsViewLabel.Location = new System.Drawing.Point(296, 161);
            this.BuildingsViewLabel.Name = "BuildingsViewLabel";
            this.BuildingsViewLabel.Size = new System.Drawing.Size(139, 15);
            this.BuildingsViewLabel.TabIndex = 0;
            this.BuildingsViewLabel.Text = "You are in Buildings View";
            // 
            // CarbonFiberLevelLabel
            // 
            this.CarbonFiberLevelLabel.AutoSize = true;
            this.CarbonFiberLevelLabel.Location = new System.Drawing.Point(158, 86);
            this.CarbonFiberLevelLabel.Name = "CarbonFiberLevelLabel";
            this.CarbonFiberLevelLabel.Size = new System.Drawing.Size(46, 15);
            this.CarbonFiberLevelLabel.TabIndex = 1;
            this.CarbonFiberLevelLabel.Text = "Level: 0";
            // 
            // CarbonFiberUpgradeButton
            // 
            this.CarbonFiberUpgradeButton.Location = new System.Drawing.Point(158, 104);
            this.CarbonFiberUpgradeButton.Name = "CarbonFiberUpgradeButton";
            this.CarbonFiberUpgradeButton.Size = new System.Drawing.Size(75, 23);
            this.CarbonFiberUpgradeButton.TabIndex = 2;
            this.CarbonFiberUpgradeButton.Text = "Upgrade";
            this.CarbonFiberUpgradeButton.UseVisualStyleBackColor = true;
            this.CarbonFiberUpgradeButton.Click += new System.EventHandler(this.CarbonFiberUpgradeButton_Click);
            // 
            // CarbonFiberNameLabel
            // 
            this.CarbonFiberNameLabel.AutoSize = true;
            this.CarbonFiberNameLabel.Location = new System.Drawing.Point(129, 71);
            this.CarbonFiberNameLabel.Name = "CarbonFiberNameLabel";
            this.CarbonFiberNameLabel.Size = new System.Drawing.Size(122, 15);
            this.CarbonFiberNameLabel.TabIndex = 3;
            this.CarbonFiberNameLabel.Text = "Carbon Fiber Building";
            this.CarbonFiberNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarbonFiberCostLabel
            // 
            this.CarbonFiberCostLabel.AutoSize = true;
            this.CarbonFiberCostLabel.Location = new System.Drawing.Point(158, 130);
            this.CarbonFiberCostLabel.Name = "CarbonFiberCostLabel";
            this.CarbonFiberCostLabel.Size = new System.Drawing.Size(58, 15);
            this.CarbonFiberCostLabel.TabIndex = 4;
            this.CarbonFiberCostLabel.Text = "Cost:  100";
            // 
            // BuildingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CarbonFiberCostLabel);
            this.Controls.Add(this.CarbonFiberNameLabel);
            this.Controls.Add(this.CarbonFiberUpgradeButton);
            this.Controls.Add(this.CarbonFiberLevelLabel);
            this.Controls.Add(this.BuildingsViewLabel);
            this.Name = "BuildingsView";
            this.Size = new System.Drawing.Size(750, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BuildingsViewLabel;
        private Label CarbonFiberLevelLabel;
        private Button CarbonFiberUpgradeButton;
        private Label CarbonFiberNameLabel;
        private Label CarbonFiberCostLabel;
    }
}
