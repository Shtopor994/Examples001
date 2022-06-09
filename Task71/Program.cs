/*
Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, 
ав, ва, ви, ив, св, вс
*/

void UniqWords(string alfabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{new String(word)}");
    }
    else
    {
    for (int i = 0; i < alfabet.Length; i++)
    {
        word[length] = alfabet[i];
        UniqWords(alfabet, word, length + 1);
    }
    }
}
UniqWords("аисв", new char[2]);

