//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
//задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
//обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}  ");
        }
}
void NewArray(string[] array)
{  
    string[] new_array = new string [array.Length];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
                {
                    new_array[i] = array[i];
                    Console.Write($"{new_array[i]}   ");
                }
        }
}


string[] words = {"Hello", "12", "Programs", "Yes", "))))", "!!", ":-)", "3", "No", "987"};
PrintArray(words);
Console.WriteLine();
NewArray(words);

