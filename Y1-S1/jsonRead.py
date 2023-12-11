from tabulate import tabulate
import json
with open("char_classes.json") as f:
    data=json.load(f)
#d=(data.values())
#x=['Class']+(list(data["warrior"].keys()))
#print(x)
print(tabulate(data.values(),headers={ '':"str", '':"int", '':"wis", '':"dex", '':"con"},showindex=data.keys()))
print(tabulate([(k,)+v for k,v in data.items()]))