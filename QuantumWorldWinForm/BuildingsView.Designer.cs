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
            // BuildingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BuildingsViewLabel);
            this.Name = "BuildingsView";
            this.Size = new System.Drawing.Size(750, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BuildingsViewLabel;
    }
}
