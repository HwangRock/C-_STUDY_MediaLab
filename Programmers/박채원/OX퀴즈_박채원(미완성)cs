string answer = "X";
           string[] quiz = Console.ReadLine().Split(" ");
           int a = int.Parse(quiz[0]);
           int b = int.Parse(quiz[2]);
           int result = int.Parse(quiz[4]);

           if (quiz[1] == "+")
           {
               int x = a + b;
               if (x == result)
               {
                   answer = "O";
               }

               else if (quiz[1] == "-")
               {
                   int y = a - b;
                   if (y == result)
                   {
                       answer = "X";
                   }
               }

           }
           Console.WriteLine(answer);
