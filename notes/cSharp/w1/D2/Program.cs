//  == functions ==
//  static
//      - static function can be called within the scope of its definition or by calling it on the class it's defined in
//      - non-static method has to be called on an instance of an object
static void SayHello(){ // w/o parameters
    Console.WriteLine($"Hello!");
}

static int AddNumbers(int a, int b) // w/ parameters
{
    return a + b;
}

SayHello(); // call function
