namespace QuantumWorldWinForm
{
    partial class OverviewView
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
            this.OverviewViewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OverviewViewLabel
            // 
            this.OverviewViewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverviewViewLabel.AutoSize = true;
            this.OverviewViewLabel.Location = new System.Drawing.Point(307, 166);
            this.OverviewViewLabel.Name = "OverviewViewLabel";
            this.OverviewViewLabel.Size = new System.Drawing.Size(136, 15);
            this.OverviewViewLabel.TabIndex = 0;
            this.OverviewViewLabel.Text = "You are in OverviewView";
            this.OverviewViewLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // OverviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OverviewViewLabel);
            this.Name = "OverviewView";
            this.Size = new System.Drawing.Size(750, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OverviewViewLabel;
    }
}
