i = int(input())
if(i%2==0):
    j = i/2;
    if(j%2==0 or j-1 !=0):
        print("YES")
    else:
        print("NO")
                
else:
    print("NO")
