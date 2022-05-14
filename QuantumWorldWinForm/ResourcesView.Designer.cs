namespace QuantumWorldWinForm
{
    partial class ResourcesView
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
            this.ResourcesViewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResourcesViewLabel
            // 
            this.ResourcesViewLabel.AutoSize = true;
            this.ResourcesViewLabel.Location = new System.Drawing.Point(302, 162);
            this.ResourcesViewLabel.Name = "ResourcesViewLabel";
            this.ResourcesViewLabel.Size = new System.Drawing.Size(140, 15);
            this.ResourcesViewLabel.TabIndex = 0;
            this.ResourcesViewLabel.Text = "You are in ResourcesView";
            // 
            // ResourcesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResourcesViewLabel);
            this.Name = "ResourcesView";
            this.Size = new System.Drawing.Size(750, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ResourcesViewLabel;
    }
}
