namespace BlazorApp_Flex_Fun;

public class SquareCssStyleValues
{
    DisplayType DisplayType { get; set; }
    public required string BorderColor { get; set; }
    public int? Width { get; set; } = 42;
    public int? Height { get; set; } = 42;
    public int MarginTop { get; set; }
    public int MarginBottom { get; set; }
    public int MarginLeft { get; set; }
    public int MarginRight { get; set; }
    public int PaddingTop { get; set; }
    public int PaddingBottom { get; set; }
    public int PaddingLeft { get; set; }
    public int PaddingRight { get; set; }
}
