// start main


int userChoice = GetUserChoice(); //priming read
while(userChoice!=3){
  RouteEm(userChoice);
  userChoice=GetUserChoice();  //update read
}



// end main

static int GetUserChoice(){
    DisplayMenu();
    string userChoice=Console.ReadLine();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput){
    if(userInput=="1" || userInput=="2" || userInput=="3"){
        return true;
    }
    return false;
}

static void GetFull(){
    Random rnd = new Random();
    int sizeOfTriangle = rnd.Next(3,10);
    for(int i = 1; i < sizeOfTriangle; i++){
       for(int j = 1; j<i; j++){
            Console.Write("o");
       }
        Console.Write("o\n");
    }

    PauseAction();
}



static void GetPartial(){
   Random rnd = new Random();
   int sizeOfTriangle = rnd.Next(3,10);
   Random rand = new Random();
   
   for(int i = 1; i < sizeOfTriangle; i++){
    for(int j = 1; j<i; j++){
        int number = rand.Next(1,3);
        if(number == 1){
            Console.Write("o");
        } 
        else if(number == 2){
            Console.Write(" ");
        }
    }
    Console.Write("o\n");
   }
    PauseAction();
}

static void SayInvalid(){
    System.Console.WriteLine("Invalid!");
    PauseAction();
}

static void RouteEm(int menuChoice){
    if(menuChoice==1){
        GetFull();
    }
    else if (menuChoice==2){
        GetPartial();
    }
    else if (menuChoice!=3){
        SayInvalid();
    }
}

static void PauseAction(){
    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}



