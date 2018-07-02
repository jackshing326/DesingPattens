using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Operator
    {
        private double _NumberA = 0;
        private double _NumberB = 1;

        public double NumberA
        {
            get { return _NumberA; }
            set { _NumberA = value; }
        }

        public double NumberB
        {
            get { return _NumberB; }
            set { _NumberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    public class OperationAdd : Operator
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    public class OperationSub : Operator
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    public class OperationMul : Operator
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    public class OperationDiv : Operator
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除數不可為0");
            result = NumberA / NumberB;
            return result;
        }
    }
}
