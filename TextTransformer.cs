using System.Text;
using System.Text.RegularExpressions;
using static System.String;

namespace TextTransformer;

public class TextTransformer
{
    // Function to check if a sentence ends with a proper sentence boundary
    private static bool IsSentenceEnd(string sentence) => sentence.EndsWith(".") || sentence.EndsWith("!") || sentence.EndsWith("?");

    // Function to capitalize the first letter of a sentence
    private static string CapitalizeSentence(string sentence)
    {
        if (IsNullOrWhiteSpace(sentence))
            return sentence;

        // Capitalize only the first character if it's a letter
        return char.ToUpper(sentence[0]) + sentence.Substring(1);
    }

    public string TransformTextToParagraphs(string plainText, int sentencesPerParagraph = 3)
    {
        // Clean up extra line breaks and spaces from the input
        var cleanedText = Regex.Replace(plainText, @"\s+", " ").Trim();

        // Split sentences based on common sentence-ending punctuation, considering possible newline
        var regex = new Regex(@"(?<=[.!?])\s+|(?<=[.!?])\n+");
        var sentences = regex.Split(cleanedText);

        var formattedText = new StringBuilder();
        var sentenceCount = 0;

        foreach (var sentence in sentences)
        {
            // Trim any extra spaces
            var trimmedSentence = sentence.Trim();
            if (IsNullOrEmpty(trimmedSentence)) continue; // Skip empty sentences

            // Capitalize the first letter of the sentence
            trimmedSentence = CapitalizeSentence(trimmedSentence);

            formattedText.Append(trimmedSentence + " ");

            // Check if this sentence ends with a valid sentence boundary and count it
            if (IsSentenceEnd(trimmedSentence))
            {
                sentenceCount++;
            }

            // After the specified number of sentences, add a paragraph break
            if (sentenceCount >= sentencesPerParagraph)
            {
                formattedText.Append("\n\n"); // Insert paragraph break
                sentenceCount = 0; // Reset sentence counter for the next paragraph
            }
        }

        return formattedText.ToString().Trim(); // Return the final formatted text
    }
}