using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slotkin_P4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tbSummary_TextChanged(object sender, EventArgs e)
        {
            //whoops!
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {
            if (rbStraightLineDep.Checked == true)
            {
                DepreciationStraightLine dslItem = new DepreciationStraightLine();
                dslItem.Title = tbItem.Text;
                dslItem.StartOfLifeValue = decimal.Parse(tbStartValue.Text);
                dslItem.EndOfLifeValue = decimal.Parse(tbEndingValue.Text);
                dslItem.LifetimeOfItem = int.Parse(tbLifetime.Text);
                dslItem.DateAddedToInventory = DateTime.Parse(dtpDateIn.Text);
                dslItem.DateRemovedFromInventory = DateTime.Parse(dtpDateOut.Text);
                lbInventory.Items.Add(dslItem.ToString());
                lbInventory.Refresh();

            }
            else if (rbDoubleDeclineDep.Checked == true)
            {
                DepreciationDoubleDeclining dddItem = new DepreciationDoubleDeclining();
                dddItem.Title = tbItem.Text;
                dddItem.StartOfLifeValue = decimal.Parse(tbStartValue.Text);
                dddItem.EndOfLifeValue = decimal.Parse(tbEndingValue.Text);
                dddItem.LifetimeOfItem = int.Parse(tbLifetime.Text);
                dddItem.DateAddedToInventory = DateTime.Parse(dtpDateIn.Text);
                dddItem.DateRemovedFromInventory = DateTime.Parse(dtpDateOut.Text);
                lbInventory.Items.Add(dddItem.ToString());
                lbInventory.Refresh();
            }
        }

        private void lbInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //whoops!
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbInventory.Items.Remove(lbInventory.SelectedItem);

        }
        private void lbInventory_DoubleClick(Object sender, EventArgs e)
        {
            for (int i = 0; i < lbInventory.Items.Count; i++)
            {
                if (lbInventory.GetSelected(i) == true)

                    MessageBox.Show(lbInventory.SelectedIndices[i].ToString());
            }
        }

        private void rbDoubleDeclineDep_CheckedChanged(object sender, EventArgs e)
        {
            //ahhh, whoops!
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            List<decimal> annualDepreciation = new List<decimal>();

            decimal totalAnnualDepreciation = 0;

            for (int i = 0; i < lbInventory.Items.Count; i++)
            {
                totalAnnualDepreciation =+ 20;  //tried annualDepreciation.AnnualDeprectiation in place of 20 but it doesn't work     
            }
         
            tbSummary.Text = "The total yearly depreciation value of your inventory is $" + totalAnnualDepreciation + ".";
        }
    }
}


