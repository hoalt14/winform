# some application by winform

* set form parent
```
Properties -> IsMdiContainer -> True
```

* set two primary key
```
press crtl + shift -> right mouse click
```

* remove database connect string
```
Open VS 2015

View -> Server Explorer -> Data Connections
```

* remove recent project

```
The MRU list just moved for VS 2015. It's still stored in the registry, it's just in a different place.

Open regedit and delete the items in:

Recent Projects
HKEY_CURRENT_USER\SOFTWARE\Microsoft\VisualStudio\14.0\MRUItems\{a9c4a31f-f9cb-47a9-abc0-49ce82d0b3ac}\Items

Recent Files
HKEY_CURRENT_USER\SOFTWARE\Microsoft\VisualStudio\14.0\MRUItems\{01235aad-8f1b-429f-9d02-61a0101ea275}\Items

Restart Visual Studio and that should do it.
```
