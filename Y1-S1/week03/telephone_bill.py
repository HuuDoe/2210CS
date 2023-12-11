pences_per_pound = 100

used_minutes = int(input('Enter number of minutes: '))

if used_minutes > 0:
    print('Number of minutes:', used_minutes)

    call_rate = 15
    vat_rate = 0.2

    basic_call_charge = used_minutes * call_rate / pences_per_pound
    print("Basic call charge:", basic_call_charge)

    vat_due = vat_rate * basic_call_charge
    print('VAT due: {:.2f}'.format(vat_due))

    total_bill = vat_due + basic_call_charge
    print('Total bill: {:.2f}'.format(total_bill))
else:
    print('The used minutes must be greater than zero')