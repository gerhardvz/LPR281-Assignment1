using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPR281_Assignment1
{
    class DecisionVariable
    {

        private int _num;
        private string _name;
        private string _description;

        public int getNum()
        {
            return _num;
        }

        public string getName()
        {
            return _name;
        }

        public string toString()
        {
            return _name;
        }

        public DecisionVariable(int num,string name)
        {
            _num = num;
            _name = name;
        }
    }
}
