# TextTransformer

## Overview

The `TextTransformer` project is a C# application designed to transform plain text into well-formatted paragraphs. It organizes text by grouping sentences into paragraphs, with a default of three sentences per paragraph. The application ensures that each sentence starts with a capital letter and maintains proper sentence boundaries.

## Features

- **Sentence Capitalization**: Automatically capitalizes the first letter of each sentence.
- **Sentence Boundary Detection**: Recognizes common sentence-ending punctuation (., !, ?) to properly format text.
- **Paragraph Formatting**: Groups sentences into paragraphs, with a configurable number of sentences per paragraph.
- **Whitespace Cleanup**: Removes unnecessary spaces and line breaks from the input text.

## Installation

1. Ensure you have the .NET SDK installed on your machine. You can download it from the [.NET website](https://dotnet.microsoft.com/download).

2. Clone the repository or download the source code.

   ```bash
   git clone https://github.com/0samaHaider/TextTransformer.git
