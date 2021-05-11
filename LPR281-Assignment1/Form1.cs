using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPR281_Assignment1
{
    public partial class Form1 : Form
    {
        LPRCalculator lpr = new LPRCalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecisionVariableAdd_Click(object sender, EventArgs e)
        {
            using (DecisionVariable dialog = new DecisionVariable())
            {
                DialogResult result = dialog.ShowDialog();

                switch (result)
                {
                    // put in how you want the various results to be handled
                    // if ok, then something like var x = dialog.MyX;
                    case DialogResult.OK: { lpr.AddDecisionVariable(dialog.getName(), dialog.getDescription());

                        break; }
                    case DialogResult.Cancel:
                        {
                            break;
                        }

                }

            }
            UpdateDecisionVariableGroup();
        }
        private void btnDecisionVariableChange_Click(object sender, EventArgs e)
        {
            
            using (DecisionVariable dialog = new DecisionVariable())
            {
                DialogResult result = dialog.ShowDialog();

                switch (result)
                {
                    // put in how you want the various results to be handled
                    // if ok, then something like var x = dialog.MyX;
                    case DialogResult.OK:
                        {
                            lpr.AddDecisionVariable(dialog.getName(), dialog.getDescription());

                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }

                }

            }
            UpdateDecisionVariableGroup();
        }

        private void UpdateDecisionVariableGroup()
        {
            gbDecisionVariable.Controls.Clear();
            foreach(DecisionVariable dv in lpr.getDecisionVariables())
            {
                Label lblDV = new Label();
                lblDV.Text = dv.ToString();
                lblDV.Click += new System.EventHandler(this.btnDecisionVariableChange_Click);
                gbDecisionVariable.Controls.Add(lblDV);

            }
        }
    }
}
