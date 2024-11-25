namespace BetListNPOI.SS.UserModel
{
    public interface DifferentialStyleProvider
    {
        IBorderFormatting BorderFormatting { get; }
        IFontFormatting FontFormatting { get; }
        IPatternFormatting PatternFormatting { get; }
        ExcelNumberFormat NumberFormat { get; }
        int StripeSize { get; }
    }
}
