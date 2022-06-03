Console.WriteLine("1 to run Permutations");
Console.WriteLine("2 to run Binary Search Word");
Console.WriteLine("3 to run InserTion Sort");
Console.WriteLine("4 to run Bubble Sort");
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
    case 3:
        AlgorithmPrograms.InsertionSort sort = new AlgorithmPrograms.InsertionSort();
        sort.StringInserTionSort();
        break;
    case 4:
        AlgorithmPrograms.BubbleSort bubbleSort = new AlgorithmPrograms.BubbleSort();
        bubbleSort.BubbleSortofInteger();
        break;


}





