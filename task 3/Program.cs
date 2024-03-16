Random random = new Random();
int RandomInt() {
    return random.Next(0, 1000);
}

void FillArray(int[] array, int index) {
    if(index >= array.Length) return;
    array[index] = RandomInt();
    FillArray(array, ++index);

}

void PrintIntReverse(int[] array, int index) {
    if(index < 0) return;
    Console.WriteLine(array[index]);
    PrintIntReverse(array, --index);
}
int size = 0;
int[] arr;
Console.WriteLine("Введите размер массива: ");
size = Convert.ToInt32(Console.ReadLine());

arr = new int[size];
FillArray(arr, 0);
Console.WriteLine("Сгенерированный массив: ");
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("Перевернутый массив: ");
PrintIntReverse(arr, size - 1);



