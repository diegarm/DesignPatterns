𝐖𝐡𝐚𝐭 𝐢𝐬 𝐭𝐡𝐞 𝐒𝐭𝐚𝐭𝐞 𝐏𝐚𝐭𝐭𝐞𝐫𝐧?

Why is useful? 👇 

The State Pattern is a behavioral design pattern that 𝐚𝐥𝐥𝐨𝐰𝐬 𝐚𝐧 𝐨𝐛𝐣𝐞𝐜𝐭 𝐭𝐨 𝐚𝐥𝐭𝐞𝐫 𝐢𝐭𝐬 𝐛𝐞𝐡𝐚𝐯𝐢𝐨𝐫 𝐰𝐡𝐞𝐧 𝐢𝐭𝐬 𝐢𝐧𝐭𝐞𝐫𝐧𝐚𝐥 𝐬𝐭𝐚𝐭𝐞 𝐜𝐡𝐚𝐧𝐠𝐞𝐬. 
It appears as if the object has changed its class. 

This pattern is particularly useful for implementing finite-state machines in object-oriented programming.

Consider a traffic light system with three states: Red, Yellow, and Green. 

Each of these states can be represented by a separate class that implements a common interface.

You can see the implementation below.

The TrafficLight object changes its behavior based on its internal state, which transitions from Red to Yellow to Green and back to Red. 

This is achieved without if-else or switch-case statements, making the code more maintainable and scalable.

In my "Design Patterns Simplified" ebook I explained 10 Design patterns in a similar way (real-world example, code implementation, etc.).