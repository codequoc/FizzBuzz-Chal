public string FizzBuzz(int number) {
    if (number % 3 == 0) {
        return "fizz";
    }
    if (number % 5 == 0) {
        return "buzz";
    }
    if (number % 5 == 0 && number % 3 == 0) {
        return "fizzbuzz";
    }
}