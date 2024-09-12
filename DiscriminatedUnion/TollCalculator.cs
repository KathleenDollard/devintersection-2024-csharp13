using PossibleFuture_DiscriminatedUnion.ExternalSystems;

namespace PossibleFuture_DiscriminatedUnion;

/// <summary>
/// Example class of how to use a union today. See Vehicle.cs for caveats.
/// </summary>
public static class TollCalculator // Partial implementation
{
    private const decimal carBase = 2.00m;
    private const decimal taxiBase = 3.50m;
    private const decimal busBase = 5.00m;
    private const decimal deliveryTruckBase = 10.00m;

    public static decimal GetBillAmount(Vehicle vehicle, DateTime timeOfToll, bool inbound)
        => CalculateToll(vehicle);

    private static decimal CalculateToll(Vehicle vehicle)
    {
        return vehicle switch
        {
            null => throw new ArgumentNullException(nameof(vehicle)),
            Vehicle.Car car => CarToll(car),
            Vehicle.Taxi { Fares: var fares} => TaxiToll(fares),
            Vehicle.Bus bus => BusToll(bus),
            // Default would not be needed if exhaustiveness is enforced
            _ => throw new NotImplementedException() 
        };

        static decimal CarToll(Vehicle.Car car)
            => car.Passengers switch
            {
                0 => carBase + 0.5m,
                1 => carBase,
                2 => carBase - 0.5m,
                _ => carBase - 1.00m
            };

        static decimal TaxiToll(int fares)
            => fares switch
            {
                0 => taxiBase + 1.0m,
                1 => taxiBase,
                2 => taxiBase - 0.50m,
                _ => taxiBase - 1.0m,
            };

        static decimal BusToll(Vehicle.Bus bus)
            => bus switch
            {
                { } when (double)bus.Riders / bus.Capacity < 0.50 => busBase + 2.00m,
                { } when (double)bus.Riders / bus.Capacity > 0.90 => busBase - 1.00m,
                _ => busBase
            };

        /*
        static decimal DeliveryTruckToll(Vehicle.DeliveryTruck truck)
           => truck.GrossWeightClass switch
           {
               > 5000 => deliveryTruckBase + 5.00m,
               < 3000 => deliveryTruckBase - 2.00m,
               _ => deliveryTruckBase
           };
        */
    }
}
