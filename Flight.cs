using System;
class Program
{
	
//const double tax = 0.55;
public static void GetPassenger(params string[] passenger)
{
Console.Write("\nEnter passenger- 'child' or an 'adult' ? : ");
}
public static void GetPassengerClass(params string[] passengerClass)
{
Console.Write("Passenger class\n[economy]\n[business]\n[first]\n\nEnter Class here: ");
}
public static double GetchildGct(double price, double tax)
{
double gct = price * tax;
return gct;
}
public static double GetadultGct(double price, double tax)
{
double gct = price * tax;
return gct;
}
public static double Totalprice(double price, double gct)
{
double totalPrice = price + gct;
return totalPrice;
}
public static double TotalCA(double totalca, double totalprice)
{
totalca = totalca + totalprice;
return totalca;
}
	
static void Main()
{
double gctC, gctA;
string[] passenger = new string[35];
string[] passengerClass = new string[35];
string name;
var countC = 0;
var countA = 0;
gctC = 0;
gctA = 0;
double totalC = 0;
double totalA = 0;
int count = 0;
double totalBtaxC, totalBtaxA;
totalBtaxC = 0;
totalBtaxA = 0;
var totalPrice = new double[2] { 0, 0 };
var totalMoney = new double[35];
const double tax = 0.55;
var price = new double[6] { 5000, 10000, 15000, 10000, 15000, 20000 };
Console.WriteLine();
Console.Write("| PRIVATE FLIGHT AIRLINE |\t");
DateTime aDate = DateTime.Now;
Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
Console.WriteLine("--------------------------------------------------------");
Console.Write("Enter User: ");
name = Console.ReadLine();
Console.Clear();
Console.WriteLine("Welcome, {0}", name);
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("|{0}| passenger onboard\n ", count);
while (count < 35)
{
GetPassenger(passenger);
passenger[count] = Console.ReadLine();
GetPassengerClass(passengerClass);
passengerClass[count] = Console.ReadLine();

Console.Clear();
if (passenger[count].ToLower() == "child" && passengerClass[count].ToLower() ==
"economy")
{
totalBtaxC = totalBtaxC + price[0];
gctC = GetchildGct(price[0], tax);
totalPrice[0] = Totalprice(gctC, price[0]);
totalC = TotalCA(totalPrice[0], totalC);
totalMoney[count] = Totalprice(gctC, price[0]);
countC = countC + 1;
count = count + 1;
Console.WriteLine("Price is {0:c}\nAdded value tax is {1:c}\nTotal price after tax is {2:c}", price[0], gctC, totalPrice[0]);

}
else if (passenger[count].ToLower() == "child" && passengerClass[count].ToLower() == "business")
{
totalBtaxC = totalBtaxC + price[1];
gctC = GetchildGct(price[1], tax);
totalPrice[0] = Totalprice(gctC, price[1]);
totalC = TotalCA(totalPrice[0], totalC);
totalMoney[count] = Totalprice(gctC, price[1]);
countC = countC + 1;
count = count + 1;
Console.WriteLine("Price is {0:c}\n Added value tax is {1:c}\nTotal price after tax is {2:c}", price[1], gctC, totalPrice[0]);
}
else if (passenger[count].ToLower() == "child" && passengerClass[count].ToLower() ==
"first")
{
totalBtaxC = totalBtaxC + price[2];
gctC = GetchildGct(price[2], tax);
totalPrice[0] = Totalprice(gctC, price[2]);
totalC = TotalCA(totalPrice[0], totalC);
totalMoney[count] = Totalprice(gctC, price[2]);
countC = countC + 1;
count = count + 1;
Console.WriteLine("Price is {0:c}\n Added value tax is {1:c}\nTotal price after tax is {2:c}", price[2], gctC, totalPrice[0]);
}
else if (passenger[count].ToLower() == "adult" && passengerClass[count].ToLower() == "economy")
{
totalBtaxA = totalBtaxA + price[3];
gctA = GetadultGct(price[3], tax);
totalPrice[1] = Totalprice(gctA, price[3]);
totalA = TotalCA(totalA, totalPrice[1]);
totalMoney[count] = Totalprice(gctC, price[3]);
countA = countA + 1;
count = count + 1;
Console.WriteLine("Price is {0:c}\nAdded value tax is {1:c}\nTotal price after tax is {2:c}", price[3], gctA, totalPrice[1]);
}
else if (passenger[count].ToLower() == "adult" && passengerClass[count].ToLower() == "business")
{
totalBtaxA = totalBtaxA + price[4];
gctA = GetadultGct(price[4], tax);
totalPrice[1] = Totalprice(gctA, price[4]);
totalA = TotalCA(totalPrice[1], totalA);
totalMoney[count] = Totalprice(gctC, price[4]);
countA = countA + 1;
count = count + 1;
Console.WriteLine("Price is {0:c}\nAdded value tax is {1:c}\nTotal price after tax is {2:c}", price[4], gctA, totalPrice[1]);
}

else if (passenger[count].ToLower() == "adult" && passengerClass[count].ToLower() == "first")
{
totalBtaxA = totalBtaxA + price[5];
gctA = GetadultGct(price[5], tax);
totalPrice[1] = Totalprice(gctA, price[5]);
totalA = TotalCA(totalPrice[1], totalA);
totalMoney[count] = Totalprice(gctC, price[5]);
countA = countA + 1;
count = count + 1;
Console.WriteLine("| Price is {0:c} |\n| Added value tax is {1:c} |\n| Total price after tax is {2:c} |", price[5], gctA, totalPrice[1]);
}
else
{
Console.WriteLine("| Invalid Entry >>> Please enter with the appropiate values |");
}
Console.WriteLine("------------------------------------------------------");
Console.Write("{0} is Active \t|\t", name);
Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("|{0}| passengers onboard |", count);
Console.WriteLine("------------------------------------------------------");

// Console.WriteLine("| Total Child price before tax is {0:c} \n| Added value tax is {1:c} ", totalBtaxC, gctC);
Console.WriteLine("| Total number of child passenger is {0} \n| Total price for all child passenger after tax: {1:c} ", countC, totalC);
Console.WriteLine("-------------------------------------------------------");
//Console.WriteLine("| Total adult price before tax is {0:c} \n| Added value tax is {1:c} ", totalBtaxA, gctA);
Console.WriteLine("| Total number of adult passenger is {0} \n| Total price for all adult passenger after tax: {1:c} ", countA, totalA);
Console.WriteLine(" -------------------------------------------------------");
Console.WriteLine("| Total money {0:c} |", totalC + totalA);
Console.WriteLine("-------------------------------------------------------");
}
Console.Clear();
Console.WriteLine("------------------------------------------------------");

Console.Write("{0} is Active \t|\t", name);
Console.WriteLine(aDate.ToString(";dddd, dd MMMM yyyy"));
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("|{0}| passengers onboard |", count);
Console.WriteLine("------------------------------------------------------");
for (count = 0; count < 35; count++)
{
Console.WriteLine("Passenger {0} | {1} \t| Class: {2}\t|\tTotal amount after tax: {3:c}",
count, passenger[count], passengerClass[count],totalMoney[count]);
}
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("| Total number of child passenger is {0} \n| Total amount for all child passenger after tax: {1:c} ", countC, totalC);
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("| Total number of adult passenger is {0} \n| Total amount for all adult passenger after tax: {1:c} ", countA, totalA);
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("| Total revenue\t {0:c} |", totalC + totalA);
//Console.WriteLine("------------------------------------------------------");
}
}

