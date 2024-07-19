Random rand = new();

List<int> lottoNumbers = new List<int>();

for (int i = 1; i <= 49; i++)
{
    lottoNumbers.Add(i);
}

int[] lottoWinners = new int[6];

for(int i = 0; i < lottoWinners.Length; i++)
{
    int random = rand.Next(0, lottoNumbers.Count);
    lottoWinners[i] = lottoNumbers[random];
    lottoNumbers.RemoveAt(random);

}

foreach(int number in lottoWinners)
{
Console.WriteLine(number);
}