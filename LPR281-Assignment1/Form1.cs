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
            using (DecisionVariableDialog dialog = new DecisionVariableDialog())
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
            lvDecisionVariable.Items.Clear();
            foreach (DecisionVariable dv in lpr.getDecisionVariables())
            {
                //  Label lblDV = new Label();
                //  lblDV.Text = dv.ToString();
                //   lblDV.DoubleClick += new System.EventHandler(this.btnDecisionVariableChange_Click);
                ListViewItem listViewItem = new ListViewItem(dv.ToString());
                //listViewItem.


                lvDecisionVariable.Items.Add(listViewItem);

            }
        }




        private void btnDecisionVariableRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvDecisionVariable.SelectedItems)
            {
                //remove LPRDecisionVariable
                lpr.RemoveDecisionVariable(lvi.Text);
            }
            UpdateDecisionVariableGroup();
        }



        private void btnConstraintRemove_Click(object sender, EventArgs e)
        {

        }
        private void UpdateObjectiveFunctionGroup()
        {
            lvObjectiveFunction.Items.Clear();

            ListViewItem listViewItem = new ListViewItem(lpr.getObjectiveFunction().ToString());
            //listViewItem.

            lvObjectiveFunction.Items.Add(listViewItem);


        }
        private void UpdateConstraintsGroup()
        {
            lvConstraints.Items.Clear();
            foreach (LPREntry dv in lpr.getConstraints())
            {
                //  Label lblDV = new Label();
                //  lblDV.Text = dv.ToString();
                //   lblDV.DoubleClick += new System.EventHandler(this.btnDecisionVariableChange_Click);
                ListViewItem listViewItem = new ListViewItem(dv.ToString());
                //listViewItem.


                lvConstraints.Items.Add(listViewItem);

            }
        }

        private void btnObjectiveFunctionAdd_Click(object sender, EventArgs e)
        {
            using (ObjectiveFunctionDialog dialog = new ObjectiveFunctionDialog(lpr.ListDecisionVaraibleNames()))
            {
                DialogResult result = dialog.ShowDialog();

                switch (result)
                {
                    // put in how you want the various results to be handled
                    // if ok, then something like var x = dialog.MyX;
                    //TODO:: Fix so that you can get data from Dialog
                    case DialogResult.OK:
                        {


                            lpr.setObjectiveFunction(dialog.getLPREntry());
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }

                }

            }
            UpdateObjectiveFunctionGroup();
        }

        //TODO::
        private void btnObjectiveFunctionRemove_Click(object sender, EventArgs e)
        {

        }

        private void lvDecisionVariable_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in ((ListView)sender).SelectedItems)
            {

                int pos = lpr.getDecisionVariableIndex(lvi.Text);
                if (pos == -1) { return; }

                using (DecisionVariableDialog dialog = new DecisionVariableDialog(lpr.getDecisionVariables()[pos]))
                {
                    DialogResult result = dialog.ShowDialog();

                    switch (result)
                    {
                        // put in how you want the various results to be handled
                        // if ok, then something like var x = dialog.MyX;
                        case DialogResult.OK:
                            {
                                lpr.ChangeDecisionVariable(pos, dialog.getName(), dialog.getDescription());

                                break;
                            }
                        case DialogResult.Cancel:
                            {
                                break;
                            }

                    }

                }
            }
            UpdateDecisionVariableGroup();
        }

        //TODO::Change to Objective function
        private void lvObjectiveFunction_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in ((ListView)sender).SelectedItems)
            {

                int pos = lpr.getDecisionVariableIndex(lvi.Text);
                if (pos == -1) { return; }

                using (ObjectiveFunctionDialog dialog = new ObjectiveFunctionDialog(lpr.getObjectiveFunction()))
                {
                    DialogResult result = dialog.ShowDialog();

                    switch (result)
                    {
                        // put in how you want the various results to be handled
                        // if ok, then something like var x = dialog.MyX;
                        case DialogResult.OK:
                            {
                                lpr.setObjectiveFunction(dialog.getLPREntry());

                                break;
                            }
                        case DialogResult.Cancel:
                            {
                                break;
                            }

                    }

                }
            }
            UpdateObjectiveFunctionGroup();
        }

        private void lvConstraints_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in ((ListView)sender).SelectedItems)
            {

                int pos = lpr.getConstraintIndex(lvi.Text);
                if (pos == -1) { return; }

                using (ConstraintDialog dialog = new ConstraintDialog(lpr.getConstraints()[pos]))
                {
                    DialogResult result = dialog.ShowDialog();

                    switch (result)
                    {
                        // put in how you want the various results to be handled
                        // if ok, then something like var x = dialog.MyX;
                        case DialogResult.OK:
                            {
                                //TODO::Change to fit constraints
                                //   lpr.ChangeConstraint(pos, dialog.getName(), dialog.getDescription());

                                break;
                            }
                        case DialogResult.Cancel:
                            {
                                break;
                            }

                    }

                }
            }
            UpdateDecisionVariableGroup();
        }

        private void btnConstraintAdd_Click(object sender, EventArgs e)
        {


            using (ConstraintDialog dialog = new ConstraintDialog(lpr.ListDecisionVaraibleNames()))
            {
                DialogResult result = dialog.ShowDialog();

                switch (result)
                {
                    // put in how you want the various results to be handled
                    // if ok, then something like var x = dialog.MyX;
                    case DialogResult.OK:
                        {
                            //TODO::Change to fit constraints
                            //   lpr.ChangeConstraint(pos, dialog.getName(), dialog.getDescription());
                            dialog.ToLPREntry();
                            //lpr.AddConstraint();
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
    }
}
