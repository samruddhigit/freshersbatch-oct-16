using System;


Console.WriteLine("Single Dimension Array Sample");

string[] strArray = new string[] {
    "Mahesh Chand",
    "Mike Gold",
    "Raj Beniwal",
    "Praveen Kumar",
    "Dinesh Beniwal"
};

foreach (string str in strArray)
{
    Console.WriteLine(str);
}
Console.WriteLine("-----------------------------");
Console.WriteLine("Multi-Dimension Array Sample");
string[,] string2DArray = new string[2, 2] {
    {
        "Rosy",
        "Amy"
    }, {
        "Peter",
        "Albert"
    }
};
foreach (string str in string2DArray)
{
    Console.WriteLine(str);
}
Console.WriteLine("-----------------------------");
Console.WriteLine("Jagged Array Sample");
int[][] intJaggedArray3 = {
    new int[] {
        2,
        12
    },
    new int[] {
        14,
        14,
        24,
        34
    },
    new int[] {
        6,
        16,
        26,
        36,
        46,
        56
    }
};

for (int i = 0; i < intJaggedArray3.Length; i++)
{
    Console.Write($"Element({i}): ");
    for (int j = 0; j < intJaggedArray3[i].Length; j++)
    {
        Console.Write($"{intJaggedArray3[i][j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("-----------------------------");
