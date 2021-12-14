using System;


public class Rot13
{

	//ROT13 is a simple letter substitution cipher that replaces a letter with 
	//the letter 13 letters after it in the alphabet.ROT13 is an example of the Caesar cipher.

	//Create a function that takes a string and returns the string ciphered with Rot13. 
	//If there are numbers or special characters included in the string, they should 
	//be returned as they are. Only letters from the latin/english alphabet should be shifted, 
	//like in the original Rot13 "implementation".


	public Rot13()
	{
		public static string Rot13(string message)
		{
			message = message.ToLower();
			byte coder = 13;
			byte asciiNumbers = 232;
			byte[] asciiMessage = System.Text.Encoding.ASCII.GetBytes(message);
			byte[] codedMessage = new byte[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
				if (asciiMessage[i] + 13 > 122)
                {
					codedMessage[i] = asciiMessage[i] - asciiNumbers;
                }
				else
                {
					codedMessage[i] = asciiMessage[i] + coder;
                }
            }
			var rot13 = System.Text.Encoding.ASCII.GetString(codedMessage);
			return rot13;
		}
	}
}
