# Zoo
Repository for Zoo project (OOP principles lab) for seattle-dn-401d6 

## Day 5 and 6 lab: Zoo
This lab covers some of the basic object-oriented principles for the C# language, including inheritance, abstraction, polymorphism, and encapsulation.
This lab also shows how an interface can be defined and implemented in a class.

## Day 5 - OOP Principles

#### Directions
Using all 4 of the Object Oriented Principles (OOPs): 
- Build out the hierarchical class structure of the animals within a zoo within Visual Studio and a digital diagram. 
- There should be at least 3 layers of inheritance with at least 5 different types of animals.
- Prove that the OOP principles are being used by returning strings as necessary to prove that a methods were property implemented or inherited.

Include the following labels on the diagram:
-Label the parent and derived classes
-Label the abstract classes and concrete classes
-Label the access modifiers for each of the classes
-Label where you are using Polymorphism in your program. Where are the virtual and abstract methods defined, and where are they being overridden?

Your program class should instantiate each of the concrete animals to prove the functionality of it’s base classes.

#### Requirements
Part one:
- Include a digital drawing of the system design of your zoo
- Your drawing of your zoo diagram should be clearly labeled
- Have at least 3 different abstract classes
- Have at least 3 layers of inheritance
- Have at least 5 concrete animals
- Have at least 2 abstract methods (make sure you override them)
- Have at least 2 abstract Properties (make sure you override them)
- Have at least 2 virtual methods (make sure you override at least one of them)
- Have at least 2 virtual properties (make sure you override at least one of them)

Additionally, in the Readme complete the following:
- An introduction to the project
- Your digital drawing of your zoo
- Create your own technical documentation. Breakdown and define each of the OOP principles in your own words.
- Provide under each OOP definition a couple (you do not have to define all) of examples of how you are applying this into your project

#### Digital Drawing
- ![System Design Image w/o interfaces](https://github.com/Dervival/Lab0506-Zoo/blob/master/UpdatedZooSystemDesign.PNG);

#### Techincal Documentation
- Inheritance: In all object-oriented languages, a class can use not only properties and methods that it has defined for itself but also anything that it has inherited from another class. For instance, if class A defines a property IsRed and a method ReadRed() and class B defines property IsBlue and a method BrewBlue(), if B inherits from A, B has access to IsRed, IsBlue, ReadRed() and BrewBlue(). C# only supports single inheritance - class B can only inherit from A or C, but not both. However, inheritance is transitive; if C inherits from B and B inherits from A, C has also inherited from A (assuming that the sealed keyword was not invoked, preventing inheritance of the sealed item in general). In C#, the class that is being inherited from is the base class, and the class that is inheriting is the derived class. Some examples of this in my zoo are the derived Pidgeon class, who inherits the property hasWings from the base Bird class, and the derived Corgi class, who inherits IsReal from the derived Dog class, who in turn inherited IsReal from the base Mammal class.
- Abstraction: A class does not necessarily need to be instantiatable in order to be useful. For instance, if we want to create a base class with common properties and methods of different vehicles, we can use abstraction to create an abstract Vehicle class whose purpose is to have all its contents inherited by a derived concrete Car or Truck class that is designed to be instantiated. Abstract classes can be thought of as general blueprints to be used to create an actual object; objects cannot be made out of them directly, as they can be missing information or implementation details. The Animal, Mammal, Bird, Reptile and Dog classes were abstract classes for this zoo, all of which have other classes inheriting from them; the Corgi, Samoyed, Pidgeon, Eagle, Snake, and Dragon classes were instantiatable concrete classes.
- Polymorphism - Not only can derived classes inherit properties and methods from their base classes, they can also change them through polymorphism. For instance, if class A from the Inheritance documentation above has set IsRed to true, class B can inherit that property but then override it to a different value (of the same type). This polymorphic ability is associated with two keywords for methods and properties: abstract and virtual. Abstract methods and properties must be overridden at some point before an object is made, whether that be in an intermediary abstract class or at a final concrete class, and cannot provide any implementation details. Virtual methods and properties can but are not required to be overridden, and must provide a default implementation that will be directly inherited if not overridden. Both abstract and virtual keywords are limited to non-concrete classes. There are also concrete methods and properties that can be called at any level - this is the standard for default methods and properties. In my zoo, there is an abstract property IsReal in the Animal Class that is overridden at the Snake and Dragon classes, and an abstract method named BrushSelf() in the Dog class that is overridden in both the Corgi and Samoyed classes. There is a virtual property called NumberOfLegs that is inherited by Dog and overridden by Bird, and a virtual property HasFur in the Dog class that is never overridden. There is also a virtual method named Firebreath() that is overridden by the Dragon class but is directly inherited by the Snake class (the other virtual method, Walk(), is overridden at some point by all concrete classes).
- Encapsulation - In general, encapsulation is just the process of grouping (usually related) items in some sort of logical package or structure. In C# (and programming in general), this is done through the organization of classes and various access modifiers that allow or prevent access to a class's methods and properties based on where the attempted access is coming from in the program. There are three common access modifiers that are common to all languages - public, where the method or property is accessible from anywhere; protected, where they are only accessible from the class they are defined in or any classes derived from that base class; and private, which is only accessible from within the same class. By default in C#, classes, methods, and properties have the private access modifier and must be overridden with the public or protected keyword to change that access modifier. For this zoo, though not documented on the system design document, I exclusively used the public access modifier for ease of testing; for instance, the Corgi class's Flop() method, the Bird class's IsReal property, and all instances of Animal.AnimalName are publicly accessible so that I could directly call or use them in Main to print to the console. 

## Day 6 - Interfaces
Part two:
- Create a minimum of 2 interfaces.
- Each interface created should be implemented by more than one class.
- Have at least one class implement more than one interface
- Test your code with Unit testing
- When running your application, it should output each of the concrete animals and one behavior that it has inherited without any direct code manipulation

#### Technical Documentation - Interfaces
An interface essentially acts as a guarantee or contract that any class that implements the interface *must* implement every method or property within the interface. The interface does not (and cannot) implement the elements it contains; instead, it only defines a signature that must be fulfilled that the interface is attached to. Because the interface does not care about implementation, it lets a developer group disparate classes by what they can do, not what they are (as inheritance groups classes) or how they do it.
The two interfaces in this zoo are IFly and IHibernate.
- IFly is an interface for animals that can fly. It requires a boolean property of the current state of flight, as well as two methods for taking off and landing. The two classes derived from the Bird class and the Dragon class implement this interface, as all three of them should have the ability to fly.
- IHibernate is an interface for animals that hibernate, typically during the winter. It requires a boolean property for the current state of hibernation, as well as two methods for starting and stopping hibernation. The Snake class inherits this from the Reptile class, and the Dragon class implements it directly.

#### Sample input
No inputs for this project.

#### Sample output
The program will output an instance of each of the concrete animals and all the behaviors its behaviors including inherited and overwritten behaviors.
See the bottom two pictures below.

#### Screen captures:
- ![System Design Image w interfaces](https://github.com/Dervival/Lab0506-Zoo/blob/master/UpdatedZooSystemDesignWithInterfaces.PNG);
- ![Part one of sample output of program](https://github.com/Dervival/Lab0506-Zoo/blob/master/OutputOne.PNG);
- ![Part two of sample output of program](https://github.com/Dervival/Lab0506-Zoo/blob/master/OutputTwo.PNG);
