
namespace BaseSim2021
{
    partial class Modif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOk = new System.Windows.Forms.Button();
            this.ButtonAnnuler = new System.Windows.Forms.Button();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(80, 18);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 35);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // ButtonAnnuler
            // 
            this.ButtonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAnnuler.Location = new System.Drawing.Point(80, 82);
            this.ButtonAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.Size = new System.Drawing.Size(112, 35);
            this.ButtonAnnuler.TabIndex = 1;
            this.ButtonAnnuler.Text = "Annuler";
            this.ButtonAnnuler.UseVisualStyleBackColor = true;
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(10, 52);
            this.NumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(60, 26);
            this.NumericUpDown.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(114, 166);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "label1";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 223);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.ButtonAnnuler);
            this.Controls.Add(this.buttonOk);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Modif";
            this.Text = "Modif";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button ButtonAnnuler;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Label labelName;
    }
}