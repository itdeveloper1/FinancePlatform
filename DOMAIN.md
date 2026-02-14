
### DOMAIN.md
```markdown
# Domain Model

## Transactions
- Transaction: يمثل معاملة مالية.
- TransactionItem: يمثل عنصر داخل المعاملة.
- Events:
  - TransactionSubmitted
  - TransactionCancelled

## Payments
- Payment: يمثل عملية دفع مرتبطة بمعاملة.
- Events:
  - PaymentStarted
  - PaymentConfirmed
  - PaymentFailed

## قواعد الأعمال
- لا يمكن تأكيد معاملة بدون عناصر.
- الدفع مرتبط دائمًا بمعاملة موجودة.
