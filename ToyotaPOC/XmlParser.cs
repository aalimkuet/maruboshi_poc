﻿using System.Xml.Xsl;
using System.Xml;
using Newtonsoft.Json;
using MaruboshiPOC;
using HtmlAgilityPack;

internal class XmlParser
{

    private static string _dataDir = @"D:\\BS23\\Marobusho\\MaruboshiPOC\\PdfSamples\\";
    public void GenerateXslFromXml()
    {
        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_dataDir + "myFile.xml");

            XmlDocument xsltDoc = new XmlDocument();

            XmlElement xsltRoot = xsltDoc.CreateElement("xsl:stylesheet", "http://www.w3.org/1999/XSL/Transform");
            xsltDoc.AppendChild(xsltRoot);

            XmlElement identityTemplate = xsltDoc.CreateElement("xsl:template", "http://www.w3.org/1999/XSL/Transform");
            identityTemplate.SetAttribute("match", "/");
            xsltRoot.AppendChild(identityTemplate);
#pragma warning disable CS8602
            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                if (node is XmlElement)
                {
                    XmlElement template = xsltDoc.CreateElement("xsl:template", "http://www.w3.org/1999/XSL/Transform");
                    template.SetAttribute("match", "/" + node.Name);
                    identityTemplate.AppendChild(template);

                    XmlElement copy = xsltDoc.CreateElement("xsl:copy", "http://www.w3.org/1999/XSL/Transform");
                    template.AppendChild(copy);

                    XmlElement applyAttributes = xsltDoc.CreateElement("xsl:apply-templates", "http://www.w3.org/1999/XSL/Transform");
                    applyAttributes.SetAttribute("select", "@*");
                    copy.AppendChild(applyAttributes);

                    // Apply children copy
                    XmlElement applyChildren = xsltDoc.CreateElement("xsl:apply-templates", "http://www.w3.org/1999/XSL/Transform");
                    copy.AppendChild(applyChildren);
                }
            }

            // Save the generated XSLT to a file
            xsltDoc.Save(_dataDir + "generated.xslt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public void CreatePdf()
    {
        string _dataDir1 = @"D:\\BS23\\Marobusho\\MaruboshiPOC\\PdfSamples\\";
        var XmlContent = File.ReadAllText(_dataDir1 + @"HelloWorld.xml");
        var XsltContent = File.ReadAllText(_dataDir1 + @"HelloWorld.xslt");
        var options = new Aspose.Pdf.HtmlLoadOptions();
        // set page size to A5      
        options.PageInfo.Height = 595;
        options.PageInfo.Width = 420;
        var pdfDocument = new Aspose.Pdf.Document(TransformXmltoHtml(XmlContent, XsltContent), options);
        pdfDocument.Save(_dataDir1 + "helloworld.pdf");
    }

    public static MemoryStream TransformXmltoHtml(string inputXml, string xsltString)
    {
        var transform = new XslCompiledTransform();
        using (var reader = XmlReader.Create(new StringReader(xsltString)))
        {
            transform.Load(reader);
        }
        var memoryStream = new MemoryStream();
        var results = new StreamWriter(memoryStream);
        using (var reader = XmlReader.Create(new StringReader(inputXml)))
        {
            transform.Transform(reader, null, results);
        }
        memoryStream.Position = 0;
        return memoryStream;
    }

    public void GenerateXslFromModel()
    {

        string _dataDir1 = @"D:\\BS23\\Marobusho\\MaruboshiPOC\\PdfSamples\\";
        var XmlContent = File.ReadAllText(_dataDir1 + @"HelloWorld.xml");
        var XsltContent = File.ReadAllText(_dataDir1 + @"HelloWorld.xslt");

        XslCompiledTransform transform = new XslCompiledTransform();
        using (XmlReader reader = XmlReader.Create(new StringReader(XsltContent)))
        {
            transform.Load(reader);
        }
        StringWriter results = new StringWriter();
        using (XmlReader reader = XmlReader.Create(new StringReader(XmlContent)))
        {
            transform.Transform(reader, null, results);
        }
        IronPdf.ChromePdfRenderer Renderer = new IronPdf.ChromePdfRenderer();
        // options, headers and footers may be set there
        // Render our XML as a PDF via XSLT
        Renderer.RenderHtmlAsPdf(results.ToString()).SaveAs("FinalIronPdf.pdf");
    }

    public void XmlToJson()
    {
        try
        {
            var fileName = Console.ReadLine();

            //var fileName = "M02525Utousenvhch06-MY100923"; 
            var xmlFilePath = Path.Combine(XmlCleaning._xmlDataDir, fileName + ".xml");

            string xmlContent = File.ReadAllText(xmlFilePath);
            XmlCleaning.ReplacingWords.ForEach(word =>
            {
                xmlContent = xmlContent.Replace(word, "");
            });

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlContent);

            string json = JsonConvert.SerializeXmlNode(xmlDoc);
            var jsonFilePath = Path.Combine(_dataDir, fileName + ".json");

            File.WriteAllText(jsonFilePath, json);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
    }

    public void JsonToCSharpClass()
    {
        try
        {
            var fileName = "M02525Utousenvhch06-MY100923";
            string jsonString = File.ReadAllText(XmlCleaning._xmlDataDir + fileName + ".json");

            var dynamicObject = JsonConvert.DeserializeObject<dynamic>(jsonString);
            dynamicObject = Convert.ToString(dynamicObject);
            var jsonFilePath = Path.Combine(_dataDir, fileName + ".cs");

            // Write the JSON string to the output file
            File.WriteAllText(jsonFilePath, dynamicObject);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
    }


    public void XmlManupulation()
    {
        string _dataDir1 = @"D:\\Clients\\USA\\Toyota\\Docs\\XmlToHtml\\";
        var XmlContent = File.ReadAllText(_dataDir1 + @"M02525Utousenvhch06-MY100923.xml");
        // XmlTagInsertion(_dataDir1);

    }

    public void XmlTagInsertion(string titleString)
    {
        string _dataDir = @"D:\\Clients\\USA\\Toyota\\Docs\\XmlToHtml\\";
        var filePath = _dataDir + @"M02525Utousenvhch06-MY100923.xml";
        var XmlContent = File.ReadAllText(filePath);

        var doc = new HtmlDocument();
        doc.LoadHtml(XmlContent);
        var targetTitleNode = doc.DocumentNode.SelectSingleNode($"//title[contains(text(), 'Cleaning and protecting the vehicle interior')]");

        if (targetTitleNode != null)
        {
            var nearestTopicNode = targetTitleNode.Ancestors("subsection_maintenance").FirstOrDefault();

            if (nearestTopicNode != null)
            {
                var plNode = doc.CreateElement("PL");

                plNode.AppendChild(nearestTopicNode.CloneNode(true));


                nearestTopicNode.ParentNode.ReplaceChild(plNode, nearestTopicNode);
                doc.Save(filePath);
                // Console.WriteLine(doc.DocumentNode.OuterHtml);
            }
            else
            {
                Console.WriteLine("No ancestor topic node found.");
            }
        }
        else
        {
            Console.WriteLine("Title node not found.");
        }
    }
}