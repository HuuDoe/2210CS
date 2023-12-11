adults = 'adults'
children = 'children'
concessions = 'concessions'

stalls = {
    adults: 10.5,
    children: 7.3,
    concessions: 8.4
}

delivery_fee = 2.34

discount_exceeding_limit = 100
discount_exceeding = 0
discount_exceeding_level = 0.1

total = int(input('Total in party: '))

tickets = {
    adults: -1
}

tickets[adults] = int(input('Number of adults: '))

while tickets[adults] <= 0:
    print('All children must be accomplished by at least 1 adults!')
    tickets[adults] = int(input('Number of adults: '))

tickets[concessions] = int(input('Number of concessions: '))

tickets[children] = total - tickets[adults] - tickets[concessions]

free_adults = tickets[children] // 10
if free_adults > 10:
    free_adults = 10

tickets[adults] = tickets[adults] - free_adults if tickets[adults] > free_adults else 0

fees = {}
total_fees = 0
for key, stall in stalls.items():
    fees[key] = stall * tickets[key]
    total_fees += fees[key]

if total_fees > discount_exceeding_limit:
    discount_exceeding = total_fees * discount_exceeding_level
    total_fees -= discount_exceeding

total_fees += delivery_fee

print('Tickets', 'Number(applied discounts)', 'Fee', sep = '\t\t')
for key, value in tickets.items():
    dkey = key
    if key == adults:
        dkey += '\t'
    print(dkey.capitalize(), value, '\t\t\t', '{:.2f}'.format(fees[key]), sep='\t')

print('Exceeding number discount:', discount_exceeding)
print('Tickets Delivery fee:', delivery_fee)

print('Total bill:', total_fees)
