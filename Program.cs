//Task 1
// void myPower(int num, int pow){
//     int temp = 1;
//     for(int i = 1; i <= pow; i++ ){
//         temp *= num; 
//     }
//     Console.WriteLine($"{num}"); 
// }

//Task 2
// void sumOfNums(int num){
//     int sum = 0;
//     while(num != 0){
//         sum += num % 10;
//         num /= 10;
//     }
//     Console.WriteLine($"{sum}");
// }

//Task 3

void toArray(){
    Console.WriteLine("Ввод чисел остановится после введения 0 ");
    List<int> arr = new List<int>();
    int count = 0;
    int num = 0;
    Console.WriteLine("Введите последовательность чисел  : ");
    do{
        num = Convert.ToInt32(Console.ReadLine());
        if(num != 0){
            arr.Add(num);
        }
        count++;
    }while(num != 0);
    for(int i = 0; i < arr.Count; i++){
        Console.Write($"{arr[i]} ");
    }
}

//Task 1
// Console.WriteLine("Введите число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень в которую надо возвести : ");
// int pow = Convert.ToInt32(Console.ReadLine());
// myPower(num, pow);

//Task 2
// Console.WriteLine("Введите число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// sumOfNums(num);

//Task 3
toArray();