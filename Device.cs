
public class Device
{
    public string Name {get; set;}
    public int InsecticideLevel {get; set;}
    public bool IsOnline {get;set;}

    public Device (String name, int insecticideLevel, bool isOnline)
    {
        this.Name=name;
        this.InsecticideLevel= insecticideLevel;
        this.IsOnline= isOnline;
    }
    public void Spray()
    {    if(IsOnline && InsecticideLevel >= 5)
        {
            InsecticideLevel= InsecticideLevel -5;
                        Console.WriteLine("Spraying..");

        }
        else
        {
            Console.WriteLine("Error");
        }
        
    }


}