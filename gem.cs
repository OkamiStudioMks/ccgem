using System;
using System.Threading;

class Gem{
    static void Main(){
        // Banner
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("  _____");
        Console.WriteLine(" / ____|");
        Console.WriteLine("| |       ___    __ _   ___  _ __ ___");
        Console.WriteLine("| |      / __|  / _` | / _ \\| '_ ` _ \\ ");
        Console.WriteLine("| |____ | (__  | (_| ||  __/| | | | | |");
        Console.WriteLine(" \\_____| \\___|  \\__, | \\___||_| |_| |_|");
        Console.WriteLine("                 __/ |");
        Console.WriteLine("                |___/");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("v0.0.1b");
        Console.WriteLine("By:: @OkamiMware\n\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("["); 
        Console.ForegroundColor = ConsoleColor.Magenta; 
        Console.Write("+"); 
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("]");
        Console.Write("COMANDOS");
        Console.Write("["); 
        Console.ForegroundColor = ConsoleColor.Magenta;  
        Console.Write("+"); 
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("]");
        Console.Write("["); 
        Console.ForegroundColor = ConsoleColor.Magenta;  
        Console.Write("+"); 
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("]");
        Console.WriteLine("!gem -bin\n\n");


        int[] numbers = new int[]{0,1,2,3,4,5,6,7,8,9};
        int[] card = new int[16];
        int[] Yy = new int[2];
        int[] Mm = new int[2];
        int[] cvv = new int[3];
        int quant, cc, i;
        string carding, dateMm, dateYy, valid;
        string[] cardTypes = new string[]{"Mastercard", "Visa", "Dinners club", "Discover", "JCB", "American express"};
        string consoleComand;
        quant=cc=i=0;

        while(true){
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(">> ");
            consoleComand = Console.ReadLine();
            if(consoleComand=="!gem"){
                while(true){
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("6 digits Card: ");
                    carding = Console.ReadLine();
                    if(carding.Length>6 || carding.Length<6){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bin inválida");
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Date Yy: ");
                    dateYy = Console.ReadLine();
                    if(dateYy.Length>2 || dateYy.Length<2){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Data inválida");
                        break;
                    }
                    
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Date Mm: ");
                    dateMm = Console.ReadLine();
                    if(dateMm.Length>2 || dateMm.Length<2){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Data inválida");
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Cvv: ");
                    valid = Console.ReadLine();
                    if(valid.Length >3){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tamanho não permitido");
                    }

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Quantidade: ");
                    quant = Convert.ToInt32(Console.ReadLine());
                    if(quant >9999){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Tamanho não permitido");
                    }
                    else{
                        int cont=0;
                        for(cont=0; cont<quant; cont++){     
                            Thread.Sleep(100);
                            Random random = new Random();
                            for(i=0; i<10; i++){cc = Convert.ToInt32(random.Next(9));card[i] =cc;}
                            Console.WriteLine(carding+card[0]+card[1]+card[2]+card[3]+card[4]+card[5]+card[6]+card[7]+card[8]+card[9]+"|"+dateMm+"|"+dateYy+"|"+valid);
                            card[0]=card[1]=card[2]=card[3]=card[4]=card[5]=card[6]=card[7]=card[8]=card[9];
                        }
                    }
                }
            }else if(consoleComand=="!exit"){break;}
        }
    }
}
