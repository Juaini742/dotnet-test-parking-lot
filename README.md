# Parking Lot Management System

This is a simple console-based Parking Lot Management System implemented in C#. The application allows users to:

1. Park a vehicle in an available parking slot.
2. Free up a slot when a vehicle leaves.
3. View the current status of parked vehicles.
4. Exit the application.

## Features

- **Interactive Menu:** The application provides a user-friendly menu to choose operations such as parking a vehicle, freeing up a slot, viewing the status, or exiting the program.
- **Dynamic Slot Allocation:** Automatically finds the next available slot for parking.
- **Status Reporting:** Displays the current parking status with details of each parked vehicle.

## Prerequisites

- .NET SDK installed on your machine.
- A C# compiler (e.g., Visual Studio or Visual Studio Code with the C# extension).

## How to Run

1. Clone or download the code to your local machine.
2. Open the project in your preferred IDE or text editor.
3. Compile and run the `Program.cs` file.
4. Enter the total number of parking slots when prompted.
5. Use the interactive menu to perform operations.

## Usage

When the program runs, you'll see a menu like this:

```
Menu:
1. Park Vehicle
2. Leave Slot
3. Show Status
4. Exit
Choose an option:
```

### Operations

1. **Park Vehicle**
   - Enter the vehicle's registration number, color, and type (e.g., car, motorbike).
   - The program will allocate the next available slot and display the slot number.

2. **Leave Slot**
   - Enter the slot number to free up.
   - The program will mark the slot as free and remove the vehicle from the list.

3. **Show Status**
   - Displays the details of all parked vehicles, including:
     - Slot number
     - Vehicle type
     - Registration number
     - Color

4. **Exit**
   - Ends the program.

## Example Interaction

```
Enter the total number of parking slots:
6

Menu:
1. Park Vehicle
2. Leave Slot
3. Show Status
4. Exit
Choose an option: 1
Enter Registration Number: B-1234-XYZ
Enter Color: White
Enter Vehicle Type (e.g., Car, Motorbike): Car
Allocated slot number: 1

Menu:
1. Park Vehicle
2. Leave Slot
3. Show Status
4. Exit
Choose an option: 3
Slot No.   Type       Registration No   Colour
1          Car        B-1234-XYZ        White

Menu:
1. Park Vehicle
2. Leave Slot
3. Show Status
4. Exit
Choose an option: 4
Exiting program. Goodbye!
```

## Notes

- Ensure that the total number of parking slots is specified at the start.
- Slot numbers are allocated sequentially from 1.
- If the parking lot is full, an appropriate message will be displayed.
- Enter valid slot numbers when freeing up a slot.

## License

This project is for educational and testing purposes and does not come with any license for commercial use.

---

Feel free to modify or expand the application as needed for your test or personal learning!

