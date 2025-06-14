class Bicycle: IVehicle
{
    public double MaxSpeed { get; set; } = 20;

    public double GetSpeed() => MaxSpeed;
}
