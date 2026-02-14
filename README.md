# MoneyFellows Backend Quest

## Requirements
- .NET 8
- SQL Server
- RabbitMQ
- Docker

## How to Run
1. Run `docker-compose up` to start SQL Server and RabbitMQ.
2. Update connection strings in `appsettings.json`.
3. Run TransactionsService and PaymentsService.
4. Use Swagger UI to test APIs.

## Endpoints
- Transactions:
  - POST /transactions
  - POST /transactions/{id}/items
  - POST /transactions/{id}/submit
  - POST /transactions/{id}/cancel
- Payments:
  - POST /payments/start
  - POST /payments/{id}/confirm
  - POST /payments/{id}/fail
