namespace MultiForms;

public static class StringExtension
{
    public static List<double>? ToValues(this string str, string separator = "/")
    {
        string[] arr = str.Split(separator);
        List<double> result = new();
        foreach (string ele in arr)
        {
            if (double.TryParse(ele, out double value) == false)
                return null;
            result.Add(value);
        }
        return result;
    }
}