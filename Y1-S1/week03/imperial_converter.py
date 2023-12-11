inches_per_foot = 12
kilometer_per_inch = 2.54 * 10 ** (-5)


input_feet = float(input('Feet: '))
input_inches = float(input('Inches: '))

total_inches = input_inches + inches_per_foot * input_feet

total_km = total_inches * kilometer_per_inch
total_m = total_km * 1000
total_cm = total_m * 100
total_mm = total_cm * 10

print("Height in kilometers:", total_km)
print("Height in meters:", total_m)
print("Height in centimeters:", total_cm)
print("Height in milimeters:", total_mm)