# Unity Safe Loops 0.1.0
An extension for Unity that allows using custom functions to replace while loops, coroutines, for, and other types of cycles with "safe" variants that prevent infinite loops and subsequent engine crashes.

Just download the .dll file and add in your Assets folder.


Changelog:

v.0.1.0
  - created Safe.@while (function that replace normal while)

v.0.2.0
  - created Safe.CheckFor (function that replace "for" condition)
  - created Safe.@for (function that replace normal for)
  - incremented default iterations limit to 1000
