namespace QuantumWorldWinForm
{
    partial class DocksView
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
            this.DocksViewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DocksViewLabel
            // 
            this.DocksViewLabel.AutoSize = true;
            this.DocksViewLabel.Location = new System.Drawing.Point(321, 166);
            this.DocksViewLabel.Name = "DocksViewLabel";
            this.DocksViewLabel.Size = new System.Drawing.Size(119, 15);
            this.DocksViewLabel.TabIndex = 0;
            this.DocksViewLabel.Text = "You are in DocksView";
            // 
            // DocksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DocksViewLabel);
            this.Name = "DocksView";
            this.Size = new System.Drawing.Size(750, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DocksViewLabel;
    }
}
