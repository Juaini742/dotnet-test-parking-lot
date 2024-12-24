using System;
using System.Collections.Generic;

class ParkingLot
{
    private int totalSlots;
    private bool[] slots;
    private Dictionary<int, Vehicle> parkedVehicles;

    public ParkingLot(int totalSlots)
    {
        this.totalSlots = totalSlots;
        slots = new bool[totalSlots];
        parkedVehicles = new Dictionary<int, Vehicle>();
    }

    public void ParkVehicle(string registrationNumber, string color, string type)
    {
        for (int i = 0; i < totalSlots; i++)
        {
            if (!slots[i])
            {
                slots[i] = true;
                parkedVehicles[i + 1] = new Vehicle(registrationNumber, color, type);
                Console.WriteLine($"Allocated slot number: {i + 1}");
                return;
            }
        }
        Console.WriteLine("Sorry, parking lot is full");
    }

    public void LeaveSlot(int slotNumber)
    {
        if (slotNumber > 0 && slotNumber <= totalSlots && slots[slotNumber - 1])
        {
            slots[slotNumber - 1] = false;
            parkedVehicles.Remove(slotNumber);
            Console.WriteLine($"Slot number {slotNumber} is free");
        }
        else
        {
            Console.WriteLine("Slot number is invalid or already free");
        }
    }

    public void Status()
    {
        Console.WriteLine("Slot No.\tType\t\tRegistration No\tColour");
        for (int i = 0; i < totalSlots; i++)
        {
            if (slots[i])
            {
                var vehicle = parkedVehicles[i + 1];
                Console.WriteLine($"{i + 1}\t\t{vehicle.Type}\t{vehicle.RegistrationNumber}\t{vehicle.Color}");
            }
        }
    }
}

class Vehicle
{
    public string RegistrationNumber { get; }
    public string Color { get; }
    public string Type { get; }

    public Vehicle(string registrationNumber, string color, string type)
    {
        RegistrationNumber = registrationNumber;
        Color = color;
        Type = type;
    }
}

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the total number of parking slots:");
        int totalSlots = int.Parse(Console.ReadLine());
        ParkingLot parkingLot = new ParkingLot(totalSlots);

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Park Vehicle");
            Console.WriteLine("2. Leave Slot");
            Console.WriteLine("3. Show Status");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Registration Number: ");
                    string regNumber = Console.ReadLine();
                    Console.Write("Enter Color: ");
                    string color = Console.ReadLine();
                    Console.Write("Enter Vehicle Type (e.g., Car, Motorbike): ");
                    string type = Console.ReadLine();
                    parkingLot.ParkVehicle(regNumber, color, type);
                    break;

                case "2":
                    Console.Write("Enter Slot Number to Free: ");
                    int slotNumber;
                    if (int.TryParse(Console.ReadLine(), out slotNumber))
                    {
                        parkingLot.LeaveSlot(slotNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid slot number.");
                    }
                    break;

                case "3":
                    parkingLot.Status();
                    break;

                case "4":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
