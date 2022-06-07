using BetListNPOI.SS.Formula.Eval;
using BetListNPOI.SS.Formula.PTG;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetListNPOI.SS.Formula.Functions
{
    public class Areas : Function
    {
        public ValueEval Evaluate(ValueEval[] args, int srcRowIndex, int srcColumnIndex)
        {
            if (args.Length == 0)
            {
                return ErrorEval.VALUE_INVALID;
            }
            try
            {
                ValueEval valueEval = args[0];
                int result = 1;
                if (valueEval is RefListEval) {
                    RefListEval refListEval = (RefListEval)valueEval;
                    result = refListEval.GetList().Count;
                }
                NumberEval numberEval = new NumberEval(new NumberPtg(result));
                return numberEval;
            }
            catch (Exception e)
            {
                return ErrorEval.VALUE_INVALID;
            }
        }
    }
}
