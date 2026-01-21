using System.Drawing;
using Go4Library;
//main

game();
//main

//methods
void game()
{
PlayField field = new PlayField();
    field.createField();
    Console.WriteLine("giocatore 1 inserisci il tuo nome");
    string nameP1=Console.ReadLine();
    Player p1 = new Player(nameP1,"rosso");
    Console.WriteLine("giocatore 2 inserisic il tuo nome");
    string nameP2=Console.ReadLine();
    Player p2 = new Player(nameP2,"giallo");
    
    bool turn=true;
    Random rand = new Random();
    int playercCount= rand.Next(1,3);
    while (turn)
    {
        Console.Clear();
        if (playercCount == 1)
        {
            stampField(field);
            player(p1, field);
            stampField(field);
            playercCount++;
        }
        else if (playercCount == 2)
        {
            stampField(field);
            player(p2, field);
            stampField(field);
            playercCount--;
        }
    }
}
void stampField(PlayField field)
{
    for(int i = 0; i<6;i++)
    {
        for (int j = 0; j < 7; j++)
        {
            if (field.gameField[i,j] == " r ")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" o ");
                Console.ResetColor();
            }
            else if(field.gameField[i, j] == " g ")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" o ");
                Console.ResetColor();
            }
            else
            {
            Console.Write(field.gameField[i, j]);
            }
        }
        Console.WriteLine();       
            if (i == 5)
            {
            Console.Write(" 1  2  3  4  5  6  7");
            }
    }
}

void player(Player player,PlayField field)
{
    Console.WriteLine("\n"+player.Name + " inserisci una posizone ");
    string pos = Console.ReadLine();

    bool turn=true;
    int count = 5;

    if (player.Color == "rosso")
    {
        switch (pos)
        {
            case "1":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 0] != " r " && field.gameField[count, 0] != " g ")
                        {
                            field.gameField[count, 0] = " r ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "2":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 1] != " r " && field.gameField[count, 1] != " g ")
                        {
                            field.gameField[count, 1] = " r ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "3":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 2] != " r " && field.gameField[count, 2] != " g ")
                        {
                            field.gameField[count, 2] = " r ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "4":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 3] != " r " && field.gameField[count, 3] != " g ")
                        {
                            field.gameField[count, 3] = " r ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "5":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 4] != " r " && field.gameField[count, 4] != " g ")
                        {
                            field.gameField[count, 4] = " r ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "6":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 5] != " r " && field.gameField[count, 5] != " g ")
                        {
                            field.gameField[count, 5] = " r ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "7":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 6] != " r " && field.gameField[count, 6] != " g ")
                        {
                            field.gameField[count, 6] = " r ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            default:
                Console.WriteLine("valore non riconosciuto turno perso");
                Console.ReadLine();
                break;
        }
    }
    else
    {
        switch (pos)
        {
            case "1":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 0] != " r " && field.gameField[count, 0] != " g ")
                        {
                            field.gameField[count, 0] = " g ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "2":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 1] != " r " && field.gameField[count, 1] != " g ")
                        {
                            field.gameField[count, 1] = " g ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "3":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 2] != " r " && field.gameField[count, 2] != " g ")
                        {
                            field.gameField[count, 2] = " g ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "4":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 3] != " r " && field.gameField[count, 3] != " g ")
                        {
                            field.gameField[count, 3] = " g ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "5":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 4] != " r " && field.gameField[count, 4] != " g ")
                        {
                            field.gameField[count, 4] = " g ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "6":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 5] != " r " && field.gameField[count, 5] != " g ")
                        {
                            field.gameField[count, 5] = " g ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            case "7":
                while (turn)
                {
                    if (count >= 0)
                    {
                        if (field.gameField[count, 6] != " r " && field.gameField[count, 6] != " g ")
                        {
                            field.gameField[count, 6] = " g ";
                            turn = false;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la posizione e piena turno perso");
                        Console.ReadLine();
                        turn = false;
                    }
                }
                break;
            default:
                Console.WriteLine("valore non riconosciuto turno perso");
                Console.ReadLine();
                break;
        }
    }
    
}
//methods