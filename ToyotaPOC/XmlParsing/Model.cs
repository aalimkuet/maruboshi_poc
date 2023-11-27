#pragma warning disable CS8618

using System.Xml.Serialization;

namespace XmlParsing;

[Serializable()]

public partial class rootObject
{

    private Book bookField;

    [XmlElement("book")]
    public Book book
    {
        get
        {
            return bookField;
        }
        set
        {
            bookField = value;
        }
    }
}

public partial class Book
{

    private object[] itemsField;

    private string idField;

    private bookManualtype manualtypeField;

    private bookLang langField;

    private string vehicle_codeField;

    private string dev_codeField;

    private string lo_dateField;

    private bookScale scaleField;

    private string change_infoField;

    private string myField;

    private bookVehicle_type vehicle_typeField;

    private bookBody_type body_typeField;

    private string modelField;

    private bookDrive_train drive_trainField;

    private bookBrand brandField;

    private string period_fromField;

    private string period_toField;

    private string pubnoField;

    private string pubnameField;

    private string identify_codeField;

    private string om_styleField;

    private bookDestination destinationField;

    private string revisionField;

    private string publish_dateField;

    private string productionField;


    [XmlElement("appendix", typeof(appendix))]
    [XmlElement("chapter", typeof(Chapter))]
    [XmlElement("illusttoc", typeof(illusttoc))]
    [XmlElement("index", typeof(index))]
    [XmlElement("intro", typeof(intro))]
    [XmlElement("toc", typeof(toc))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public bookManualtype manualtype
    {
        get
        {
            return manualtypeField;
        }
        set
        {
            manualtypeField = value;
        }
    }


    [XmlAttribute()]
    public bookLang lang
    {
        get
        {
            return langField;
        }
        set
        {
            langField = value;
        }
    }


    [XmlAttribute()]
    public string vehicle_code
    {
        get
        {
            return vehicle_codeField;
        }
        set
        {
            vehicle_codeField = value;
        }
    }


    [XmlAttribute()]
    public string dev_code
    {
        get
        {
            return dev_codeField;
        }
        set
        {
            dev_codeField = value;
        }
    }


    [XmlAttribute()]
    public string lo_date
    {
        get
        {
            return lo_dateField;
        }
        set
        {
            lo_dateField = value;
        }
    }


    [XmlAttribute()]
    public bookScale scale
    {
        get
        {
            return scaleField;
        }
        set
        {
            scaleField = value;
        }
    }


    [XmlAttribute()]
    public string change_info
    {
        get
        {
            return change_infoField;
        }
        set
        {
            change_infoField = value;
        }
    }


    [XmlAttribute()]
    public string my
    {
        get
        {
            return myField;
        }
        set
        {
            myField = value;
        }
    }


    [XmlAttribute()]
    public bookVehicle_type vehicle_type
    {
        get
        {
            return vehicle_typeField;
        }
        set
        {
            vehicle_typeField = value;
        }
    }


    [XmlAttribute()]
    public bookBody_type body_type
    {
        get
        {
            return body_typeField;
        }
        set
        {
            body_typeField = value;
        }
    }


    [XmlAttribute()]
    public string model
    {
        get
        {
            return modelField;
        }
        set
        {
            modelField = value;
        }
    }


    [XmlAttribute()]
    public bookDrive_train drive_train
    {
        get
        {
            return drive_trainField;
        }
        set
        {
            drive_trainField = value;
        }
    }


    [XmlAttribute()]
    public bookBrand brand
    {
        get
        {
            return brandField;
        }
        set
        {
            brandField = value;
        }
    }


    [XmlAttribute()]
    public string period_from
    {
        get
        {
            return period_fromField;
        }
        set
        {
            period_fromField = value;
        }
    }


    [XmlAttribute()]
    public string period_to
    {
        get
        {
            return period_toField;
        }
        set
        {
            period_toField = value;
        }
    }


    [XmlAttribute()]
    public string pubno
    {
        get
        {
            return pubnoField;
        }
        set
        {
            pubnoField = value;
        }
    }


    [XmlAttribute()]
    public string pubname
    {
        get
        {
            return pubnameField;
        }
        set
        {
            pubnameField = value;
        }
    }


    [XmlAttribute()]
    public string identify_code
    {
        get
        {
            return identify_codeField;
        }
        set
        {
            identify_codeField = value;
        }
    }


    [XmlAttribute()]
    public string om_style
    {
        get
        {
            return om_styleField;
        }
        set
        {
            om_styleField = value;
        }
    }


    [XmlAttribute()]
    public bookDestination destination
    {
        get
        {
            return destinationField;
        }
        set
        {
            destinationField = value;
        }
    }


    [XmlAttribute()]
    public string revision
    {
        get
        {
            return revisionField;
        }
        set
        {
            revisionField = value;
        }
    }


    [XmlAttribute()]
    public string publish_date
    {
        get
        {
            return publish_dateField;
        }
        set
        {
            publish_dateField = value;
        }
    }


    [XmlAttribute()]
    public string production
    {
        get
        {
            return productionField;
        }
        set
        {
            productionField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class appendix
{

    private titlegroup titlegroupField;

    private body[] bodyField;

    private string idField;

    private string numField;

    private appendixColumn columnField;

    private string versionField;

    private string dateField;

    private appendixPublish_em publish_emField;

    private appendixPublish_pm publish_pmField;

    private appendixPublish_fullpm publish_fullpmField;

    public appendix()
    {
        columnField = appendixColumn.col;
        publish_emField = appendixPublish_em.yes;
        publish_pmField = appendixPublish_pm.yes;
        publish_fullpmField = appendixPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("body")]
    public body[] body
    {
        get
        {
            return bodyField;
        }
        set
        {
            bodyField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string num
    {
        get
        {
            return numField;
        }
        set
        {
            numField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(appendixColumn.col)]
    public appendixColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(appendixPublish_em.yes)]
    public appendixPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(appendixPublish_pm.yes)]
    public appendixPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(appendixPublish_fullpm.yes)]
    public appendixPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}


[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]

public partial class titlegroup
{

    private titlegroupbody[] titlegroupbodyField;

    private string tabletypeField;

    private string widthField;


    [XmlElement("titlegroupbody")]
    public titlegroupbody[] titlegroupbody
    {
        get
        {
            return titlegroupbodyField;
        }
        set
        {
            titlegroupbodyField = value;
        }
    }


    [XmlAttribute()]
    public string tabletype
    {
        get
        {
            return tabletypeField;
        }
        set
        {
            tabletypeField = value;
        }
    }


    [XmlAttribute()]
    public string width
    {
        get
        {
            return widthField;
        }
        set
        {
            widthField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
public partial class titlegroupbody
{

    private titlegrouprow[] titlegrouprowField;


    [XmlElement("titlegrouprow")]
    public titlegrouprow[] titlegrouprow
    {
        get
        {
            return titlegrouprowField;
        }
        set
        {
            titlegrouprowField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class titlegrouprow
{

    private titlegroupcell[] titlegroupcellField;


    [XmlElement("titlegroupcell")]
    public titlegroupcell[] titlegroupcell
    {
        get
        {
            return titlegroupcellField;
        }
        set
        {
            titlegroupcellField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class titlegroupcell
{

    private Title titleField;


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class Title
{

    private object[] itemsField;

    private string[] textField;

    private titleColumn columnField;

    private titlePage pageField;

    private string ominfoField;

    public Title()
    {
        columnField = titleColumn.col;
        pageField = titlePage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(titleColumn.col)]
    public titleColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(titlePage.none)]
    public titlePage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class b
{

    private object[] itemsField;

    private string[] textField;

    private bType typeField;

    public b()
    {
        typeField = bType.other;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(bType.other)]
    public bType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class @break
{

    private breakType typeField;

    public @break()
    {
        typeField = breakType.@return;
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(breakType.@return)]
    public breakType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}



[Serializable()]

public enum breakType
{


    @return,


    tab,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class function
{

    private object[] itemsField;

    private string[] textField;

    private string functionidField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string functionid
    {
        get
        {
            return functionidField;
        }
        set
        {
            functionidField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class i
{

    private object[] itemsField;

    private string[] textField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class indexmarker
{

    private string markerField;

    private string markeridField;


    [XmlAttribute()]
    public string marker
    {
        get
        {
            return markerField;
        }
        set
        {
            markerField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string markerid
    {
        get
        {
            return markeridField;
        }
        set
        {
            markeridField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class option
{

    private object[] itemsField;

    private string[] textField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class sub
{

    private object[] itemsField;

    private string[] textField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}


[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]

public partial class sup
{

    private object[] itemsField;

    private string[] textField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class symbol
{

    private string idField;

    private string hrefField;

    private string widthField;

    private string heightField;

    private string xoffsetField;

    private string yoffsetField;


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string href
    {
        get
        {
            return hrefField;
        }
        set
        {
            hrefField = value;
        }
    }


    [XmlAttribute()]
    public string width
    {
        get
        {
            return widthField;
        }
        set
        {
            widthField = value;
        }
    }


    [XmlAttribute()]
    public string height
    {
        get
        {
            return heightField;
        }
        set
        {
            heightField = value;
        }
    }


    [XmlAttribute()]
    public string xoffset
    {
        get
        {
            return xoffsetField;
        }
        set
        {
            xoffsetField = value;
        }
    }


    [XmlAttribute()]
    public string yoffset
    {
        get
        {
            return yoffsetField;
        }
        set
        {
            yoffsetField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]

public partial class u
{

    private object[] itemsField;

    private string[] textField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]

public partial class xref
{

    private string refidField;

    private string idrefField;

    private string typeField;

    private string srcfileField;

    private string labelField;

    private xrefRef_em ref_emField;

    private xrefRef_pm ref_pmField;

    private xrefRef_fullpm ref_fullpmField;

    public xref()
    {
        ref_emField = xrefRef_em.yes;
        ref_pmField = xrefRef_pm.yes;
        ref_fullpmField = xrefRef_fullpm.yes;
    }


    [XmlAttribute(DataType = "IDREF")]
    public string refid
    {
        get
        {
            return refidField;
        }
        set
        {
            refidField = value;
        }
    }


    [XmlAttribute()]
    public string idref
    {
        get
        {
            return idrefField;
        }
        set
        {
            idrefField = value;
        }
    }


    [XmlAttribute()]
    public string type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute()]
    public string srcfile
    {
        get
        {
            return srcfileField;
        }
        set
        {
            srcfileField = value;
        }
    }


    [XmlAttribute()]
    public string label
    {
        get
        {
            return labelField;
        }
        set
        {
            labelField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(xrefRef_em.yes)]
    public xrefRef_em ref_em
    {
        get
        {
            return ref_emField;
        }
        set
        {
            ref_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(xrefRef_pm.yes)]
    public xrefRef_pm ref_pm
    {
        get
        {
            return ref_pmField;
        }
        set
        {
            ref_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(xrefRef_fullpm.yes)]
    public xrefRef_fullpm ref_fullpm
    {
        get
        {
            return ref_fullpmField;
        }
        set
        {
            ref_fullpmField = value;
        }
    }
}



[Serializable()]

public enum xrefRef_em
{


    yes,


    no,
}



[Serializable()]

public enum xrefRef_pm
{


    yes,


    no,
}



[Serializable()]

public enum xrefRef_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum bType
{


    stepnum,


    mbold,


    other,
}



[Serializable()]

public enum titleColumn
{


    col,


    full,
}



[Serializable()]

public enum titlePage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class body
{

    private object[] itemsField;

    private string idField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private bodyPublish_em publish_emField;

    private bodyPublish_pm publish_pmField;

    private bodyPublish_fullpm publish_fullpmField;

    public body()
    {
        publish_emField = bodyPublish_em.yes;
        publish_pmField = bodyPublish_pm.yes;
        publish_fullpmField = bodyPublish_fullpm.yes;
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paragroup", typeof(paragroup))]
    [XmlElement("paraselect", typeof(paraselect))]
    [XmlElement("quickref", typeof(quickref))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(bodyPublish_em.yes)]
    public bodyPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(bodyPublish_pm.yes)]
    public bodyPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(bodyPublish_fullpm.yes)]
    public bodyPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class Attention
{

    private attentiontbl[] attentiontblField;

    private string idField;

    private attentionType typeField;

    private attentionColumn columnField;

    private attentionPage pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private attentionPublish_em publish_emField;

    private attentionPublish_pm publish_pmField;

    private attentionPublish_fullpm publish_fullpmField;

    public Attention()
    {
        columnField = attentionColumn.col;
        pageField = attentionPage.none;
        publish_emField = attentionPublish_em.yes;
        publish_pmField = attentionPublish_pm.yes;
        publish_fullpmField = attentionPublish_fullpm.yes;
    }


    [XmlElement("attentiontbl")]
    public attentiontbl[] attentiontbl
    {
        get
        {
            return attentiontblField;
        }
        set
        {
            attentiontblField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public attentionType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(attentionColumn.col)]
    public attentionColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(attentionPage.none)]
    public attentionPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(attentionPublish_em.yes)]
    public attentionPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(attentionPublish_pm.yes)]
    public attentionPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(attentionPublish_fullpm.yes)]
    public attentionPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class attentiontbl
{

    private attentiontbl_body[] attentiontbl_bodyField;

    private string tabletypeField;

    private string widthField;


    [XmlElement("attentiontbl_body")]
    public attentiontbl_body[] attentiontbl_body
    {
        get
        {
            return attentiontbl_bodyField;
        }
        set
        {
            attentiontbl_bodyField = value;
        }
    }


    [XmlAttribute()]
    public string tabletype
    {
        get
        {
            return tabletypeField;
        }
        set
        {
            tabletypeField = value;
        }
    }


    [XmlAttribute()]
    public string width
    {
        get
        {
            return widthField;
        }
        set
        {
            widthField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class attentiontbl_body
{

    private attentiontbl_body_row[] attentiontbl_body_rowField;


    [XmlElement("attentiontbl_body_row")]
    public attentiontbl_body_row[] attentiontbl_body_row
    {
        get
        {
            return attentiontbl_body_rowField;
        }
        set
        {
            attentiontbl_body_rowField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class attentiontbl_body_row
{

    private attention_body[] attention_bodyField;


    [XmlElement("attention_body")]
    public attention_body[] attention_body
    {
        get
        {
            return attention_bodyField;
        }
        set
        {
            attention_bodyField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class attention_body
{

    private object[] itemsField;

    private string ominfoField;


    [XmlElement("attention_mark", typeof(attention_mark))]
    [XmlElement("attention_para", typeof(attention_para))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class attention_mark
{
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class attention_para
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string ominfoField;

    private string versionField;

    private string dateField;

    private attention_paraPublish_em publish_emField;

    private attention_paraPublish_pm publish_pmField;

    private attention_paraPublish_fullpm publish_fullpmField;

    public attention_para()
    {
        publish_emField = attention_paraPublish_em.yes;
        publish_pmField = attention_paraPublish_pm.yes;
        publish_fullpmField = attention_paraPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("att_fig", typeof(att_fig))]
    [XmlElement("att_list1", typeof(att_list1))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(attention_paraPublish_em.yes)]
    public attention_paraPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(attention_paraPublish_pm.yes)]
    public attention_paraPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(attention_paraPublish_fullpm.yes)]
    public attention_paraPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class att_fig
{

    private object[] itemsField;

    private Paragraphs pField;

    private object[] items1Field;

    private string ominfoField;

    private att_figPublish_em publish_emField;

    private att_figPublish_pm publish_pmField;

    private att_figPublish_fullpm publish_fullpmField;

    public att_fig()
    {
        publish_emField = att_figPublish_em.yes;
        publish_pmField = att_figPublish_pm.yes;
        publish_fullpmField = att_figPublish_fullpm.yes;
    }


    [XmlElement("audio", typeof(audio))]
    [XmlElement("image", typeof(image))]
    [XmlElement("video", typeof(video))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    public Paragraphs p
    {
        get
        {
            return pField;
        }
        set
        {
            pField = value;
        }
    }


    [XmlElement("att_callout", typeof(att_callout))]
    [XmlElement("calloutgroup", typeof(calloutgroup))]
    public object[] Items1
    {
        get
        {
            return items1Field;
        }
        set
        {
            items1Field = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(att_figPublish_em.yes)]
    public att_figPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(att_figPublish_pm.yes)]
    public att_figPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(att_figPublish_fullpm.yes)]
    public att_figPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class audio
{

    private string idField;

    private string hrefField;

    private audioPreload preloadField;

    private string autoplayField;

    private string mediagroupField;

    private string loopField;

    private string mutedField;

    private string controlsField;

    public audio()
    {
        preloadField = audioPreload.metadata;
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string href
    {
        get
        {
            return hrefField;
        }
        set
        {
            hrefField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(audioPreload.metadata)]
    public audioPreload preload
    {
        get
        {
            return preloadField;
        }
        set
        {
            preloadField = value;
        }
    }


    [XmlAttribute()]
    public string autoplay
    {
        get
        {
            return autoplayField;
        }
        set
        {
            autoplayField = value;
        }
    }


    [XmlAttribute()]
    public string mediagroup
    {
        get
        {
            return mediagroupField;
        }
        set
        {
            mediagroupField = value;
        }
    }


    [XmlAttribute()]
    public string loop
    {
        get
        {
            return loopField;
        }
        set
        {
            loopField = value;
        }
    }


    [XmlAttribute()]
    public string muted
    {
        get
        {
            return mutedField;
        }
        set
        {
            mutedField = value;
        }
    }


    [XmlAttribute()]
    public string controls
    {
        get
        {
            return controlsField;
        }
        set
        {
            controlsField = value;
        }
    }
}



[Serializable()]

public enum audioPreload
{


    none,


    metadata,


    auto,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class image
{

    private string idField;

    private string hrefField;

    private string widthField;

    private string heightField;

    private string scaleField;

    private imageBorder borderField;

    private string alignField;

    private string xoffsetField;

    private string yoffsetField;

    public image()
    {
        borderField = imageBorder.Item1;
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string href
    {
        get
        {
            return hrefField;
        }
        set
        {
            hrefField = value;
        }
    }


    [XmlAttribute()]
    public string width
    {
        get
        {
            return widthField;
        }
        set
        {
            widthField = value;
        }
    }


    [XmlAttribute()]
    public string height
    {
        get
        {
            return heightField;
        }
        set
        {
            heightField = value;
        }
    }


    [XmlAttribute()]
    public string scale
    {
        get
        {
            return scaleField;
        }
        set
        {
            scaleField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(imageBorder.Item1)]
    public imageBorder border
    {
        get
        {
            return borderField;
        }
        set
        {
            borderField = value;
        }
    }


    [XmlAttribute()]
    public string align
    {
        get
        {
            return alignField;
        }
        set
        {
            alignField = value;
        }
    }


    [XmlAttribute()]
    public string xoffset
    {
        get
        {
            return xoffsetField;
        }
        set
        {
            xoffsetField = value;
        }
    }


    [XmlAttribute()]
    public string yoffset
    {
        get
        {
            return yoffsetField;
        }
        set
        {
            yoffsetField = value;
        }
    }
}



[Serializable()]

public enum imageBorder
{


    [XmlEnum("0")]
    Item0,


    [XmlEnum("1")]
    Item1,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class video
{

    private vtt[] vttField;

    private string idField;

    private string hrefField;

    private videoPreload preloadField;

    private string autoplayField;

    private string mediagroupField;

    private string loopField;

    private string mutedField;

    private string controlsField;

    private string posterField;

    private string heightField;

    private string widthField;

    public video()
    {
        preloadField = videoPreload.metadata;
    }


    [XmlElement("vtt")]
    public vtt[] vtt
    {
        get
        {
            return vttField;
        }
        set
        {
            vttField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string href
    {
        get
        {
            return hrefField;
        }
        set
        {
            hrefField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(videoPreload.metadata)]
    public videoPreload preload
    {
        get
        {
            return preloadField;
        }
        set
        {
            preloadField = value;
        }
    }


    [XmlAttribute()]
    public string autoplay
    {
        get
        {
            return autoplayField;
        }
        set
        {
            autoplayField = value;
        }
    }


    [XmlAttribute()]
    public string mediagroup
    {
        get
        {
            return mediagroupField;
        }
        set
        {
            mediagroupField = value;
        }
    }


    [XmlAttribute()]
    public string loop
    {
        get
        {
            return loopField;
        }
        set
        {
            loopField = value;
        }
    }


    [XmlAttribute()]
    public string muted
    {
        get
        {
            return mutedField;
        }
        set
        {
            mutedField = value;
        }
    }


    [XmlAttribute()]
    public string controls
    {
        get
        {
            return controlsField;
        }
        set
        {
            controlsField = value;
        }
    }


    [XmlAttribute()]
    public string poster
    {
        get
        {
            return posterField;
        }
        set
        {
            posterField = value;
        }
    }


    [XmlAttribute()]
    public string height
    {
        get
        {
            return heightField;
        }
        set
        {
            heightField = value;
        }
    }


    [XmlAttribute()]
    public string width
    {
        get
        {
            return widthField;
        }
        set
        {
            widthField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class vtt
{

    private object[] itemsField;

    private string[] textField;

    private string titleField;

    private string beginField;

    private string endField;

    private string lineField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("i", typeof(i))]
    [XmlElement("u", typeof(u))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    public string title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlAttribute()]
    public string begin
    {
        get
        {
            return beginField;
        }
        set
        {
            beginField = value;
        }
    }


    [XmlAttribute()]
    public string end
    {
        get
        {
            return endField;
        }
        set
        {
            endField = value;
        }
    }


    [XmlAttribute()]
    public string line
    {
        get
        {
            return lineField;
        }
        set
        {
            lineField = value;
        }
    }
}



[Serializable()]

public enum videoPreload
{


    none,


    metadata,


    auto,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
public partial class Paragraphs
{

    private object[] itemsField;

    private string[] textField;

    private pColumn columnField;

    private pPage pageField;

    private string ominfoField;

    public Paragraphs()
    {
        columnField = pColumn.col;
        pageField = pPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(pColumn.col)]
    public pColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(pPage.none)]
    public pPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]

public enum pColumn
{


    col,


    full,
}



[Serializable()]

public enum pPage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class att_callout
{

    private calloutitem[] calloutitemField;

    private footnote footnoteField;

    private att_calloutType typeField;

    private att_calloutStartnumber startnumberField;

    private string ominfoField;

    public att_callout()
    {
        typeField = att_calloutType.illust;
        startnumberField = att_calloutStartnumber.Item1;
    }


    [XmlElement("calloutitem")]
    public calloutitem[] calloutitem
    {
        get
        {
            return calloutitemField;
        }
        set
        {
            calloutitemField = value;
        }
    }


    public footnote footnote
    {
        get
        {
            return footnoteField;
        }
        set
        {
            footnoteField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(att_calloutType.illust)]
    public att_calloutType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(att_calloutStartnumber.Item1)]
    public att_calloutStartnumber startnumber
    {
        get
        {
            return startnumberField;
        }
        set
        {
            startnumberField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class calloutitem
{

    private callouttxt callouttxtField;

    private object[] itemsField;

    private string ominfoField;


    public callouttxt callouttxt
    {
        get
        {
            return callouttxtField;
        }
        set
        {
            callouttxtField = value;
        }
    }


    [XmlElement("calloutlist", typeof(calloutlist))]
    [XmlElement("callouttxt_sub", typeof(callouttxt_sub))]
    [XmlElement("footnote", typeof(footnote))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class callouttxt
{

    private object[] itemsField;

    private string[] textField;

    private string numberField;

    private callouttxtColumn columnField;

    private callouttxtPage pageField;

    public callouttxt()
    {
        columnField = callouttxtColumn.col;
        pageField = callouttxtPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    public string number
    {
        get
        {
            return numberField;
        }
        set
        {
            numberField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(callouttxtColumn.col)]
    public callouttxtColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(callouttxtPage.none)]
    public callouttxtPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }
}



[Serializable()]

public enum callouttxtColumn
{


    col,


    full,
}



[Serializable()]

public enum callouttxtPage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class calloutlist
{

    private calloutlist_item[] calloutlist_itemField;

    private calloutlistColumn columnField;

    public calloutlist()
    {
        columnField = calloutlistColumn.col;
    }


    [XmlElement("calloutlist_item")]
    public calloutlist_item[] calloutlist_item
    {
        get
        {
            return calloutlist_itemField;
        }
        set
        {
            calloutlist_itemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(calloutlistColumn.col)]
    public calloutlistColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class calloutlist_item
{

    private itemtxt itemtxtField;

    private object[] itemsField;


    [XmlElement(Order = 0)]
    public itemtxt itemtxt
    {
        get
        {
            return itemtxtField;
        }
        set
        {
            itemtxtField = value;
        }
    }


    [XmlElement("itemtxt", typeof(itemtxt), Order = 1)]
    [XmlElement("itemtxt_sub", typeof(itemtxt_sub), Order = 1)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class itemtxt
{

    private object[] itemsField;

    private string[] textField;

    private itemtxtPage pageField;

    public itemtxt()
    {
        pageField = itemtxtPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(itemtxtPage.none)]
    public itemtxtPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }
}



[Serializable()]

public enum itemtxtPage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class itemtxt_sub
{

    private object[] itemsField;

    private string[] textField;

    private itemtxt_subPage pageField;

    public itemtxt_sub()
    {
        pageField = itemtxt_subPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(itemtxt_subPage.none)]
    public itemtxt_subPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }
}



[Serializable()]

public enum itemtxt_subPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum calloutlistColumn
{


    col,


    full,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class callouttxt_sub
{

    private object[] itemsField;

    private string[] textField;

    private callouttxt_subColumn columnField;

    private callouttxt_subPage pageField;

    public callouttxt_sub()
    {
        columnField = callouttxt_subColumn.col;
        pageField = callouttxt_subPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(callouttxt_subColumn.col)]
    public callouttxt_subColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(callouttxt_subPage.none)]
    public callouttxt_subPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }
}



[Serializable()]

public enum callouttxt_subColumn
{


    col,


    full,
}



[Serializable()]

public enum callouttxt_subPage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class footnote
{

    private object[] itemsField;

    private string idField;

    private footnoteType typeField;

    private footnoteNum numField;

    private bool numFieldSpecified;

    private string ominfoField;

    public footnote()
    {
        typeField = footnoteType.other;
    }


    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_sub", typeof(p_sub))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(footnoteType.other)]
    public footnoteType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute()]
    public footnoteNum num
    {
        get
        {
            return numField;
        }
        set
        {
            numField = value;
        }
    }


    [XmlIgnore()]
    public bool numSpecified
    {
        get
        {
            return numFieldSpecified;
        }
        set
        {
            numFieldSpecified = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class p_sub
{

    private object[] itemsField;

    private string[] textField;

    private p_subColumn columnField;

    private p_subPage pageField;

    private string ominfoField;

    public p_sub()
    {
        columnField = p_subColumn.col;
        pageField = p_subPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(p_subColumn.col)]
    public p_subColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(p_subPage.none)]
    public p_subPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]

public enum p_subColumn
{


    col,


    full,
}



[Serializable()]

public enum p_subPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum footnoteType
{


    option,


    other,
}



[Serializable()]

public enum footnoteNum
{


    [XmlEnum("0")]
    Item0,


    [XmlEnum("1")]
    Item1,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("3")]
    Item3,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("5")]
    Item5,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("7")]
    Item7,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("9")]
    Item9,


    [XmlEnum("10")]
    Item10,
}



[Serializable()]

public enum att_calloutType
{


    number,


    illust,
}



[Serializable()]

public enum att_calloutStartnumber
{


    [XmlEnum("1")]
    Item1,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("3")]
    Item3,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("5")]
    Item5,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("7")]
    Item7,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("9")]
    Item9,


    [XmlEnum("10")]
    Item10,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class calloutgroup
{

    private Title titleField;

    private object[] itemsField;

    private footnote footnoteField;

    private calloutgroupType typeField;

    private calloutgroupStartnumber startnumberField;

    private calloutgroupTitletype titletypeField;

    public calloutgroup()
    {
        typeField = calloutgroupType.illust;
        startnumberField = calloutgroupStartnumber.Item1;
        titletypeField = calloutgroupTitletype.triangle;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("calloutitem", typeof(calloutitem))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    public footnote footnote
    {
        get
        {
            return footnoteField;
        }
        set
        {
            footnoteField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(calloutgroupType.illust)]
    public calloutgroupType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(calloutgroupStartnumber.Item1)]
    public calloutgroupStartnumber startnumber
    {
        get
        {
            return startnumberField;
        }
        set
        {
            startnumberField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(calloutgroupTitletype.triangle)]
    public calloutgroupTitletype titletype
    {
        get
        {
            return titletypeField;
        }
        set
        {
            titletypeField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class table
{

    private tabletitle tabletitleField;

    private tgroup[] tgroupField;

    private footnote footnoteField;

    private tableFrame frameField;

    private bool frameFieldSpecified;

    private tableFontsize fontsizeField;

    private string pgwideField;

    private tableColumn columnField;

    private string colsepField;

    private string rowsepField;

    private tablePage pageField;

    private string ominfoField;

    public table()
    {
        fontsizeField = tableFontsize.Item85;
        columnField = tableColumn.col;
        pageField = tablePage.none;
    }


    public tabletitle tabletitle
    {
        get
        {
            return tabletitleField;
        }
        set
        {
            tabletitleField = value;
        }
    }


    [XmlElement("tgroup")]
    public tgroup[] tgroup
    {
        get
        {
            return tgroupField;
        }
        set
        {
            tgroupField = value;
        }
    }


    public footnote footnote
    {
        get
        {
            return footnoteField;
        }
        set
        {
            footnoteField = value;
        }
    }


    [XmlAttribute()]
    public tableFrame frame
    {
        get
        {
            return frameField;
        }
        set
        {
            frameField = value;
        }
    }


    [XmlIgnore()]
    public bool frameSpecified
    {
        get
        {
            return frameFieldSpecified;
        }
        set
        {
            frameFieldSpecified = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tableFontsize.Item85)]
    public tableFontsize fontsize
    {
        get
        {
            return fontsizeField;
        }
        set
        {
            fontsizeField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKEN")]
    public string pgwide
    {
        get
        {
            return pgwideField;
        }
        set
        {
            pgwideField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tableColumn.col)]
    public tableColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    public string colsep
    {
        get
        {
            return colsepField;
        }
        set
        {
            colsepField = value;
        }
    }


    [XmlAttribute()]
    public string rowsep
    {
        get
        {
            return rowsepField;
        }
        set
        {
            rowsepField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tablePage.none)]
    public tablePage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class tabletitle
{

    private object[] itemsField;

    private string[] textField;

    private tabletitleColumn columnField;

    private tabletitlePage pageField;

    public tabletitle()
    {
        columnField = tabletitleColumn.col;
        pageField = tabletitlePage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tabletitleColumn.col)]
    public tabletitleColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tabletitlePage.none)]
    public tabletitlePage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }
}



[Serializable()]

public enum tabletitleColumn
{


    col,


    full,
}



[Serializable()]

public enum tabletitlePage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class tgroup
{

    private colspec[] colspecField;

    private thead theadField;

    private tbody tbodyField;

    private string colsField;

    private string tabletypeField;

    private string colsepField;

    private string rowsepField;


    [XmlElement("colspec")]
    public colspec[] colspec
    {
        get
        {
            return colspecField;
        }
        set
        {
            colspecField = value;
        }
    }


    public thead thead
    {
        get
        {
            return theadField;
        }
        set
        {
            theadField = value;
        }
    }


    public tbody tbody
    {
        get
        {
            return tbodyField;
        }
        set
        {
            tbodyField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKEN")]
    public string cols
    {
        get
        {
            return colsField;
        }
        set
        {
            colsField = value;
        }
    }


    [XmlAttribute()]
    public string tabletype
    {
        get
        {
            return tabletypeField;
        }
        set
        {
            tabletypeField = value;
        }
    }


    [XmlAttribute()]
    public string colsep
    {
        get
        {
            return colsepField;
        }
        set
        {
            colsepField = value;
        }
    }


    [XmlAttribute()]
    public string rowsep
    {
        get
        {
            return rowsepField;
        }
        set
        {
            rowsepField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class colspec
{

    private string colnumField;

    private string colnameField;

    private string colwidthField;

    private string colsepField;


    [XmlAttribute()]
    public string colnum
    {
        get
        {
            return colnumField;
        }
        set
        {
            colnumField = value;
        }
    }


    [XmlAttribute()]
    public string colname
    {
        get
        {
            return colnameField;
        }
        set
        {
            colnameField = value;
        }
    }


    [XmlAttribute()]
    public string colwidth
    {
        get
        {
            return colwidthField;
        }
        set
        {
            colwidthField = value;
        }
    }


    [XmlAttribute()]
    public string colsep
    {
        get
        {
            return colsepField;
        }
        set
        {
            colsepField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class thead
{

    private row[] rowField;

    private theadValign valignField;

    private bool valignFieldSpecified;


    [XmlElement("row")]
    public row[] row
    {
        get
        {
            return rowField;
        }
        set
        {
            rowField = value;
        }
    }


    [XmlAttribute()]
    public theadValign valign
    {
        get
        {
            return valignField;
        }
        set
        {
            valignField = value;
        }
    }


    [XmlIgnore()]
    public bool valignSpecified
    {
        get
        {
            return valignFieldSpecified;
        }
        set
        {
            valignFieldSpecified = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class row
{

    private entry[] entryField;

    private rowValign valignField;

    private bool valignFieldSpecified;

    private string ominfoField;


    [XmlElement("entry")]
    public entry[] entry
    {
        get
        {
            return entryField;
        }
        set
        {
            entryField = value;
        }
    }


    [XmlAttribute()]
    public rowValign valign
    {
        get
        {
            return valignField;
        }
        set
        {
            valignField = value;
        }
    }


    [XmlIgnore()]
    public bool valignSpecified
    {
        get
        {
            return valignFieldSpecified;
        }
        set
        {
            valignFieldSpecified = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class entry
{

    private object[] itemsField;

    private entryAlign alignField;

    private bool alignFieldSpecified;

    private entryValign valignField;

    private bool valignFieldSpecified;

    private string colnameField;

    private string namestField;

    private string nameendField;

    private string morerowsField;

    private entryFontwidth fontwidthField;

    private string bordertopField;

    private string borderbottomField;

    private string borderleftField;

    private string borderrightField;

    private entryPadding_top padding_topField;

    private bool padding_topFieldSpecified;

    private entryPadding_bottom padding_bottomField;

    private bool padding_bottomFieldSpecified;

    private entryPadding_left padding_leftField;

    private bool padding_leftFieldSpecified;

    private entryPadding_right padding_rightField;

    private bool padding_rightFieldSpecified;

    private entryBackgroundcolor backgroundcolorField;

    private bool backgroundcolorFieldSpecified;

    private string ominfoField;

    public entry()
    {
        fontwidthField = entryFontwidth.normal;
    }


    [XmlElement("audio", typeof(audio))]
    [XmlElement("diagnostic", typeof(diagnostic))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("image", typeof(image))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("tbl_fig", typeof(tbl_fig))]
    [XmlElement("tbl_list1", typeof(tbl_list1))]
    [XmlElement("video", typeof(video))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute()]
    public entryAlign align
    {
        get
        {
            return alignField;
        }
        set
        {
            alignField = value;
        }
    }


    [XmlIgnore()]
    public bool alignSpecified
    {
        get
        {
            return alignFieldSpecified;
        }
        set
        {
            alignFieldSpecified = value;
        }
    }


    [XmlAttribute()]
    public entryValign valign
    {
        get
        {
            return valignField;
        }
        set
        {
            valignField = value;
        }
    }


    [XmlIgnore()]
    public bool valignSpecified
    {
        get
        {
            return valignFieldSpecified;
        }
        set
        {
            valignFieldSpecified = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKEN")]
    public string colname
    {
        get
        {
            return colnameField;
        }
        set
        {
            colnameField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKEN")]
    public string namest
    {
        get
        {
            return namestField;
        }
        set
        {
            namestField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKEN")]
    public string nameend
    {
        get
        {
            return nameendField;
        }
        set
        {
            nameendField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKEN")]
    public string morerows
    {
        get
        {
            return morerowsField;
        }
        set
        {
            morerowsField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(entryFontwidth.normal)]
    public entryFontwidth fontwidth
    {
        get
        {
            return fontwidthField;
        }
        set
        {
            fontwidthField = value;
        }
    }


    [XmlAttribute("border-top", DataType = "NMTOKEN")]
    public string bordertop
    {
        get
        {
            return bordertopField;
        }
        set
        {
            bordertopField = value;
        }
    }


    [XmlAttribute("border-bottom", DataType = "NMTOKEN")]
    public string borderbottom
    {
        get
        {
            return borderbottomField;
        }
        set
        {
            borderbottomField = value;
        }
    }


    [XmlAttribute("border-left", DataType = "NMTOKEN")]
    public string borderleft
    {
        get
        {
            return borderleftField;
        }
        set
        {
            borderleftField = value;
        }
    }


    [XmlAttribute("border-right", DataType = "NMTOKEN")]
    public string borderright
    {
        get
        {
            return borderrightField;
        }
        set
        {
            borderrightField = value;
        }
    }


    [XmlAttribute()]
    public entryPadding_top padding_top
    {
        get
        {
            return padding_topField;
        }
        set
        {
            padding_topField = value;
        }
    }


    [XmlIgnore()]
    public bool padding_topSpecified
    {
        get
        {
            return padding_topFieldSpecified;
        }
        set
        {
            padding_topFieldSpecified = value;
        }
    }


    [XmlAttribute()]
    public entryPadding_bottom padding_bottom
    {
        get
        {
            return padding_bottomField;
        }
        set
        {
            padding_bottomField = value;
        }
    }


    [XmlIgnore()]
    public bool padding_bottomSpecified
    {
        get
        {
            return padding_bottomFieldSpecified;
        }
        set
        {
            padding_bottomFieldSpecified = value;
        }
    }


    [XmlAttribute()]
    public entryPadding_left padding_left
    {
        get
        {
            return padding_leftField;
        }
        set
        {
            padding_leftField = value;
        }
    }


    [XmlIgnore()]
    public bool padding_leftSpecified
    {
        get
        {
            return padding_leftFieldSpecified;
        }
        set
        {
            padding_leftFieldSpecified = value;
        }
    }


    [XmlAttribute()]
    public entryPadding_right padding_right
    {
        get
        {
            return padding_rightField;
        }
        set
        {
            padding_rightField = value;
        }
    }


    [XmlIgnore()]
    public bool padding_rightSpecified
    {
        get
        {
            return padding_rightFieldSpecified;
        }
        set
        {
            padding_rightFieldSpecified = value;
        }
    }


    [XmlAttribute()]
    public entryBackgroundcolor backgroundcolor
    {
        get
        {
            return backgroundcolorField;
        }
        set
        {
            backgroundcolorField = value;
        }
    }


    [XmlIgnore()]
    public bool backgroundcolorSpecified
    {
        get
        {
            return backgroundcolorFieldSpecified;
        }
        set
        {
            backgroundcolorFieldSpecified = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class diagnostic
{

    private object[] diagbodyField;

    private result resultField;

    private string idField;


    [XmlArrayItem("diag_list1", typeof(diag_list1), IsNullable = false)]
    [XmlArrayItem("diagtxt", typeof(diagtxt), IsNullable = false)]
    [XmlArrayItem("diagtxt_sub", typeof(diagtxt_sub), IsNullable = false)]
    [XmlArrayItem("p", typeof(Paragraphs), IsNullable = false)]
    [XmlArrayItem("p_sub", typeof(p_sub), IsNullable = false)]
    public object[] diagbody
    {
        get
        {
            return diagbodyField;
        }
        set
        {
            diagbodyField = value;
        }
    }


    public result result
    {
        get
        {
            return resultField;
        }
        set
        {
            resultField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class diag_list1
{

    private diag_list1_item[] diag_list1_itemField;

    private diag_list1Type typeField;

    public diag_list1()
    {
        typeField = diag_list1Type.bull;
    }


    [XmlElement("diag_list1_item")]
    public diag_list1_item[] diag_list1_item
    {
        get
        {
            return diag_list1_itemField;
        }
        set
        {
            diag_list1_itemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(diag_list1Type.bull)]
    public diag_list1Type type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class diag_list1_item
{

    private diag_fig diag_figField;

    private itemtxt itemtxtField;

    private object[] itemsField;


    [XmlElement(Order = 0)]
    public diag_fig diag_fig
    {
        get
        {
            return diag_figField;
        }
        set
        {
            diag_figField = value;
        }
    }


    [XmlElement(Order = 1)]
    public itemtxt itemtxt
    {
        get
        {
            return itemtxtField;
        }
        set
        {
            itemtxtField = value;
        }
    }


    [XmlElement("diag_fig", typeof(diag_fig), Order = 2)]
    [XmlElement("diag_list2", typeof(diag_list2), Order = 2)]
    [XmlElement("footnote", typeof(footnote), Order = 2)]
    [XmlElement("itemtxt", typeof(itemtxt), Order = 2)]
    [XmlElement("itemtxt_sub", typeof(itemtxt_sub), Order = 2)]
    [XmlElement("p_select", typeof(p_select), Order = 2)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class diag_fig
{

    private object[] itemsField;

    private Paragraphs pField;

    private object[] items1Field;

    private diag_figPublish_em publish_emField;

    private diag_figPublish_pm publish_pmField;

    private diag_figPublish_fullpm publish_fullpmField;

    public diag_fig()
    {
        publish_emField = diag_figPublish_em.yes;
        publish_pmField = diag_figPublish_pm.yes;
        publish_fullpmField = diag_figPublish_fullpm.yes;
    }


    [XmlElement("audio", typeof(audio))]
    [XmlElement("image", typeof(image))]
    [XmlElement("video", typeof(video))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    public Paragraphs p
    {
        get
        {
            return pField;
        }
        set
        {
            pField = value;
        }
    }


    [XmlElement("calloutgroup", typeof(calloutgroup))]
    [XmlElement("diag_callout", typeof(diag_callout))]
    public object[] Items1
    {
        get
        {
            return items1Field;
        }
        set
        {
            items1Field = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(diag_figPublish_em.yes)]
    public diag_figPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(diag_figPublish_pm.yes)]
    public diag_figPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(diag_figPublish_fullpm.yes)]
    public diag_figPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class diag_callout
{

    private calloutitem[] calloutitemField;

    private footnote footnoteField;

    private diag_calloutType typeField;

    private diag_calloutStartnumber startnumberField;

    public diag_callout()
    {
        typeField = diag_calloutType.illust;
        startnumberField = diag_calloutStartnumber.Item1;
    }


    [XmlElement("calloutitem")]
    public calloutitem[] calloutitem
    {
        get
        {
            return calloutitemField;
        }
        set
        {
            calloutitemField = value;
        }
    }


    public footnote footnote
    {
        get
        {
            return footnoteField;
        }
        set
        {
            footnoteField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(diag_calloutType.illust)]
    public diag_calloutType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(diag_calloutStartnumber.Item1)]
    public diag_calloutStartnumber startnumber
    {
        get
        {
            return startnumberField;
        }
        set
        {
            startnumberField = value;
        }
    }
}



[Serializable()]

public enum diag_calloutType
{


    number,


    illust,
}



[Serializable()]

public enum diag_calloutStartnumber
{


    [XmlEnum("1")]
    Item1,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("3")]
    Item3,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("5")]
    Item5,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("7")]
    Item7,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("9")]
    Item9,


    [XmlEnum("10")]
    Item10,
}



[Serializable()]

public enum diag_figPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum diag_figPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum diag_figPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class diag_list2
{

    private diag_list2_item[] diag_list2_itemField;

    private diag_list2Type typeField;

    public diag_list2()
    {
        typeField = diag_list2Type.dot;
    }


    [XmlElement("diag_list2_item")]
    public diag_list2_item[] diag_list2_item
    {
        get
        {
            return diag_list2_itemField;
        }
        set
        {
            diag_list2_itemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(diag_list2Type.dot)]
    public diag_list2Type type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class diag_list2_item
{

    private itemtxt itemtxtField;

    private object[] itemsField;


    [XmlElement(Order = 0)]
    public itemtxt itemtxt
    {
        get
        {
            return itemtxtField;
        }
        set
        {
            itemtxtField = value;
        }
    }


    [XmlElement("footnote", typeof(footnote), Order = 1)]
    [XmlElement("itemtxt", typeof(itemtxt), Order = 1)]
    [XmlElement("itemtxt_sub", typeof(itemtxt_sub), Order = 1)]
    [XmlElement("p_select", typeof(p_select), Order = 1)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class p_select
{

    private object[] itemsField;

    private string[] textField;

    private p_selectColumn columnField;

    private p_selectPage pageField;

    public p_select()
    {
        columnField = p_selectColumn.col;
        pageField = p_selectPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(p_selectColumn.col)]
    public p_selectColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(p_selectPage.none)]
    public p_selectPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }
}



[Serializable()]

public enum p_selectColumn
{


    col,


    full,
}



[Serializable()]

public enum p_selectPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum diag_list2Type
{


    dot,


    dash,
}



[Serializable()]

public enum diag_list1Type
{


    bull,


    dot,


    dash,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class diagtxt
{

    private object[] itemsField;

    private string[] textField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class diagtxt_sub
{

    private object[] itemsField;

    private string[] textField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class result
{

    private object[] itemsField;

    private object[] items1Field;

    private footnote[] footnoteField;


    [XmlElement("diag_list1", typeof(diag_list1), Order = 0)]
    [XmlElement("resulttxt", typeof(resulttxt), Order = 0)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlElement("diag_list1", typeof(diag_list1), Order = 1)]
    [XmlElement("p", typeof(Paragraphs), Order = 1)]
    [XmlElement("p_sub", typeof(p_sub), Order = 1)]
    public object[] Items1
    {
        get
        {
            return items1Field;
        }
        set
        {
            items1Field = value;
        }
    }


    [XmlElement("footnote", Order = 2)]
    public footnote[] footnote
    {
        get
        {
            return footnoteField;
        }
        set
        {
            footnoteField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class resulttxt
{

    private object[] itemsField;

    private string[] textField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class tbl_fig
{

    private object[] itemsField;

    private tbl_figPublish_em publish_emField;

    private tbl_figPublish_pm publish_pmField;

    private tbl_figPublish_fullpm publish_fullpmField;

    public tbl_fig()
    {
        publish_emField = tbl_figPublish_em.yes;
        publish_pmField = tbl_figPublish_pm.yes;
        publish_fullpmField = tbl_figPublish_fullpm.yes;
    }


    [XmlElement("audio", typeof(audio))]
    [XmlElement("image", typeof(image))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("video", typeof(video))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tbl_figPublish_em.yes)]
    public tbl_figPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tbl_figPublish_pm.yes)]
    public tbl_figPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tbl_figPublish_fullpm.yes)]
    public tbl_figPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum tbl_figPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum tbl_figPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum tbl_figPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class tbl_list1
{

    private tbl_list1_item[] tbl_list1_itemField;

    private tbl_list1Type typeField;

    public tbl_list1()
    {
        typeField = tbl_list1Type.bull;
    }


    [XmlElement("tbl_list1_item")]
    public tbl_list1_item[] tbl_list1_item
    {
        get
        {
            return tbl_list1_itemField;
        }
        set
        {
            tbl_list1_itemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tbl_list1Type.bull)]
    public tbl_list1Type type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class tbl_list1_item
{

    private itemtxt itemtxtField;

    private object[] itemsField;


    [XmlElement(Order = 0)]
    public itemtxt itemtxt
    {
        get
        {
            return itemtxtField;
        }
        set
        {
            itemtxtField = value;
        }
    }


    [XmlElement("footnote", typeof(footnote), Order = 1)]
    [XmlElement("itemtxt", typeof(itemtxt), Order = 1)]
    [XmlElement("itemtxt_sub", typeof(itemtxt_sub), Order = 1)]
    [XmlElement("p_select", typeof(p_select), Order = 1)]
    [XmlElement("tbl_list2", typeof(tbl_list2), Order = 1)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class tbl_list2
{

    private tbl_list2_item[] tbl_list2_itemField;

    private tbl_list2Type typeField;

    public tbl_list2()
    {
        typeField = tbl_list2Type.dot;
    }


    [XmlElement("tbl_list2_item")]
    public tbl_list2_item[] tbl_list2_item
    {
        get
        {
            return tbl_list2_itemField;
        }
        set
        {
            tbl_list2_itemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tbl_list2Type.dot)]
    public tbl_list2Type type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class tbl_list2_item
{

    private itemtxt itemtxtField;

    private object[] itemsField;


    [XmlElement(Order = 0)]
    public itemtxt itemtxt
    {
        get
        {
            return itemtxtField;
        }
        set
        {
            itemtxtField = value;
        }
    }


    [XmlElement("footnote", typeof(footnote), Order = 1)]
    [XmlElement("itemtxt", typeof(itemtxt), Order = 1)]
    [XmlElement("itemtxt_sub", typeof(itemtxt_sub), Order = 1)]
    [XmlElement("p_select", typeof(p_select), Order = 1)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }
}



[Serializable()]

public enum tbl_list2Type
{


    dot,


    dash,
}



[Serializable()]

public enum tbl_list1Type
{


    bull,


    dot,


    dash,
}



[Serializable()]

public enum entryAlign
{


    left,


    right,


    center,


    justify,
}



[Serializable()]

public enum entryValign
{


    top,


    middle,


    bottom,
}



[Serializable()]

public enum entryFontwidth
{


    normal,


    [XmlEnum("90")]
    Item90,


    [XmlEnum("80")]
    Item80,


    [XmlEnum("70")]
    Item70,


    [XmlEnum("60")]
    Item60,
}



[Serializable()]

public enum entryPadding_top
{


    [XmlEnum("0")]
    Item0,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("10")]
    Item10,


    [XmlEnum("12")]
    Item12,
}



[Serializable()]

public enum entryPadding_bottom
{


    [XmlEnum("0")]
    Item0,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("10")]
    Item10,


    [XmlEnum("12")]
    Item12,
}



[Serializable()]

public enum entryPadding_left
{


    [XmlEnum("0")]
    Item0,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("10")]
    Item10,


    [XmlEnum("12")]
    Item12,
}



[Serializable()]

public enum entryPadding_right
{


    [XmlEnum("0")]
    Item0,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("10")]
    Item10,


    [XmlEnum("12")]
    Item12,
}



[Serializable()]

public enum entryBackgroundcolor
{


    colorA,


    colorB,


    colorC,
}



[Serializable()]

public enum rowValign
{


    top,


    middle,


    bottom,
}



[Serializable()]

public enum theadValign
{


    top,


    middle,


    bottom,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class tbody
{

    private row[] rowField;

    private tbodyValign valignField;

    private bool valignFieldSpecified;


    [XmlElement("row")]
    public row[] row
    {
        get
        {
            return rowField;
        }
        set
        {
            rowField = value;
        }
    }


    [XmlAttribute()]
    public tbodyValign valign
    {
        get
        {
            return valignField;
        }
        set
        {
            valignField = value;
        }
    }


    [XmlIgnore()]
    public bool valignSpecified
    {
        get
        {
            return valignFieldSpecified;
        }
        set
        {
            valignFieldSpecified = value;
        }
    }
}



[Serializable()]

public enum tbodyValign
{


    top,


    middle,


    bottom,
}



[Serializable()]

public enum tableFrame
{


    top,


    bottom,


    topbot,


    all,


    sides,


    none,
}



[Serializable()]

public enum tableFontsize
{


    [XmlEnum("9.5")]
    Item95,


    [XmlEnum("8.5")]
    Item85,
}



[Serializable()]

public enum tableColumn
{


    col,


    full,
}



[Serializable()]

public enum tablePage
{


    page,


    col,


    none,
}



[Serializable()]

public enum calloutgroupType
{


    number,


    illust,
}



[Serializable()]

public enum calloutgroupStartnumber
{


    [XmlEnum("1")]
    Item1,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("3")]
    Item3,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("5")]
    Item5,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("7")]
    Item7,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("9")]
    Item9,


    [XmlEnum("10")]
    Item10,
}



[Serializable()]

public enum calloutgroupTitletype
{


    triangle,


    square,
}



[Serializable()]

public enum att_figPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum att_figPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum att_figPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class att_list1
{

    private att_list1_item[] att_list1_itemField;

    private att_list1Type typeField;

    private att_list1Column columnField;

    private string ominfoField;

    public att_list1()
    {
        typeField = att_list1Type.bull;
        columnField = att_list1Column.col;
    }


    [XmlElement("att_list1_item")]
    public att_list1_item[] att_list1_item
    {
        get
        {
            return att_list1_itemField;
        }
        set
        {
            att_list1_itemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(att_list1Type.bull)]
    public att_list1Type type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(att_list1Column.col)]
    public att_list1Column column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class att_list1_item
{

    private att_fig att_figField;

    private itemtxt itemtxtField;

    private object[] itemsField;

    private string ominfoField;


    [XmlElement(Order = 0)]
    public att_fig att_fig
    {
        get
        {
            return att_figField;
        }
        set
        {
            att_figField = value;
        }
    }


    [XmlElement(Order = 1)]
    public itemtxt itemtxt
    {
        get
        {
            return itemtxtField;
        }
        set
        {
            itemtxtField = value;
        }
    }


    [XmlElement("att_fig", typeof(att_fig), Order = 2)]
    [XmlElement("att_list2", typeof(att_list2), Order = 2)]
    [XmlElement("footnote", typeof(footnote), Order = 2)]
    [XmlElement("itemtxt", typeof(itemtxt), Order = 2)]
    [XmlElement("itemtxt_sub", typeof(itemtxt_sub), Order = 2)]
    [XmlElement("p_select", typeof(p_select), Order = 2)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class att_list2
{

    private att_list2_item[] att_list2_itemField;

    private att_list2Type typeField;

    private string ominfoField;

    public att_list2()
    {
        typeField = att_list2Type.dot;
    }


    [XmlElement("att_list2_item")]
    public att_list2_item[] att_list2_item
    {
        get
        {
            return att_list2_itemField;
        }
        set
        {
            att_list2_itemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(att_list2Type.dot)]
    public att_list2Type type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class att_list2_item
{

    private itemtxt itemtxtField;

    private object[] itemsField;

    private string ominfoField;


    [XmlElement(Order = 0)]
    public itemtxt itemtxt
    {
        get
        {
            return itemtxtField;
        }
        set
        {
            itemtxtField = value;
        }
    }


    [XmlElement("footnote", typeof(footnote), Order = 1)]
    [XmlElement("itemtxt", typeof(itemtxt), Order = 1)]
    [XmlElement("itemtxt_sub", typeof(itemtxt_sub), Order = 1)]
    [XmlElement("p_select", typeof(p_select), Order = 1)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]

public enum att_list2Type
{


    dot,


    dash,
}



[Serializable()]

public enum att_list1Type
{


    bull,


    dot,


    dash,
}



[Serializable()]

public enum att_list1Column
{


    col,


    full,
}



[Serializable()]

public enum attention_paraPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum attention_paraPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum attention_paraPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum attentionType
{


    warning,


    notice,
}



[Serializable()]

public enum attentionColumn
{


    col,


    full,
}



[Serializable()]

public enum attentionPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum attentionPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum attentionPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum attentionPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class fig
{

    private object[] itemsField;

    private Paragraphs pField;

    private object[] items1Field;

    private figColumn columnField;

    private figPage pageField;

    private string ominfoField;

    private figPublish_em publish_emField;

    private figPublish_pm publish_pmField;

    private figPublish_fullpm publish_fullpmField;

    public fig()
    {
        columnField = figColumn.col;
        pageField = figPage.none;
        publish_emField = figPublish_em.yes;
        publish_pmField = figPublish_pm.yes;
        publish_fullpmField = figPublish_fullpm.yes;
    }


    [XmlElement("audio", typeof(audio))]
    [XmlElement("image", typeof(image))]
    [XmlElement("video", typeof(video))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    public Paragraphs p
    {
        get
        {
            return pField;
        }
        set
        {
            pField = value;
        }
    }


    [XmlElement("callout", typeof(callout))]
    [XmlElement("calloutgroup", typeof(calloutgroup))]
    public object[] Items1
    {
        get
        {
            return items1Field;
        }
        set
        {
            items1Field = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(figColumn.col)]
    public figColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(figPage.none)]
    public figPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(figPublish_em.yes)]
    public figPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(figPublish_pm.yes)]
    public figPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(figPublish_fullpm.yes)]
    public figPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class callout
{

    private object[] itemsField;

    private footnote footnoteField;

    private calloutType typeField;

    private calloutStartnumber startnumberField;

    public callout()
    {
        typeField = calloutType.illust;
        startnumberField = calloutStartnumber.Item1;
    }


    [XmlElement("calloutitem", typeof(calloutitem))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    public footnote footnote
    {
        get
        {
            return footnoteField;
        }
        set
        {
            footnoteField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(calloutType.illust)]
    public calloutType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(calloutStartnumber.Item1)]
    public calloutStartnumber startnumber
    {
        get
        {
            return startnumberField;
        }
        set
        {
            startnumberField = value;
        }
    }
}



[Serializable()]

public enum calloutType
{


    number,


    illust,
}



[Serializable()]

public enum calloutStartnumber
{


    [XmlEnum("1")]
    Item1,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("3")]
    Item3,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("5")]
    Item5,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("7")]
    Item7,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("9")]
    Item9,


    [XmlEnum("10")]
    Item10,
}



[Serializable()]

public enum figColumn
{


    col,


    full,
}



[Serializable()]

public enum figPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum figPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum figPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum figPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class list1
{

    private list1_item[] list1_itemField;

    private list1Type typeField;

    private list1Column columnField;

    private string ominfoField;

    public list1()
    {
        typeField = list1Type.bull;
        columnField = list1Column.col;
    }


    [XmlElement("list1_item")]
    public list1_item[] list1_item
    {
        get
        {
            return list1_itemField;
        }
        set
        {
            list1_itemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(list1Type.bull)]
    public list1Type type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(list1Column.col)]
    public list1Column column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class list1_item
{

    private fig figField;

    private itemtxt itemtxtField;

    private object[] itemsField;

    private string ominfoField;


    [XmlElement(Order = 0)]
    public fig fig
    {
        get
        {
            return figField;
        }
        set
        {
            figField = value;
        }
    }


    [XmlElement(Order = 1)]
    public itemtxt itemtxt
    {
        get
        {
            return itemtxtField;
        }
        set
        {
            itemtxtField = value;
        }
    }


    [XmlElement("attention", typeof(Attention), Order = 2)]
    [XmlElement("fig", typeof(fig), Order = 2)]
    [XmlElement("footnote", typeof(footnote), Order = 2)]
    [XmlElement("itemtxt", typeof(itemtxt), Order = 2)]
    [XmlElement("itemtxt_sub", typeof(itemtxt_sub), Order = 2)]
    [XmlElement("list2", typeof(list2), Order = 2)]
    [XmlElement("note", typeof(note), Order = 2)]
    [XmlElement("p_select", typeof(p_select), Order = 2)]
    [XmlElement("para", typeof(Para), Order = 2)]
    [XmlElement("table", typeof(table), Order = 2)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class list2
{

    private list2_item[] list2_itemField;

    private list2Type typeField;

    private string ominfoField;

    public list2()
    {
        typeField = list2Type.dot;
    }


    [XmlElement("list2_item")]
    public list2_item[] list2_item
    {
        get
        {
            return list2_itemField;
        }
        set
        {
            list2_itemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(list2Type.dot)]
    public list2Type type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class list2_item
{

    private itemtxt itemtxtField;

    private object[] itemsField;

    private string ominfoField;


    [XmlElement(Order = 0)]
    public itemtxt itemtxt
    {
        get
        {
            return itemtxtField;
        }
        set
        {
            itemtxtField = value;
        }
    }


    [XmlElement("attention", typeof(Attention), Order = 1)]
    [XmlElement("fig", typeof(fig), Order = 1)]
    [XmlElement("footnote", typeof(footnote), Order = 1)]
    [XmlElement("itemtxt", typeof(itemtxt), Order = 1)]
    [XmlElement("itemtxt_sub", typeof(itemtxt_sub), Order = 1)]
    [XmlElement("note", typeof(note), Order = 1)]
    [XmlElement("p_select", typeof(p_select), Order = 1)]
    [XmlElement("para", typeof(Para), Order = 1)]
    [XmlElement("table", typeof(table), Order = 1)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class note
{

    private note_body[] note_bodyField;

    private string idField;

    private noteColumn columnField;

    private notePage pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private notePublish_em publish_emField;

    private notePublish_pm publish_pmField;

    private notePublish_fullpm publish_fullpmField;

    public note()
    {
        columnField = noteColumn.col;
        pageField = notePage.none;
        publish_emField = notePublish_em.yes;
        publish_pmField = notePublish_pm.yes;
        publish_fullpmField = notePublish_fullpm.yes;
    }


    [XmlElement("note_body")]
    public note_body[] note_body
    {
        get
        {
            return note_bodyField;
        }
        set
        {
            note_bodyField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(noteColumn.col)]
    public noteColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(notePage.none)]
    public notePage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(notePublish_em.yes)]
    public notePublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(notePublish_pm.yes)]
    public notePublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(notePublish_fullpm.yes)]
    public notePublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class note_body
{

    private note_para[] note_paraField;

    private string ominfoField;


    [XmlElement("note_para")]
    public note_para[] note_para
    {
        get
        {
            return note_paraField;
        }
        set
        {
            note_paraField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class note_para
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string categoryField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private note_paraPublish_em publish_emField;

    private note_paraPublish_pm publish_pmField;

    private note_paraPublish_fullpm publish_fullpmField;

    public note_para()
    {
        publish_emField = note_paraPublish_em.yes;
        publish_pmField = note_paraPublish_pm.yes;
        publish_fullpmField = note_paraPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("att_fig", typeof(att_fig))]
    [XmlElement("att_list1", typeof(att_list1))]
    [XmlElement("att_step", typeof(att_step))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string category
    {
        get
        {
            return categoryField;
        }
        set
        {
            categoryField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(note_paraPublish_em.yes)]
    public note_paraPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(note_paraPublish_pm.yes)]
    public note_paraPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(note_paraPublish_fullpm.yes)]
    public note_paraPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class att_step
{

    private att_stepitem[] att_stepitemField;

    private att_stepStartnumber startnumberField;

    private string ominfoField;

    public att_step()
    {
        startnumberField = att_stepStartnumber.Item1;
    }


    [XmlElement("att_stepitem")]
    public att_stepitem[] att_stepitem
    {
        get
        {
            return att_stepitemField;
        }
        set
        {
            att_stepitemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(att_stepStartnumber.Item1)]
    public att_stepStartnumber startnumber
    {
        get
        {
            return startnumberField;
        }
        set
        {
            startnumberField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class att_stepitem
{

    private steptxt steptxtField;

    private object[] itemsField;

    private string ominfoField;


    public steptxt steptxt
    {
        get
        {
            return steptxtField;
        }
        set
        {
            steptxtField = value;
        }
    }


    [XmlElement("att_fig", typeof(att_fig))]
    [XmlElement("att_list1", typeof(att_list1))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("steptxt_sub", typeof(steptxt_sub))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class steptxt
{

    private object[] itemsField;

    private string[] textField;

    private steptxtNum numField;

    private string numberField;

    private steptxtPage pageField;

    private string ominfoField;

    public steptxt()
    {
        numField = steptxtNum.num;
        pageField = steptxtPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(steptxtNum.num)]
    public steptxtNum num
    {
        get
        {
            return numField;
        }
        set
        {
            numField = value;
        }
    }


    [XmlAttribute()]
    public string number
    {
        get
        {
            return numberField;
        }
        set
        {
            numberField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(steptxtPage.none)]
    public steptxtPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]

public enum steptxtNum
{


    num,


    none,
}



[Serializable()]

public enum steptxtPage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class Para
{

    private ParaTable[] paratableField;

    private paraColumn columnField;

    private paraPage pageField;

    public Para()
    {
        columnField = paraColumn.col;
        pageField = paraPage.none;
    }


    [XmlElement("paratable")]
    public ParaTable[] paratable
    {
        get
        {
            return paratableField;
        }
        set
        {
            paratableField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(paraColumn.col)]
    public paraColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(paraPage.none)]
    public paraPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class ParaTable
{

    private ParaTableBody[] paratablebodyField;

    private string tabletypeField;

    private string widthField;


    [XmlElement("paratablebody")]
    public ParaTableBody[] paratablebody
    {
        get
        {
            return paratablebodyField;
        }
        set
        {
            paratablebodyField = value;
        }
    }


    [XmlAttribute()]
    public string tabletype
    {
        get
        {
            return tabletypeField;
        }
        set
        {
            tabletypeField = value;
        }
    }


    [XmlAttribute()]
    public string width
    {
        get
        {
            return widthField;
        }
        set
        {
            widthField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class ParaTableBody
{

    private ParaTableRow[] paratablerowField;


    [XmlElement("paratablerow")]
    public ParaTableRow[] paratablerow
    {
        get
        {
            return paratablerowField;
        }
        set
        {
            paratablerowField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class ParaTableRow
{

    private ParaTableCell[] paratablecellField;


    [XmlElement("paratablecell")]
    public ParaTableCell[] paratablecell
    {
        get
        {
            return paratablecellField;
        }
        set
        {
            paratablecellField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class ParaTableCell
{

    private paratitle paratitleField;

    private object[] itemsField;


    public paratitle paratitle
    {
        get
        {
            return paratitleField;
        }
        set
        {
            paratitleField = value;
        }
    }


    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("para_fig", typeof(para_fig))]
    [XmlElement("para_list", typeof(para_list))]
    [XmlElement("paratabletxt", typeof(ParaTableText))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class paratitle
{

    private object[] itemsField;

    private string[] textField;

    private string ominfoField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class para_fig
{

    private object[] itemsField;

    private Paragraphs pField;

    private object[] items1Field;

    private string ominfoField;

    private para_figPublish_em publish_emField;

    private para_figPublish_pm publish_pmField;

    private para_figPublish_fullpm publish_fullpmField;

    public para_fig()
    {
        publish_emField = para_figPublish_em.yes;
        publish_pmField = para_figPublish_pm.yes;
        publish_fullpmField = para_figPublish_fullpm.yes;
    }


    [XmlElement("audio", typeof(audio))]
    [XmlElement("image", typeof(image))]
    [XmlElement("video", typeof(video))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    public Paragraphs p
    {
        get
        {
            return pField;
        }
        set
        {
            pField = value;
        }
    }


    [XmlElement("calloutgroup", typeof(calloutgroup))]
    [XmlElement("para_callout", typeof(para_callout))]
    public object[] Items1
    {
        get
        {
            return items1Field;
        }
        set
        {
            items1Field = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(para_figPublish_em.yes)]
    public para_figPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(para_figPublish_pm.yes)]
    public para_figPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(para_figPublish_fullpm.yes)]
    public para_figPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class para_callout
{

    private calloutitem[] calloutitemField;

    private footnote footnoteField;

    private para_calloutType typeField;

    private para_calloutStartnumber startnumberField;

    public para_callout()
    {
        typeField = para_calloutType.illust;
        startnumberField = para_calloutStartnumber.Item1;
    }


    [XmlElement("calloutitem")]
    public calloutitem[] calloutitem
    {
        get
        {
            return calloutitemField;
        }
        set
        {
            calloutitemField = value;
        }
    }


    public footnote footnote
    {
        get
        {
            return footnoteField;
        }
        set
        {
            footnoteField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(para_calloutType.illust)]
    public para_calloutType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(para_calloutStartnumber.Item1)]
    public para_calloutStartnumber startnumber
    {
        get
        {
            return startnumberField;
        }
        set
        {
            startnumberField = value;
        }
    }
}



[Serializable()]

public enum para_calloutType
{


    number,


    illust,
}



[Serializable()]

public enum para_calloutStartnumber
{


    [XmlEnum("1")]
    Item1,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("3")]
    Item3,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("5")]
    Item5,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("7")]
    Item7,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("9")]
    Item9,


    [XmlEnum("10")]
    Item10,
}



[Serializable()]

public enum para_figPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum para_figPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum para_figPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class para_list
{

    private para_list_item[] para_list_itemField;

    private para_listType typeField;

    private string ominfoField;

    public para_list()
    {
        typeField = para_listType.bull;
    }


    [XmlElement("para_list_item")]
    public para_list_item[] para_list_item
    {
        get
        {
            return para_list_itemField;
        }
        set
        {
            para_list_itemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(para_listType.bull)]
    public para_listType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class para_list_item
{

    private para_fig para_figField;

    private itemtxt itemtxtField;

    private object[] itemsField;

    private string ominfoField;


    [XmlElement(Order = 0)]
    public para_fig para_fig
    {
        get
        {
            return para_figField;
        }
        set
        {
            para_figField = value;
        }
    }


    [XmlElement(Order = 1)]
    public itemtxt itemtxt
    {
        get
        {
            return itemtxtField;
        }
        set
        {
            itemtxtField = value;
        }
    }


    [XmlElement("footnote", typeof(footnote), Order = 2)]
    [XmlElement("itemtxt", typeof(itemtxt), Order = 2)]
    [XmlElement("itemtxt_sub", typeof(itemtxt_sub), Order = 2)]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]

public enum para_listType
{


    bull,


    dot,


    dash,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class ParaTableText
{

    private object[] itemsField;

    private string[] textField;

    private paratabletxtType typeField;

    private string ominfoField;

    public ParaTableText()
    {
        typeField = paratabletxtType.typeA;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(paratabletxtType.typeA)]
    public paratabletxtType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]

public enum paratabletxtType
{


    typeA,


    typeB,
}



[Serializable()]

public enum paraColumn
{


    col,


    full,
}



[Serializable()]

public enum paraPage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class steptxt_sub
{

    private object[] itemsField;

    private string[] textField;

    private steptxt_subPage pageField;

    private string ominfoField;

    public steptxt_sub()
    {
        pageField = steptxt_subPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(steptxt_subPage.none)]
    public steptxt_subPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]

public enum steptxt_subPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum att_stepStartnumber
{


    [XmlEnum("1")]
    Item1,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("3")]
    Item3,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("5")]
    Item5,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("7")]
    Item7,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("9")]
    Item9,


    [XmlEnum("10")]
    Item10,
}



[Serializable()]

public enum note_paraPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum note_paraPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum note_paraPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum noteColumn
{


    col,


    full,
}



[Serializable()]

public enum notePage
{


    page,


    col,


    none,
}



[Serializable()]

public enum notePublish_em
{


    yes,


    no,
}



[Serializable()]

public enum notePublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum notePublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum list2Type
{


    dot,


    dash,
}



[Serializable()]

public enum list1Type
{


    bull,


    dot,


    dash,
}



[Serializable()]

public enum list1Column
{


    col,


    full,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class paragroup
{

    private Title titleField;

    private object[] itemsField;

    private string ominfoField;


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paraselect", typeof(paraselect))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class paraselect
{

    private paraselectitem[] paraselectitemField;

    private string ominfoField;


    [XmlElement("paraselectitem")]
    public paraselectitem[] paraselectitem
    {
        get
        {
            return paraselectitemField;
        }
        set
        {
            paraselectitemField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class paraselectitem
{

    private Title titleField;

    private object[] itemsField;

    private string ominfoField;


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class Step
{

    private StepItem[] stepitemField;

    private stepColumn columnField;

    private stepStartnumber startnumberField;

    private string ominfoField;

    public Step()
    {
        columnField = stepColumn.col;
        startnumberField = stepStartnumber.Item1;
    }


    [XmlElement("stepitem")]
    public StepItem[] StepItem
    {
        get
        {
            return stepitemField;
        }
        set
        {
            stepitemField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(stepColumn.col)]
    public stepColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(stepStartnumber.Item1)]
    public stepStartnumber startnumber
    {
        get
        {
            return startnumberField;
        }
        set
        {
            startnumberField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class StepItem
{

    private steptxt steptxtField;

    private object[] itemsField;

    private stepitemColumn columnField;

    private string ominfoField;

    public StepItem()
    {
        columnField = stepitemColumn.col;
    }


    public steptxt steptxt
    {
        get
        {
            return steptxtField;
        }
        set
        {
            steptxtField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("steptxt_sub", typeof(steptxt_sub))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(stepitemColumn.col)]
    public stepitemColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }
}



[Serializable()]

public enum stepitemColumn
{


    col,


    full,
}



[Serializable()]

public enum stepColumn
{


    col,


    full,
}



[Serializable()]

public enum stepStartnumber
{


    [XmlEnum("1")]
    Item1,


    [XmlEnum("2")]
    Item2,


    [XmlEnum("3")]
    Item3,


    [XmlEnum("4")]
    Item4,


    [XmlEnum("5")]
    Item5,


    [XmlEnum("6")]
    Item6,


    [XmlEnum("7")]
    Item7,


    [XmlEnum("8")]
    Item8,


    [XmlEnum("9")]
    Item9,


    [XmlEnum("10")]
    Item10,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class quickref
{

    private quickreftable[] quickreftableField;

    private string idField;

    private quickrefColumn columnField;

    private quickrefPage pageField;

    private string versionField;

    private string dateField;

    private quickrefPublish_em publish_emField;

    private quickrefPublish_pm publish_pmField;

    private quickrefPublish_fullpm publish_fullpmField;

    public quickref()
    {
        columnField = quickrefColumn.col;
        pageField = quickrefPage.none;
        publish_emField = quickrefPublish_em.yes;
        publish_pmField = quickrefPublish_pm.yes;
        publish_fullpmField = quickrefPublish_fullpm.yes;
    }


    [XmlElement("quickreftable")]
    public quickreftable[] quickreftable
    {
        get
        {
            return quickreftableField;
        }
        set
        {
            quickreftableField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(quickrefColumn.col)]
    public quickrefColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(quickrefPage.none)]
    public quickrefPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(quickrefPublish_em.yes)]
    public quickrefPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(quickrefPublish_pm.yes)]
    public quickrefPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(quickrefPublish_fullpm.yes)]
    public quickrefPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class quickreftable
{

    private quickreftablebody[] quickreftablebodyField;

    private string tabletypeField;

    private string widthField;


    [XmlElement("quickreftablebody")]
    public quickreftablebody[] quickreftablebody
    {
        get
        {
            return quickreftablebodyField;
        }
        set
        {
            quickreftablebodyField = value;
        }
    }


    [XmlAttribute()]
    public string tabletype
    {
        get
        {
            return tabletypeField;
        }
        set
        {
            tabletypeField = value;
        }
    }


    [XmlAttribute()]
    public string width
    {
        get
        {
            return widthField;
        }
        set
        {
            widthField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class quickreftablebody
{

    private quickreftablerow[] quickreftablerowField;


    [XmlElement("quickreftablerow")]
    public quickreftablerow[] quickreftablerow
    {
        get
        {
            return quickreftablerowField;
        }
        set
        {
            quickreftablerowField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class quickreftablerow
{

    private quickreftablecell[] quickreftablecellField;


    [XmlElement("quickreftablecell")]
    public quickreftablecell[] quickreftablecell
    {
        get
        {
            return quickreftablecellField;
        }
        set
        {
            quickreftablecellField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class quickreftablecell
{

    private object[] itemsField;

    private string bordertopField;

    private string borderbottomField;

    private string borderleftField;

    private string borderrightField;

    private quickreftablecellBackgroundcolor backgroundcolorField;

    private bool backgroundcolorFieldSpecified;


    [XmlElement("quickrefcomment", typeof(quickrefcomment))]
    [XmlElement("quickrefkeyword", typeof(quickrefkeyword))]
    [XmlElement("quickreflist", typeof(quickreflist))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute("border-top", DataType = "NMTOKEN")]
    public string bordertop
    {
        get
        {
            return bordertopField;
        }
        set
        {
            bordertopField = value;
        }
    }


    [XmlAttribute("border-bottom", DataType = "NMTOKEN")]
    public string borderbottom
    {
        get
        {
            return borderbottomField;
        }
        set
        {
            borderbottomField = value;
        }
    }


    [XmlAttribute("border-left", DataType = "NMTOKEN")]
    public string borderleft
    {
        get
        {
            return borderleftField;
        }
        set
        {
            borderleftField = value;
        }
    }


    [XmlAttribute("border-right", DataType = "NMTOKEN")]
    public string borderright
    {
        get
        {
            return borderrightField;
        }
        set
        {
            borderrightField = value;
        }
    }


    [XmlAttribute()]
    public quickreftablecellBackgroundcolor backgroundcolor
    {
        get
        {
            return backgroundcolorField;
        }
        set
        {
            backgroundcolorField = value;
        }
    }


    [XmlIgnore()]
    public bool backgroundcolorSpecified
    {
        get
        {
            return backgroundcolorFieldSpecified;
        }
        set
        {
            backgroundcolorFieldSpecified = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class quickrefcomment
{

    private object[] itemsField;

    private string[] textField;

    private quickrefcommentType typeField;

    private bool typeFieldSpecified;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    public quickrefcommentType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }


    [XmlIgnore()]
    public bool typeSpecified
    {
        get
        {
            return typeFieldSpecified;
        }
        set
        {
            typeFieldSpecified = value;
        }
    }
}



[Serializable()]

public enum quickrefcommentType
{


    typeA,


    typeB,


    typeC,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class quickrefkeyword
{

    private string keywordField;


    [XmlAttribute()]
    public string keyword
    {
        get
        {
            return keywordField;
        }
        set
        {
            keywordField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class quickreflist
{

    private object[] itemsField;

    private string[] textField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}



[Serializable()]

public enum quickreftablecellBackgroundcolor
{


    colorA,


    colorB,


    colorC,
}



[Serializable()]

public enum quickrefColumn
{


    col,


    full,
}



[Serializable()]

public enum quickrefPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum quickrefPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum quickrefPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum quickrefPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum bodyPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum bodyPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum bodyPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum appendixColumn
{


    col,


    full,
}



[Serializable()]

public enum appendixPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum appendixPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum appendixPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class Chapter
{

    private Title titleField;

    private subtitle subtitleField;

    private chapcontents chapcontentsField;

    private object[] itemsField;

    private string idField;

    private string chapnumField;

    private chapterChaptype chaptypeField;

    private string versionField;

    private string dateField;

    private chapterPublish_em publish_emField;

    private chapterPublish_pm publish_pmField;

    private chapterPublish_fullpm publish_fullpmField;

    public Chapter()
    {
        publish_emField = chapterPublish_em.yes;
        publish_pmField = chapterPublish_pm.yes;
        publish_fullpmField = chapterPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    public subtitle subtitle
    {
        get
        {
            return subtitleField;
        }
        set
        {
            subtitleField = value;
        }
    }


    public chapcontents chapcontents
    {
        get
        {
            return chapcontentsField;
        }
        set
        {
            chapcontentsField = value;
        }
    }


    [XmlElement("body", typeof(body))]
    [XmlElement("section", typeof(Section))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string chapnum
    {
        get
        {
            return chapnumField;
        }
        set
        {
            chapnumField = value;
        }
    }


    [XmlAttribute()]
    public chapterChaptype chaptype
    {
        get
        {
            return chaptypeField;
        }
        set
        {
            chaptypeField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(chapterPublish_em.yes)]
    public chapterPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(chapterPublish_pm.yes)]
    public chapterPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(chapterPublish_fullpm.yes)]
    public chapterPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subtitle
{

    private object[] itemsField;

    private string[] textField;


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexmarker", typeof(indexmarker))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    [XmlElement("xref", typeof(xref))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class chapcontents
{

    private toclevel1[] toclevel1Field;

    private chapcontentsType typeField;

    public chapcontents()
    {
        typeField = chapcontentsType.right;
    }


    [XmlElement("toclevel1")]
    public toclevel1[] toclevel1
    {
        get
        {
            return toclevel1Field;
        }
        set
        {
            toclevel1Field = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(chapcontentsType.right)]
    public chapcontentsType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class toclevel1
{

    private tocleveltxt tocleveltxtField;

    private toclevel2[] toclevel2Field;

    private string labelField;


    public tocleveltxt tocleveltxt
    {
        get
        {
            return tocleveltxtField;
        }
        set
        {
            tocleveltxtField = value;
        }
    }


    [XmlElement("toclevel2")]
    public toclevel2[] toclevel2
    {
        get
        {
            return toclevel2Field;
        }
        set
        {
            toclevel2Field = value;
        }
    }


    [XmlAttribute()]
    public string label
    {
        get
        {
            return labelField;
        }
        set
        {
            labelField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class tocleveltxt
{

    private object[] itemsField;

    private string[] textField;

    private tocleveltxtPage pageField;

    public tocleveltxt()
    {
        pageField = tocleveltxtPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("keyword", typeof(keyword))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("toclevelref", typeof(toclevelref))]
    [XmlElement("u", typeof(u))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(tocleveltxtPage.none)]
    public tocleveltxtPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class keyword
{

    private string keyword1Field;


    [XmlAttribute("keyword")]
    public string keyword1
    {
        get
        {
            return keyword1Field;
        }
        set
        {
            keyword1Field = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class toclevelref
{

    private string refidField;

    private string idrefField;

    private string srcfileField;


    [XmlAttribute(DataType = "IDREF")]
    public string refid
    {
        get
        {
            return refidField;
        }
        set
        {
            refidField = value;
        }
    }


    [XmlAttribute()]
    public string idref
    {
        get
        {
            return idrefField;
        }
        set
        {
            idrefField = value;
        }
    }


    [XmlAttribute()]
    public string srcfile
    {
        get
        {
            return srcfileField;
        }
        set
        {
            srcfileField = value;
        }
    }
}



[Serializable()]

public enum tocleveltxtPage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class toclevel2
{

    private tocleveltxt tocleveltxtField;

    private string labelField;

    private string keywordField;


    public tocleveltxt tocleveltxt
    {
        get
        {
            return tocleveltxtField;
        }
        set
        {
            tocleveltxtField = value;
        }
    }


    [XmlAttribute()]
    public string label
    {
        get
        {
            return labelField;
        }
        set
        {
            labelField = value;
        }
    }


    [XmlAttribute()]
    public string keyword
    {
        get
        {
            return keywordField;
        }
        set
        {
            keywordField = value;
        }
    }
}



[Serializable()]

public enum chapcontentsType
{


    left,


    right,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class Section
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string secnumField;

    private string versionField;

    private string dateField;

    private sectionPublish_em publish_emField;

    private sectionPublish_pm publish_pmField;

    private sectionPublish_fullpm publish_fullpmField;

    public Section()
    {
        publish_emField = sectionPublish_em.yes;
        publish_pmField = sectionPublish_pm.yes;
        publish_fullpmField = sectionPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("body", typeof(body))]
    [XmlElement("subsection_attention", typeof(Subsection))]
    [XmlElement("subsection_introduction", typeof(subsection_introduction))]
    [XmlElement("subsection_law", typeof(subsection_law))]
    [XmlElement("subsection_maintenance", typeof(subsection_maintenance))]
    [XmlElement("subsection_operation", typeof(subsection_operation))]
    [XmlElement("subsection_specification", typeof(subsection_specification))]
    [XmlElement("subsection_supplement", typeof(subsection_supplement))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string secnum
    {
        get
        {
            return secnumField;
        }
        set
        {
            secnumField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(sectionPublish_em.yes)]
    public sectionPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(sectionPublish_pm.yes)]
    public sectionPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(sectionPublish_fullpm.yes)]
    public sectionPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}


[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
public partial class Subsection
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subsection_attentionColumn columnField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subsection_attentionPublish_em publish_emField;

    private subsection_attentionPublish_pm publish_pmField;

    private subsection_attentionPublish_fullpm publish_fullpmField;

    public Subsection()
    {
        columnField = subsection_attentionColumn.col;
        publish_emField = subsection_attentionPublish_em.yes;
        publish_pmField = subsection_attentionPublish_pm.yes;
        publish_fullpmField = subsection_attentionPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("body", typeof(body))]
    [XmlElement("note", typeof(note))]
    [XmlElement("overview", typeof(Overview))]
    [XmlElement("quickref", typeof(quickref))]
    [XmlElement("topic", typeof(Topic))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_attentionColumn.col)]
    public subsection_attentionColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_attentionPublish_em.yes)]
    public subsection_attentionPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_attentionPublish_pm.yes)]
    public subsection_attentionPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_attentionPublish_fullpm.yes)]
    public subsection_attentionPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class Overview
{

    private object[] itemsField;

    private string idField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private overviewPublish_em publish_emField;

    private overviewPublish_pm publish_pmField;

    private overviewPublish_fullpm publish_fullpmField;

    public Overview()
    {
        publish_emField = overviewPublish_em.yes;
        publish_pmField = overviewPublish_pm.yes;
        publish_fullpmField = overviewPublish_fullpm.yes;
    }


    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paraselect", typeof(paraselect))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(overviewPublish_em.yes)]
    public overviewPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(overviewPublish_pm.yes)]
    public overviewPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(overviewPublish_fullpm.yes)]
    public overviewPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum overviewPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum overviewPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum overviewPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class Topic
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private topicColumn columnField;

    private topicPage pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private topicPublish_em publish_emField;

    private topicPublish_pm publish_pmField;

    private topicPublish_fullpm publish_fullpmField;

    public Topic()
    {
        columnField = topicColumn.col;
        pageField = topicPage.none;
        publish_emField = topicPublish_em.yes;
        publish_pmField = topicPublish_pm.yes;
        publish_fullpmField = topicPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("note", typeof(note))]
    [XmlElement("om_body", typeof(OmBody))]
    [XmlElement("subtopiclv1", typeof(subtopiclv1))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topicColumn.col)]
    public topicColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topicPage.none)]
    public topicPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topicPublish_em.yes)]
    public topicPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topicPublish_pm.yes)]
    public topicPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topicPublish_fullpm.yes)]
    public topicPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class OmBody
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private om_bodyPublish_em publish_emField;

    private om_bodyPublish_pm publish_pmField;

    private om_bodyPublish_fullpm publish_fullpmField;

    public OmBody()
    {
        publish_emField = om_bodyPublish_em.yes;
        publish_pmField = om_bodyPublish_pm.yes;
        publish_fullpmField = om_bodyPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paragroup", typeof(paragroup))]
    [XmlElement("paraselect", typeof(paraselect))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(om_bodyPublish_em.yes)]
    public om_bodyPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(om_bodyPublish_pm.yes)]
    public om_bodyPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(om_bodyPublish_fullpm.yes)]
    public om_bodyPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum om_bodyPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum om_bodyPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum om_bodyPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subtopiclv1
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subtopiclv1Column columnField;

    private subtopiclv1Page pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subtopiclv1Publish_em publish_emField;

    private subtopiclv1Publish_pm publish_pmField;

    private subtopiclv1Publish_fullpm publish_fullpmField;

    public subtopiclv1()
    {
        columnField = subtopiclv1Column.col;
        pageField = subtopiclv1Page.none;
        publish_emField = subtopiclv1Publish_em.yes;
        publish_pmField = subtopiclv1Publish_pm.yes;
        publish_fullpmField = subtopiclv1Publish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("note", typeof(note))]
    [XmlElement("om_body", typeof(OmBody))]
    [XmlElement("subtopiclv2", typeof(subtopiclv2))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1Column.col)]
    public subtopiclv1Column column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1Page.none)]
    public subtopiclv1Page page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1Publish_em.yes)]
    public subtopiclv1Publish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1Publish_pm.yes)]
    public subtopiclv1Publish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1Publish_fullpm.yes)]
    public subtopiclv1Publish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subtopiclv2
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subtopiclv2Column columnField;

    private subtopiclv2Page pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subtopiclv2Publish_em publish_emField;

    private subtopiclv2Publish_pm publish_pmField;

    private subtopiclv2Publish_fullpm publish_fullpmField;

    public subtopiclv2()
    {
        columnField = subtopiclv2Column.col;
        pageField = subtopiclv2Page.none;
        publish_emField = subtopiclv2Publish_em.yes;
        publish_pmField = subtopiclv2Publish_pm.yes;
        publish_fullpmField = subtopiclv2Publish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("note", typeof(note))]
    [XmlElement("om_body", typeof(OmBody))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2Column.col)]
    public subtopiclv2Column column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2Page.none)]
    public subtopiclv2Page page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2Publish_em.yes)]
    public subtopiclv2Publish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2Publish_pm.yes)]
    public subtopiclv2Publish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2Publish_fullpm.yes)]
    public subtopiclv2Publish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum subtopiclv2Column
{


    col,


    full,
}



[Serializable()]

public enum subtopiclv2Page
{


    page,


    col,


    none,
}



[Serializable()]

public enum subtopiclv2Publish_em
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv2Publish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv2Publish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv1Column
{


    col,


    full,
}



[Serializable()]

public enum subtopiclv1Page
{


    page,


    col,


    none,
}



[Serializable()]

public enum subtopiclv1Publish_em
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv1Publish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv1Publish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum topicColumn
{


    col,


    full,
}



[Serializable()]

public enum topicPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum topicPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum topicPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum topicPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum subsection_attentionColumn
{


    col,


    full,
}



[Serializable()]

public enum subsection_attentionPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subsection_attentionPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subsection_attentionPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subsection_introduction
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subsection_introductionColumn columnField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subsection_introductionPublish_em publish_emField;

    private subsection_introductionPublish_pm publish_pmField;

    private subsection_introductionPublish_fullpm publish_fullpmField;

    public subsection_introduction()
    {
        columnField = subsection_introductionColumn.col;
        publish_emField = subsection_introductionPublish_em.yes;
        publish_pmField = subsection_introductionPublish_pm.yes;
        publish_fullpmField = subsection_introductionPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("body", typeof(body))]
    [XmlElement("note", typeof(note))]
    [XmlElement("overview", typeof(Overview))]
    [XmlElement("quickref", typeof(quickref))]
    [XmlElement("topic", typeof(Topic))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_introductionColumn.col)]
    public subsection_introductionColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_introductionPublish_em.yes)]
    public subsection_introductionPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_introductionPublish_pm.yes)]
    public subsection_introductionPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_introductionPublish_fullpm.yes)]
    public subsection_introductionPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum subsection_introductionColumn
{


    col,


    full,
}



[Serializable()]

public enum subsection_introductionPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subsection_introductionPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subsection_introductionPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subsection_law
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subsection_lawColumn columnField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subsection_lawPublish_em publish_emField;

    private subsection_lawPublish_pm publish_pmField;

    private subsection_lawPublish_fullpm publish_fullpmField;

    public subsection_law()
    {
        columnField = subsection_lawColumn.col;
        publish_emField = subsection_lawPublish_em.yes;
        publish_pmField = subsection_lawPublish_pm.yes;
        publish_fullpmField = subsection_lawPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("body", typeof(body))]
    [XmlElement("note", typeof(note))]
    [XmlElement("overview", typeof(Overview))]
    [XmlElement("quickref", typeof(quickref))]
    [XmlElement("topic", typeof(Topic))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_lawColumn.col)]
    public subsection_lawColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_lawPublish_em.yes)]
    public subsection_lawPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_lawPublish_pm.yes)]
    public subsection_lawPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_lawPublish_fullpm.yes)]
    public subsection_lawPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum subsection_lawColumn
{


    col,


    full,
}



[Serializable()]

public enum subsection_lawPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subsection_lawPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subsection_lawPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subsection_maintenance
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subsection_maintenanceColumn columnField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subsection_maintenancePublish_em publish_emField;

    private subsection_maintenancePublish_pm publish_pmField;

    private subsection_maintenancePublish_fullpm publish_fullpmField;

    public subsection_maintenance()
    {
        columnField = subsection_maintenanceColumn.col;
        publish_emField = subsection_maintenancePublish_em.yes;
        publish_pmField = subsection_maintenancePublish_pm.yes;
        publish_fullpmField = subsection_maintenancePublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("body", typeof(body))]
    [XmlElement("note", typeof(note))]
    [XmlElement("overview", typeof(Overview))]
    [XmlElement("quickref", typeof(quickref))]
    [XmlElement("topic", typeof(Topic))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_maintenanceColumn.col)]
    public subsection_maintenanceColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_maintenancePublish_em.yes)]
    public subsection_maintenancePublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_maintenancePublish_pm.yes)]
    public subsection_maintenancePublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_maintenancePublish_fullpm.yes)]
    public subsection_maintenancePublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum subsection_maintenanceColumn
{


    col,


    full,
}



[Serializable()]

public enum subsection_maintenancePublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subsection_maintenancePublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subsection_maintenancePublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subsection_operation
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subsection_operationColumn columnField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subsection_operationPublish_em publish_emField;

    private subsection_operationPublish_pm publish_pmField;

    private subsection_operationPublish_fullpm publish_fullpmField;

    public subsection_operation()
    {
        columnField = subsection_operationColumn.col;
        publish_emField = subsection_operationPublish_em.yes;
        publish_pmField = subsection_operationPublish_pm.yes;
        publish_fullpmField = subsection_operationPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("note", typeof(note))]
    [XmlElement("overview", typeof(Overview))]
    [XmlElement("quickref", typeof(quickref))]
    [XmlElement("topic_function_advanced", typeof(topic_function_advanced))]
    [XmlElement("topic_function_basic", typeof(topic_function_basic))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_operationColumn.col)]
    public subsection_operationColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_operationPublish_em.yes)]
    public subsection_operationPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_operationPublish_pm.yes)]
    public subsection_operationPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_operationPublish_fullpm.yes)]
    public subsection_operationPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class topic_function_advanced
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private topic_function_advancedColumn columnField;

    private topic_function_advancedPage pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private topic_function_advancedPublish_em publish_emField;

    private topic_function_advancedPublish_pm publish_pmField;

    private topic_function_advancedPublish_fullpm publish_fullpmField;

    public topic_function_advanced()
    {
        columnField = topic_function_advancedColumn.col;
        pageField = topic_function_advancedPage.none;
        publish_emField = topic_function_advancedPublish_em.yes;
        publish_pmField = topic_function_advancedPublish_pm.yes;
        publish_fullpmField = topic_function_advancedPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("advanced_description", typeof(advanced_description))]
    [XmlElement("advanced_operation", typeof(advanced_operation))]
    [XmlElement("alert_attention", typeof(alert_attention))]
    [XmlElement("attention", typeof(Attention))]
    [XmlElement("automatic_control", typeof(automatic_control))]
    [XmlElement("basic_description", typeof(basic_description))]
    [XmlElement("basic_operation", typeof(basic_operation))]
    [XmlElement("main_explanation", typeof(main_explanation))]
    [XmlElement("note", typeof(note))]
    [XmlElement("subtopiclv1_function_advanced", typeof(subtopiclv1_function_advanced))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topic_function_advancedColumn.col)]
    public topic_function_advancedColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topic_function_advancedPage.none)]
    public topic_function_advancedPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topic_function_advancedPublish_em.yes)]
    public topic_function_advancedPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topic_function_advancedPublish_pm.yes)]
    public topic_function_advancedPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topic_function_advancedPublish_fullpm.yes)]
    public topic_function_advancedPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class advanced_description
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private advanced_descriptionPublish_em publish_emField;

    private advanced_descriptionPublish_pm publish_pmField;

    private advanced_descriptionPublish_fullpm publish_fullpmField;

    public advanced_description()
    {
        publish_emField = advanced_descriptionPublish_em.yes;
        publish_pmField = advanced_descriptionPublish_pm.yes;
        publish_fullpmField = advanced_descriptionPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paraselect", typeof(paraselect))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(advanced_descriptionPublish_em.yes)]
    public advanced_descriptionPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(advanced_descriptionPublish_pm.yes)]
    public advanced_descriptionPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(advanced_descriptionPublish_fullpm.yes)]
    public advanced_descriptionPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum advanced_descriptionPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum advanced_descriptionPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum advanced_descriptionPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class advanced_operation
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private advanced_operationPublish_em publish_emField;

    private advanced_operationPublish_pm publish_pmField;

    private advanced_operationPublish_fullpm publish_fullpmField;

    public advanced_operation()
    {
        publish_emField = advanced_operationPublish_em.yes;
        publish_pmField = advanced_operationPublish_pm.yes;
        publish_fullpmField = advanced_operationPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paraselect", typeof(paraselect))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(advanced_operationPublish_em.yes)]
    public advanced_operationPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(advanced_operationPublish_pm.yes)]
    public advanced_operationPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(advanced_operationPublish_fullpm.yes)]
    public advanced_operationPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum advanced_operationPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum advanced_operationPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum advanced_operationPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class alert_attention
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private alert_attentionPublish_em publish_emField;

    private alert_attentionPublish_pm publish_pmField;

    private alert_attentionPublish_fullpm publish_fullpmField;

    public alert_attention()
    {
        publish_emField = alert_attentionPublish_em.yes;
        publish_pmField = alert_attentionPublish_pm.yes;
        publish_fullpmField = alert_attentionPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paraselect", typeof(paraselect))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(alert_attentionPublish_em.yes)]
    public alert_attentionPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(alert_attentionPublish_pm.yes)]
    public alert_attentionPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(alert_attentionPublish_fullpm.yes)]
    public alert_attentionPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum alert_attentionPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum alert_attentionPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum alert_attentionPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class automatic_control
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private automatic_controlPublish_em publish_emField;

    private automatic_controlPublish_pm publish_pmField;

    private automatic_controlPublish_fullpm publish_fullpmField;

    public automatic_control()
    {
        publish_emField = automatic_controlPublish_em.yes;
        publish_pmField = automatic_controlPublish_pm.yes;
        publish_fullpmField = automatic_controlPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paraselect", typeof(paraselect))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(automatic_controlPublish_em.yes)]
    public automatic_controlPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(automatic_controlPublish_pm.yes)]
    public automatic_controlPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(automatic_controlPublish_fullpm.yes)]
    public automatic_controlPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum automatic_controlPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum automatic_controlPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum automatic_controlPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class basic_description
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private basic_descriptionPublish_em publish_emField;

    private basic_descriptionPublish_pm publish_pmField;

    private basic_descriptionPublish_fullpm publish_fullpmField;

    public basic_description()
    {
        publish_emField = basic_descriptionPublish_em.yes;
        publish_pmField = basic_descriptionPublish_pm.yes;
        publish_fullpmField = basic_descriptionPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paraselect", typeof(paraselect))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(basic_descriptionPublish_em.yes)]
    public basic_descriptionPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(basic_descriptionPublish_pm.yes)]
    public basic_descriptionPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(basic_descriptionPublish_fullpm.yes)]
    public basic_descriptionPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum basic_descriptionPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum basic_descriptionPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum basic_descriptionPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class basic_operation
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private basic_operationPublish_em publish_emField;

    private basic_operationPublish_pm publish_pmField;

    private basic_operationPublish_fullpm publish_fullpmField;

    public basic_operation()
    {
        publish_emField = basic_operationPublish_em.yes;
        publish_pmField = basic_operationPublish_pm.yes;
        publish_fullpmField = basic_operationPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paraselect", typeof(paraselect))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(basic_operationPublish_em.yes)]
    public basic_operationPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(basic_operationPublish_pm.yes)]
    public basic_operationPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(basic_operationPublish_fullpm.yes)]
    public basic_operationPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum basic_operationPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum basic_operationPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum basic_operationPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class main_explanation
{

    private Title titleField;

    private object[] itemsField;

    private string idField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private main_explanationPublish_em publish_emField;

    private main_explanationPublish_pm publish_pmField;

    private main_explanationPublish_fullpm publish_fullpmField;

    public main_explanation()
    {
        publish_emField = main_explanationPublish_em.yes;
        publish_pmField = main_explanationPublish_pm.yes;
        publish_fullpmField = main_explanationPublish_fullpm.yes;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("fig", typeof(fig))]
    [XmlElement("footnote", typeof(footnote))]
    [XmlElement("list1", typeof(list1))]
    [XmlElement("note", typeof(note))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_select", typeof(p_select))]
    [XmlElement("p_sub", typeof(p_sub))]
    [XmlElement("para", typeof(Para))]
    [XmlElement("paraselect", typeof(paraselect))]
    [XmlElement("step", typeof(Step))]
    [XmlElement("table", typeof(table))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(main_explanationPublish_em.yes)]
    public main_explanationPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(main_explanationPublish_pm.yes)]
    public main_explanationPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(main_explanationPublish_fullpm.yes)]
    public main_explanationPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum main_explanationPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum main_explanationPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum main_explanationPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subtopiclv1_function_advanced
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subtopiclv1_function_advancedColumn columnField;

    private subtopiclv1_function_advancedPage pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subtopiclv1_function_advancedPublish_em publish_emField;

    private subtopiclv1_function_advancedPublish_pm publish_pmField;

    private subtopiclv1_function_advancedPublish_fullpm publish_fullpmField;

    public subtopiclv1_function_advanced()
    {
        columnField = subtopiclv1_function_advancedColumn.col;
        pageField = subtopiclv1_function_advancedPage.none;
        publish_emField = subtopiclv1_function_advancedPublish_em.yes;
        publish_pmField = subtopiclv1_function_advancedPublish_pm.yes;
        publish_fullpmField = subtopiclv1_function_advancedPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("advanced_description", typeof(advanced_description))]
    [XmlElement("advanced_operation", typeof(advanced_operation))]
    [XmlElement("alert_attention", typeof(alert_attention))]
    [XmlElement("attention", typeof(Attention))]
    [XmlElement("automatic_control", typeof(automatic_control))]
    [XmlElement("basic_description", typeof(basic_description))]
    [XmlElement("basic_operation", typeof(basic_operation))]
    [XmlElement("main_explanation", typeof(main_explanation))]
    [XmlElement("note", typeof(note))]
    [XmlElement("subtopiclv2_function_advanced", typeof(subtopiclv2_function_advanced))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1_function_advancedColumn.col)]
    public subtopiclv1_function_advancedColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1_function_advancedPage.none)]
    public subtopiclv1_function_advancedPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1_function_advancedPublish_em.yes)]
    public subtopiclv1_function_advancedPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1_function_advancedPublish_pm.yes)]
    public subtopiclv1_function_advancedPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1_function_advancedPublish_fullpm.yes)]
    public subtopiclv1_function_advancedPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subtopiclv2_function_advanced
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subtopiclv2_function_advancedColumn columnField;

    private subtopiclv2_function_advancedPage pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subtopiclv2_function_advancedPublish_em publish_emField;

    private subtopiclv2_function_advancedPublish_pm publish_pmField;

    private subtopiclv2_function_advancedPublish_fullpm publish_fullpmField;

    public subtopiclv2_function_advanced()
    {
        columnField = subtopiclv2_function_advancedColumn.col;
        pageField = subtopiclv2_function_advancedPage.none;
        publish_emField = subtopiclv2_function_advancedPublish_em.yes;
        publish_pmField = subtopiclv2_function_advancedPublish_pm.yes;
        publish_fullpmField = subtopiclv2_function_advancedPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("advanced_description", typeof(advanced_description))]
    [XmlElement("advanced_operation", typeof(advanced_operation))]
    [XmlElement("alert_attention", typeof(alert_attention))]
    [XmlElement("attention", typeof(Attention))]
    [XmlElement("automatic_control", typeof(automatic_control))]
    [XmlElement("basic_description", typeof(basic_description))]
    [XmlElement("basic_operation", typeof(basic_operation))]
    [XmlElement("main_explanation", typeof(main_explanation))]
    [XmlElement("note", typeof(note))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2_function_advancedColumn.col)]
    public subtopiclv2_function_advancedColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2_function_advancedPage.none)]
    public subtopiclv2_function_advancedPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2_function_advancedPublish_em.yes)]
    public subtopiclv2_function_advancedPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2_function_advancedPublish_pm.yes)]
    public subtopiclv2_function_advancedPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2_function_advancedPublish_fullpm.yes)]
    public subtopiclv2_function_advancedPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum subtopiclv2_function_advancedColumn
{


    col,


    full,
}



[Serializable()]

public enum subtopiclv2_function_advancedPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum subtopiclv2_function_advancedPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv2_function_advancedPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv2_function_advancedPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv1_function_advancedColumn
{


    col,


    full,
}



[Serializable()]

public enum subtopiclv1_function_advancedPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum subtopiclv1_function_advancedPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv1_function_advancedPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv1_function_advancedPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum topic_function_advancedColumn
{


    col,


    full,
}



[Serializable()]

public enum topic_function_advancedPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum topic_function_advancedPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum topic_function_advancedPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum topic_function_advancedPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class topic_function_basic
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private topic_function_basicColumn columnField;

    private topic_function_basicPage pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private topic_function_basicPublish_em publish_emField;

    private topic_function_basicPublish_pm publish_pmField;

    private topic_function_basicPublish_fullpm publish_fullpmField;

    public topic_function_basic()
    {
        columnField = topic_function_basicColumn.col;
        pageField = topic_function_basicPage.none;
        publish_emField = topic_function_basicPublish_em.yes;
        publish_pmField = topic_function_basicPublish_pm.yes;
        publish_fullpmField = topic_function_basicPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("advanced_description", typeof(advanced_description))]
    [XmlElement("advanced_operation", typeof(advanced_operation))]
    [XmlElement("attention", typeof(Attention))]
    [XmlElement("basic_description", typeof(basic_description))]
    [XmlElement("basic_operation", typeof(basic_operation))]
    [XmlElement("note", typeof(note))]
    [XmlElement("subtopiclv1_function_basic", typeof(subtopiclv1_function_basic))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topic_function_basicColumn.col)]
    public topic_function_basicColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topic_function_basicPage.none)]
    public topic_function_basicPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topic_function_basicPublish_em.yes)]
    public topic_function_basicPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topic_function_basicPublish_pm.yes)]
    public topic_function_basicPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(topic_function_basicPublish_fullpm.yes)]
    public topic_function_basicPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subtopiclv1_function_basic
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subtopiclv1_function_basicColumn columnField;

    private subtopiclv1_function_basicPage pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subtopiclv1_function_basicPublish_em publish_emField;

    private subtopiclv1_function_basicPublish_pm publish_pmField;

    private subtopiclv1_function_basicPublish_fullpm publish_fullpmField;

    public subtopiclv1_function_basic()
    {
        columnField = subtopiclv1_function_basicColumn.col;
        pageField = subtopiclv1_function_basicPage.none;
        publish_emField = subtopiclv1_function_basicPublish_em.yes;
        publish_pmField = subtopiclv1_function_basicPublish_pm.yes;
        publish_fullpmField = subtopiclv1_function_basicPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("advanced_description", typeof(advanced_description))]
    [XmlElement("advanced_operation", typeof(advanced_operation))]
    [XmlElement("attention", typeof(Attention))]
    [XmlElement("basic_description", typeof(basic_description))]
    [XmlElement("basic_operation", typeof(basic_operation))]
    [XmlElement("note", typeof(note))]
    [XmlElement("subtopiclv2_function_basic", typeof(subtopiclv2_function_basic))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1_function_basicColumn.col)]
    public subtopiclv1_function_basicColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1_function_basicPage.none)]
    public subtopiclv1_function_basicPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1_function_basicPublish_em.yes)]
    public subtopiclv1_function_basicPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1_function_basicPublish_pm.yes)]
    public subtopiclv1_function_basicPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv1_function_basicPublish_fullpm.yes)]
    public subtopiclv1_function_basicPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subtopiclv2_function_basic
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subtopiclv2_function_basicColumn columnField;

    private subtopiclv2_function_basicPage pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subtopiclv2_function_basicPublish_em publish_emField;

    private subtopiclv2_function_basicPublish_pm publish_pmField;

    private subtopiclv2_function_basicPublish_fullpm publish_fullpmField;

    public subtopiclv2_function_basic()
    {
        columnField = subtopiclv2_function_basicColumn.col;
        pageField = subtopiclv2_function_basicPage.none;
        publish_emField = subtopiclv2_function_basicPublish_em.yes;
        publish_pmField = subtopiclv2_function_basicPublish_pm.yes;
        publish_fullpmField = subtopiclv2_function_basicPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("advanced_description", typeof(advanced_description))]
    [XmlElement("advanced_operation", typeof(advanced_operation))]
    [XmlElement("attention", typeof(Attention))]
    [XmlElement("basic_description", typeof(basic_description))]
    [XmlElement("basic_operation", typeof(basic_operation))]
    [XmlElement("note", typeof(note))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2_function_basicColumn.col)]
    public subtopiclv2_function_basicColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2_function_basicPage.none)]
    public subtopiclv2_function_basicPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2_function_basicPublish_em.yes)]
    public subtopiclv2_function_basicPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2_function_basicPublish_pm.yes)]
    public subtopiclv2_function_basicPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subtopiclv2_function_basicPublish_fullpm.yes)]
    public subtopiclv2_function_basicPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum subtopiclv2_function_basicColumn
{


    col,


    full,
}



[Serializable()]

public enum subtopiclv2_function_basicPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum subtopiclv2_function_basicPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv2_function_basicPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv2_function_basicPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv1_function_basicColumn
{


    col,


    full,
}



[Serializable()]

public enum subtopiclv1_function_basicPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum subtopiclv1_function_basicPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv1_function_basicPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subtopiclv1_function_basicPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum topic_function_basicColumn
{


    col,


    full,
}



[Serializable()]

public enum topic_function_basicPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum topic_function_basicPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum topic_function_basicPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum topic_function_basicPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum subsection_operationColumn
{


    col,


    full,
}



[Serializable()]

public enum subsection_operationPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subsection_operationPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subsection_operationPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subsection_specification
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subsection_specificationColumn columnField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subsection_specificationPublish_em publish_emField;

    private subsection_specificationPublish_pm publish_pmField;

    private subsection_specificationPublish_fullpm publish_fullpmField;

    public subsection_specification()
    {
        columnField = subsection_specificationColumn.col;
        publish_emField = subsection_specificationPublish_em.yes;
        publish_pmField = subsection_specificationPublish_pm.yes;
        publish_fullpmField = subsection_specificationPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("body", typeof(body))]
    [XmlElement("note", typeof(note))]
    [XmlElement("overview", typeof(Overview))]
    [XmlElement("quickref", typeof(quickref))]
    [XmlElement("topic", typeof(Topic))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_specificationColumn.col)]
    public subsection_specificationColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_specificationPublish_em.yes)]
    public subsection_specificationPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_specificationPublish_pm.yes)]
    public subsection_specificationPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_specificationPublish_fullpm.yes)]
    public subsection_specificationPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum subsection_specificationColumn
{


    col,


    full,
}



[Serializable()]

public enum subsection_specificationPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subsection_specificationPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subsection_specificationPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class subsection_supplement
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private subsection_supplementColumn columnField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private subsection_supplementPublish_em publish_emField;

    private subsection_supplementPublish_pm publish_pmField;

    private subsection_supplementPublish_fullpm publish_fullpmField;

    public subsection_supplement()
    {
        columnField = subsection_supplementColumn.col;
        publish_emField = subsection_supplementPublish_em.yes;
        publish_pmField = subsection_supplementPublish_pm.yes;
        publish_fullpmField = subsection_supplementPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("attention", typeof(Attention))]
    [XmlElement("body", typeof(body))]
    [XmlElement("note", typeof(note))]
    [XmlElement("overview", typeof(Overview))]
    [XmlElement("quickref", typeof(quickref))]
    [XmlElement("topic", typeof(Topic))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_supplementColumn.col)]
    public subsection_supplementColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_supplementPublish_em.yes)]
    public subsection_supplementPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_supplementPublish_pm.yes)]
    public subsection_supplementPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(subsection_supplementPublish_fullpm.yes)]
    public subsection_supplementPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum subsection_supplementColumn
{


    col,


    full,
}



[Serializable()]

public enum subsection_supplementPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum subsection_supplementPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum subsection_supplementPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum sectionPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum sectionPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum sectionPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum chapterChaptype
{


    intro,


    anzen,


    quick,


    chapter,


    trouble,


    other,
}



[Serializable()]

public enum chapterPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum chapterPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum chapterPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class illusttoc
{

    private Title titleField;

    private subtitle[] subtitleField;

    private body[] bodyField;

    private string idField;

    private string versionField;

    private string dateField;


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("subtitle")]
    public subtitle[] subtitle
    {
        get
        {
            return subtitleField;
        }
        set
        {
            subtitleField = value;
        }
    }


    [XmlElement("body")]
    public body[] body
    {
        get
        {
            return bodyField;
        }
        set
        {
            bodyField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class index
{

    private Title titleField;

    private chapcontents chapcontentsField;

    private Section[] sectionField;

    private keywordindex[] keywordindexField;

    private string idField;


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    public chapcontents chapcontents
    {
        get
        {
            return chapcontentsField;
        }
        set
        {
            chapcontentsField = value;
        }
    }


    [XmlElement("section")]
    public Section[] section
    {
        get
        {
            return sectionField;
        }
        set
        {
            sectionField = value;
        }
    }


    [XmlElement("keywordindex")]
    public keywordindex[] keywordindex
    {
        get
        {
            return keywordindexField;
        }
        set
        {
            keywordindexField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class keywordindex
{

    private Title titleField;

    private object[] itemsField;

    private keywordindexColumn columnField;

    private string idField;

    private string typeField;

    public keywordindex()
    {
        columnField = keywordindexColumn.col;
    }


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("indexgroup", typeof(indexgroup))]
    [XmlElement("indexlevel1", typeof(indexlevel1))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(keywordindexColumn.col)]
    public keywordindexColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class indexgroup
{

    private grouplabel grouplabelField;

    private string grouptitleField;

    private indexlevel1[] indexlevel1Field;

    private indexgroupType typeField;

    public indexgroup()
    {
        typeField = indexgroupType.index;
    }


    public grouplabel grouplabel
    {
        get
        {
            return grouplabelField;
        }
        set
        {
            grouplabelField = value;
        }
    }


    public string grouptitle
    {
        get
        {
            return grouptitleField;
        }
        set
        {
            grouptitleField = value;
        }
    }


    [XmlElement("indexlevel1")]
    public indexlevel1[] indexlevel1
    {
        get
        {
            return indexlevel1Field;
        }
        set
        {
            indexlevel1Field = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(indexgroupType.index)]
    public indexgroupType type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class grouplabel
{

    private grouplabelPage pageField;

    public grouplabel()
    {
        pageField = grouplabelPage.none;
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(grouplabelPage.none)]
    public grouplabelPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }
}



[Serializable()]

public enum grouplabelPage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class indexlevel1
{

    private indexleveltxt indexleveltxtField;

    private indexlevel2[] indexlevel2Field;

    private string labelField;


    public indexleveltxt indexleveltxt
    {
        get
        {
            return indexleveltxtField;
        }
        set
        {
            indexleveltxtField = value;
        }
    }


    [XmlElement("indexlevel2")]
    public indexlevel2[] indexlevel2
    {
        get
        {
            return indexlevel2Field;
        }
        set
        {
            indexlevel2Field = value;
        }
    }


    [XmlAttribute()]
    public string label
    {
        get
        {
            return labelField;
        }
        set
        {
            labelField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class indexleveltxt
{

    private object[] itemsField;

    private string[] textField;

    private indexleveltxtPage pageField;

    public indexleveltxt()
    {
        pageField = indexleveltxtPage.none;
    }


    [XmlElement("b", typeof(b))]
    [XmlElement("break", typeof(@break))]
    [XmlElement("function", typeof(function))]
    [XmlElement("i", typeof(i))]
    [XmlElement("indexlevelref", typeof(indexlevelref))]
    [XmlElement("option", typeof(option))]
    [XmlElement("sub", typeof(sub))]
    [XmlElement("sup", typeof(sup))]
    [XmlElement("symbol", typeof(symbol))]
    [XmlElement("u", typeof(u))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlText()]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(indexleveltxtPage.none)]
    public indexleveltxtPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class indexlevelref
{

    private string refidField;

    private string idrefField;

    private string srcfileField;


    [XmlAttribute(DataType = "IDREF")]
    public string refid
    {
        get
        {
            return refidField;
        }
        set
        {
            refidField = value;
        }
    }


    [XmlAttribute()]
    public string idref
    {
        get
        {
            return idrefField;
        }
        set
        {
            idrefField = value;
        }
    }


    [XmlAttribute()]
    public string srcfile
    {
        get
        {
            return srcfileField;
        }
        set
        {
            srcfileField = value;
        }
    }
}



[Serializable()]

public enum indexleveltxtPage
{


    page,


    col,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class indexlevel2
{

    private indexleveltxt indexleveltxtField;

    private string labelField;


    public indexleveltxt indexleveltxt
    {
        get
        {
            return indexleveltxtField;
        }
        set
        {
            indexleveltxtField = value;
        }
    }


    [XmlAttribute()]
    public string label
    {
        get
        {
            return labelField;
        }
        set
        {
            labelField = value;
        }
    }
}



[Serializable()]

public enum indexgroupType
{


    index,


    navi_index,
}



[Serializable()]

public enum keywordindexColumn
{


    col,


    full,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class intro
{

    private titlegroup titlegroupField;

    private object[] itemsField;

    private string idField;

    private string numField;

    private introColumn columnField;

    private string versionField;

    private string dateField;

    private introPublish_em publish_emField;

    private introPublish_pm publish_pmField;

    private introPublish_fullpm publish_fullpmField;

    public intro()
    {
        columnField = introColumn.col;
        publish_emField = introPublish_em.yes;
        publish_pmField = introPublish_pm.yes;
        publish_fullpmField = introPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("body", typeof(body))]
    [XmlElement("introsub", typeof(introsub))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    public string num
    {
        get
        {
            return numField;
        }
        set
        {
            numField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(introColumn.col)]
    public introColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(introPublish_em.yes)]
    public introPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(introPublish_pm.yes)]
    public introPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(introPublish_fullpm.yes)]
    public introPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class introsub
{

    private titlegroup titlegroupField;

    private body[] bodyField;

    private string idField;

    private introsubColumn columnField;

    private introsubPage pageField;

    private string versionField;

    private string dateField;

    private string ominfoField;

    private introsubPublish_em publish_emField;

    private introsubPublish_pm publish_pmField;

    private introsubPublish_fullpm publish_fullpmField;

    public introsub()
    {
        columnField = introsubColumn.col;
        pageField = introsubPage.none;
        publish_emField = introsubPublish_em.yes;
        publish_pmField = introsubPublish_pm.yes;
        publish_fullpmField = introsubPublish_fullpm.yes;
    }


    public titlegroup titlegroup
    {
        get
        {
            return titlegroupField;
        }
        set
        {
            titlegroupField = value;
        }
    }


    [XmlElement("body")]
    public body[] body
    {
        get
        {
            return bodyField;
        }
        set
        {
            bodyField = value;
        }
    }


    [XmlAttribute(DataType = "ID")]
    public string id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(introsubColumn.col)]
    public introsubColumn column
    {
        get
        {
            return columnField;
        }
        set
        {
            columnField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(introsubPage.none)]
    public introsubPage page
    {
        get
        {
            return pageField;
        }
        set
        {
            pageField = value;
        }
    }


    [XmlAttribute()]
    public string version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }


    [XmlAttribute()]
    public string date
    {
        get
        {
            return dateField;
        }
        set
        {
            dateField = value;
        }
    }


    [XmlAttribute(DataType = "NMTOKENS")]
    public string ominfo
    {
        get
        {
            return ominfoField;
        }
        set
        {
            ominfoField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(introsubPublish_em.yes)]
    public introsubPublish_em publish_em
    {
        get
        {
            return publish_emField;
        }
        set
        {
            publish_emField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(introsubPublish_pm.yes)]
    public introsubPublish_pm publish_pm
    {
        get
        {
            return publish_pmField;
        }
        set
        {
            publish_pmField = value;
        }
    }


    [XmlAttribute()]
    [System.ComponentModel.DefaultValue(introsubPublish_fullpm.yes)]
    public introsubPublish_fullpm publish_fullpm
    {
        get
        {
            return publish_fullpmField;
        }
        set
        {
            publish_fullpmField = value;
        }
    }
}



[Serializable()]

public enum introsubColumn
{


    col,


    full,
}



[Serializable()]

public enum introsubPage
{


    page,


    col,


    none,
}



[Serializable()]

public enum introsubPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum introsubPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum introsubPublish_fullpm
{


    yes,


    no,
}



[Serializable()]

public enum introColumn
{


    col,


    full,
}



[Serializable()]

public enum introPublish_em
{


    yes,


    no,
}



[Serializable()]

public enum introPublish_pm
{


    yes,


    no,
}



[Serializable()]

public enum introPublish_fullpm
{


    yes,


    no,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class toc
{

    private Title titleField;

    private object[] itemsField;


    public Title title
    {
        get
        {
            return titleField;
        }
        set
        {
            titleField = value;
        }
    }


    [XmlElement("chapgroup", typeof(chapgroup))]
    [XmlElement("introtoc", typeof(introtoc))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class chapgroup
{

    private chaptitletable chaptitletableField;

    private toclevel1[] toclevel1Field;


    public chaptitletable chaptitletable
    {
        get
        {
            return chaptitletableField;
        }
        set
        {
            chaptitletableField = value;
        }
    }


    [XmlElement("toclevel1")]
    public toclevel1[] toclevel1
    {
        get
        {
            return toclevel1Field;
        }
        set
        {
            toclevel1Field = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class chaptitletable
{

    private chaptitletablebody[] chaptitletablebodyField;

    private string tabletypeField;

    private string widthField;


    [XmlElement("chaptitletablebody")]
    public chaptitletablebody[] chaptitletablebody
    {
        get
        {
            return chaptitletablebodyField;
        }
        set
        {
            chaptitletablebodyField = value;
        }
    }


    [XmlAttribute()]
    public string tabletype
    {
        get
        {
            return tabletypeField;
        }
        set
        {
            tabletypeField = value;
        }
    }


    [XmlAttribute()]
    public string width
    {
        get
        {
            return widthField;
        }
        set
        {
            widthField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class chaptitletablebody
{

    private chaptitletablerow[] chaptitletablerowField;


    [XmlElement("chaptitletablerow")]
    public chaptitletablerow[] chaptitletablerow
    {
        get
        {
            return chaptitletablerowField;
        }
        set
        {
            chaptitletablerowField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class chaptitletablerow
{

    private chapnumcell[] chapnumcellField;

    private string[] chaptitlecellField;


    [XmlElement("chapnumcell")]
    public chapnumcell[] chapnumcell
    {
        get
        {
            return chapnumcellField;
        }
        set
        {
            chapnumcellField = value;
        }
    }


    [XmlElement("chaptitlecell")]
    public string[] chaptitlecell
    {
        get
        {
            return chaptitlecellField;
        }
        set
        {
            chaptitlecellField = value;
        }
    }
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class chapnumcell
{

    private chapnumcellNumtype numtypeField;

    private bool numtypeFieldSpecified;

    private string valueField;


    [XmlAttribute()]
    public chapnumcellNumtype numtype
    {
        get
        {
            return numtypeField;
        }
        set
        {
            numtypeField = value;
        }
    }


    [XmlIgnore()]
    public bool numtypeSpecified
    {
        get
        {
            return numtypeFieldSpecified;
        }
        set
        {
            numtypeFieldSpecified = value;
        }
    }


    [XmlText()]
    public string Value
    {
        get
        {
            return valueField;
        }
        set
        {
            valueField = value;
        }
    }
}



[Serializable()]

public enum chapnumcellNumtype
{


    normal,


    none,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class introtoc
{

    private object itemField;

    private string labelField;


    [XmlElement("toclevelref", typeof(toclevelref))]
    [XmlElement("tocleveltxt", typeof(tocleveltxt))]
    public object Item
    {
        get
        {
            return itemField;
        }
        set
        {
            itemField = value;
        }
    }


    [XmlAttribute()]
    public string label
    {
        get
        {
            return labelField;
        }
        set
        {
            labelField = value;
        }
    }
}



[Serializable()]

public enum bookManualtype
{


    vh,


    nv,
}



[Serializable()]

public enum bookLang
{


    ja,


    en,


    es,


    fr,


    de,


    it,


    pt,


    nl,


    sv,


    no,


    da,


    ru,


    fi,


    el,


    pl,


    uk,


    tr,


    hu,


    cs,


    sk,


    ro,


    fm,


    ar,


    zh,


    tw,


    hk,


    ko,


    th,


    ms,


    id,


    vi,


    he,
}



[Serializable()]

public enum bookScale
{


    @new,


    major,


    minor,


    improvement,


    rc,
}



[Serializable()]

public enum bookVehicle_type
{


    conventional,


    hv,


    conventional_hv,


    ev,


    fcv,
}



[Serializable()]

public enum bookBody_type
{


    sedan,


    hb,


    wg,


    truck,


    coupe,


    onebox,
}



[Serializable()]

public enum bookDrive_train
{


    ff,


    fr,
}



[Serializable()]

public enum bookBrand
{


    le,


    to,


    sc,
}



[Serializable()]

public enum bookDestination
{


    jp,


    us,


    mx,


    eu,


    au,


    se,


    me,


    @in,


    la,


    za,


    cn,


    hk,


    tw,


    kr,


    ge,
}



[Serializable()]
[System.Diagnostics.DebuggerStepThrough()]



public partial class diagbody
{

    private object[] itemsField;


    [XmlElement("diag_list1", typeof(diag_list1))]
    [XmlElement("diagtxt", typeof(diagtxt))]
    [XmlElement("diagtxt_sub", typeof(diagtxt_sub))]
    [XmlElement("p", typeof(Paragraphs))]
    [XmlElement("p_sub", typeof(p_sub))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }
}
