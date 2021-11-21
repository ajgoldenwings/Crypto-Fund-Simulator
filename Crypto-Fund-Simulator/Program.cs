// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crypto Fund Simulator");

var minerCount = 0;
var minerAverageCost = 2000;
var minerAverageProfitabilityPerDay = 5;

int tempTodaysRevenue;

var currentCapital = 100000.0;
var daysPerNextMinerPurchase = 1;

var simulationDays = 1000;

for (var currentDay = 0; currentDay < simulationDays; currentDay++)
{
    // Purchase Computer
    if (currentDay % daysPerNextMinerPurchase == 0)
    {
        minerCount++;
        currentCapital -= minerAverageCost;
    }

    // Calculate Todays Profit
    tempTodaysRevenue = minerCount * minerAverageProfitabilityPerDay;

    // Add Profit to Capital
    currentCapital += tempTodaysRevenue;

    Console.WriteLine($"Day: {currentDay}, Miner Count: {minerCount}, Todays Profit: {tempTodaysRevenue}, Current Capital: {currentCapital}");
}
