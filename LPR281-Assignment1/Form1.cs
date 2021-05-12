﻿using System;
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


        private void lvDecisionVariable_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
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

        private void btnDecisionVariableRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvDecisionVariable.SelectedItems)
            {
                //remove LPRDecisionVariable
                lpr.RemoveDecisionVariable(lvi.Text);
            }
            UpdateDecisionVariableGroup();
        }

        private void btnConstraintAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnConstraintRemove_Click(object sender, EventArgs e)
        {

        }
        private void UpdateObjectiveFunctionGroup()
        {
            lvDecisionVariable.Items.Clear();

            ListViewItem listViewItem = new ListViewItem(lpr.getObjectiveFunction().ToString());
            //listViewItem.

            lvDecisionVariable.Items.Add(listViewItem);


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
    }
}
