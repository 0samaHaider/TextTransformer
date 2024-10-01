var transformer = new TextTransformer.TextTransformer();

// Prompt the user for input
Console.WriteLine("Please enter your text (press Enter when done):");
var plainText = Console.ReadLine(); // Take user input

// Transform the user input into paragraphs with 3 sentences per paragraph
var transformedText = transformer.TransformTextToParagraphs(plainText!);

// Print the formatted text
Console.WriteLine("\nFormatted text:\n");
Console.WriteLine(transformedText);