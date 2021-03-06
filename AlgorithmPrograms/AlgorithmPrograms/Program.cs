Console.WriteLine("1 to run Permutations");
Console.WriteLine("2 to run Binary Search Word");
Console.WriteLine("3 to run InserTion Sort");
Console.WriteLine("4 to run Bubble Sort");
Console.WriteLine("5 to run Anagram");
Console.WriteLine("6 to run MergeSort");
Console.WriteLine("7 to run Unordered List");
Console.WriteLine("8 to run Ordered List");
Console.WriteLine("9 to run Balanced Parenthesis");
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
    case 5:
        AlgorithmPrograms.CheckAnagram run = new AlgorithmPrograms.CheckAnagram();
        run.Anagram();
        break;
    case 6:
        AlgorithmPrograms.MergeSort mergesort = new AlgorithmPrograms.MergeSort();
        int[] array = { 30, 20, 50, 70, 120, 180, 100, 40 };       
        Console.WriteLine("Before Sorting:");
        mergesort.Print(array);
        Console.WriteLine("\nAfter Sorting");
        mergesort.sort(array, 0, array.Length - 1);
        mergesort.Print(array);
        break;
    case 7:
        {
            AlgorithmPrograms.Unordered_List unordedlist = new AlgorithmPrograms.Unordered_List();
            unordedlist.UnorderedList();
            break;
        }
    case 8:
        {
            AlgorithmPrograms.Ordered_List ordedlist = new AlgorithmPrograms.Ordered_List();
            ordedlist.OrderedList();
            break;
        }
    case 9:
        {
            AlgorithmPrograms.Balanced_Parentheses balanced = new AlgorithmPrograms.Balanced_Parentheses();
            balanced.BalanceChecker();
            break;
        }
}





