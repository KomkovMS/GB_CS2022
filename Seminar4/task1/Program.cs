bool isPalindromeLight(int[] arr) {
    bool result = false;
    const N = arr.Lenght;
    for (int i = 0; i < N / 2; i++) {
        if (arr[i] != arr[N - i - 1]) {
            Console.WriteLine("Not Polindrom");
            return result;
        }
    }
    result = true;
    Console.WriteLine("Polindrom");

    return result;
}


int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
isPalindromeLight(arr);