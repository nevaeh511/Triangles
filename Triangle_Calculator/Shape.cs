using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Calculator
{
    //use an interface to allow for flexiblity
    //use a factory pattern to sparate the decision making in creating different kinds of triangles
    //If we want to add other specific kinds of triangle to the code
    //  then we would only have one place to change the code
    interface TriangleFactory
    {
        Triangle DetermineTriangle(decimal sideA, decimal sideB, decimal sideC);
    }
    public class ProduceTrangle : TriangleFactory
    {
        public ProduceTrangle() { }
        public Triangle DetermineTriangle(decimal sideA, decimal sideB, decimal sideC)
        {
            //check if all sides are the same length
            if(sideA == sideB && sideB == sideC)
            {
                return new Equilateral();
            }
            //check if the sum of side A squared and side B squared equals side C squared
            else if((sideA*sideA) + (sideB*sideB) == (sideC * sideC))
            {
                return new Right();
            }
            //Check if any two sides are the length
            else if((sideA == sideB) || (sideA == sideC) || (sideB == sideC))
            {
                return new Isosceles();
            }
            //any other triangle found
            else
            {
                return new Triangle();
            }
        }
    }
    public class Triangle
    {
        protected decimal sideA;
        protected decimal sideB;
        protected decimal sideC;
        private const string MESSAGE = "These side lengths produce a valid triangle!";
        TriangleFactory triangleFactory;
        public Triangle()
        {
            sideA = default(decimal);
            sideB = default(decimal);
            sideC = default(decimal);
            triangleFactory = new ProduceTrangle();
        }
        public Triangle(decimal _sideA, decimal _sideB, decimal _sideC)
        {
            sideA = _sideA;
            sideB = _sideB;
            sideC = _sideC;
            triangleFactory = new ProduceTrangle();
        }
        /// <summary>
        /// Determines if a triangle is valid or not
        /// </summary>
        /// <returns>bool</returns>
        public bool IsTriangle()
        {
            //if the sum of any two sides are less than the third then it's invalid
            //if any side is of length zero then it's invalid
            //otherwise it's a valid triangle
            decimal sumAB = sideA + sideB;
            decimal sumBC = sideB + sideC;
            decimal sumAC = sideA + sideC;
            if (sumAC < sideB) { return false; }
            if (sumAB < sideC) { return false; }
            if (sumBC < sideA) { return false; }
            if (sideA == 0 || sideB == 0 || sideC == 0) { return false; }
            return true;
        }
        /// <summary>
        /// Retrieve the correct triangle
        /// </summary>
        /// <returns>Triangle</returns>
        public Triangle DetermineTriangle()
        {
            //Goes to the factory and has the factory determine the correct type
            return triangleFactory.DetermineTriangle(this.sideA, this.sideB, this.sideC);
        }
        //Our virtual method that each Triangle will implement specifically
        public virtual string DisplayMessage(){ return MESSAGE; }
    }
    public class Right : Triangle
    {
        private const string MESSAGE = "These side lengths produce a Right triangle!";
        public Right() { }
        public Right(decimal _sideA, decimal _sideB, decimal _sideC)
        {
            this.sideA = _sideA;
            this.sideB = _sideB;
            this.sideC = _sideC;
        }
        public override string DisplayMessage()
        {
            return MESSAGE;
        }
    }
    public class Equilateral : Triangle
    {
        private const string MESSAGE = "These side lengths produce an Equilateral triangle!";
        public Equilateral() { }
        public Equilateral(decimal _sideA, decimal _sideB, decimal _sideC)
        {
            this.sideA = _sideA;
            this.sideB = _sideB;
            this.sideC = _sideC;
        }
        public override string DisplayMessage()
        {
            return MESSAGE;
        }
    }
    public class Isosceles : Triangle
    {
        private const string MESSAGE = "These side lengths produce an Isosceles triangle!";
        public Isosceles() { }
        public Isosceles(decimal _sideA, decimal _sideB, decimal _sideC)
        {
            this.sideA = _sideA;
            this.sideB = _sideB;
            this.sideC = _sideC;
        }
        public override string DisplayMessage()
        {
            return MESSAGE;
        }
    }
}
