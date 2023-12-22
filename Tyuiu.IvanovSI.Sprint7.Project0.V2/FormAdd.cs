using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2
{
    public partial class FormAdd : MetroForm
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonAdd_ISI_Click(object sender, EventArgs e)
        {
            string[] rowData = new string[] { textBoxName_ISI.Text, textBoxTel_ISI.Text, textBoxLocation_ISI.Text, textBoxTelStore_ISI.Text, textBoxFIO_ISI.Text, textBoxTelPostavk_ISI.Text, textBoxPrice_ISI.Text };


            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public string[] GetRowData()
        {
            
            return new string[] { textBoxName_ISI.Text, textBoxTel_ISI.Text, textBoxLocation_ISI.Text, textBoxTelStore_ISI.Text, textBoxFIO_ISI.Text, textBoxTelPostavk_ISI.Text, textBoxPrice_ISI.Text };

        }



    }
}
