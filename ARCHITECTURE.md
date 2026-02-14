# Architecture

## Layers
- Domain: الكيانات والأحداث.
- Application: الخدمات وقواعد الأعمال.
- Infrastructure: قواعد البيانات، Outbox، RabbitMQ.
- API: Controllers وواجهات REST.

## Patterns
- Outbox Pattern لضمان نشر الأحداث بشكل موثوق.
- Idempotency لتجنب التكرار.
- DLQ (Dead Letter Queue) لمعالجة الأخطاء.
- CI/CD عبر GitHub Actions.

## Trade-offs
- اخترنا RabbitMQ لأنه أبسط من Kafka في هذا السياق.
- استخدمنا SQL Server لأنه مدعوم رسميًا مع EF Core.
