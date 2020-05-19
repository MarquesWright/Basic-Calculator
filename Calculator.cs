using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Calculator
    {

        private decimal currentValue;   // stores the result currently displayed
        private decimal operand1;       // stores the value of the first operand
        private decimal operand2;       // stores the value of the second operand
        private Operator op;            // stores a member of the Operator enumeration

        // an enumeration of constants
        private enum Operator
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            None
        }
        
        // creates a Calculator object that sets default values
        public Calculator()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = Operator.None;
        }


        // gets and sets the value the currentValue field
        public decimal CurrentValue
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = value;
            }
        }

        public void Add(decimal displayValue)
        {
            // sets operand1 and currentValue fields to the value that's passed to it
            operand1 = displayValue;        
            currentValue = displayValue;

            // sets the op field to Operator.Add
            op = Operator.Add;
        }

        //
        public void Subtract(decimal displayValue)
        {
            // sets operand1 and currentValue fields to the value that's passed to it
            operand1 = displayValue;
            currentValue = displayValue;

            // sets the op field to Operator.Subtract
            op = Operator.Subtract;
        }

        public void Multiply(decimal displayValue)
        {
            // sets operand1 and currentValue fields to the value that's passed to it
            operand1 = displayValue;
            currentValue = displayValue;

            // sets the op field to Operator.Multiply
            op = Operator.Multiply;
        }

        public void Divide(decimal displayValue)
        {
            // sets operand1 and currentValue fields to the value that's passed to it
            operand1 = displayValue;
            currentValue = displayValue;

            // sets the op field to Operator.Divide
            op = Operator.Divide;
        }

        public void Equals()
        {
            /**
             * Performs the operation specified by the op field on the operand1 and operand2 fields,
             * and stores the results in the operand1 field.
             */
            switch (op)
            {
                case Operator.Add:
                    currentValue = operand1 + operand2;
                    operand1 = currentValue;
                    break;

                case Operator.Subtract:
                    currentValue = operand1 - operand2;
                    operand1 = currentValue;
                    break;

                case Operator.Multiply:
                    currentValue = operand1 * operand2;
                    operand1 = currentValue;
                    break;

                case Operator.Divide:
                    currentValue = operand1 / operand2;
                    operand1 = currentValue;
                    break;

                default:
                    break;
            }

        }

        // 
        public void Equals(decimal displayValue)
        {
            // operand2 is set to the value of the argument passed in.
            operand2 = displayValue;

            /**
             * Performs the operation specified by the op field on the operand1 and operand2 fields,
             * and stores the result in the operand1 field.
             */
            switch (op)
            {
                case Operator.Add:
                    currentValue = operand1 + operand2;
                    operand1 = currentValue;
                    break;

                case Operator.Subtract:
                    currentValue = operand1 - operand2;
                    operand1 = currentValue;
                    break;

                case Operator.Multiply:
                    currentValue = operand1 * operand2;
                    operand1 = currentValue;
                    break;

                case Operator.Divide:
                    currentValue = operand1 / operand2;
                    operand1 = currentValue;
                    break;

                default:
                    break;
            }

        }

        // sets the private fields to their default value
        public void Clear()
        {
            this.currentValue = 0;
            this.operand1 = 0;
            this.operand2 = 0;
        }
    }
}
