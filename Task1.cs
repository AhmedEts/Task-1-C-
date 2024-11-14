namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal pricePerSmallRoom = 25m;
            const decimal pricePerLargeRoom = 35m;
            const decimal taxRate = 0.06m;

            Console.Write("Enter the number of small rooms to be cleaned: ");
            int numSmallRooms = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of large rooms to be cleaned: ");
            int numLargeRooms = int.Parse(Console.ReadLine());

            // Calculate the costs
            decimal cost = (numSmallRooms * pricePerSmallRoom) + (numLargeRooms * pricePerLargeRoom);
            decimal tax = cost * taxRate;
            decimal totalEstimate = cost + tax;

            // Display the estimate
            Console.WriteLine(" Welcome To Laundry ");
            Console.WriteLine("\nEstimate for carpet cleaning service");
            Console.WriteLine($"Number of small rooms: {numSmallRooms}");
            Console.WriteLine($"Number of large rooms: {numLargeRooms}");
            Console.WriteLine($"Price per small room: ${pricePerSmallRoom}");
            Console.WriteLine($"Price per large room: ${pricePerLargeRoom}");
            Console.WriteLine($"Cost: ${cost}");
            Console.WriteLine($"Tax: ${tax} => Cost * {taxRate}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate: ${totalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
