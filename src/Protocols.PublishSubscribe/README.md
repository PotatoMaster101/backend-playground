# Publish Subscribe (Pub/Sub)
1. Topics (or channels) are defined on the server.
    - Publishers send messages to topics, and subscribers can receive messages from specific topics.
2. Publisher sends a message (or messages) to a topic.
3. Message broker (like RabbitMQ/Kafka) receives the message from the publisher and sends it to interested subscribers.
4. Subscribers receive the message from the message broker and process the message.

## Pros
- Scales well with multiple publishers and subscribers.
- Loose coupling, publishers and subscribers don't need to know each other.
- Publishers (or clients) can disconnect once the message is published to the message broker.

## Cons
- Hard to control message delivery, e.g. a message got lost, or a message got consumed twice.
