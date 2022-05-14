namespace QuantumWorldWinForm
{
    partial class ResearchView
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
            this.ResearchViewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResearchViewLabel
            // 
            this.ResearchViewLabel.AutoSize = true;
            this.ResearchViewLabel.Location = new System.Drawing.Point(300, 164);
            this.ResearchViewLabel.Name = "ResearchViewLabel";
            this.ResearchViewLabel.Size = new System.Drawing.Size(134, 15);
            this.ResearchViewLabel.TabIndex = 0;
            this.ResearchViewLabel.Text = "You are in ResearchView";
            // 
            // ResearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResearchViewLabel);
            this.Name = "ResearchView";
            this.Size = new System.Drawing.Size(750, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ResearchViewLabel;
    }
}
