<Query Kind="Expression" />

//Checklist
//1. Identify processes that involve several steps, each of which might fail in predictable ways
//2. Write a DU that enumerates the kinds of errors that can occur.
//	 Some cases might just identify the kind of error; others might have a payload with more info
//3. Write a function for each step in your process.
//	 Each should take a non-wrapped input and return either a good output in the form of a Result.Ok
//	 that wraps the step's successful output, or a Result.Error that wraps a case from your error-types DU
//4. Compose the steps into a single pipeline. To do this, wrap each function but the first using Result.bind
//	or Result.map(for operations that cannot fail). Compose the wrapped functions with the function composition
//	operator >>
//5. Use Result.mapError at the end of the pipeline to process failure cases, for e.g., by attaching error messages
//	or writing to a log