# Zoo
Repository for Zoo project (OOP principles lab) for seattle-dn-401d6 

## Day 5 and 6 lab: Zoo
This lab covers some of the basic object-oriented principles for the C# language, including inheritance, abstraction, polymorphism, and encapsulation.
This lab also shows how an interface can be defined and implemented in a class.
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

Part two:
- Create a minimum of 2 interfaces.
- Each interface created should be implemented by more than one class.
- Have at least one class implement more than one interface
- Test your code with Unit testing
- When running your application, it should output each of the concrete animals and one behavior that it has inherited without any direct code manipulation

#### On interfaces (README requirement from part two)
An interface essentially acts as a guarantee or contract that any class that implements the interface *must* implement every method or property within the interface. The interface does not (and cannot) implement the elements it contains; instead, it only defines a signature that must be fulfilled that the interface is attached to. Because the interface does not care about implementation, it lets a developer group disparate classes by what they can do, not what they are (as inheritance groups classes) or how they do it.
The two interfaces in this zoo are IFly and IHibernate.
- IFly is an interface for animals that can fly. It requires a boolean property of the current state of flight, as well as two methods for taking off and landing. The two classes derived from the Bird class and the Dragon class implement this interface, as all three of them should have the ability to fly.
- IHibernate is an interface for animals that hibernate, typically during the winter. It requires a boolean property for the current state of hibernation, as well as two methods for starting and stopping hibernation. The Snake class inherits this from the Reptile class, and the Dragon class implements it directly.


#### Screen captures:
- ![System Design Image w/o interfaces](https://github.com/Dervival/Lab0506-Zoo/blob/master/ZooSystemDesign.PNG);
- ![System Design Image w interfaces](https://github.com/Dervival/Lab0506-Zoo/blob/master/ZooSystemDesignWithInterfaces.PNG);
- ![Sample output of program](https://github.com/Dervival/Lab0506-Zoo/blob/master/Output.PNG);
