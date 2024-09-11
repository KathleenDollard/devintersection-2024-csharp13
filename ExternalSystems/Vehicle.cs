namespace ExternalSystems;

// should also be sealed to file or assembly, or an exclusive marker
public abstract record class Vehicle
{
    private Vehicle() { }

    public record class Car(int Passengers) : Vehicle { }

    public record class Taxi(int Fares) : Vehicle { }

    public record class Bus(int Capacity, int Riders) : Vehicle { }

    // public record class DeliveryTruck(int GrossWeightClass) { } : Vehicle
}
