

//task1//

/*

int n;

n = int.Parse(Console.ReadLine());

Console.WriteLine("-----------");

if (n == 0)
{
    Console.WriteLine("Ne cut ne de tek");
}
else if (n % 2 == 0)
{
    Console.WriteLine("Cutdur");
}
else
{
    Console.WriteLine("Tekdir");
}

*/

//task2//


//int m;

//m = int.Parse(Console.ReadLine());

//Console.WriteLine("-----------");

//for (int i = 1; i <= m; i++)
//{
//    Console.WriteLine(i);
//}

//task3

/*
int m;
int sum = 0;
m = int.Parse(Console.ReadLine());

Console.WriteLine("-----------");

for (int i = 0; i <= m; i++)
{
    sum += i;
}
Console.WriteLine(sum);

*/


//task4

//int m;
//int count=0;

//m = int.Parse(Console.ReadLine());


//for (int i = 1; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//task5

//int n;
//int m;

//int sum=0;

//n = int.Parse(Console.ReadLine());
//m = int.Parse(Console.ReadLine());

//Console.WriteLine("-----------");


//for (int i = n; i <= m; i++)
//{
//    if (i%2==0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

//task6

//int n;
//int m;

//int sum = 0;

//n = int.Parse(Console.ReadLine());
//m = int.Parse(Console.ReadLine());

//Console.WriteLine("-----------");


//for (int i = m; i <= n; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

//int fakt = 1;

//for (int j = sum; j > 0; j--)
//{
//    fakt *= j;
//}
//Console.WriteLine(fakt);

//task7

//int[] numbs = { 1, 2, 3, 4, 5, 6, 7};

//int multiply=1;

//for (int i = 0; i < numbs.Length; i++)
//{
//    if (numbs[i] % 2 == 0)
//    {
//        multiply *= numbs[i];
//    }
//}
//Console.WriteLine(multiply);




//task8

// int n;

//number:

//n = int.Parse(Console.ReadLine());
//if (n==0)
//{
//    Console.WriteLine("duzgen deyil");
//    goto number;
//}

//if (n % 3 == 0 && n % 7 == 0)
//{
//    Console.WriteLine("3 ve 7 ye bolunur");
//}
//else
//{
//    Console.WriteLine("3 ve 7 ye bolunmur");

//}

//Task 9


//int n;
//int m;

//int sum = 0;
//number:
//n = int.Parse(Console.ReadLine());
//m = int.Parse(Console.ReadLine());

//if (n==0&&m==0)
//{
//    Console.WriteLine("ne cut ne tek");
//    goto number;
//}
//else if (n % 2 == 0 && m % 2 == 0)
//{

//    sum = n + m;
//    Console.WriteLine(sum);
//}
//else
//{
//    Console.WriteLine("cut deyil");
//}


//task10

//int n;
//int m;

//int sum = 0;
//n = int.Parse(Console.ReadLine());
//m = int.Parse(Console.ReadLine());


//    for (int i = n; i <= m; i++) 
//    {
//        if (i%2==1)
//        {
//            sum +=i;
//        }
//    }
//Console.WriteLine(sum);

//task11



//int[] numbs = { 1, 2, 3, 4, 5, 6, 7,8,9,10,11 };
//int sum = 0;

//for (int i = 0; i < numbs.Length; i++)
//{
//    if (numbs[i] % 2 == 1)
//    {
//        sum+= numbs[i];
//    }
//}
//Console.WriteLine(sum);


//task12

//int[] numbs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
//int sum = 0;

//for (int i = 0; i < numbs.Length; i++)
//{
//    if (numbs[i] % 2 == 0)
//    {
//        sum += numbs[i];
//    }
//}
//Console.WriteLine(sum);

//task13

//int n;
//int count = 0;

//n = int.Parse(Console.ReadLine());

//for (int i = 1; i <=n ; i++)
//{
//    if (n%i==0)
//    {
//        count++;
//    }
//}
//if (n==0)
//{
//    Console.WriteLine("Ne sade ne de murekkeb");
//}
//else if(count==2)
//{
//    Console.WriteLine("Sadedir");
//}
//else
//{
//    Console.WriteLine("Murekkebdir");
//}


//Task14

//dersde olanlari yazmaq;

//diger program.cs de onlari yazdim