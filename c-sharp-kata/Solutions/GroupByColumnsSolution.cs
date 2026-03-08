namespace c_sharp_kata.Solutions;
public class GroupByColumnsSolution()
{
    public static string GroupByCommas(int n)
    {
        // try to iterate through it once when putting commas in
        // might take some math to consistently figure out where each comma is gonna go

        //* Assume: 0 <= n <= 2147483647

        // Base case
        if (n >= 0 && n < 1000) return n.ToString();

        bool isNegative = n < 0;
        string numString = isNegative ? n.ToString().Remove(0,1) : n.ToString();
        int len = numString.length; 
        int count = 0;

        for(let i = len; i >= 0; i--) 
        {
            count++;

            if (count == 4)
            {
                numString = numString.Insert(numString[i] , ",");
                count = 0;
            }
        }

        //* isNegative then add '-' back to the string
        if(isNegative) return numString.Insert(0,"-");

        return numString;
    }
}
