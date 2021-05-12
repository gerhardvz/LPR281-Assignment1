﻿using System;
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
           

        }


        /**
    * Remove a Constraint
    */
     
        
        public void RemoveConstraint(double result, char comparison, List<float> x)
        { 
            Predicate<LPREntry> predicate= (LPREntry lpr)=> (lpr.getResult()==result&&lpr.row.Equals(x)&&lpr.getComparison()==comparison);
            listLPRConstraints.Remove( listLPRConstraints.Find(predicate));
      
         
        }
             
        public void RemoveDecisionVariable (string value)
        { 
            Predicate<DecisionVariable> predicate= (DecisionVariable dv)=> (dv.ToString()==value);
            int pos = decisionVariable.FindIndex(predicate);
            if (pos > -1) { decisionVariable.RemoveAt(pos); }
            
            //listLPRConstraints.Remove( );
      
         
        }
                    
        public int getConstraintIndex(double result, char comparison, List<float> x)
        {
            Predicate<LPREntry> predicate = (LPREntry dv) => (dv.ToString() == new LPREntry(result,comparison,x).ToString());
            int pos = listLPRConstraints.FindIndex(predicate);
            return pos;
        }
        public int getConstraintIndex(string value)
        {
            Predicate<LPREntry> predicate = (LPREntry dv) => (dv.ToString() ==value);
            int pos = listLPRConstraints.FindIndex(predicate);
            return pos;
        }
        public int getDecisionVariableIndex(string value)
        {
            Predicate<DecisionVariable> predicate = (DecisionVariable dv) => (dv.ToString() == value);
            int pos = decisionVariable.FindIndex(predicate);
            return pos;
        }

        //TODO::
        public void ChangeConstraint( int pos, double result, char comparison, List<float> x) {
        
        }

        public void ChangeDecisionVariable(int pos, String name, String description)
        {
            decisionVariable[pos].Name = name;
            decisionVariable[pos].Desciption = description;
        }

        public List<LPREntry> getConstraints() {
            return listLPRConstraints;
        }

        public List<DecisionVariable> getDecisionVariables()
        {
            return decisionVariable;
        }

        public void setObjectiveFunction(LPREntry of) {
            ObjectiveFunction = of;
        }

        public LPREntry getObjectiveFunction()
        {
            return ObjectiveFunction;
        }

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
        public void Calculate() {
        
            //list of point = get corner point
            //get valid point of feasable region from the points gotten earlier
            //calc lp value - max/min value calculate by implementing the Objective function

        }
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
        public char getComparison() { return comparison; }
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

    public class DecisionVariable :IComparable
    {
        public DecisionVariable(String Name, String Description)
        {
            _name = Name;
            _description = Description;
        }
        String _name;
        String _description;

        public String Name { get { return _name; } set { _name = value; } }
        public String Desciption { get { return _description; } set { _description = value; } }

        override
        public String ToString()
        {
            return _name +" : " + _description;
        }
        public int CompareTo(Object o)
        {
            DecisionVariable dv = o as DecisionVariable;
            if (dv == null)
                throw new ArgumentException("Not valid object");

            if (_name.CompareTo(dv._name) != 0)
            {
                return _name.CompareTo(dv._name);
            }
            if (_description.CompareTo(dv._description) != 0)
            {
                return _description.CompareTo(dv._description);
            }


            return 0;
        }
    }
}
