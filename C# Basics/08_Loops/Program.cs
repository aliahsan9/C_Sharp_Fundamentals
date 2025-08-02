//Print Even Numbers From 1 to 10 Using for loop

for(int i = 2; i <= 10; i++){
    if(i%2 == 0){
        Console.WriteLine(i);
    }
    
}

//Counts the Number of Digits in a Number Using While Loop
int num = 1234234567;
int count = 0;
while(num != 0){
num = num/10;
count++;
}
//Prints the Number of Digits in a Number
Console.WriteLine(count);



// Calculate the Sum of First N Natural Numbers
int num1 = 10;
int sum = 0;

for(int i = 1; i<=num1; i++){
    sum+=i;
}
Console.WriteLine("Sum of First 10 Integers is:" +sum);