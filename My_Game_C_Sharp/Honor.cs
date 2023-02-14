public class HonorBD
{
  public int Honor { get; set; }

    public HonorBD(int hohor) 
    {
       this.Honor = hohor;
    }

    public void AddHonor() => Honor += 10;
   
    public void RemoveHonor() => Honor -= 10;
   
    public void ShowHonor() => Console.WriteLine(Honor);
   
}

