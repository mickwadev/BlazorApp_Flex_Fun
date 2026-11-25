namespace BlazorApp_Flex_Fun;

public static class Hints
{
    public static string GetHint(string h) =>  HintsDict.ContainsKey(h)? HintsDict[h] : "Hint not found 🤔";

    private static Dictionary<string, string> HintsDict = new() {
        ["justify-content"] = "Jak zachowują się elementy w 1 rzędzie? Jeśli któryś ma grow to nie będzie widać żadnej różnicy"  
    };
    
}
