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
    public partial class DecisionVariableDialog : Form
    {
        public DecisionVariableDialog()
        {
            InitializeComponent();
        }

        public DecisionVariableDialog(String name,String descr)
        {
            edtName.Text = name;
            edtDescription.Text = descr;
            InitializeComponent();
        }

        public String getName()
        {
            return edtName.Text;
        }

        public String getDescription()
        {
            return edtDescription.Text;
        }
        

       
    }
}
