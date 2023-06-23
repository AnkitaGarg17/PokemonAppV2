
# Pokémon Console Application

This application allows you to retrieve information about Pokémon strengths and weaknesses against other types.

## Installation

To run the Pokémon console application locally, you need to have [.NET Core](https://dotnet.microsoft.com/download) installed on your machine.

1. Open a command prompt or terminal and navigate to the directory you want to save the project.
2. Clone this repository to your local machine using the following command: git clone https://github.com/AnkitaGarg17/PokemonAppV2.git
3. Run command: ```cd PokemonAppV2```
4. Build the application by running command: ```dotnet build```
5. Run command: ```cd Latest_PokemonApp```
6. Run the application: ```dotnet run```
7. Enter the name of the Pokémon you want to get strengths and weaknesses for.
8. The application will display the strengths and weaknesses of the Pokémon against other types

 #Example -
``` 
Latest_PokemonApp % dotnet run
Enter pokemon name?
ditto
Pokemon ditto's Strengths:
ghost

Pokemon ditto's Weaknesses:
fighting
rock
steel
ghost

Latest_PokemonApp % dotnet run
Enter pokemon name?
ivysaur
Pokemon ivysaur's Strengths:
ground
rock
water
grass
electric
fairy
fighting
poison
bug

Pokemon ivysaur's Weaknesses:
flying
poison
bug
fire
ice
steel
grass
dragon
ground
psychic
rock
ghost
```

## Error Handling
If you encounter any errors or the application does not return any data for a Pokémon, ensure the following:

The Pokémon name is spelled correctly.
Your internet connection is stable.
The PokéAPI is available and accessible.

## Dependencies

This application utilizes the following dependencies:
- System.Text.Json - A popular JSON framework for .NET.
