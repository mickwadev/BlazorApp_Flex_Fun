using System.Text;

namespace BlazorApp_Flex_Fun;

public static class FlexHelpers
{
    public static string GetStyle(FlexDirection direction, JustifyContent justifyContent)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Display: Flex;");
        sb.Append($"flex-direction: {EnumToCss(direction.ToString())};");
        sb.Append($"justify-content: {EnumToCss(justifyContent.ToString())};");
        return sb.ToString();
    }
  
    public static string EnumToCss(string enumName)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(char.ToLower(enumName[0]));

        for (int i = 1; i < enumName.Length; i++) 
        {
            char c = enumName[i];
            sb.Append($"{(char.IsUpper(c)?"-":"")}{char.ToLower(c)}");
        }
        return sb.ToString();
    }
}
