start=["J","Q","K","A","J","Q","K","A","J","Q","K","A","J","Q","K","A"]
var=[]
score=0
def game():
    #for i in range(len(start)):
        #globals[(f"var_{i}")]=i
    '''for i in range (4):
        print (i, start[int(i*4)], start[int((i*4)+1)], start[int((i*4)+2)], start[int((i*4)+3)])'''
    print (f'''
   0  1  2  3 
0  {start[0]}  {start[1]}  {start[2]}  {start[3]}        
1  {start[4]}  {start[5]}  {start[6]}  {start[7]} 
2  {start[8]}  {start[9]}  {start[10]}  {start[11]} 
3  {start[12]}  {start[13]}  {start[14]}  {start[15]} 
           ''')

    try:
        while True:
            for i in range(2):
                column=input("Enter column: ")
                row=input("Enter row: ")
                pos=int(column)+(int(row)*4)
                var.append(pos)
            if var[0] == var[1]:
                print ('nice')
                score+=1
            else:
                None
            var.clear()
        
        return(score)
    except:
        return
game() 