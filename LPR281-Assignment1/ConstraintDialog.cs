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
    //Custom Dialog Box for Adding and Editing Constraints
    public partial class ConstraintDialog : Form
    {
        private List<String> columns = new List<string>();
        public ConstraintDialog(List<String> columnNames)
        {
           
            
            columns.AddRange(columnNames);
            columns.Add("comparison");
            columns.Add("result");
            //Format will be Z=X1+X2+X3....
            InitializeComponent();

        }

        public ConstraintDialog(LPREntry constraint)
        {
            
            columns.AddRange(constraint.getColumns());
            columns.Add("comparison");
            columns.Add("result");
            //Format will be Z=X1+X2+X3....
            InitializeComponent();


            for (int i = 0; i < constraint.getColumns().Count; i++)
            {
                Control[] ctrls = tblMatrix.Controls.Find(constraint.getColumns()[i] + "-multiplier", true);
                if (ctrls == null)
                    continue;


                double val = constraint.getValue()[i];
                ctrls[0].Text = val.ToString();
            }
        }

        public List<double> getValues()
        {
            List<double> values = new List<double>();


            foreach (Control ctrl in tblMatrix.Controls)
            {
                if (ctrl.Name.Contains("-multiplier"))
                {
                    double val = double.Parse(ctrl.Text);
                    values.Add(val);
                }
            }
            return values;
        }

        public List<String> getColumns()
        {
            List<String> columns = this.columns;
            columns.RemoveAt(this.columns.Count-2);
            return columns;
        }

        public LPREntry ToLPREntry()
        {
            List<double> values = new List<double>();
            double result = new double();
            char comp=new char();
            foreach (Control ctrl in tblMatrix.Controls)
            {
                if (ctrl.Name.Contains("result"))
                {
                    result = double.Parse(ctrl.Text);
                    
                    continue;
                }
                if (ctrl.Name.Contains("comparison"))
                {
                    comp =ctrl.Text[0];
                    continue;
                }
                if (ctrl.Name.Contains("-multiplier"))
                {
                    double val = double.Parse(ctrl.Text);
                    values.Add(val);
                }
               
               
            }
            
            List<String> valueNames = getColumns();
            

          
           valueNames.RemoveAt(valueNames.Count-1);
            
            LPREntry constraintEntry = new LPREntry(result, comp, valueNames, values);
            return constraintEntry;
        }
    }
}
