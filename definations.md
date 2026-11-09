the class:
  it is reference type allocted in heap memory. It can have constructors,methods, properties, events, and fields. It can implement 
  interfaces and inherit from other classes. Instances of a class are created using the 'new' keyword.
  support all four pillars of object-oriented programming: encapsulation, inheritance, polymorphism, and abstraction.
the struct:
  it is value type allocated in stack memory. It can have constructors, methods, properties, and fields. It cannot inherit from other
  classes or implement interfaces. Instances of a struct are created without the 'new' keyword.
  support encapsulation and polymorphism but not inheritance and abstraction.
the interface:
  it is a reference type that defines a contract for classes and structs to implement. It can contain method signatures, properties,
  events, and indexers. Interfaces cannot have constructors or fields. Classes and structs can implement multiple interfaces.
  support abstraction and polymorphism but not encapsulation and inheritance.
the enum:
  it is a value type that defines a set of named constants. It can be used to represent a collection of related values. Enums cannot
  have methods, properties, or fields. Instances of an enum are created using the enum name and the constant value.
  support encapsulation but not inheritance, polymorphism, or abstraction.

  difference among casting,convert, parse, and tryparse:
  1-casting is used to convert one data type to another data type explicitly. It can be used for both reference types and value types.
	Casting can throw an exception if the conversion is not valid.
	double x= 10.5;
	int y= (int)x; //explicit casting

  2-convert is a class that provides methods to convert between different data types.
   It can be used for both reference types and value types.can throw an exception if the conversion is not valid.
   string str = "123";
   int num = Convert.ToInt32(str); //using Convert class

  3-parse is a method that converts a string into a specific data type.
   It can be used for both reference types and value types.
   string str = "123";
   int y= int.Parse(str); //using parse method

  4-tryparse is a method that attempts to convert a string into a specific data type and returns a boolean value 
   indicating whether the conversion was successful or not.
   It can be used for both reference types and value types. It does not throw an exception if the conversion fails.
   string str = "123";
   int y;
   bool success = int.TryParse(str, out y); //using tryparse method