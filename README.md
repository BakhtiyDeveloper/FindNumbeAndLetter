> # Welcome to the project FindNumberAndLetter

## Overview

### This program determines the number of letters and numbers in the entered text. It prompts the user for text input, counts the number of letters and numbers, and then displays the counts.

## The project consists of the following sections. 

1. Enter Text:

    * The program will ask you to enter text.
    * Enter the desired text and press Enter.

2. View Results:

    * The program displays the number of letters and numbers found in the entered text.

Example

If you enter the text HelloWorld123:

* The program displays the number of letters and numbers found in the entered text.

* The output will be:

``` 
'''
the number of letters in the text : 10
the number of numbers in the text : 3

'''
```

## Code Explanation

1. Variables:

    * `lettersCount`: Keeps track of the number of letters. 
    * `numbersCount`: Keeps track of the number of numbers.
    * `letters`: Stores the letters found in the text.
    * `numbers`: Stores the numbers found in the text.

```cs 
'''
int lettersCount = 0;
int numbersCount = 0;
string letters = "";
string numbers = "";

'''
```

2. Loop Through Input:

    * The program loops through each character in the input string.
    * It checks if the character is a digit using char.IsDigit(c).
    * It checks if the character is a letter using char.IsLetter(c).
    * Depending on the character type, it updates the respective count and string.

```cs 
'''
foreach (char c in userInput)
{
    if (char.IsDigit(c))
    {
        numbers += c;
        numbersCount++;
    }
    else if (char.IsLetter(c))
    {
        letters += c;
        lettersCount++;
    }
}

'''
```
3. Display Results:

    * After processing the input, the program displays the counts of letters and numbers.

![result to img](/Image/image.png)

4. Result to GIF:

![result to gif](/GIF/result%20gif.gif)

Download the program [FinNumbersAndLetters](https://drive.google.com/file/d/1cU5Wt4VtX_sNFMVq1_lncYK24Dzt3gCM/view?usp=sharing).

> # I'm glad you are using the program.