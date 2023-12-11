up_count=0
down_count=0
forward_count=0
with open ('advent02.txt','r') as f:
    for line in f.readlines():
        if 'up' in line:
            i =((line.replace('\n','')))
            up_count+=int(i.replace('up ',''))
        if 'down' in line:
            down.append((line.replace('\n','')))
        if 'forward' in line:
            forward.append((line.replace('\n','')))
for i in up:
    
for i in down:
    
    down_count+=int(i.replace('down ',''))
for i in forward:
    forward_count+=int(i.replace('forward ',''))
print(up_count)
print(down_count)
print(((up_count*-1)+down_count)*forward_count)
#print(down)
#print(forward)