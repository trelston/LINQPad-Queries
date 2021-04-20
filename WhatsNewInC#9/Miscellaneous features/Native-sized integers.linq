<Query Kind="Statements" />

// C# 9 includes keywords for System.IntPtr and System.UIntPtr ("native-sized integers")

//nint is equivalent to System.IntPtr
//nuint is equivalent to System.UIntPtr

(typeof (nint) == typeof (IntPtr)).Dump();
(typeof (nuint) == typeof (UIntPtr)).Dump();

nint x = IntPtr.Zero;
nuint y = 234;

new {x, y}.Dump();

// Should you declare your own type called 'nint' or 'nuint',
// your type wins and the new keywords are masked.
