using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiphersWindowsApp
{
    public class Caesar
    {


        public string Encode(string inputStr, int shiftKey)
        {
            Console.Write("Original Cipher: " + inputStr);
            Console.WriteLine("");
            char temp;
            var sb = new StringBuilder();

            for (int i = 0; i < inputStr.Length; i++)
            {

                if (inputStr[i] != ' ')
                {
                    temp = (char)(inputStr[i] + shiftKey); //shift the char by the key amound and this will be the new shifted value


                    if (temp > 'z')
                    { // if surpasses z in alphabet in mod will wrap it round
                        temp = (char)(inputStr[i] - (26 - shiftKey % 26));
                    }

                    sb.Append(temp);

                }
                else
                {
                    sb.Append(" ");

                }

            }
            return sb.ToString();
        }

        public string Decode(string inputStr, int shiftKey)
        {
            int newKey = 26 - (shiftKey % 26);
            Console.Write("Original Cipher: " + inputStr);
            Console.WriteLine("");
            char temp;
            var sb = new StringBuilder();


            for (int i = 0; i < inputStr.Length; i++)
            {

                if (inputStr[i] != ' ')
                {
                    temp = (char)(inputStr[i] + newKey); //shift the char by the key amound and this will be the new shifted value


                    if (temp > 'z')
                    { // if surpasses z in alphabet in mod will wrap it round
                        temp = (char)(inputStr[i] - (26 - newKey % 26));
                    }

                    sb.Append(temp);

                }
                else
                {
                    sb.Append(" ");

                }

            }
            return sb.ToString();
        }

        public string bruteForce(string inputStr)
        {
            var sb = new StringBuilder();

            for (int i = 1; i <= 26; i++)
            {
                sb.Append(Decode(inputStr, i) + "    with key: " + i);
                sb.AppendLine("");
                sb.AppendLine("");
            }

            return sb.ToString();

        }


        public string removeSpaces(string inputStr)
        {
            return String.Concat(inputStr.Where(c => !Char.IsWhiteSpace(c)));

        }




    }
}
