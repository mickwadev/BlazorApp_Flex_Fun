using BlazorApp_Flex_Fun.Extenstions;
using Microsoft.AspNetCore.Components;
using System.Globalization;
using System.Text;

namespace BlazorApp_Flex_Fun;

public static class FlexHelpers
{
    public static string GetStyle(FlexDirection direction, 
        JustifyContent justifyContent,
        AlignContent alignContent,
        AlignItems alignItems,
        FlexWrap flexWrap,
        int gap, int rowGap)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Display: Flex;");
        sb.Append($"gap: {gap}px;");
        sb.Append($"row-gap: {rowGap}px;");
        sb.Append($"flex-direction: {EnumToCss(direction)};");
        sb.Append($"flex-wrap: {EnumToCss(flexWrap)};");
        sb.Append($"justify-content: {EnumToCss(justifyContent)};");
        sb.Append($"align-content: {EnumToCss(alignContent)};");
        sb.Append($"align-items: {EnumToCss(alignItems)};");
        return sb.ToString();
    }
  
    public static string EnumToCss<T>(T enumName)
    {
        var enu = enumName.ToString();
        StringBuilder sb = new StringBuilder();
        sb.Append(char.ToLower(enu[0]));

        for (int i = 1; i < enu.Length; i++) 
        {
            char c = enu[i];
            sb.Append($"{(char.IsUpper(c)?"-":"")}{char.ToLower(c)}");
        }
        return sb.ToString();
    }

    public static MarkupString StyleFromValues(StyleValues sv)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendHtmlNewLine($"flex-basis: {sv.FlexBasis}");
        sb.AppendHtmlNewLine($"flex-grow: {sv.FlexGrow.ToString(CultureInfo.InvariantCulture)}");
        sb.AppendHtmlNewLine($"flex-shrink: {sv.FlexShrink.ToString(CultureInfo.InvariantCulture)}");
        if (sv.UseFixedWidth)
        {
            sb.AppendHtmlNewLine($"width: {sv.Width}");
        }
        if (sv.UseFixedHeight)
        {
            sb.AppendHtmlNewLine($"height: {sv.Height}");
        }

        sb.Append($"align-self:{sv.AlignSelf}");
        return (MarkupString) sb.ToString();
    }

    public static string CssStyleFromValues(StyleValues sv)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"flex-basis: {sv.FlexBasis}px; ");
        sb.Append($"flex-grow: {sv.FlexGrow.ToString(CultureInfo.InvariantCulture)}; ");
        sb.Append($"flex-shrink: {sv.FlexShrink.ToString(CultureInfo.InvariantCulture)}; ");
        if (sv.UseFixedWidth)
        {
            sb.Append($"width: {sv.Width}px; ");
        }
        if (sv.UseFixedHeight)
        {
            sb.Append($"height: {sv.Height}px; ");
        }
        sb.Append($"align-self:{EnumToCss(sv.AlignSelf)}");
        return sb.ToString();
    }
}
