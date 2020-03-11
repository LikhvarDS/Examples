namespace ClassDevelopment
{
  public class Examples1
  {
    public const int Constant = 1;

    private int number;

    public int GetNumber()
    {
      return number;
    }

    public void SetNumber(int number)
    {
      this.number = number;
    }

    private string text;

    public string Text
    {
      get
      {
        return text + number.ToString();
      }
      set
      {
        if (/*валидация*/ true)
          text = value;
      }
    }

    public string Text2 { get; set; }




    private int privateField;

    protected int PropertyForChildren { get; }

    internal int PropertyForAssembly { get; }

    protected internal int PropertyForChildrenAndAssembly { get; set; }

    public int PropertyForEveryone { get; set; }
  }
}