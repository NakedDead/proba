def Replace(A, size, index):  
    largest = index
    left = (2 * index) + 1
    child = (2 * index) + 2
    if left < size and A[left] > A[largest]:
        largest = left
    if child < size and A[child] > A[largest]:
        largest = child
    if largest != index:
        A[index], A[largest] = A[largest], A[index]
        Replace(A, size, largest)
        
def Sort(A):  
    n = len(A)
    for i in range(n, -1, -1):
        Replace(A, n, i)

    for i in range(n - 1, 0, -1):
        A[i], A[0] = A[0], A[i]
        Replace(A, i, 0)

A = [35, 12, 43, 8, 51]  
Sort(A)  
print(A) 