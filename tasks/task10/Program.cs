int randomNumber = new Random().Next(100, 1000);

int twoDigitNumber = randomNumber / 10;
int secondDigit = twoDigitNumber % 10;

Console.WriteLine(randomNumber);
Console.WriteLine(secondDigit);
