[![McCoy Software Logo](McCoySoftware.png)](http://mccoysoftware.uk)

# .NetThisToThat
A simple .Net library of basic type conversion extensions.

### Install
The quickest way to include the library in your project is to install using NuGet.  
First [install NuGet](https://docs.nuget.org/consume/installing-nuget). Then, install [.NetThisToThat](https://www.nuget.org/packages/NetThisToThat/) from the package manager console.

    PM> Install-Package NetThisToThat

### How To Use

C#
```C#

int? myInt = myUlong.ToInt32Nullable();
byte myByte = "42".ToByteOrDefault(0);
bool? myBool = "True".ToBooleanNullable();
```




