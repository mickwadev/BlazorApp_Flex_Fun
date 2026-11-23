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
        FlexWrap flexWrap)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Display: Flex;");
        sb.Append($"flex-direction: {EnumToCss(direction.ToString())};");
        sb.Append($"flex-wrap: {EnumToCss(flexWrap.ToString())};");
        sb.Append($"justify-content: {EnumToCss(justifyContent.ToString())};");
        sb.Append($"align-content: {EnumToCss(alignContent.ToString())};");
        sb.Append($"align-items: {EnumToCss(alignItems.ToString())};");
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

    public static MarkupString StyleFromValues(StyleValues sv)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendHtmlNewLine($"flex-basis: {sv.FlexBasis}");
        sb.AppendHtmlNewLine($"flex-grow: {sv.FlexGrow.ToString(CultureInfo.InvariantCulture)}");
        sb.AppendHtmlNewLine($"flex-shrink: {sv.FlexShrink.ToString(CultureInfo.InvariantCulture)}");
        if (sv.Width is not null)
        {
            sb.AppendHtmlNewLine($"width: {sv.Width}");
        }
        if (sv.Height is not null)
        {
            sb.AppendHtmlNewLine($"height: {sv.Height}");
        }

        return (MarkupString) sb.ToString();
    }

    public static string CssStyleFromValues(StyleValues sv)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"flex-basis: {sv.FlexBasis}px; ");
        sb.Append($"flex-grow: {sv.FlexGrow.ToString(CultureInfo.InvariantCulture)}; ");
        sb.Append($"flex-shrink: {sv.FlexShrink.ToString(CultureInfo.InvariantCulture)}; ");
        if (sv.Width is not null)
        {
            sb.Append($"width: {sv.Width}px; ");
        }
        if (sv.Height is not null)
        {
            sb.Append($"height: {sv.Height}px; ");
        }

        return sb.ToString();
    }
}
