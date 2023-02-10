for(int i = 1; i <= 255; i++){
    // Console.WriteLine(i);
}

Random rand = new Random();
for(int i = 1; i <= 5; i++) {
    // Console.WriteLine(rand.Next(10,21));
}

for (int i = 1; i <= 5; i++) {   
    i += rand.Next(10, 21);
    // Console.WriteLine(i); 
}