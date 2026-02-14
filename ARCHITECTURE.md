# Architecture

## Diagram
Transactions Service → RabbitMQ → Payments Service → RabbitMQ → Transactions Service

## Components
- **Transactions Service**: Manages transactions and items.
- **Payments Service**: Manages payments linked to transactions.
- **RabbitMQ**: Event broker.
- **SQL Server**: Persistent storage.
- **Outbox Pattern**: Ensures reliable event publishing.

## Trade-offs
- RabbitMQ chosen for simplicity and reliability.
- Outbox Pattern chosen to avoid lost events.
- Idempotency ensures duplicate events do not cause errors.
- DLQ handles failed events safely.
