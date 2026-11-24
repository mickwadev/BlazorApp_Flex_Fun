namespace BlazorApp_Flex_Fun;

public class SquareData(string borderColor)
{
    public int Id { get; set; }
    public SquareCssStyleValues Style { get; set; } = new SquareCssStyleValues() {BorderColor = borderColor };
}
