Console.Write("Enter a text: ");
string inputText = Console.ReadLine();
Console.Write("Enter a letter: ");
char letter = Convert.ToChar(Console.ReadLine());
bool has = false;
for (int i = 0; i < inputText.Length; i++) {
    if (inputText[i] == letter) {
        has = true;
		break;
    }
}
	if (has)
        Console.WriteLine($"There is a letter {letter}");
	else
        Console.WriteLine($"There is not any letter {letter}");
