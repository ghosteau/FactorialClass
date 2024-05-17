class Factorial:

    # Calculates the factorial of a whole number where the factorial function is defined
    # No limits are required, unlike the Java class I made, due to how Python handles integer overflow
    def factorialRun(num):

        # Initialize factorial number as 1
        factorialNum = 1

        # Factorial of 0 and 1 are both 1
        if num == 0 or num == 1:
            return factorialNum
    
        # Factorial not defined for negative numbers
        if num < 0:
            raise Exception("Factorial operand not defined for numbers below zero")
    
        # Multiplies every number from 2 all the way to the inserted number (made inclusive due to + 1)
        for nextNum in range(2, num + 1):
            factorialNum *= nextNum

        return factorialNum
    

# Essentially what would be out in "main" -- use of the class and function.
print(Factorial.factorialRun(0))
print(Factorial.factorialRun(25))
