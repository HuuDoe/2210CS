data=[]
count=0
with open ('advent01.txt','r') as f:
    for line in f.readlines():
        data.append(int(line.replace('\n','')))
for i in range(0,len(data)-3):
    sum1=(data[i]+data[i+1]+data[i+2])
    sum2=(data[i+1]+data[i+2]+data[i+3])
    print(sum1,sum2)
    if sum2>sum1:
        count+=1
    print(count)
