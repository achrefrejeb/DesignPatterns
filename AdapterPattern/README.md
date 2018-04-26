# Adapter Pattern
Adapter (or wrapper) pattern is a structural design pattern. It is used to make existing classes work with others without modifying their source code.
It means that the pattern involves a single class which is responsible to join functionalities of independent or incompatible interfaces.
In my sample, which I found it very helpful to understand the utility of using this pattern, I made the Charger class working with any mobile phone by introducing the phone adapter which implement the IChargeable interface and encapsulate the phone class.
