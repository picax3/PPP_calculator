using System;
using System.Collections.Generic; // loading classes from the system library //
using System.Text;
using System.Linq;

namespace Calculator
{
    class Controller
    {

/*      private readonly List<Operation> fOperations; // readonly - good practice. to protect our code from outside modifications // */

        public List<Operation> Operations { get; }

        public int  OperationCount
        {
            get
            {
                return Operations.Count; // returns the untouchable variable //
            }
        }

        private Operation SelectOperation(CalculatorUI userInterface)
        {
            int index = userInterface.SelectOperationIndex();
            return (0 < index && index <= Operations.Count) ? Operations.ElementAt(index - 1) : null; 
        }

        public void AddOperation(Operation operation) // adding a method for people to add operations as if "plus", "minus"... //
        {
            Operations.Add(operation);
        }

        public void Run(CalculatorUI userInterface)
        {
            Operation operation;
            do
            {
                userInterface.DisplayOperations();
                operation = SelectOperation(userInterface);
                if (!(operation is null))
                {
                    double? x = userInterface.RequestArguement(); // nullable double - cant use  a nullable double as a double must have x.value for e.g. //
                    double? y = userInterface.RequestArguement();
                    if (x is null || y is null)
                    {
                        userInterface.ShowError();
                    }
                    else
                    {
                        userInterface.ShowResult(operation.BinaryFunction(x.Value, y.Value));
                    }
                }
            }
            while (!(operation is null)); // exclamation mark means not - operation is not null // turns false into true and vice versa //
        
        }

        public Controller() // controller is a constructor of controller class line 7. we naming an instance of operation via function addoperation
        {
            Operations = new List<Operation>();
            AddOperation(new Operation("Add", (x, y) => x + y)); //addoperation is a function of the class controller line 7. the input values become the sum //
            AddOperation(new Operation("Subract", (x, y) => x - y));
            AddOperation(new Operation("Multiply", (x, y) => x * y));
            AddOperation(new Operation("Divide", (x, y) => x / y));
            AddOperation(new Operation("Exponent", (x, y) => Math.Pow(x, y));
         
        }
    }
}