namespace c_sharp_kata.Solutions;

public class DeadFish 
{
  public static int[] Parse(string data)
  {
    Char[] letters = data.ToCharArray();
    List<int> res = [];
    int value = 0;

    foreach (char letter in letters)
    {
      switch (letter)
      {
        case 'i':
          value++;
          break;
        case 'd':
          value--;
          break;
        case 's':
          value *= value;
          break;
        case 'o':
          res.Add(value);
          break;
        default:
          continue;
      }
    }
        
    // iterate through each letter
    // with switch case
    /*
    i: Increment the value
    d: Decrement the value
    s: Square the value
    o: Output(Add) the value to a result array 
    */

    return [..res]; // placeholder return 
  }
}