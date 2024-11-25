// See https://aka.ms/new-console-template for more information

using BetListNPOI.HSSF.UserModel;
using BetListNPOI.SS.UserModel;

Console.WriteLine("Hello, World!");
void CreateCell(IRow CurrentRow, int CellIndex, string Value, HSSFCellStyle Style)
{
    ICell Cell = CurrentRow.CreateCell(CellIndex);
    Cell.SetCellValue(Value);
    Cell.CellStyle = Style;
}

HSSFWorkbook workbook = new HSSFWorkbook();
HSSFFont myFont = (HSSFFont)workbook.CreateFont();
myFont.FontHeightInPoints = 11;
myFont.FontName = "Tahoma";


// Defining a border
HSSFCellStyle borderedCellStyle = (HSSFCellStyle)workbook.CreateCellStyle();
borderedCellStyle.SetFont(myFont);
borderedCellStyle.BorderLeft = BorderStyle.Medium;
borderedCellStyle.BorderTop = BorderStyle.Medium;
borderedCellStyle.BorderRight = BorderStyle.Medium;
borderedCellStyle.BorderBottom = BorderStyle.Medium;
borderedCellStyle.VerticalAlignment = VerticalAlignment.Center;

ISheet Sheet = workbook.CreateSheet("Report");
//Creat The Headers of the excel
IRow HeaderRow = Sheet.CreateRow(0);

//Create The Actual Cells
CreateCell(HeaderRow, 0, "Batch Name", borderedCellStyle);
CreateCell(HeaderRow, 1, "RuleID", borderedCellStyle);
CreateCell(HeaderRow, 2, "Rule Type", borderedCellStyle);
CreateCell(HeaderRow, 3, "Code Message Type", borderedCellStyle);
CreateCell(HeaderRow, 4, "Severity", borderedCellStyle);

// Write Excel to disk 
using var fileData = new FileStream("ReportName.xls", FileMode.Create);
workbook.Write(fileData);