IDENTIFICATION DIVISION.
PROGRAM-ID. INVOICE.

DATA DIVISION.
WORKING-STORAGE SECTION.
01 Discount         PIC 9(3)V99 VALUE ZEROS.
01 Total            PIC 9(5)V99 VALUE ZEROS.
01 InvoiceType      PIC A(10) VALUE SPACES.
01 InvoiceTypeDs.
   05 OneTime       PIC A(10) VALUE 'OneTime'.
   05 Recurring     PIC A(10) VALUE 'Recurring'.

PROCEDURE DIVISION.

GetInvoiceDiscount SECTION.
GetInvoiceDiscount-Para.
    EVALUATE TRUE
        WHEN InvoiceType = 'OneTime'
            MOVE 0.1 TO Discount
        WHEN InvoiceType = 'Recurring'
            MOVE 0.2 TO Discount
        WHEN OTHER
            MOVE 0 TO Discount
    END-EVALUATE.
    EXIT SECTION.

GetTotal SECTION.
GetTotal-Para.
    PERFORM GetInvoiceDiscount-Para
    COMPUTE Total = Total - Discount
    DISPLAY 'Total after discount: ' Total
    EXIT SECTION.

END PROGRAM INVOICE.
