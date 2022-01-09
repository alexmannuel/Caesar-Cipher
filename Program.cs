string logo = @"
   ____                                  ____  _         _                 
  / ___| __ _   ___  ___   __ _  _ __   / ___|(_) _ __  | |__    ___  _ __ 
 | |    / _` | / _ \/ __| / _` || '__| | |    | || '_ \ | '_ \  / _ \| '__|
 | |___| (_| ||  __/\__ \| (_| || |    | |___ | || |_) || | | ||  __/| |   
  \____|\__,_| \___||___/ \__,_||_|     \____||_|| .__/ |_| |_| \___||_|   
                                                 |_|                       
";


Console.WriteLine(logo);

//Declare globar variable
int option;
int key = 0;
string message;
string answer;
bool end = true;

while(end!=false){
Console.WriteLine(" Menu:");
Console.WriteLine(" 1.Encrypt a message\n 2.Decrypt a message \n 3.End Program");
Console.WriteLine();
option = Convert.ToInt32(Console.ReadLine());

//The user options
switch (option)
{
    case 1:
        Console.WriteLine("Enter a text you wanto to encrypt:");
        message = Console.ReadLine().ToLower();

        Console.WriteLine("Enter a Key:");
        key = Convert.ToInt32(Console.ReadLine());

        string encryptMes = Encrypt(message, key);

        Console.WriteLine($"The encode message is: {encryptMes}");
        Console.WriteLine();
        break;

    case 2:

        Console.WriteLine("Enter a text you want to decrypt:");
        message = Console.ReadLine().ToLower();

        Console.WriteLine("Enter a Key:");
        key = Convert.ToInt32(Console.ReadLine());

        string descryptMes = Decrypt(message, key);

        Console.WriteLine($"The decode message is: {descryptMes}");
        Console.WriteLine();
        break;

    case 3:
        Console.WriteLine("If you want to end program enter \"yes\"");
        answer = Console.ReadLine().ToLower();
        if(answer == "yes"){
            end = false;
        }
        break;

    default:
        Console.WriteLine("You enter a wrong choice.");
        break;



}
}

//Method with the logic to encrypt the text.
static string Encrypt(string text, int key)
{
    char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    char[] secreteMessage = text.ToCharArray();
    char[] encryptedMessage = new char[secreteMessage.Length];


    for (int i = 0; i < text.Length; i++)
    {
        char letter = text[i];
        int position = Array.IndexOf(alphabet, letter);
        int index = (position + key) % 26;
        encryptedMessage[i] = alphabet[index];
    }

    string encrypt = String.Join("", encryptedMessage);
    return encrypt;
}

//Method with the logic to decypt the text.
static string Decrypt(string text, int key)
{
    char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    char[] descryptArray = text.ToCharArray();
    char[] decryptedMessage = new char[descryptArray.Length];

    for (int i = 0; i < text.Length; i++)
    {
        char letter = text[i];
        int position = Array.IndexOf(alphabet, (letter));
        int index = (position - key) + 26;
        decryptedMessage[i] = alphabet[index];


    }
    string descrypt = String.Join("", decryptedMessage);
    return descrypt;
}


