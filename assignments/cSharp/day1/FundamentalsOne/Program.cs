
//* Create a loop that prints all values from 1-255.
for (int i = 1; i <= 255; i++)
{
  // Console.WriteLine(i);
}


//* Create a new loop that generates 5 random numbers between 10 and 20.
// Random rand = new Random();
// for (int i = 1; i <= 5; i++)
// {
//   Console.WriteLine(rand.Next(10, 21));
// }


//* Modify the previous loop to add the random values together and print the sum after the loop finishes.
// Random rand = new Random();
// int random = 0;
// int line = 0;
// int sum = 0;
// for (int i = 1; i <= 5; i++)
// {
//   line++;
//   random = rand.Next(10, 21);
//   sum += random;
//   Console.WriteLine("number: {0}: {1}", line, random);

// }
// Console.WriteLine("Sum is " + sum);


//* Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both. 
// Random fizzBuzz = new Random();
// for (int i = 1; i <= 100; i++)
// {
//   if (i % 3 == 0 || i % 5 == 0) ;
//   {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//       continue;
//     };

//     Console.WriteLine(i);
//   }
// }

//* Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.

// Random fizzBuzz = new Random();
// for (int i = 1; i <= 100; i++)
// {
//   {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//       continue;
//     }
//     else if (i % 3 == 0)
//     {
//       Console.WriteLine("Fizz");
//     }
//     else if (i % 5 == 0)
//     {
//       Console.WriteLine("Buzz");
//     }
//     Console.WriteLine(i);
//   }
// }

//* Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.
Random fizzBuzz = new Random();
for (int i = 1; i <= 100; i++)
{
  if (i % 3 == 0 || i % 5 == 0) ;
  {
    if (i % 3 == 0 && i % 5 == 0)
    {
      Console.WriteLine("FizzBuzz");
      continue;

    }
    Console.WriteLine(i);
  }
}