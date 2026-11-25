namespace BlazorApp_Flex_Fun.Components;

public class SquareCssStyleValues
{
    public DisplayType DisplayType { get; set; }
    public FloatType FloatType { get; set; } = FloatType.None;
    public required string BorderColor { get; set; }

    public bool UseFixedWidth { get; set; } = true;
    public bool UseFixedHeight { get; set; } = true;
    public int Width { get; set; } = 42;
    public int Height { get; set; } = 42;
    public int MarginTop { get; set; }
    public int MarginBottom { get; set; }
    public int MarginLeft { get; set; }
    public int MarginRight { get; set; }
    public int PaddingTop { get; set; }
    public int PaddingBottom { get; set; }
    public int PaddingLeft { get; set; }
    public int PaddingRight { get; set; }
}
