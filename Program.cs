using System;

namespace морской_бой
{
    class Program
    {
        static void PrintField(char[,] field)
        {
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void VerticalBorder(char[,] field)
        {
            for (int cols = 1; cols < 18; cols += 2)            //building vertical boundaries
            {
                for (int rows = 0; rows < 18; rows += 2)
                {
                    field[rows, cols] = '|';
                }
            }
        }
        static void HorizontalBorder(char[,] field)
        {
            for (int cols = 0; cols < 18; cols++)            //building horizontal boundaries
            {
                for (int rows = 1; rows < 18; rows += 2)
                {
                    field[rows, cols] = '-';
                }
            }
        }
        static void VerticalCoordinats(char[,] field, char verticalItem = '1')
        {
            for (int rows = 2; rows < 18; rows += 2)        //arranging vertical boundaries
            {
                field[rows, 0] = verticalItem;
                verticalItem++;
            }
        }
        static void HorizontalCoordinats(char[,] field, char horizontalItem = 'a')
        {
            for (int cols = 2; cols < 18; cols += 2)         //building horizontal boundaries
            {
                field[0, cols] = horizontalItem;
                horizontalItem++;
            }
        }
        static void ArangeAndCheckShips(int shipsAmount, char[,] field, int[] shipsInfoX, int[] shipsInfoY, char[,] usersField)
        {
            int dx, dy;
            string shipToCell;
            for (int i = 0; i < shipsAmount; i++)
            {
                shipToCell = Console.ReadLine();
                while (shipToCell.Length != 2 || shipToCell[0] < 97 || shipToCell[0] > 104 || //checking for correct input
                                   shipToCell[1] < 49 || shipToCell[1] > 56)
                {
                    Console.WriteLine("Uncorrect input! Try again:");
                    shipToCell = Console.ReadLine();
                }
                dx = ((shipToCell[0] - 97) * 2 + 2);        //determination of the horizontal coordinate
                dy = ((shipToCell[1] - 49) * 2 + 2);        //determination of the vertical coordinate
                shipsInfoX[i] = dx;
                shipsInfoY[i] = dy;
                switch (i)                                    //checking that the ships are not standing nearby
                {
                    case 1:
                        {
                            if (Math.Abs(shipsInfoX[1] - shipsInfoX[0]) <= 2 && Math.Abs(shipsInfoY[1] - shipsInfoY[0]) <= 2)
                            {
                                Console.WriteLine("Error! 2 ship is near 1. Try again!");
                                i--;
                            }
                            else
                            {
                                Console.Clear();
                                field[dy, dx] = '@';
                                PrintField(usersField);
                            }
                            break;
                        }
                    case 2:
                        {
                            if (Math.Abs(shipsInfoX[2] - shipsInfoX[0]) <= 2 && Math.Abs(shipsInfoY[2] - shipsInfoY[0]) <= 2)
                            {
                                Console.WriteLine("Error! 3 ship is near 1. Try again!");
                                i--;
                            }
                            else if (Math.Abs(shipsInfoX[2] - shipsInfoX[1]) <= 2 && Math.Abs(shipsInfoY[2] - shipsInfoY[1]) <= 2)
                            {
                                Console.WriteLine("Error! 3 ship is near 2. Try again!");
                                i--;
                            }
                            else
                            {
                                Console.Clear();
                                field[dy, dx] = '@';
                                PrintField(usersField);
                            }
                            break;
                        }
                    case 3:
                        {
                            if (Math.Abs(shipsInfoX[3] - shipsInfoX[0]) <= 2 && Math.Abs(shipsInfoY[3] - shipsInfoY[0]) <= 2)
                            {
                                Console.WriteLine("Error! 4 ship is near 1. Try again!");
                                i--;
                            }
                            else if (Math.Abs(shipsInfoX[3] - shipsInfoX[1]) <= 2 && Math.Abs(shipsInfoY[3] - shipsInfoY[1]) <= 2)
                            {
                                Console.WriteLine("Error! 4 ship is near 2. Try again!");
                                i--;
                            }
                            else if (Math.Abs(shipsInfoX[3] - shipsInfoX[2]) <= 2 && Math.Abs(shipsInfoY[3] - shipsInfoY[2]) <= 2)
                            {
                                Console.WriteLine("Error! 4 ship is near 3. Try again!");
                                i--;
                            }
                            else
                            {
                                Console.Clear();
                                field[dy, dx] = '@';
                                PrintField(usersField);
                            }
                            break;
                        }

                    case 4:
                        {
                            if (Math.Abs(shipsInfoX[4] - shipsInfoX[0]) <= 2 && Math.Abs(shipsInfoY[4] - shipsInfoY[0]) <= 2)
                            {
                                Console.WriteLine("Error! 5 ship is near 1. Try again!");
                                i--;
                            }
                            else if (Math.Abs(shipsInfoX[4] - shipsInfoX[1]) <= 2 && Math.Abs(shipsInfoY[4] - shipsInfoY[1]) <= 2)
                            {
                                Console.WriteLine("Error! 5 ship is near 2. Try again!");
                                i--;
                            }
                            else if (Math.Abs(shipsInfoX[4] - shipsInfoX[2]) <= 2 && Math.Abs(shipsInfoY[4] - shipsInfoY[2]) <= 2)
                            {
                                Console.WriteLine("Error! 5 ship is near 3. Try again!");
                                i--;
                            }
                            else if (Math.Abs(shipsInfoX[4] - shipsInfoX[3]) <= 2 && Math.Abs(shipsInfoY[4] - shipsInfoY[3]) <= 2)
                            {
                                Console.WriteLine("Error! 5 ship is near 4. Try again!");
                                i--;
                            }
                            else
                            {
                                Console.Clear();
                                field[dy, dx] = '@';
                            }
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            field[dy, dx] = '@';
                            PrintField(usersField);
                            break;
                        }

                }
            }
        }
        static void ComputerArangeAndCheckShips(int shipsAmount, char[,] field, ref int dx1, ref int dx2, ref int dx3, ref int dx4,
            ref int dx5, ref int dy1, ref int dy2, ref int dy3, ref int dy4, ref int dy5)
        {
            int computerDx, computerDy;
            Random computerShipsX = new Random();
            Random computerShipsY = new Random();
            for (int i = 0; i < shipsAmount; i++)
            {
                computerDx = computerShipsX.Next(2, 17);
                computerDy = computerShipsY.Next(2, 17);
                while (computerDx % 2 == 1)
                {
                    computerDx = computerShipsX.Next(2, 16);
                }
                while (computerDy % 2 == 1)
                {
                    computerDy = computerShipsY.Next(2, 16);
                }
                switch (i)
                {
                    case 0:
                        dx1 = computerDx;
                        dy1 = computerDy;
                        break;
                    case 1:
                        dx2 = computerDx;
                        dy2 = computerDy;
                        if (Math.Abs(dx1 - dx2) <= 2 && Math.Abs(dy1 - dy2) <= 2)
                        {
                            i--;
                        }
                        break;
                    case 2:
                        dx3 = computerDx;
                        dy3 = computerDy;
                        if (Math.Abs(dx1 - dx3) <= 2 && Math.Abs(dy1 - dy3) <= 2)
                        {
                            i--;
                        }
                        else if (Math.Abs(dx2 - dx3) <= 2 && Math.Abs(dy2 - dy3) <= 2)
                        {
                            i--;
                        }
                        break;
                    case 3:
                        dx4 = computerDx;
                        dy4 = computerDy;
                        if (Math.Abs(dx1 - dx4) <= 2 && Math.Abs(dy1 - dy4) <= 2)
                        {
                            i--;
                        }
                        else if (Math.Abs(dx2 - dx4) <= 2 && Math.Abs(dy2 - dy4) <= 2)
                        {
                            i--;
                        }
                        else if (Math.Abs(dx3 - dx4) <= 2 && Math.Abs(dy3 - dy4) <= 2)
                        {
                            i--;
                        }
                        break;
                    case 4:
                        dx5 = computerDx;
                        dy5 = computerDy;
                        if (Math.Abs(dx1 - dx5) <= 2 && Math.Abs(dy1 - dy5) <= 2)
                        {
                            i--;
                        }
                        else if (Math.Abs(dx2 - dx5) <= 2 && Math.Abs(dy2 - dy5) <= 2)
                        {
                            i--;
                        }
                        else if (Math.Abs(dx3 - dx5) <= 2 && Math.Abs(dy3 - dy5) <= 2)
                        {
                            i--;
                        }
                        else if (Math.Abs(dx4 - dx5) <= 2 && Math.Abs(dy4 - dy5) <= 2)
                        {
                            i--;
                        }
                        break;
                }
            }
        }
        static void DrawFields(char[,] usersField, char[,] computersField)
        {
            Console.Clear();
            PrintField(usersField);
            int x, y, rows, cols;
            for (y = 0, rows = 0; y < 18 && rows < 18; y++, rows++)
            {
                for (x = 60, cols = 0; x < 96 && cols < 18; x += 2, cols++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(computersField[rows, cols]);
                }
            }
            Console.WriteLine();
        }
        static void ComputersAtacking(char[,] usersField, char[,] computersField, int Amount, int[] shipsInfoX, int[] ShipsInfoY,
            ref int dx1, ref int dx2, ref int dx3, ref int dx4, ref int dx5, ref int dy1, ref int dy2, ref int dy3, ref int dy4, ref int dy5,
            ref int ExitGameForComputer, ref int ExitGameForUser)
        {
            ExitGame(ref ExitGameForComputer, ref ExitGameForUser, usersField, computersField);
            Random AtackX = new Random();
            Random AtackY = new Random();
            int i, j;
            int computerAtackX = AtackX.Next(2, 16);
            int computerAtackY = AtackX.Next(2, 16);
            while (computerAtackX % 2 == 1)
            {
                computerAtackX = AtackX.Next(2, 16);
            }
            while (computerAtackY % 2 == 1)
            {
                computerAtackY = AtackY.Next(2, 16);
            }
            while(computersField[computerAtackY, computerAtackX] == '0')        //cycle to let the computer select different cells
            {
                ComputersAtacking(usersField, computersField, Amount, shipsInfoX, ShipsInfoY, ref dx1, ref dx2, ref dx3, ref dx4,
                        ref dx5, ref dy1, ref dy2, ref dy3, ref dy4, ref dy5, ref ExitGameForComputer, ref ExitGameForUser);
            }
            for (i = 0, j = 0; i < Amount && j < Amount; i++, j++)
            {
                if (computerAtackX == shipsInfoX[i] && computerAtackY == ShipsInfoY[i])     //if computer is hit
                {
                    ExitGameForUser--;
                    DotsAroundShip(computerAtackX, computerAtackY, usersField);             //computer shoots again
                    DrawFields(usersField, computersField);
                    ComputersAtacking(usersField, computersField, Amount, shipsInfoX, ShipsInfoY, ref dx1, ref dx2, ref dx3, ref dx4,
                        ref dx5, ref dy1, ref dy2, ref dy3, ref dy4, ref dy5, ref ExitGameForComputer, ref ExitGameForUser);
                }
            }
                if (usersField[computerAtackY, computerAtackX] != 'X')     //if computer isnt hit
                {
                    usersField[computerAtackY, computerAtackX] = '0';
                    DrawFields(usersField, computersField);
                    UsersAtacking(computersField, Amount, ref dx1, ref dx2, ref dx3, ref dx4, ref dx5, ref dy1, ref dy2, ref dy3, ref dy4, ref dy5,
                        usersField, shipsInfoX, ShipsInfoY, ref ExitGameForComputer, ref ExitGameForUser);        //user hits
                }
            
        }
        static void DotsAroundShip(int dx, int dy, char[,] field)
        {
            for (int rows = 2; rows < 18; rows += 2)
            {
                for (int cols = 2; cols < 18; cols += 2)
                {
                    if (Math.Abs(cols - dx) <= 2 && Math.Abs(rows - dy) <= 2)
                    {
                        field[rows, cols] = '0';
                    }
                }
            }
            field[dy, dx] = 'X';
            Console.Clear();
        }
        static void UsersAtacking(char[,] computersField, int Amount, ref int dx1, ref int dx2, ref int dx3, ref int dx4,
            ref int dx5, ref int dy1, ref int dy2, ref int dy3, ref int dy4, ref int dy5, char[,] usersField,
            int[] shipsInfoX, int[] shipsInfoY, ref int ExitGameForComputer, ref int ExitGameForUser)
        {
            ExitGame(ref ExitGameForComputer, ref ExitGameForUser, usersField, computersField);
            string choice = Console.ReadLine();
            int dx, dy;
            while (choice.Length != 2 || choice[0] < 97 || choice[0] > 104 || //checking for correct input
                               choice[1] < 49 || choice[1] > 56)
            {
                Console.WriteLine("Uncorrect input! Try again:");
                choice = Console.ReadLine();
            }
            dx = ((choice[0] - 97) * 2 + 2);
            dy = ((choice[1] - 49) * 2 + 2);
            while(computersField[dy,dx] == '0')     //a cycle that checks that it is impossible to shoot at the same cell twice
            {
                Console.WriteLine("You cant choose this cell. Try another!");
                UsersAtacking(computersField, Amount, ref dx1, ref dx2, ref dx3, ref dx4,
            ref dx5, ref dy1, ref dy2, ref dy3, ref dy4, ref dy5, usersField, shipsInfoX, shipsInfoY, ref ExitGameForComputer, ref ExitGameForUser);
            }
            if ((dx == dx1 && dy == dy1) || (dx == dx2 && dy == dy2) || (dx == dx3 && dy == dy3) || (dx == dx4 && dy == dy4) ||
                (dx == dx5 && dy == dy5))           //if user hits
            {
                ExitGameForComputer--;
                DotsAroundShip(dx, dy, computersField);
                DrawFields(usersField, computersField);
                UsersAtacking(computersField, Amount, ref dx1, ref dx2, ref dx3, ref dx4,
            ref dx5, ref dy1, ref dy2, ref dy3, ref dy4, ref dy5, usersField, shipsInfoX, shipsInfoY, ref ExitGameForComputer, ref ExitGameForUser);
            }
            else
            {               //if user doesnt hit
                computersField[dy, dx] = '0';
                DrawFields(usersField, computersField);
                ComputersAtacking(usersField, computersField, Amount, shipsInfoX, shipsInfoY, ref dx1, ref dx2, ref dx3, ref dx4,
            ref dx5, ref dy1, ref dy2, ref dy3, ref dy4, ref dy5, ref ExitGameForComputer, ref ExitGameForUser);
            }
        }
        static void ExitGame(ref int ExitGameForComputer, ref int ExitGameForUser, char[,] usersField, char[,] computersField)
        {
            if (ExitGameForComputer == 0)
            {
                Console.Clear();
                DrawFields(usersField, computersField);
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("You win!");
            }
            if (ExitGameForUser == 0)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("You lose(");
                Console.SetCursorPosition(0, 10);
                DrawFields(usersField, computersField);
            }
        }

        static void DrawMenuItem(int Item, string[] KeyNames, ConsoleColor Foreground, ConsoleColor Background)
        {
            Console.SetCursorPosition(Console.BufferWidth / 2 - KeyNames.Length / 2, Console.BufferHeight / 2 - KeyNames.Length / 2 + Item);
            Console.BackgroundColor = Background;
            Console.ForegroundColor = Foreground;
            Console.Write(KeyNames[Item]);
        }

        static void Game()
        {
            Console.CursorVisible = true;
            int shipsAmount = 5, dx1 = 0, dx2 = 0, dx3 = 0, dx4 = 0, dx5 = 0, dy1 = 0, dy2 = 0, dy3 = 0, dy4 = 0, dy5 = 0,
                ExitGameForUser = shipsAmount, ExitGameForComputer = shipsAmount;
            char[,] usersField = new char[18, 18];
            char[,] computersField = new char[18, 18];
            int[] shipsInfoX = new int[shipsAmount];            //array for storing the horizontal coordinates of the user's ships
            int[] shipsInfoY = new int[shipsAmount];            //array for storing the vertical coordinates of the user's ships
            char horizontalItem = 'a', verticalItem = '1';
            //******************************USERS FIELD******************************
            VerticalBorder(usersField);
            HorizontalBorder(usersField);
            VerticalCoordinats(usersField, verticalItem);
            HorizontalCoordinats(usersField, horizontalItem);
            PrintField(usersField);
            Console.WriteLine("Arrange ships in format a4 or g5:");
            ArangeAndCheckShips(shipsAmount, usersField, shipsInfoX, shipsInfoY, usersField);
            Console.WriteLine();
            //******************************COMPUTERS FIELD******************************
            VerticalBorder(computersField);
            HorizontalBorder(computersField);
            VerticalCoordinats(computersField, verticalItem);
            HorizontalCoordinats(computersField, horizontalItem);
            PrintField(computersField);
            //******************************DRAWING FIELDS******************************
            DrawFields(usersField, computersField);
            ComputerArangeAndCheckShips(shipsAmount, computersField, ref dx1, ref dx2, ref dx3, ref dx4, ref dx5, ref dy1,
                ref dy2, ref dy3, ref dy4, ref dy5);
            //******************************GAME PROCESS******************************
            Console.WriteLine("Enter a cell (for example f3 or h7) for atacking: ");
            UsersAtacking(computersField, shipsAmount, ref dx1, ref dx2, ref dx3, ref dx4, ref dx5, ref dy1, ref dy2,
                ref dy3, ref dy4, ref dy5, usersField, shipsInfoX, shipsInfoY, ref ExitGameForComputer, ref ExitGameForUser);
            DrawFields(usersField, computersField);
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
            Console.CursorVisible = false;
            int Selected = 0;
            ConsoleKeyInfo Button;
            string[] KeyNames = { "Play", "Exit" };
            DrawMenuItem(0, KeyNames, ConsoleColor.Black, ConsoleColor.White);
            for (int i = 1; i < KeyNames.Length; i++)
            {
                DrawMenuItem(i, KeyNames, ConsoleColor.White, ConsoleColor.Black);
            }
            bool Exit = false;
            do
            {
                Button = Console.ReadKey(true);
                if (Button.Key == ConsoleKey.UpArrow && Selected > 0)
                {
                    DrawMenuItem(Selected, KeyNames, ConsoleColor.White, ConsoleColor.Black);
                    Selected--;
                    DrawMenuItem(Selected, KeyNames, ConsoleColor.Black, ConsoleColor.White);
                }
                if (Button.Key == ConsoleKey.DownArrow && Selected < KeyNames.Length - 1)
                {
                    DrawMenuItem(Selected, KeyNames, ConsoleColor.White, ConsoleColor.Black);
                    Selected++;
                    DrawMenuItem(Selected, KeyNames, ConsoleColor.Black, ConsoleColor.White);
                }
                if (Button.Key == ConsoleKey.Enter)
                {
                    switch (Selected)
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Game();
                            break;
                        case 1:
                            Exit = true;
                            break;
                    }
                }
            } while (!Exit);
        }
    }
}
