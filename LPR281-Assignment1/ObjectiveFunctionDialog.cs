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
    public partial class ObjectiveFunctionDialog : Form
    {
        //columnNames - List of strings that should be the column names for the table
        //One for each Decision variable and the comparison and result is automatically added
        private List<String> columns = new List<string>();
        public ObjectiveFunctionDialog(List<String> columnNames)
        {
            columns.Add("Z");
            columns.Add("=");
            columns.AddRange(columnNames);
            //Format will be Z=X1+X2+X3....
            InitializeComponent();
            
        }

        public ObjectiveFunctionDialog(LPREntry objectiveFunction)
        {
            columns.Add("Z");
            columns.Add("=");
            columns.AddRange(objectiveFunction.getColumns());
            //Format will be Z=X1+X2+X3....
            InitializeComponent();
           

            for (int i = 0; i < objectiveFunction.getColumns().Count; i++)
            {
                Control[] ctrls = tblMatrix.Controls.Find(objectiveFunction.getColumns()[i] + "-multiplier", true);
                double val = objectiveFunction.getValue()[i];
                ctrls[0].Text =val.ToString();
            }

        }

        public List<double> getValues()
        {
            List<double> values = new List<double>();
           

            foreach(Control ctrl in tblMatrix.Controls)
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
             List<String> columns =this.columns;
            columns.RemoveAt(1);
            return columns;
        }

        public LPREntry getLPREntry()
        {
           
            List<double> values = getValues();
            List<String> valueNames = getColumns();
            double z = values[0];

            values.RemoveAt(0);
            valueNames.RemoveAt(0);
            LPREntry ObjectiveFunction = new LPREntry(z, '=',valueNames, values);
            return ObjectiveFunction;
        }



    }
}
