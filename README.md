[![McCoy Software Logo](McCoySoftware.png)](http://mccoysoftware.uk)

# .NetThisToThat

[![Join the chat at https://gitter.im/DanMcCoy/.NetThisToThat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/DanMcCoy/.NetThisToThat?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
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




