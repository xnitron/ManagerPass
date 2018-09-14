namespace PasswordManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            Controller controller = new Controller(model);
        }
    }
}
