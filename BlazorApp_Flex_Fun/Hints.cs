namespace BlazorApp_Flex_Fun;

public static class Hints
{
    public static List<string> GetHints(string h) =>  HintsDict.ContainsKey(h)? HintsDict[h] : new() {  };

    private static Dictionary<string,List<string>> HintsDict = new() {
        ["justify-content"] = new() {
            "Controls how elements behave in each single row",
            "To see a difrence, there must be free space. So size of elements must be smaller than container size, and sum of flex-grow of children < 1 (in row)"},
        ["align-items"] = new() {
            "Controls how elements behave in each single row in cross axis",
            "If each element in row has same size, it won't have influence",
            "Bahaves in different way if there is 'wrap' or 'no-wrap'.",
            "When 'no-wrap' is selected, it changes allignment in cross axis for whole container, for example stretch will fill whole container",
            "When 'wrap' is selected, it changes allignment for each individual flex line/row, for example stretch will fill line to highest element in line/row"
        },

        ["align-content"] = new()
        { 
            "When 'no-wrap' is selected it does nothing",
            "When 'wrap' is selected, controls how each row is alligned in cross axis"
        }

    };
    
}
