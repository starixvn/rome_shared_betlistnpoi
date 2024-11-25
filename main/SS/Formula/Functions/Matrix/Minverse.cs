using BetListNPOI.SS.Formula.Eval;
using MathNet.Numerics.LinearAlgebra;
using static BetListNPOI.SS.Formula.Functions.Matrix.MatrixFunction;

namespace BetListNPOI.SS.Formula.Functions.Matrix
{
    public class Minverse : MatrixFunction.OneArrayArg
    {
        private MutableValueCollector instance = new MutableValueCollector(false, false);

        protected override double[] CollectValues(ValueEval arg)
        {
            double[] values = instance.collectValues(arg);

            /* handle case where MDETERM is operating on an array that that is not completely filled*/
            if (arg is AreaEval && values.Length == 1)
                throw new EvaluationException(ErrorEval.VALUE_INVALID);

            return values;
        }
        protected override double[,] Evaluate(double[,] d1)
        {
            if (d1.GetLength(0) != d1.GetLength(1))
            {
                throw new EvaluationException(ErrorEval.VALUE_INVALID);
            }
            var temp = Matrix<double>.Build.DenseOfArray(d1);
            return temp.Inverse().ToArray();
        }
    }
}
