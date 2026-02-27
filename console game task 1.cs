using System;



public partial class Program
{
	
	static void tictactoe(){
int turns  = 0;
bool player1turn = true; 
string[] grid = new string[9] {"1", "2", "3", "4", "5", "6", "7", "8", "9"}; // creating a new string grid and assigning it a new string of 9 strings
while (!win() && turns != 9){ //ends while loop apon win or if turns reach 9 which is a draw
	
    
    newTTT(grid);
	
    if (player1turn)
		Console.WriteLine("Player 1's Turn");
	
    else 
		Console.WriteLine("Player 2's Turn");
	
    string choice = Console.ReadLine();
	
    if(grid.Contains(choice) && choice != "X" && choice != "O"){
		int gridInt = Convert.ToInt32(choice) - 1;
        if (player1turn)
        grid[gridInt] = "X";
        else 
        grid[gridInt] = "O";
        turns++; //adds 1 for turn counter, 
	}
   
    player1turn = !player1turn; //really cool way to alternate turns, it turns play1turn to the oposite
}

if(win()){
	Console.WriteLine("~~~~~~~~~~~~~");
    Console.WriteLine("You have won!");
	Console.WriteLine("~~~~~~~~~~~~~");
}
else{
    Console.WriteLine("Draw!");
}
bool win()
{
    bool row1 = grid[0] == grid[1] && grid[1] == grid[2]; 
    bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
    bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
    bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
    bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
    bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
    bool diag1 = grid[0] == grid[4] && grid[4] == grid[8];
    bool diag2 = grid[6] == grid[4] && grid[4] == grid[2];
    return row1 || row2 || row3 || col1 || col2 || col3 || diag1 || diag2;
}
}
	
	
	
	static void newTTT(string[] grid){
	for(int i = 0; i < 3; i++){
		for (int j = 0; j < 3; j++){
		Console.Write("|"+ grid[i*3+j] + "|"); //------------------------------------------------------------
			
		
		}
		Console.WriteLine();
		Console.WriteLine("---------");
	}
	}
	
	static void goback(){
		Console.WriteLine("Enter 'BACK' To return to menu");
		Console.WriteLine("---------");
		string userback = Console.ReadLine();
		switch(userback.ToUpper()){
			case "BACK":
				Main();
				break;
			default:
				Console.WriteLine("Inavlid Input");
				break;
		
		}
		
		
		}
	static void playTTT()
	{
		string[,] columns = {{"1", "2", "3"}, 
							 {"4", "5", "6"},
						 	{"7", "8", "9"}};
		for(int i = 0; i < 3; i++){
			string res = "";
		for (int j = 0; j < 3; j++){
			res += "|" + columns[i,j] + "|";
	}
			Console.WriteLine(res);
			Console.WriteLine("---------");
		}
}


	static void playRPS()
	{ 
	int playerscore = 0;
	int compscore = 0;
	string border = "~~~~~~~~~~~~~~~~";
		while (true)
{
	int userIn;
	Console.WriteLine(border+border);
	Console.WriteLine("Enter 1 for Rock, Enter 2 for Paper, Enter 3 for Scissors");
	Console.WriteLine("Press 4  Menu");
	Console.WriteLine(border+border);
	int.TryParse(Console.ReadLine(), out userIn);
	if (userIn == 4)
	{
		break;
	}
	Console.Clear();		
	Console.WriteLine($"The player chose {userIn}");
	int computerIn = randNum();
	Console.WriteLine($"The computer chose {computerIn}");
	if (computerIn == userIn)
	{
		Console.WriteLine(border);
		Console.WriteLine("Draw");
		Console.WriteLine(border);
	}
			
	else if (
		(computerIn == 1 && userIn ==2) ||
		(computerIn == 1 && userIn ==3) ||
		(computerIn == 3 && userIn ==2)){
		Console.WriteLine(border);
		Console.WriteLine("You Won");
		playerscore++;
		Console.WriteLine("Player score is now "+playerscore);
		Console.WriteLine(border);
	}
	else if (
		(computerIn == 2 && userIn ==1) ||
		(computerIn == 3 && userIn ==1) ||
		(computerIn == 2 && userIn ==3)){
		Console.WriteLine(border);
		Console.WriteLine("You Lost");
		compscore++;
		Console.WriteLine("Computer score is now "+compscore);
		Console.WriteLine(border);
	}
	else
	{
		Console.WriteLine("Invalid Input");
	}
} }
static int randNum()
{
	Random rand = new Random();
	int randomValue = rand.Next(1, 4);
	return randomValue;
	}

	public static void Main()
	{
		bool running = true;
			while (running) {
			Console.WriteLine("~~~~~~~~ Select Game ~~~~~~~~");
			Console.WriteLine("Enter 'RPS' to play Rock Paper Sissors");
			Console.WriteLine("Enter 'TTT' to play Tic Tac Toe");
			Console.WriteLine("Enter 'EXIT' to quit");
			String choice = Console.ReadLine(); 
			{

				switch (choice.ToUpper()) //the toupper converts all the letters to capital 
				{
					case "RPS":
						playRPS();
						break;
					case "TTT":
						tictactoe();
						break;
					case "EXIT":
						Console.Write("Goodbye....");
						running = false;
						break;
					default:
						Console.WriteLine("Invalid Input...");
						break;
				}
			}
		}
 	}
	
		

  

		
			
} //you found the easter egg! :) 
