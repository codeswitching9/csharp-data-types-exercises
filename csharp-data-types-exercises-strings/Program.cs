// Strings
string alice = @"Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

Console.WriteLine(alice);
Console.WriteLine("What word would you like to look for in the above sentence?");
string searchTerm = Console.ReadLine();
string compareSearchTerm = searchTerm.ToLower();
string compareAlice = alice.ToLower();

if (compareAlice.IndexOf(compareSearchTerm, 0) != -1)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}

int index = alice.IndexOf(searchTerm);
int searchTermLength = searchTerm.Length;
Console.WriteLine("Your search term first occurs at index " + index + ", and your term is " + searchTermLength + " characters long.");
string updatedSentence = alice.Replace(searchTerm, "");
Console.WriteLine(updatedSentence);