# Stack & Heap

## Diagram 1 — After line 1

```text
STACK                         HEAP

┌───────────────┐             ┌──────────────────────────┐
│ o1            │───────────► │ Order                    │
│ address: 0x01 │             │                          │
└───────────────┘             │ OrderId = 1              │
                              │ CustomerName = "Ali"     │
                              │ Quantity = 0              │
                              │ UnitPrice = 0             │
                              │ TotalPrice = 0            │
                              │ IsPaid = false            │
                              │ ...                       │
                              └──────────────────────────┘


                              STACK                         HEAP

┌───────────────┐
│ o1            │───────┐
│ address: 0x01 │       │
└───────────────┘       │      ┌──────────────────────────┐
                        └─────►│ Order                    │
┌───────────────┐       │      │                          │
│ o2            │───────┘      │ OrderId = 1              │
│ address: 0x01 │              │ CustomerName = "Ali"     │
└───────────────┘              │ IsPaid = false            │
                               │ ...                       │
                               └──────────────────────────┘






                               ---

## Diagram 3 — After line 3

```text
STACK                         HEAP

┌───────────────┐
│ o1            │───────┐
│ address: 0x01 │       │
└───────────────┘       │
                        │      ┌──────────────────────────┐
┌───────────────┐       └─────►│ Order                    │
│ o2            │─────────────►│                          │
│ address: 0x01 │              │ OrderId = 1              │
└───────────────┘              │ CustomerName = "Ali"     │
                               │ IsPaid = true             │
                               │ ...                       │
                               └──────────────────────────┘