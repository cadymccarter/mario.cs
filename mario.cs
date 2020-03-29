using System;

class UserInput {

//gets user input and parses value into a string

    public int getInt(String prompt) {
      Console.Write(prompt + ": ");
      String value = Console.ReadLine();


        return int.Parse(value);
    }
}

class MainProgram {

    static void Main() {

    int num;

        //do while loop to get vaule between 1 and 8

        do {


            UserInput reader = new UserInput();

             num = reader.getInt("Height");
            }

        //while num is 1 through 8 execute nested for loops to print hashes, spaces and new lines

        while(num < 1 || num > 8);

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num - 1 - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write("#");
            }

            Console.Write("\n");
        }


    }
}
