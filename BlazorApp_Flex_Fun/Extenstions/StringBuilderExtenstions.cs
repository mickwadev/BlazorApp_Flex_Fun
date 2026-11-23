using System.Text;

namespace BlazorApp_Flex_Fun.Extenstions;

public static class StringBuilderExtenstions
{
    extension(StringBuilder stringBuilder)
    {
        public void AppendHtmlNewLine(string str)
        { 
            stringBuilder.Append(str+"<br/>");
        }
    }
}
