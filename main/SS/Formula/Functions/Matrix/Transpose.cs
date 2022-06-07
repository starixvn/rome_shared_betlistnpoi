using MathNet.Numerics.LinearAlgebra;
using BetListNPOI.SS.Formula.Eval;
using System;
using System.Collections.Generic;
using System.Text;
using static BetListNPOI.SS.Formula.Functions.MatrixFunction;

namespace BetListNPOI.SS.Formula.Functions
{
    public class Transpose : OneArrayArg
    {
        private MutableValueCollector instance = new MutableValueCollector(false, true);

        protected override double[] CollectValues(ValueEval arg)
        {
            return instance.collectValues(arg);
        }

        protected override double[,] Evaluate(double[,] d1)
        {
            var temp = Matrix<double>.Build.DenseOfArray(d1);
            return temp.Transpose().ToArray();
        }
    }
}
