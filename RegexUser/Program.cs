namespace RegexUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option:\n1.Valid first name\n2.Valid last name\n3.Valid Email\n4.Valid Mobile number(+91 1234567890)\n5.Minimum 8 characters\n6.At least 1 upper case\n7.At least 1 numberic value\n8.At least 1 special character\n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FirstName.ValidFirstName();
                    break;
                case 2:
                    LastName.ValidateLastName();
                    break;
                case 3:
                    Email.ValidateEmail();
                    break;
                case 4:
                    MobileNumber.ValidateMobileNumber();
                    break;
                case 5:
                    Console.WriteLine("Enter a password : ");
                    string input1 = Console.ReadLine();
                    Rule1.ValidatePassword(input1);
                    break;
                case 6:
                    Console.WriteLine("Enter a password : ");
                    string input2 = Console.ReadLine();
                    Rule2.ValidatePassword(input2);
                    break;
                case 7:
                    Console.WriteLine("Enter a password : ");
                    string input3 = Console.ReadLine();
                    Rule3.ValidatePassword(input3);
                    break;
                case 8:
                    Console.WriteLine("Enter a password : ");
                    string input4 = Console.ReadLine();
                    Rule4.ValidatePassword(input4);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}