using System;
enum Menu {
    Login = 1,
    Register
}


namespace MTT2
{
    class Program
    {
        
        
        static void Main(string[] args){

            PrintMenuScreen(); 
        }
        
        
        static void PrintMenuScreen() { 
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }

        static void PrintHeader(){
            Console.WriteLine("Welcome to Digital Library.");
            Console.WriteLine("---------------------------");
        }
        
        static void PrintListMenu() {
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
        }

        static void InputMenuFromKeyboard() {
            Console.Write("Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu) {
            if (menu == Menu.Login) {
                ShowInputLogin(); 
            } else if (menu == Menu.Register) {
                ShowInputRegister(); 
            }else{
                ShowMassageIsInCorrect();
            }
        }

        static void ShowInputLogin(){
            Console.Clear();
            PrintHeaderLogin();

            InputLoginFromkeyboard();
        }

        static void InputLoginFromkeyboard(){
            Console.Clear();
            PrintHeaderLogin();

            Person person = CreateNewPerson();

        }

        static Person CreateNewPerson(){
            return new Person (InputName(),
            InputPassword(),
            InputUserType());
            
        }
        static string InputName() {
            Console.Write("Input name: ");
            
            return Console.ReadLine();
        }
        static string InputPassword() {
            Console.Write("Input Password: ");
            
            return Console.ReadLine();
        }
        static string InputUserType() {
            Console.Write("Input User Type 1 = Student, 2 = Employee: {0} ");
            
            return Console.ReadLine();
        }
        

    

        static void PrintHeaderLogin(){
            Console.WriteLine("Login Screen");
            Console.WriteLine("------------");

        }

        static void ShowInputRegister(){
            Console.Clear();
            PrintHeaderRigister();
        }

        static void PrintHeaderRigister(){
            Console.WriteLine("Register new Person");
            Console.WriteLine("-------------------"); 

        }

        static void ShowMassageIsInCorrect(){
            Console.Clear();
            Console.WriteLine("Incorrect Please try again.");
            InputMenuFromKeyboard();
        }
    }

}
