/*
1. Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
заменить большими «К», а большие «С» заменить на маленькие «с»
*/

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwert";
//             01234
// s[3] // r

string Raplace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)

    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Raplace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Raplace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine( );
newText = Raplace(newText, 'С', 'с');
Console.WriteLine(newText);
