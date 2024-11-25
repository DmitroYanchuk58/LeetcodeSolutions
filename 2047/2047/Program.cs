var count = CountValidWords("  okkx3el1rmzwqfimm  jcn vham ");
Console.WriteLine(count);
static int CountValidWords(string sentence)
{
    if (string.IsNullOrEmpty(sentence))
    {
        return 0;
    }

    string[] tokens = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);


    int result = 0;
    foreach (string word in tokens)
    {
        if (IsWordValid(word))
        {
            result++;
        }
    }

    return result;
}
static bool IsWordValid(string word)
{
    
    if (string.IsNullOrEmpty(word))
    {
        return false;
    }

    bool hasHyphen = false;
    bool hasPunctuation = false;

    for (int i = 0; i < word.Length; i++)
    {
        char c = word[i];

        if (char.IsDigit(c))
        {
            return false;
        }

        if (c == '-')
        {
            if (hasHyphen || i == 0 || i == word.Length - 1 || !char.IsLower(word[i - 1]) || !char.IsLower(word[i + 1]))
            {
                return false;
            }
            hasHyphen = true;
        }

        if (c == '!' || c == '.' || c == ',')
        {
            if (hasPunctuation || i != word.Length - 1)
            {
                return false;
            }
            hasPunctuation = true;
        }

        if (!char.IsLower(c) && c != '-' && c != '!' && c != '.' && c != ',')
        {
            return false;
        }
    }

    return true;

}
