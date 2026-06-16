# FileDuplicator
## Description
This program duplicates and adds an incrementing counter to the new file. It is primarily used to duplicate new versions
of weekly reports for the mandatory "IHK - Wochenbericht".


## Getting started
1. Clone the repository
```
git clone https://github.com/noodles-png/FileDuplicator.git
```
2. Open Program.cs and change directory path
```csharp 
    var program  = FileDuplicator(
        @"C:\Your\folder\here")
```
3. Run the program:
``` 
cd FileDuplicator
dotnet run
```
### Building as .exe
```
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```
The executable program will be in `bin/Release/net10.0/win-x64/publish/`.

## Configuration
The counter is searched via the keyword KW ("Kalenderwoche": german for calendar week"). It can be changed to any other 
keyword, the relevant section can be found in FileDuplicator.cs: 

```csharp
int kwIndex = srcFile.LastIndexOf("kw", StringComparison.OrdinalIgnoreCase);
```

```csharp
newName = prefixName + "KW" + newCounter.ToString("D2");
```