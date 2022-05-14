namespace QuantumWorldWinForm
{
    partial class LogoutView
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
            this.LogoutViewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogoutViewLabel
            // 
            this.LogoutViewLabel.AutoSize = true;
            this.LogoutViewLabel.Location = new System.Drawing.Point(313, 157);
            this.LogoutViewLabel.Name = "LogoutViewLabel";
            this.LogoutViewLabel.Size = new System.Drawing.Size(125, 15);
            this.LogoutViewLabel.TabIndex = 0;
            this.LogoutViewLabel.Text = "You are in LogoutView";
            // 
            // LogoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogoutViewLabel);
            this.Name = "LogoutView";
            this.Size = new System.Drawing.Size(750, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LogoutViewLabel;
    }
}
