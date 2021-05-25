
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
            this.labelDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(53, 12);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // ButtonAnnuler
            // 
            this.ButtonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAnnuler.Location = new System.Drawing.Point(53, 53);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.ButtonAnnuler.TabIndex = 1;
            this.ButtonAnnuler.Text = "Annuler";
            this.ButtonAnnuler.UseVisualStyleBackColor = true;
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(7, 34);
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.NumericUpDown.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(70, 89);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "label1";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(70, 112);
            this.labelDesc.MaximumSize = new System.Drawing.Size(150, 150);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(35, 13);
            this.labelDesc.TabIndex = 4;
            this.labelDesc.Text = "label1";
            // 
            // Modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 145);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.ButtonAnnuler);
            this.Controls.Add(this.buttonOk);
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
        private System.Windows.Forms.Label labelDesc;
    }
}