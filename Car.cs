class Car : IVehicle
{
    public double MaxSpeed { get; set; } = 280;

    public double GetSpeed() => MaxSpeed;
}
