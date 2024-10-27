

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int resulte = userNum % 2;

if(resulte != 0) //!= - ei ole 
{
    Console.WriteLine("User number is odd.");
} else 
{ 
    Console.WriteLine("User number is even.");
}