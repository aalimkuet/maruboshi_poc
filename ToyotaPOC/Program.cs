using Aspose.Pdf;
using Aspose.Pdf.Text;
using HtmlAgilityPack;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel; 
using System.Xml;  

#pragma warning disable CS8321

string filePath = "D:\\BS23\\Marobusho\\MaruboshiPOC\\myFile.xml";

var excelParser = new ExcelParser();

excelParser.XcelParsingWithNpoi();
//XmlParsingWithHtmlAgilityPack();
//XmlParsingXmlReader();
//CreatePDFFromXmlWithAspose();

var xmlParser = new XmlParser();
//xmlParser.GenerateXslFromModel();
//xmlParser.XmlToJson();
//xmlParser.JsonToCSharpClass();
//xmlParser.XmlManupulation();


void XmlParsingWithHtmlAgilityPack()
{
    HtmlDocument someDoc = new HtmlDocument();
    someDoc.Load(filePath);
    Console.WriteLine(someDoc);

    string html = File.ReadAllText(path: filePath);

    var doc = new HtmlDocument();
    doc.LoadHtml(html);

    var channel = doc.DocumentNode.SelectSingleNode("//channel");
    var titleNode = channel.SelectSingleNode("//title");

    // Create and append the new <head> element
    //var headElement = doc.CreateElement("head");
    //headElement.InnerHtml = "Your new content here";
    //channel.InsertAfter(headElement, titleNode);

    var headNodes = doc.DocumentNode.SelectNodes("//head");

    if (headNodes != null)
    {
        foreach (var headNode in headNodes.ToList())
        {
            var bigHeadElement = doc.CreateElement("bighead");
            bigHeadElement.InnerHtml = headNode.InnerHtml;
            headNode.ParentNode.ReplaceChild(bigHeadElement, headNode);
        }
    }
    doc.Save(filePath);

    foreach (HtmlNode nodeRss in someDoc.DocumentNode.SelectNodes("rss"))
    {
        Console.WriteLine(nodeRss.Attributes["version"].Value);

        Console.WriteLine("View data with boolean value in the model data!!");

        foreach (HtmlNode aNode2 in nodeRss.SelectNodes("channel"))
        {
            Console.WriteLine(aNode2.ChildNodes.Count());
            foreach (HtmlNode aNode3 in aNode2.SelectNodes("item"))
            {
                Console.WriteLine(aNode3.SelectSingleNode("title").InnerText);
                Console.WriteLine(aNode3.SelectSingleNode("link").NextSibling.InnerText);
            }
        }
    }

}
void XmlParsingXmlReader()
{
    XmlReaderSettings settings = new XmlReaderSettings();
    settings.IgnoreWhitespace = true;

    using (var fileStream = File.OpenText(filePath))
    using (XmlReader reader = XmlReader.Create(fileStream, settings))
    {
        while (reader.Read())
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Element:
                    Console.WriteLine($"Start Element: {reader.Name}. Has Attributes? : {reader.HasAttributes}");
                    break;
                case XmlNodeType.Text:
                    Console.WriteLine($"Inner Text: {reader.Value}");
                    break;
                case XmlNodeType.EndElement:
                    Console.WriteLine($"End Element: {reader.Name}");
                    break;
                default:
                    Console.WriteLine($"Unknown: {reader.NodeType}");
                    break;
            }
        }
    }

}

void CreatePDFFromXmlWithAspose()
{

    string _dataDir = "D:\\BS23\\Marobusho\\MaruboshiPOC\\PdfSamples";

    // Initialize document object
    Document document = new Document();
    // Add page
    Page page = document.Pages.Add();

    // -------------------------------------------------------------
    // Add image
    var imageFileName = Path.Combine(_dataDir, "logo.png");
    page.AddImage(imageFileName, new Aspose.Pdf.Rectangle(20, 730, 120, 830));

    // -------------------------------------------------------------
    // Add Header
    var header = new TextFragment("New ferry routes in Fall 2020");
    header.TextState.Font = FontRepository.FindFont("Arial");
    header.TextState.FontSize = 24;
    header.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
    header.Position = new Position(130, 720);
    page.Paragraphs.Add(header);

    // Add description
    var descriptionText = "Visitors must buy tickets online and tickets are limited to 5,000 per day. Ferry service is operating at half capacity and on a reduced schedule. Expect lineups.";
    var description = new TextFragment(descriptionText);
    description.TextState.Font = FontRepository.FindFont("Times New Roman");
    description.TextState.FontSize = 14;
    description.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Left;
    page.Paragraphs.Add(description);


    // Add table
    var table = new Aspose.Pdf.Table
    {
        ColumnWidths = "200",
        Border = new BorderInfo(BorderSide.Box, 1f, Aspose.Pdf.Color.DarkSlateGray),
        DefaultCellBorder = new BorderInfo(BorderSide.Box, 0.5f, Aspose.Pdf.Color.Black),
        DefaultCellPadding = new MarginInfo(4.5, 4.5, 4.5, 4.5),
        Margin =
                {
                    Bottom = 10
                },
        DefaultCellTextState =
                {
                    Font =  FontRepository.FindFont("Helvetica")
                }
    };

    var headerRow = table.Rows.Add();
    headerRow.Cells.Add("Departs City");
    headerRow.Cells.Add("Departs Island");
    foreach (Cell headerRowCell in headerRow.Cells)
    {
        headerRowCell.BackgroundColor = Aspose.Pdf.Color.Gray;
        headerRowCell.DefaultCellTextState.ForegroundColor = Aspose.Pdf.Color.WhiteSmoke;
    }

    var time = new TimeSpan(6, 0, 0);
    var incTime = new TimeSpan(0, 30, 0);
    for (int i = 0; i < 10; i++)
    {
        var dataRow = table.Rows.Add();
        dataRow.Cells.Add(time.ToString(@"hh\:mm"));
        time = time.Add(incTime);
        dataRow.Cells.Add(time.ToString(@"hh\:mm"));
    }

    page.Paragraphs.Add(table);

    document.Save(System.IO.Path.Combine(_dataDir, "Complex.pdf"));

}