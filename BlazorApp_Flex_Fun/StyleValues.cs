namespace BlazorApp_Flex_Fun;

public class StyleValues
{
    public AlignSelf AlignSelf { get; set; }
    public int? Width { get; set; } = null;// Random.Shared.Next(30,100);
    public int? Height { get; set; } = null;// Random.Shared.Next(30, 100);

    public double FlexGrow { get; set; } = 1;
    public double FlexShrink { get; set; } = 1;
    public int FlexBasis { get; set; } = 100;

    public int? Order { get; set; } = null;
}
