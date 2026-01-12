namespace InterfaceExercise;

public class Car: IManufacturer
{
    public bool HasTrunk { get; set; }
    public int NumberOfDoors { get; set; }
    public string NameOfCompany { get; set; }
    public string Logo { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string Location { get; set; }
}