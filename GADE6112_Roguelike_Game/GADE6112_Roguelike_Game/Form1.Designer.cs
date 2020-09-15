namespace GADE6112_Roguelike_Game
{
    partial class frmRLG
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
            this.txtInfoBox = new System.Windows.Forms.RichTextBox();
            this.lblMap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInfoBox
            // 
            this.txtInfoBox.Location = new System.Drawing.Point(13, 359);
            this.txtInfoBox.Name = "txtInfoBox";
            this.txtInfoBox.Size = new System.Drawing.Size(775, 79);
            this.txtInfoBox.TabIndex = 0;
            this.txtInfoBox.Text = "";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(13, 13);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(35, 13);
            this.lblMap.TabIndex = 1;
            this.lblMap.Text = "label1";
            // 
            // frmRLG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.txtInfoBox);
            this.Name = "frmRLG";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInfoBox;
        private System.Windows.Forms.Label lblMap;
    }
}

