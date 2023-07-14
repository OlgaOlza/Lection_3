// Задача 
// Необходимо заменить пробелы черточками
// Маленькие буквы "к" заменить на большие "К",
// Большие "С" заменить на маление "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послалт вместо нашего милого Винценгероде,"
            + "вы бы взяли присткпом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s [3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
return result;
}
string newText = Replace(text, " ", "|" );
Console.WriteLine(newText);
Console.WriteLine();
char newText = Replace(newText, "к", "К" );
Console.WriteLine(newText);