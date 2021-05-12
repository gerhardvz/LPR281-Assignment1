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

      

    }
}
