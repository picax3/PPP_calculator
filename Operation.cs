using System;
using System.Collections.Generic;
using System.Linq; // allows to do declarative functions in c# coding
using System.Text;

namespace Calculator
{
    public class Operation
    {
        public string Name { get; set; }
        // declaring a variable Name where get is class method accessors to access data and... //
        // ... set is a class method mutator to change data //
        public Func<double, double, double> BinaryFunction { get; set; }
        // double is a type of variable with decimals as if 4.5 //
        // Func is a type of a variable that contains a function //
        // BinaryFunction is basically 2 inputs for 1 output //

        public Operation(string name, Func<double, double, double> binaryFunction) // the smaller case is an arguement of the constructor function Operation //
        // Operation is a constructor which happens every time i create an instance of class named Operation //
        // the constructor always has the same name is the function //
        // line 19 is constructor function where as line 9 is the class //
        {
            this.Name = name;
         // when we create an operation we give it a name. "this" is used to refer to an object we havent named yet //
            this.BinaryFunction = binaryFunction; // assigning an operation to an object we havent named yet//
        }
    }
}