namespace InterfaceExercise;

public interface IManufacturer : ICompany, IVehicle  
{
    public string Location { get; set; }
}