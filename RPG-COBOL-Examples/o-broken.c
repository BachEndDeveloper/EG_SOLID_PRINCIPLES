**FREE
dcl-s Discount decimal(5:2);
dcl-s Total decimal(10:2);
dcl-s InvoiceType char(10);

// Function to get invoice discount
dcl-proc GetInvoiceDiscount;
    dcl-pi *n decimal(5:2);
        InvoiceType char(10);
    end-pi;

    select;
        when InvoiceType = 'OneTime' ;
            Discount = 0.1;
        when InvoiceType = 'Recurring';
            Discount = 0.2;
        other;
            Discount = 0;
    endsl;

    return Discount;
end-proc;

// Function to get total
dcl-proc GetTotal;
    dcl-pi *n decimal(10:2);
        Total decimal(10:2);
        InvoiceType char(10);
    end-pi;

    return Total - GetInvoiceDiscount(InvoiceType);
end-proc;

// Enum equivalent in RPG
dcl-ds InvoiceTypeDs qualified;
    OneTime char(10) inz('OneTime');
    Recurring char(10) inz('Recurring');
end-ds;
