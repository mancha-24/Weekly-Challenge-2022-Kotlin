Console.WriteLine("Please, write a sentence: (what ever you want!! :D)"); 
var sentence = Console.ReadLine();

if(!string.IsNullOrWhiteSpace(sentence))
{
    var words = sentence.Split(' ').ToList();
    var wordLargest = words.Where(c => !string.IsNullOrWhiteSpace(c))
                            .OrderByDescending(c => c.Length).FirstOrDefault();
    
    DrawLine(wordLargest.Length);

    words.ForEach(c => Console.WriteLine($"* {c}{"".PadRight(wordLargest.Length - c.Length + 1, ' ')}*"));
    
    DrawLine(wordLargest.Length);

    Console.ReadKey();
}

static void DrawLine(int tam) => Console.WriteLine("".PadLeft(tam + 4, '*'));



