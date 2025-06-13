using System.Globalization;

class Person
{
    public string? Name { get; set; }
    public Address address;
    public Person(string? name, string? city, string? street)
    {
        Name = name ?? "Undefined";
        this.address = new(city, street);
    }
}