using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPR281_Assignment1
{
    class LPRCalculator
    {

        public LPRCalculator()
        {

        }

        public void AddConstraint()
        {

        }

        public void AddDecisionVariable()
        {

        }

        /**
    * Remove a Constraint
    */
        public void RemoveConstraint() { }

        /**
         * Removes a Decision Variable
         */
        public void RemoveDecisionVariable() { }

        public void ChangeConstraint() { }

        public void ChangeDecisionVaraible() { }

        public void getConstraints() { }

        public void getDecisionVariables() { }

        public void setObjectiveFunction() { }
        /**
         * Calculates the max or min values for the Objective function
         * @param x - X Coordinates
         * @param y - Y Coordinates
         */
        public void Calculate(float* x, float* y) { }

        private int constraintCount;
        private int variableCount;
        private Constraints** constraint;
        private DecisionVariable** dv;
        private ObjectiveFunction of;

    }
}
