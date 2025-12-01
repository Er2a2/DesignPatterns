//client
using BasicExample.Creators;

Creator creatorA = new ConcreteCreatorA();
creatorA.Run();

Creator creatorB = new ConcreteCreatorB();
creatorB.Run();