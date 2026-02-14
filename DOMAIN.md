# Domain Model

## Transactions Context
- **Aggregates**: Transaction, TransactionItem
- **Business Rules**:
  - Cannot submit empty transaction.
  - Cannot cancel after confirmation unless merchant.
- **Events**:
  - TransactionSubmitted
  - TransactionCancelled

## Payments Context
- **Aggregates**: Payment
- **Business Rules**:
  - Payment must be linked to a transaction.
  - Payment can be confirmed or failed.
- **Events**:
  - PaymentStarted
  - PaymentConfirmed
  - PaymentFailed
