s = input()
n, w , e = s.split(' ')
n, w , e = int(n), int(w) , int(e)
sum = 0
for i in range(1, n + 1):
    for j in range(1, n + 1):
        x1 = 100 * i - 100
        x2 = 100 * i
        y1 = 100 * j - 100
        y2 = 100 * j
        y = w  + x1 * (e - w) / (100 * n)
        if ((y - y1) * (y - y2) > 0):
            y = w  + x2 * (e - w) / (100 * n)
            if ((y - y1) * (y - y2) <= 0):
                sum = sum + 1
        else:
            sum = sum + 1
print(sum)
