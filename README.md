# some application by winform

## note in VS 2015

- set form parent

```edit
Properties -> IsMdiContainer -> True
```

- remove database connect string

```edit
Open VS 2015

View -> Server Explorer -> Data Connections
```

- remove recent project

```edit
The MRU list just moved for VS 2015. It's still stored in the registry, it's just in a different place.

Open regedit and delete the items in:

Recent Projects
HKEY_CURRENT_USER\SOFTWARE\Microsoft\VisualStudio\14.0\MRUItems\{a9c4a31f-f9cb-47a9-abc0-49ce82d0b3ac}\Items

Recent Files
HKEY_CURRENT_USER\SOFTWARE\Microsoft\VisualStudio\14.0\MRUItems\{01235aad-8f1b-429f-9d02-61a0101ea275}\Items

Restart Visual Studio and that should do it.
```

## note in SQL Server 2014 Management Studio

- reset Identity column values

```edit
dbcc checkident('table name', RESEED, 0)
```

- set two primary key

```edit
press crtl + shift -> right mouse click
```

- export database

```edit
Right click database => Tasks => Generate Scripts...
=> Introduction (press Next)
=> Choose Objects (select "Script entire database and all database objects" -> press Next)
=> Set Scripting Options (default -> change File name if need -> edit "Advanced" -> Types of data to script -> Schema and data)
=> Summary (press Next)
=> Save or Publish Scripts (press Next -> Finish)
```

- import database

```edit
create new query -> open file sql -> copy paste -> edit connect string -> press excute query
