using ConsoleApplicationProject;


var usrInput = Console.ReadLine();

decimal output = 0.00000000001M;

while (decimal.TryParse(usrInput, out output) == false || output == 0.00000000001M)
{
    Console.WriteLine("Wrong Input");
    usrInput = Console.ReadLine();
};



