Console.WriteLine("1 to run Permutations");
Console.WriteLine("2 to run Binary Search Word");
int select = Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        AlgorithmPrograms.PermutationsofString permutation = new AlgorithmPrograms.PermutationsofString();
        permutation.Run();
        break;
    case 2:
        AlgorithmPrograms.BinarySearchWord binary = new AlgorithmPrograms.BinarySearchWord();
        binary.BinaryOutput("Nantha");
        break;
}





