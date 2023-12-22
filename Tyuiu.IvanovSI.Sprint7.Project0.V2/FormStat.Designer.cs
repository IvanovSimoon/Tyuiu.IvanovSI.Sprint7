
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2
{
    partial class FormStat
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
            this.buttonOk_ISI = new System.Windows.Forms.Button();
            this.textBoxMax_ISI = new System.Windows.Forms.TextBox();
            this.textBoxMin_ISI = new System.Windows.Forms.TextBox();
            this.textBoxMid_ISI = new System.Windows.Forms.TextBox();
            this.labelMax_ISI = new System.Windows.Forms.Label();
            this.labelMin_ISI = new System.Windows.Forms.Label();
            this.labelMid_ISI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk_ISI
            // 
            this.buttonOk_ISI.Location = new System.Drawing.Point(184, 167);
            this.buttonOk_ISI.Name = "buttonOk_ISI";
            this.buttonOk_ISI.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_ISI.TabIndex = 0;
            this.buttonOk_ISI.Text = "Ok";
            this.buttonOk_ISI.UseVisualStyleBackColor = true;
            this.buttonOk_ISI.Click += new System.EventHandler(this.buttonOk_ISI_Click);
            // 
            // textBoxMax_ISI
            // 
            this.textBoxMax_ISI.Location = new System.Drawing.Point(22, 79);
            this.textBoxMax_ISI.Name = "textBoxMax_ISI";
            this.textBoxMax_ISI.Size = new System.Drawing.Size(121, 20);
            this.textBoxMax_ISI.TabIndex = 1;
            // 
            // textBoxMin_ISI
            // 
            this.textBoxMin_ISI.Location = new System.Drawing.Point(22, 124);
            this.textBoxMin_ISI.Name = "textBoxMin_ISI";
            this.textBoxMin_ISI.Size = new System.Drawing.Size(121, 20);
            this.textBoxMin_ISI.TabIndex = 1;
            // 
            // textBoxMid_ISI
            // 
            this.textBoxMid_ISI.Location = new System.Drawing.Point(22, 167);
            this.textBoxMid_ISI.Name = "textBoxMid_ISI";
            this.textBoxMid_ISI.Size = new System.Drawing.Size(121, 20);
            this.textBoxMid_ISI.TabIndex = 1;
            // 
            // labelMax_ISI
            // 
            this.labelMax_ISI.AutoSize = true;
            this.labelMax_ISI.Location = new System.Drawing.Point(23, 60);
            this.labelMax_ISI.Name = "labelMax_ISI";
            this.labelMax_ISI.Size = new System.Drawing.Size(134, 13);
            this.labelMax_ISI.TabIndex = 2;
            this.labelMax_ISI.Text = "Максимальное значение";
            // 
            // labelMin_ISI
            // 
            this.labelMin_ISI.AutoSize = true;
            this.labelMin_ISI.Location = new System.Drawing.Point(23, 108);
            this.labelMin_ISI.Name = "labelMin_ISI";
            this.labelMin_ISI.Size = new System.Drawing.Size(128, 13);
            this.labelMin_ISI.TabIndex = 2;
            this.labelMin_ISI.Text = "Минимальное значение";
            // 
            // labelMid_ISI
            // 
            this.labelMid_ISI.AutoSize = true;
            this.labelMid_ISI.Location = new System.Drawing.Point(23, 151);
            this.labelMid_ISI.Name = "labelMid_ISI";
            this.labelMid_ISI.Size = new System.Drawing.Size(100, 13);
            this.labelMid_ISI.TabIndex = 2;
            this.labelMid_ISI.Text = "Среднее значение";
            // 
            // FormStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 206);
            this.Controls.Add(this.labelMid_ISI);
            this.Controls.Add(this.labelMin_ISI);
            this.Controls.Add(this.labelMax_ISI);
            this.Controls.Add(this.textBoxMid_ISI);
            this.Controls.Add(this.textBoxMin_ISI);
            this.Controls.Add(this.textBoxMax_ISI);
            this.Controls.Add(this.buttonOk_ISI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormStat";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.FormStat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_ISI;
        private System.Windows.Forms.TextBox textBoxMax_ISI;
        private System.Windows.Forms.TextBox textBoxMin_ISI;
        private System.Windows.Forms.TextBox textBoxMid_ISI;
        private System.Windows.Forms.Label labelMax_ISI;
        private System.Windows.Forms.Label labelMin_ISI;
        private System.Windows.Forms.Label labelMid_ISI;
    }
}