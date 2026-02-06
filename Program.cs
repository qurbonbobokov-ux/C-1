//1
/*
string input = Console.ReadLine();
string[] tokens = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

foreach (string token in tokens)
{
    double dep = double.Parse(token);
    double inte = 0;

    if (dep < 100)
        inte = 0.05;
    else if (dep <= 200)
        inte = 0.07;
    else
        inte = 0.10; 

    double tot = dep + dep * inte;

    Console.Write((int)tot + "            ");
}

Console.WriteLine();
*/

//2

/*
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int product = 1;
foreach (int num in arr)
{
    product *= num;
}


string[] elementsWithBrackets = arr.Select(x => x < 0 ? $"({x})" : x.ToString()).ToArray();

string multiplication = string.Join("*", elementsWithBrackets);
Console.WriteLine($"{multiplication} = {product}");
*/

//3


/*
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int maxIndex = 0;

for (int i = 1; i < n; i++)
{
    if (arr[i] > arr[maxIndex])
    {
        maxIndex = i;
    }
}

Console.WriteLine(maxIndex);

*/

//4


/*
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < n; i++)
{
    int count = 0;

    for (int j = 0; j < n; j++)
    {
        if (arr[i] == arr[j])
            count++;
    }
    if (count == 1)
        Console.Write(arr[i] + " ");
}
*/


//5

/*
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int minIndex = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] < arr[minIndex])
    {
        minIndex = i;
    }
}
Console.WriteLine(minIndex);

*/




//6


/*
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int cnt = 0;

for (int i = 1; i < n - 1; i++)
{
    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
    {
        cnt++;
    }
}
Console.WriteLine(cnt);
*/


//7



/*
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int fst = 0, snd = 0;
bool fnd = false;

for (int i = 0; i <n-1; i++)
{
    if ((arr[i] > 0 && arr[i + 1] > 0) ||
        (arr[i] < 0 && arr[i + 1] < 0))
    {
        fst = arr[i];
        snd = arr[i + 1];
        fnd = true;
    }
}
if (fnd)
    Console.WriteLine(fst + " " + snd);

*/

//8


/*
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 != 0)
    {
        Console.Write(i + " ");
    }
}

*/



//9



/*

int n = int.Parse(Console.ReadLine());
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
int a = ab[0];
int b = ab[1];

int start = Math.Min(a, b);
int end = Math.Max(a, b);

for (int i = start + 1; i < end; i++)
{
    if (arr[i] % 2 != 0)
    {
        Console.Write(arr[i] + " ");
    }
}

*/


//10



int n = int.Parse(Console.ReadLine());
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 != 0) 
    {
        Console.Write(arr[i] * arr[i] + " ");
    }
}