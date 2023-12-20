
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.buttonClose_ISI = new System.Windows.Forms.Button();
            this.textBoxInfo_ISI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClose_ISI
            // 
            this.buttonClose_ISI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose_ISI.Location = new System.Drawing.Point(702, 522);
            this.buttonClose_ISI.Name = "buttonClose_ISI";
            this.buttonClose_ISI.Size = new System.Drawing.Size(75, 23);
            this.buttonClose_ISI.TabIndex = 0;
            this.buttonClose_ISI.Text = "Ок";
            this.buttonClose_ISI.UseVisualStyleBackColor = true;
            this.buttonClose_ISI.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxInfo_ISI
            // 
            this.textBoxInfo_ISI.Location = new System.Drawing.Point(23, 63);
            this.textBoxInfo_ISI.Multiline = true;
            this.textBoxInfo_ISI.Name = "textBoxInfo_ISI";
            this.textBoxInfo_ISI.ReadOnly = true;
            this.textBoxInfo_ISI.Size = new System.Drawing.Size(754, 453);
            this.textBoxInfo_ISI.TabIndex = 1;
            this.textBoxInfo_ISI.Text = resources.GetString("textBoxInfo_ISI.Text");
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.textBoxInfo_ISI);
            this.Controls.Add(this.buttonClose_ISI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormInfo";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Краткое руководство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose_ISI;
        private System.Windows.Forms.TextBox textBoxInfo_ISI;
    }
}