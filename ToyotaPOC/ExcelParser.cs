using MaruboshiPOC.XmlParsing;
using Npoi.Mapper;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

internal class ExcelParser
{

    private static string _dataDir = @"D:\\BS23\\Marobusho\\MaruboshiPOC\\PdfSamples\\";

    public void XcelParsingWithNpoi()
    {
        string directoryPath = @"D:\\Clients\\USA\\Toyota\\Docs\\";

        //WriteFile(directoryPath);
        ReadFile(directoryPath);
    }
    static void WriteFile(string directoryPath)
    {
        string filePath = Path.Combine(directoryPath, "PL_CS_Check_Lists_070623.xlsm");

        IWorkbook workBook = new XSSFWorkbook();
        ISheet sheet = workBook.CreateSheet("Day01");
        IRow row0 = sheet.CreateRow(0);
        ICell cell0 = row0.CreateCell(0);
        cell0.SetCellValue("First Cell");
        cell0.SetAsActiveCell();
        for (int i = 1; i <= 10; i++)
        {
            IRow row = sheet.CreateRow(i);
            ICell cell = row.CreateCell(0); // Always create the cell in the first column (column 0).
            cell.SetCellValue($"Hello {i}!");
        }
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            workBook.Write(fs);
        }
        Console.WriteLine("Excel file created and data written to MyWorkBook.xlsx.");
    }

    static void ReadFile(string directoryPath)
    {

        string filePath = Path.Combine(directoryPath, "PL_CS_Check_Lists_070623.xlsm");
        try
        {
            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workBook = new XSSFWorkbook(file);
                var mapper = new Mapper(workBook);

                mapper.Map<ExcelRulesMetaData>("Chapter", "Chapter");
                mapper.Map<ExcelRulesMetaData>("Section", "Section");
                mapper.Map<ExcelRulesMetaData>("Subsection", "Subsection");
                mapper.Map<ExcelRulesMetaData>("Paragraph", "Paragraph");
                mapper.Map<ExcelRulesMetaData>("Points", "Points");
                mapper.Map<ExcelRulesMetaData>("Highlander", "Highlander");
                mapper.Map<ExcelRulesMetaData>("PL H", "PLH");
                mapper.Map<ExcelRulesMetaData>("Sienna", "Sienna");

                var exelData = mapper.Take<ExcelRulesMetaData>("data").Select(x => x.Value).ToList();
                var titleString = exelData.Where(x => x.Chapter == "Maintenance and care" && x.PLH == "Y").Select(x => x.Section).FirstOrDefault();
                new XmlParser().XmlTagInsertion(titleString ?? "");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}