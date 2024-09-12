namespace PossibleFuture_DiscriminatedUnion.ExternalSystems;

// should also be sealed to file or assembly, or an exclusive marker,
// or otherwise indicate exhaustiveness, which you cannot do today.

/// <summary>
/// One way to implement Discriminated Union style constructs today
/// </summary>
/// <remarks>
/// We might not implement unions, and if we do this may not be
/// how they are designed.
/// </remarks>
public abstract record class Vehicle
{
    private Vehicle() { }

    public record class Car(int Passengers) : Vehicle { }

    public record class Taxi(int Fares) : Vehicle { }

    public record class Bus(int Capacity, int Riders) : Vehicle { }

    // public record class DeliveryTruck(int GrossWeightClass) { } : Vehicle
}

