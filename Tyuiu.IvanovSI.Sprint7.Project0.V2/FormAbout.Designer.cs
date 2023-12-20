
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOk_ISI = new System.Windows.Forms.Button();
            this.pictureBoxAva_ISI = new System.Windows.Forms.PictureBox();
            this.labelHelp_ISI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_ISI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk_ISI
            // 
            this.buttonOk_ISI.Location = new System.Drawing.Point(460, 254);
            this.buttonOk_ISI.Name = "buttonOk_ISI";
            this.buttonOk_ISI.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_ISI.TabIndex = 0;
            this.buttonOk_ISI.Text = "Ок";
            this.buttonOk_ISI.UseVisualStyleBackColor = true;
            this.buttonOk_ISI.Click += new System.EventHandler(this.buttonOk_ISI_Click);
            // 
            // pictureBoxAva_ISI
            // 
            this.pictureBoxAva_ISI.Image = global::Tyuiu.IvanovSI.Sprint7.Project0.V2.Properties.Resources._2a09gHNnzys1;
            this.pictureBoxAva_ISI.Location = new System.Drawing.Point(23, 63);
            this.pictureBoxAva_ISI.Name = "pictureBoxAva_ISI";
            this.pictureBoxAva_ISI.Size = new System.Drawing.Size(206, 214);
            this.pictureBoxAva_ISI.TabIndex = 1;
            this.pictureBoxAva_ISI.TabStop = false;
            // 
            // labelHelp_ISI
            // 
            this.labelHelp_ISI.AutoSize = true;
            this.labelHelp_ISI.Location = new System.Drawing.Point(261, 65);
            this.labelHelp_ISI.Name = "labelHelp_ISI";
            this.labelHelp_ISI.Size = new System.Drawing.Size(284, 117);
            this.labelHelp_ISI.TabIndex = 2;
            this.labelHelp_ISI.Text = resources.GetString("labelHelp_ISI.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(558, 304);
            this.Controls.Add(this.labelHelp_ISI);
            this.Controls.Add(this.pictureBoxAva_ISI);
            this.Controls.Add(this.buttonOk_ISI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_ISI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_ISI;
        private System.Windows.Forms.PictureBox pictureBoxAva_ISI;
        private System.Windows.Forms.Label labelHelp_ISI;
    }
}