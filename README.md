# exerciseFileAddedFromInput

Introduction
This C# console application allows users to create and manipulate a text file by adding custom lines of text. 
The program prompts the user to specify the number of lines they want to input, and then it collects the lines of text. 
The entered text is saved to a file named mytext. If the file already exists, it is deleted before the new content is added.

Usage

Run the application in Visual Studio Code or your preferred C# development environment.
The program will prompt you to input the number of lines you wish to add.
Enter the desired lines of text as per the prompt.
The program will create or overwrite the mytext file with the entered lines.
The content of the added text lines will be displayed on the console.

Code Explanation

Main Method

Initializes a string array ArrLines to store the lines of text.
Asks the user for the number of lines they want to input.
Collects the lines of text from the user and saves them to the ArrLines array.
Writes the content of the ArrLines array to a text file named mytext.
Reads and displays the content of the added text lines from the mytext file.

Note

The file name is set to mytext within the program (string fileName = @"mytext";). You can modify this filename based on your preferences.
Make sure to input a valid integer when specifying the number of lines to add.
The existing mytext file will be deleted before adding new content, and the program will display the updated content on the console.
