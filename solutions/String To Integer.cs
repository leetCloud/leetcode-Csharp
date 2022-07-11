using System.Text;

public class Solution
{
    public int MyAtoi(string str)
    {
        var whiteSpaceIgnore = true;
        var isPlus = true;
        var signStarted = false;
        var digitsStarted = false;
        var result = new StringBuilder();

        foreach (var c in str)
        {
            if (c == ' ')
            {
                if (whiteSpaceIgnore) { continue; }

                break;
            }

            whiteSpaceIgnore = false;

            if (c == '+')
            {
                if (signStarted || digitsStarted) { break; }

                signStarted = true;
                continue;
            }

            if (c == '-')
            {
                if (signStarted || digitsStarted) { break; }

                isPlus = false;
                signStarted = true;
                continue;
            }

            if (!"0123456789".Contains(c)) { break; }

            digitsStarted = true;

            result.Append(c);
        }

        var resultStr = result.ToString();
        if (resultStr == "") { return 0; }

        var res = int.TryParse(resultStr, out var resultInt);
        if (!res) { return isPlus ? int.MaxValue : int.MinValue; }

        return isPlus ? resultInt : -resultInt;
    }
}