namespace programming_1_exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1



            // 2
            Console.WriteLine("Please enter a word to check if it is a palindrome:");
            string palindrome = Console.ReadLine().ToLower();

            int length = palindrome.Length;
            string head;
            string tail;
            bool isPalindrome = false;

            if (length % 2 != 0)
            {
                head = palindrome.Substring(0, (int)length / 2);
                tail = palindrome.Substring((int)(length / 2) + 1, (int)length / 2);
            }
            else
            {
                head = palindrome.Substring(0, length / 2);
                tail = palindrome.Substring((length / 2), length / 2);
            }

            for (int i = 0; i < head.Length; i++)
            {
                if (head[i] != tail[head.Length - 1 - i])
                {
                    break;
                }
                else
                {
                    isPalindrome = true;
                }
            }
            Console.WriteLine(isPalindrome ? "Is palindrome." : "No palindrome.");



            // 3
            string textEncrypted = "Va qre Hzjryg fnzzrya Zrafpura ertryznrffvt trbtensvfpur Vasbezngvbara – fbtranaagr Ebuqngra:\r\njvr jrvg vfg rgjnf mhz Orvfcvry ragsreag, jvr ubpu, jvr unrhsvt xbzzg rf ibe, jvr fpujre vfg rgjnf? Hz\r\nqvrfr Ebuqngra trug rf vz Onpurybefghqvratnat Hzjrygvasbezngvx. Qvr uvre nhftrovyqrgra\r\nVasbezngvxre_vaara xbamragevrera fvpu qnenhs, req- haq hzjrygeryrinagr Qngra\r\n(Trbvasbezngvx) shre grpuavfpur Najraqhatra mh reurora, mh fgehxghevrera, mh nanylfvrera haq\r\nmh ireneorvgra. Nhs qvrfre Tehaqyntr trfgnygra bqre ernyvfvrera fvr zhygvzrqvnyr\r\nHzjrygvasbezngvbafflfgrzr bqre cnffra fvr zvg nxghryyra Qngra vzzre jvrqre na. Zngurzngvfpur Tehaqxraagavffr fvaq shre qra Fghqvratnat Hzjrygvasbezngvx rvar jvpugvtr Ibenhffrgmhat.\r\nZvguvysr iba Ghgbevra xbraara fvr vz Fghqvhz nhstrsevfpug jreqra. Qnf Fghqvhz irezvggryg nore\r\narora Vasbezngvx nhpu fcrmvryyr anghejvffrafpunsgyvpur Xraagavffr zvg Oyvpx nhs qra\r\nHzjrygorervpu.";
            string textDecrypted = "";
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };


            foreach (char ch in textEncrypted)
            {
                bool isUppercase = false;
                char tempChar = ch;

                if (char.IsUpper(tempChar))
                {
                    tempChar = char.ToLower(tempChar);
                    isUppercase = true;
                }

                bool charIsLetter = false;
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (char.ToString(tempChar) == alphabet[i])
                    {
                        charIsLetter = true;
                        if (i <= 12)
                        {
                            textDecrypted += isUppercase ? alphabet[i + 13].ToUpper() : alphabet[i + 13];
                        }
                        else
                        {
                            textDecrypted += isUppercase ? alphabet[i - 13].ToUpper() : alphabet[i - 13];
                        }
                    }
                }
                if (!charIsLetter)
                {
                    textDecrypted += tempChar;
                }
            }
            Console.WriteLine(textDecrypted);



            // 4
            Console.WriteLine("Please enter the number of dices to roll:");
            int numDices = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of throws:");
            int numThrows = int.Parse(Console.ReadLine());

            int[,] statsDiceGame = new int[numDices * 6 + 1, 1];
            Random rand = new Random();

            for (int a = numDices; a <= numDices * 6; a++)
            {
                statsDiceGame[a, 0] = 0;
            }

            for (int b = 0; b < numThrows; b++)
            {
                int numEyes = 0;
                for (int c = 0; c < numDices; c++)
                {
                    numEyes += rand.Next(1, 7);
                }
                statsDiceGame[numEyes, 0] = statsDiceGame[numEyes, 0] + 1;
            }

            for (int d = numDices; d <= numDices * 6; d++)
            {
                Console.WriteLine("Augenzahl: " + d + " Anzahl: " + statsDiceGame[d, 0]);
            }



            // 5
            int[] interval = { 0, 1000 };

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|Interval       |Anzahl        |");
            Console.WriteLine("+------------------------------+");

            while (interval[1] < 30001)
            {
                int primesCounter = 0;

                for (int i = interval[0]; i <= interval[1]; i++)
                {
                    float numberToCheck = i;
                    bool isPrime = true;

                    if (i == 0 || i == 1) continue;

                    for (int j = 2; j <= Math.Sqrt(numberToCheck); j++)
                    {
                        if (numberToCheck % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime) primesCounter++;
                }
                Console.WriteLine($"| [{interval[0]},{interval[1]}]" + "   |   " + $"{primesCounter}      |");

                interval[0] += 1000;
                interval[1] += 1000;
            }
        }
    }
}