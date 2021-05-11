using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPR281_Assignment1;

namespace LPR281_Assignment1
{
    class LPRCalculator
    {

        public LPRCalculator()
        {
            listLPRConstraints = new List<LPREntry>();
         ObjectiveFunction = new LPREntry();
        decisionVariable = new List<DecisionVariable>();
    }

        public void AddConstraint(double result, char comparison, List<float> x)
        {

            listLPRConstraints.Add(new LPREntry(result,comparison,x));
        }
        public void AddDecisionVariable(String name, String description)
        {


            decisionVariable.Add(new DecisionVariable(name, description));
            decisionVariable.Add(new (name, description));

        }


        /**
    * Remove a Constraint
    */
        public void RemoveConstraint() {}
        
        
        public void RemoveConstraint(double result, char comparison, List<float> x)
        { 
            Predicate<LPREntry> predicate= (LPREntry lpr)=> (lpr.getResult==result&&lpr.row.Equals(x)&&lpr.getComparison);
            listLPRConstraints.Remove( listLPRConstraints.Find(predicate));
      
         
        }
             
        public void RemovedecisionVariable (string value)
        { 
            Predicate<LPREntry> predicate= (LPREntry lpr)=> (lpr.toString==value);
            listLPRConstraints.Remove( listLPRConstraints.Find(predicate));
      
         
        }
                    



        public void ChangeConstraint() { }

        public void ChangeDecisionVariable(int pos, String name, String description)
        {
            decisionVariable[pos].Name = name;
            decisionVariable[pos].Desciption = description;
        }

        public void getConstraints() { }

        public List<DecisionVariable> getDecisionVariables()
        {
            return decisionVariable;
        }

        public void setObjectiveFunction() { }

        /**
         * Compares Two lines to get Intersecting point
         */
        private List<Point> getCornerPoints()
        {

            List<Point> points = new List<Point>();

            for (int i = 0; i < listLPRConstraints.Count; i++)
            {

                for (int j = 0; j < listLPRConstraints.Count; i++)
                {
                    //test if its the same line
                    if (i == j)
                    {
                        continue;
                    }

                    //Matrix Calculation to get intersecting point for the two lines (only two variables - x1 and x2)
                    //TODO: - use Matrix library to use infinite Definition Variables
                    double A1 = listLPRConstraints[i].row[0];
                    double A2 = listLPRConstraints[j].row[0];
                    double B1 = listLPRConstraints[i].row[1];
                    double B2 = listLPRConstraints[j].row[1];
                    double C1 = listLPRConstraints[i].getValue();
                    double C2 = listLPRConstraints[j].getValue();

                    double det = A1 * B2 - A2 * B1;
                    if (det != 0)
                    {
                        double x = (B2 * C1 - B1 * C2) / det;
                        double y = (A1 * C2 - A2 * C1) / det;
                        points.Add(new Point(x, y));
                    }

                }
            }
            return points;
        }

        private List<Point> validatePoints(List<Point> points)
        {
            List<Point> validPoints = new List<Point>();

            foreach (Point p in points)
            {
                for (int i = 0; i < listLPRConstraints.Count; i++)
                {
                    //Test if point adhear to constraints
                    if (listLPRConstraints[i].adhear(p))
                    {
                        validPoints.Add(p);
                    }


                }
            }

            return validPoints;
        }

        private Point CalculateLPValue(List<Point> validPoints)
        {
            //take the Objective function and substitute the valid points in and the get the min or max value for the LP

            if (isMax)
            {
                double largest = 0;
                Point pLargest = new Point(0, 0);
                foreach (Point p in validPoints)
                {
                    double val = (ObjectiveFunction.row[0] * p.x) + (ObjectiveFunction.row[1] * p.y);


                    if (largest < val)
                    {
                        largest = val;
                        pLargest = p;
                    }


                }

                return pLargest;
            }
            else
            {
                double smallest = Double.MaxValue;
                Point pSmallest = new Point(0, 0);
                foreach (Point p in validPoints)
                {
                    double val = (ObjectiveFunction.row[0] * p.x) + (ObjectiveFunction.row[1] * p.y);

                    if (smallest > val)
                    {
                        smallest = val;
                        pSmallest = p;
                    }
                }
                return pSmallest;
            }

        }
        /**
         * Calculates the max or min values for the Objective function
         * @param x - X Coordinates
         * @param y - Y Coordinates
         */
        public void Calculate() { }
        private List<LPREntry> listLPRConstraints;
        
        private LPREntry ObjectiveFunction;
        private List<DecisionVariable> decisionVariable;
        //is the Problem a Maximum problem 
        private bool isMax;

    }

    public class LPREntry
    {
        //Added Temporaraly
        public LPREntry()
        {

        }
        public LPREntry(double result, char comparison, List<float> x)
        {

            foreach (float a in x)
            {
                row.Add(a);
            }

            this.comparison = comparison;
            this.result = result;

        }
        public List<float> row;


        char comparison ;
        public char getComparison() {return comparison };
        double result;
        public double getValue() { return result; }

        public double getResult()
        {
            return result;
        }

        public String toString()
        {
            return "";
        }

        public bool adhear(Point point)
        {

            double value = (row[0] * point.x) + (row[1] * point.y);

            switch (comparison)
            {
                case '<':
                    {
                        return (value < result);

                    }
                case '>':
                    {
                        return (value > result);

                    }
                case '=':
                    {
                        return (value == result);

                    }
            }

            return false;
        }

        //slack
        //access/
        //artificail/
    }

    public class DecisionVariable
    {
        public DecisionVariable(String Name, String Description)
        {
            _name = Name;
            _description = Description;
        }
        String _name;
        String _description;

        public String Name { get; set; }
        public String Desciption { get; set; }

        override
        public String ToString()
        {
            return _name +" : " + _description;
        }
    }
}
