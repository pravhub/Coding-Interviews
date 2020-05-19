line1=input().split()
line2=input().split()
n = int(line1[0])
kth = int(line1[1])
#print(n)
#print(kth)
kthscore = -1
count=0
for i in range(n):
    if(int(line2[i])<=0):
        continue
    #print(i)
    if i<kth:
        kthscore=int(line2[i])
        #print(kthscore)
        count=count+1
    else:
        if int(line2[i])==kthscore:
            count=count+1
        else:
            break
print(count)
        
