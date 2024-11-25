using BetListNPOI.SS.Formula.Eval;
using MathNet.Numerics.LinearAlgebra;
using static BetListNPOI.SS.Formula.Functions.Matrix.MatrixFunction;

namespace BetListNPOI.SS.Formula.Functions.Matrix
{
    public class Transpose : MatrixFunction.OneArrayArg
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
