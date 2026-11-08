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