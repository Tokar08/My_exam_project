 

public class HonorBD
{
  public int Honor { get; set; }

    public HonorBD(int hohor) 
    {
       this.Honor = hohor;
    }

    public void AddHonor() => Honor += 10;
   
    public void RemoveHonor() => Honor -= 10;

    public bool CheckHonor(int honor)
    {
        if (Honor > honor) 
        {
            Console.WriteLine(":-)");
        }
        else
        {
            Console.WriteLine(":-(");
        }
        return true;
    }
   
    public void ShowHonor() => Console.WriteLine(Honor);
   
}

