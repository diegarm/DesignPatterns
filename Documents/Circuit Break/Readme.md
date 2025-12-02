How to make the system more resilient and fault-tolerant?

Did you hear about 𝐂𝐢𝐫𝐜𝐮𝐢𝐭 𝐁𝐫𝐞𝐚𝐤𝐞𝐫 𝐏𝐚𝐭𝐭𝐞𝐫𝐧?💡

The Circuit Breaker pattern is a software pattern that helps to 𝐩𝐫𝐞𝐯𝐞𝐧𝐭 𝐜𝐚𝐬𝐜𝐚𝐝𝐢𝐧𝐠 𝐟𝐚𝐢𝐥𝐮𝐫𝐞𝐬 𝐢𝐧 𝐚 𝐬𝐲𝐬𝐭𝐞𝐦 by introducing a layer of protection. This pattern is often used in distributed systems to provide a mechanism for failing fast, to prevent the system from becoming overwhelmed and unresponsive.

There 𝐚𝐫𝐞 𝐭𝐡𝐫𝐞𝐞 𝐬𝐭𝐚𝐭𝐞𝐬 that a circuit breaker can be in:

• 𝐂𝐥𝐨𝐬𝐞𝐝: In the closed state, the circuit breaker 𝐚𝐥𝐥𝐨𝐰𝐬 𝐫𝐞𝐪𝐮𝐞𝐬𝐭𝐬 𝐭𝐨 𝐩𝐚𝐬𝐬 through to the underlying system. That is the normal operating state for a circuit breaker.

• 𝐎𝐩𝐞𝐧: When the circuit breaker is in the open state, it 𝐬𝐭𝐨𝐩𝐬 𝐚𝐥𝐥 𝐫𝐞𝐪𝐮𝐞𝐬𝐭𝐬 from being sent to the underlying system. That is done to prevent further failures and to give the system a chance to recover.

• 𝐇𝐚𝐥𝐟-𝐎𝐩𝐞𝐧: In the half-open state, the circuit breaker 𝐚𝐥𝐥𝐨𝐰𝐬 𝐚 𝐥𝐢𝐦𝐢𝐭𝐞𝐝 𝐧𝐮𝐦𝐛𝐞𝐫 𝐨𝐟 𝐫𝐞𝐪𝐮𝐞𝐬𝐭𝐬 𝐭𝐨 𝐩𝐚𝐬𝐬 through to the underlying system. That is done to see if the system can handle requests again, without overwhelming it. If requests are successful, the circuit breaker will transition back to the closed state. If requests fail, the circuit breaker will return to the open state.

𝐑𝐞𝐚𝐥-𝐖𝐨𝐫𝐥𝐝 𝐄𝐱𝐚𝐦𝐩𝐥𝐞:

Let's say we have an e-commerce website that uses an external payment processing service. 
The website sends requests to the payment processing service to charge customers' credit cards when they make a purchase.

If the payment processing service experiences a failure, such as a server outage, it may be unable to handle the requests from the e-commerce website. That could cause the website to become unresponsive or even crash.

We can prevent this by using a circuit breaker on an e-commerce website to protect itself from the payment processing service's failures.

The circuit breaker will monitor the payment processing service for a failure. If a failure is detected, it will trip the circuit breaker, transitioning it to the open state. That will stop the e-commerce website from sending requests to the payment processing service, preventing the website from becoming overwhelmed and unresponsive.

Once the payment processing service can recover, the circuit breaker can be reset to the half-open state. That will allow a limited number of requests to be sent to the payment processing service to see if it can handle them without failing again.

- If the requests are successful, the circuit breaker will transition back to the closed state.
- If the requests fail, the circuit breaker will return to the open state.

When we use a circuit breaker in this way, the e-commerce website can continue to operate, even in the face of failures in the payment processing service. That helps to make the website more resilient and fault-tolerant.