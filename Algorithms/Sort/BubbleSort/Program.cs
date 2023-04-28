// Sample array
int[] a = { 3, 0, 2, 5, -1, 4, 1 };
Console.WriteLine("First Array :");
foreach (int item in a)
    Console.Write(item + " ");

// Về bản chất Bubble Sort giống như Swap nhưng chậm hơn
for (int i = a.Length - 1; i >= 1; i--)
{
    bool swapped = true;
    for (int j = 0; j < i; j++)
    {
        if (a[j] > a[j + 1])
        {
            int temp = a[j];
            a[j] = a[j + 1];
            a[j + 1] = temp;
            swapped = false;
        }
    }
    if (swapped)
    {
        break;
    }
}

//Ban đầu: 3, 0, 2, 5, -1, 4, 1
//Step 1: a[0] = 3 so với a[1] = 0, 3 > 0 --> swap --> 0 3 2 5 -1 4 1 
//Step 2: a[1] = 3 so với a[2] = 2, 3 > 2 --> swap --> 0 2 3 5 -1 4 1
//Step 3: a[2] = 3 so với a[3] = 5, 3 < 5 --> ko đổi
//Step 4: a[3] = 5 so với a[4] = -1, 5 > -1 --> swap --> 0 2 3 -1 5 4 1
//.............

// Output after sorted
Console.WriteLine("\n" + "Sorted array :");
foreach (int item in a)
    Console.Write(item + " ");
Console.Write("\n");
