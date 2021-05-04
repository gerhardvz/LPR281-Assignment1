using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPR281_Assignment1
{
    class  Constraints
    {

        private int dvCount = 0;
        private unsafe DecisionVariable*[] dv;
        private unsafe int* Multiplier = new int[2];
        private int val;
        private byte comparisonType;
        private String name;
        private String Description;

        public unsafe Constraints(DecisionVariable *dv1,int multiplier1, DecisionVariable *dv2, int multiplier2, byte comparisonType, int value)
        {

            dv = new DecisionVariable*[2];
            dv[0] = dv1;
            dv[1] = dv2;
            Multiplier[0] = multiplier1;
            Multiplier[1] = multiplier2;
            this.comparisonType = comparisonType;
            val = value;

        }
        public unsafe String toString()
        {

            string result = name + " : ";
            result += Multiplier[0];
            result += "X";
            result += dv[0]->getNum();
            result += " + ";
            result += Multiplier[1];
            result += "X";
            result += dv[1]->getNum();

            switch(comparisonType)
            {
                case 0: { break; }
                case 1: { break; }
                case 2: { break; }
            }

            result += val;
            return result;
        }
    }
}
