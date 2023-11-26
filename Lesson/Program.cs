using Lesson;

class Program
{
    static void Main()
    {

        passengersDetails passenger1 = new passengersDetails("John", "New York", 17, 1000);
     
        Console.WriteLine("Name: " + passenger1.getName());
        Console.WriteLine("Destination: " + passenger1.getDestination());
        Console.WriteLine("Passenger Age: " + passenger1.getPassengerAge());
        Console.WriteLine("Ticket Price: " + passenger1.getTicketPrice());

        passengersDetails passenger2 = new passengersDetails ("Steve", "Moscow", 20, 1000);

        Console.WriteLine("Name: " + passenger2.getName());
        Console.WriteLine("Destination: " + passenger2.getDestination());
        Console.WriteLine("Passenger Age: " + passenger2.getPassengerAge());
        Console.WriteLine("Ticket Price: " + passenger2.getTicketPrice());
    }
}
