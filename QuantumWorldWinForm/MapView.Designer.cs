namespace QuantumWorldWinForm
{
    partial class MapView
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
            this.MapViewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MapViewLabel
            // 
            this.MapViewLabel.AutoSize = true;
            this.MapViewLabel.Location = new System.Drawing.Point(322, 160);
            this.MapViewLabel.Name = "MapViewLabel";
            this.MapViewLabel.Size = new System.Drawing.Size(111, 15);
            this.MapViewLabel.TabIndex = 0;
            this.MapViewLabel.Text = "You are in MapView";
            // 
            // MapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MapViewLabel);
            this.Name = "MapView";
            this.Size = new System.Drawing.Size(750, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MapViewLabel;
    }
}
