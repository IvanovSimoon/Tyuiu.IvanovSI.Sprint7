
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
            this.textBoxSumStat_ISI = new System.Windows.Forms.TextBox();
            this.textBoxMinStat_ISI = new System.Windows.Forms.TextBox();
            this.textBoxMaxStat_ISI = new System.Windows.Forms.TextBox();
            this.textBoxAvgCostStat_ISI = new System.Windows.Forms.TextBox();
            this.labelSumStat_ISI = new System.Windows.Forms.Label();
            this.labelMinStat_ISI = new System.Windows.Forms.Label();
            this.labelMaxStat_ISI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSumStat_ISI
            // 
            this.textBoxSumStat_ISI.Location = new System.Drawing.Point(214, 102);
            this.textBoxSumStat_ISI.Name = "textBoxSumStat_ISI";
            this.textBoxSumStat_ISI.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumStat_ISI.TabIndex = 0;
            // 
            // textBoxMinStat_ISI
            // 
            this.textBoxMinStat_ISI.Location = new System.Drawing.Point(214, 157);
            this.textBoxMinStat_ISI.Name = "textBoxMinStat_ISI";
            this.textBoxMinStat_ISI.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinStat_ISI.TabIndex = 0;
            // 
            // textBoxMaxStat_ISI
            // 
            this.textBoxMaxStat_ISI.Location = new System.Drawing.Point(214, 211);
            this.textBoxMaxStat_ISI.Name = "textBoxMaxStat_ISI";
            this.textBoxMaxStat_ISI.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxStat_ISI.TabIndex = 0;
            // 
            // textBoxAvgCostStat_ISI
            // 
            this.textBoxAvgCostStat_ISI.Location = new System.Drawing.Point(214, 266);
            this.textBoxAvgCostStat_ISI.Name = "textBoxAvgCostStat_ISI";
            this.textBoxAvgCostStat_ISI.Size = new System.Drawing.Size(100, 20);
            this.textBoxAvgCostStat_ISI.TabIndex = 0;
            // 
            // labelSumStat_ISI
            // 
            this.labelSumStat_ISI.AutoSize = true;
            this.labelSumStat_ISI.Location = new System.Drawing.Point(17, 105);
            this.labelSumStat_ISI.Name = "labelSumStat_ISI";
            this.labelSumStat_ISI.Size = new System.Drawing.Size(148, 13);
            this.labelSumStat_ISI.TabIndex = 1;
            this.labelSumStat_ISI.Text = "Сумма стоимости поставок";
            // 
            // labelMinStat_ISI
            // 
            this.labelMinStat_ISI.AutoSize = true;
            this.labelMinStat_ISI.Location = new System.Drawing.Point(17, 160);
            this.labelMinStat_ISI.Name = "labelMinStat_ISI";
            this.labelMinStat_ISI.Size = new System.Drawing.Size(185, 13);
            this.labelMinStat_ISI.TabIndex = 2;
            this.labelMinStat_ISI.Text = "Минимальная стоимость поставки";
            // 
            // labelMaxStat_ISI
            // 
            this.labelMaxStat_ISI.AutoSize = true;
            this.labelMaxStat_ISI.Location = new System.Drawing.Point(17, 214);
            this.labelMaxStat_ISI.Name = "labelMaxStat_ISI";
            this.labelMaxStat_ISI.Size = new System.Drawing.Size(191, 13);
            this.labelMaxStat_ISI.TabIndex = 2;
            this.labelMaxStat_ISI.Text = "Максимальная стоимость поставки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Средняя стоимость поставки";
            // 
            // FormStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMaxStat_ISI);
            this.Controls.Add(this.labelMinStat_ISI);
            this.Controls.Add(this.labelSumStat_ISI);
            this.Controls.Add(this.textBoxAvgCostStat_ISI);
            this.Controls.Add(this.textBoxMaxStat_ISI);
            this.Controls.Add(this.textBoxMinStat_ISI);
            this.Controls.Add(this.textBoxSumStat_ISI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStat";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Статистика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSumStat_ISI;
        private System.Windows.Forms.TextBox textBoxMinStat_ISI;
        private System.Windows.Forms.TextBox textBoxMaxStat_ISI;
        private System.Windows.Forms.TextBox textBoxAvgCostStat_ISI;
        private System.Windows.Forms.Label labelSumStat_ISI;
        private System.Windows.Forms.Label labelMinStat_ISI;
        private System.Windows.Forms.Label labelMaxStat_ISI;
        private System.Windows.Forms.Label label1;
    }
}