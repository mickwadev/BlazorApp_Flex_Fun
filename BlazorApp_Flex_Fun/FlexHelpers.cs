using System.Text;

namespace BlazorApp_Flex_Fun;

public static class FlexHelpers
{
    public static string GetStyle(Direction direction)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Display: Flex ;");
        sb.Append($"flex-direction: {Enum2String(direction)}");
        return sb.ToString();
    }

    public static string Enum2String(Direction dir) => dir switch
    {
        Direction.Column => "column",
        Direction.Row => "row",
        Direction.ColumnReverse => "column-reverse",
        Direction.RowReverse => "row-reverse"
    };
}
