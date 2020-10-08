namespace Indivudella_uppgift
{
    internal class MainMenuFacade
    {
        protected string input;

        private string _menu
            = "[1]Open planetStore\n" +
                "[2]View Planets\n" +
                "[3]End Turn\n" +
                "[5]Quit\n";

        public MainMenuFacade(string input)
        {
            this.input = input;
        }

        public void Operation()
        {
            switch (input)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "5":
                    Program.isRunning = false;
                    break;
            }
        }
    }
}