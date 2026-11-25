namespace BlazorApp_Flex_Fun;

public class StyleValues
{
    public AlignSelf AlignSelf { get; set; }

    public bool UseFixedWidth { get; set; } = false;
    public int Width { get; set; } = 100;// Random.Shared.Next(30,100);

    public bool UseFixedHeight { get; set; } = false;
    public int? Height { get; set; } = 100;// Random.Shared.Next(30, 100);

    public double FlexGrow { get; set; } = 1;
    public double FlexShrink { get; set; } = 1;
    public int FlexBasis { get; set; } = 100;

    public int? Order { get; set; } = null;
}
