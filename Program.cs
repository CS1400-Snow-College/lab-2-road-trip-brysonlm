// lil question
Console.WriteLine("We are going to map out a road trip for Fall Break.");
Console.WriteLine("I'm going to ask you some specific questions about the trip,");
Console.WriteLine("and then I'll calculate a trip summary from that information.\n");


// All the questions
Console.Write("Where will you be driving? ");
string destination = Console.ReadLine();

Console.Write("Who will be driving? ");
string driver = Console.ReadLine();

Console.Write($"How many miles to get to {destination}? ");
double milesOneWay = double.Parse(Console.ReadLine());

Console.Write($"What average speed (MPH) will {driver} be travelling? ");
double speed = double.Parse(Console.ReadLine());

Console.Write("How many MPG does your car get? ");
double mpg = double.Parse(Console.ReadLine());

Console.Write("How many gallons of gas does your car hold? ");
double tankCapacity = double.Parse(Console.ReadLine());

Console.Write("Excluding the driver, how many riders in the car? ");
int riders = int.Parse(Console.ReadLine());

Console.Write("What unit of currency ($, £, ¥, €) do you use? ");
string currency = Console.ReadLine();

Console.Write($"What is the fuel price per gallon ({currency})? ");
double fuelPrice = double.Parse(Console.ReadLine());


// calculations
double roundTripMiles = milesOneWay * 2;
double totalHours = milesOneWay / speed;
int displayHours = (int)totalHours;
int displayMinutes = (int)((totalHours - displayHours) * 60);

// the fuel stuff
double fuelNeeded = roundTripMiles / mpg;
double rangePerTank = tankCapacity * mpg;
double fuelStops = Math.Ceiling(roundTripMiles / rangePerTank);
double totalFuelCost = fuelNeeded * fuelPrice;

// the people
int totalPeople = riders + 1;
double costPerPerson = totalFuelCost / totalPeople;
double costPerMile = totalFuelCost / roundTripMiles;
double costPerHour = totalFuelCost / (roundTripMiles / speed);

// music calculation
double avgSongLength = 3.5;
int songsNeeded = (int)Math.Ceiling((totalHours * 60) / avgSongLength);

// writing it all out
Console.WriteLine("-----------------------------------------");
Console.WriteLine($"{"Driver:"} {driver}");
Console.WriteLine($"{"Currency:"} {currency}");
Console.WriteLine();
Console.WriteLine($"{"Distance (miles):"} {milesOneWay}");
Console.WriteLine($"{"Average Speed (mph):"} {speed}");
Console.WriteLine($"{"Time Driving:"} {displayHours}H {displayMinutes}M");
Console.WriteLine();
Console.WriteLine($"{"Vehicle Miles per Gallon:"} {mpg}");
Console.WriteLine($"{"Fuel Needed (round trip):"} {fuelNeeded:F2} gallons");
Console.WriteLine($"{"Range per tank:"} {rangePerTank:F2}");
Console.WriteLine($"{"Estimated Fuel Stops:"} {fuelStops}");
Console.WriteLine();
Console.WriteLine($"{"Gas Price per gallon:"} {currency}{fuelPrice:F2}");
Console.WriteLine($"{"Fuel Cost:"} {currency}{totalFuelCost:F2}");
Console.WriteLine($"{"Riders (split):"} {totalPeople}");
Console.WriteLine($"{"Cost per person:"} {currency}{costPerPerson:F2} (+ Snacks)");
Console.WriteLine($"{"Cost per mile:"} {currency}{costPerMile:F2}");
Console.WriteLine($"{"Cost per driving hour:"} {currency}{costPerHour:F2}");
Console.WriteLine();
Console.WriteLine($"{"Average song length (min):"} {avgSongLength}");
Console.WriteLine($"{"Number of songs needed:"} {songsNeeded}");
Console.WriteLine("-----------------------------------------");

Console.ReadKey();