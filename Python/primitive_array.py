class DynamicArray:
    def __init__(self, capacity=2):
        self.array = [0] * capacity
        self.size = 0

    def add(self, value):
        if self.size == len(self.array):
            new_array = [0] * (len(self.array) * 2)
            for i in range(len(self.array)):
                new_array[i] = self.array[i]
            self.array = new_array
        self.array[self.size] = value
        self.size += 1

    def print(self):
        print(self.array[:self.size])

arr = DynamicArray()
arr.add(1)
arr.add(2)
arr.add(3)
arr.add(4)
arr.print()
