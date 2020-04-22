namespace closedxml_empty_sheet_test
{
    class Program
    {
        static void Main(string[] args)
        {

            ClosedXML.Excel.XLWorkbook workbook = null;
            workbook = new ClosedXML.Excel.XLWorkbook("../../WaterPumpSystem.xlsx");

            foreach (var sheet in workbook.Worksheets)
            {
                if (sheet.IsEmpty())
                {
                    System.Console.WriteLine(sheet.Name + " is empty");
                }
                else
                {
                    System.Console.WriteLine(sheet.Name + " is NOT empty");
                }
            }
        }
    }
}
