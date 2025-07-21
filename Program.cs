Random dice = new Random();
int Roll1 = dice.Next(1, 7);
int Roll2 = dice.Next(1, 7);
int Roll3 = dice.Next(1, 7);
int total = Roll1 + Roll2 + Roll3;
if (Roll1 == Roll2 || Roll2 == Roll3 || Roll1 == Roll3)
{
    Console.WriteLine($"You rolled doubes +2 bonus to the total!");
    total += 2;
}
if(Roll1==Roll2 && Roll2==Roll3)
{
    Console.WriteLine($"You rolled triples +6 bonus to the total!");
    total += 6;
}

Console.WriteLine($"The sum of the rolls: {Roll1} + {Roll2} + {Roll3} = {total}");
if (total >= 15)
{
    Console.WriteLine("You win!");
}
if (total < 15) {
    Console.WriteLine("You lose");
}
