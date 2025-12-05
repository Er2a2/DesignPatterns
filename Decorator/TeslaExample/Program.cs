// Client

using TeslaExample;

ITeslaModel3 car = new LongRangeTeslaDecorator(
     new RedPaintTeslaDecorator(
         new BasicTeslaModel3()));

Console.WriteLine($"Description: {car.GetDescription()}");
Console.WriteLine($"Price: {car.GetPrice()}");
Console.WriteLine($"Range: {car.GetRange()}");