IDENTIFICATION DIVISION.
PROGRAM-ID. INVOICE.

DATA DIVISION.
WORKING-STORAGE SECTION.
01 Discount         PIC 9V99 VALUE ZERO.
01 Total            PIC 9(5)V99 VALUE ZERO.
01 InvoiceType      PIC X(15) VALUE SPACES.

PROCEDURE DIVISION.

GetInvoiceDiscount SECTION.
    IF InvoiceType = 'OneTimeInvoice' THEN
        MOVE 1.00 TO Discount
    ELSE IF InvoiceType = 'RecurringInvoice' THEN
        MOVE 2.00 TO Discount
    ELSE IF InvoiceType = 'TopCustomerInvoice' THEN
        MOVE 3.00 TO Discount
    ELSE
        MOVE 0 TO Discount
    END-IF
    EXIT SECTION.

GetTotal SECTION.
    PERFORM GetInvoiceDiscount
    COMPUTE Total = Total - Discount
    DISPLAY "Total after discount: " Total
    EXIT SECTION.

END PROGRAM INVOICE.
