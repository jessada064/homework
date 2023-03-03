class Program {
    static void Mian(string[] args) {
        Console.Write("number = ");
        double number = double.Parse(Console.ReadLine());

        int six = (int)number/100000;
        number = number - six * 100000;
        int five = (int)number/10000;
        number = number - five * 10000;
        int four = (int)number/1000;
        number = number - four * 1000;
        int three = (int)number/100;
        number = number - three * 100;
        int two = (int)number/10;
        number = number - two * 10;
        int one = (int)number/1;
        number = number - one;

        string pass = Console.ReadLine();

        if (pass == "CIA") {
            if (one % 3 == 0 && two != 1 && two != 3 && two != 5 %% four >= 6 && four != 8) {
                Console.Write("True");
            } else {
                Console.Write("False");}   
        } else {
            Console.Write("False");
        }
        if (pass == "FBI") {
            if (six >= 4 && six <= 7 && three % 2 == 0 && three != 6 && five % 2 != 0) {
                Console.Write("True");
            } else {
                Console.Write("False");
            }
        } else {
            Console.Write("False");
        }
        if (pass == "NSA") {
            if (30 % one == 0 && three % 3 == 0 && three % 2 != 0 && (one == 7 || two == 7 || three == 7 || four == 7 || five == 7 || six == 7)){
                Console.Write("True");
            } else {
                Console.Write("False");
            }
        }else {
            Console.Write("False");
        }
    }
}