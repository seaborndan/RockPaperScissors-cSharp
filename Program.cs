using System;

Main();

void Main() {
    int userScore = 0;
    int cpuScore = 0;
    bool isDone = false;
    while(!isDone) {
        
        Console.WriteLine("User: " + $"{userScore}" + "  " +    "Computer: " + $"{cpuScore}" );
        Console.WriteLine("--------------------------------");
        Console.WriteLine("What would you like to throw?");
        Console.WriteLine("1) Rock");
        Console.WriteLine("2) Paper");
        Console.WriteLine("3) Scissors");
        string userChoice = Console.ReadLine();
        Random r = new Random();
        int cpuHand = r.Next(1, 3);
        if(userChoice == "1") {
            Console.WriteLine($@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
            if(cpuHand == 3) {
                Console.WriteLine("VS");
                Console.WriteLine($@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
");
                userScore++;
            }
            else if(cpuHand == 2) {
                Console.WriteLine("VS");
                Console.WriteLine(($@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
"));
                cpuScore++;
            }
        }
        if(userChoice == "2") {
            
            Console.WriteLine(($@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
"));
            if(cpuHand == 3) {
                Console.WriteLine("VS");
                Console.WriteLine($@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
");
                cpuScore++;
            }
            else if(cpuHand == 1) {
                Console.WriteLine("VS");
                Console.WriteLine($@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
                userScore++;
            }
        }
        if(userChoice == "3") {
            Console.WriteLine($@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
");
            if(cpuHand == 1) {
                Console.WriteLine("VS");
                Console.WriteLine($@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
                cpuScore++;
                
            }
            else if(cpuHand == 2) {
                Console.WriteLine("VS");
                Console.WriteLine(($@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
"));
                userScore++;
            }
        }
        if(userScore == 3) {
            isDone = true;
            Console.WriteLine("You win!");
        }
        if(cpuScore == 3) {
            isDone = true;
            Console.WriteLine("You lose!");
        }


    }
};