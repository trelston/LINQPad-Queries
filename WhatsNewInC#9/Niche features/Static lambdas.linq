<Query Kind="Statements" />

// In C# 9, you can prefix a lambda expression or anonymous method with 'static' if the function does 
// not capture local state:
"This is a test".Select(static c => char.ToUpper(c)).Dump();

string someLocalvariable = ".";

// The following fails to compile, because we're attempting to capture someLocalVariable:
// "This is a test".Select(static c => char.ToUpper(c) + someLocalvariable).Dump();

// Static anonymous functions have no effect on the compilation output - the IL is the same with
// or without 'static'. Nonetheless, the can be useful when micro-optimizing a code hotpath.
// Should you write a section of code such that optimal performance depends on not incurring any
// memory allocations, applying the 'static' keyword to lambda expressions protects you from 
// later modifying the lambda expression such that it captures variables, unintentionally breaking
// your optimization.