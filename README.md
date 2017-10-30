# bridger-library
honn verkefni 2

## Commands for setting up project the first time

### Creating project

dotnet new webapi -- creates a new (web) api project

dotnet new classlib -- creates a new class library project

### Adding project dependencies

dotnet add _link to csproj file to add to_ reference _link to csproj file that is to be added_ -- if you are in the folder that holds the csproj that you are going to be adding to then you can drop the first link reference

dotnet restore -- restores the project in question and updates if there are changes in the csproj file (such as adding new dependencies)

