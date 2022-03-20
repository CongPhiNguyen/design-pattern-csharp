namespace ApplicationBridge
{
    public class MainApp
    {
        public static void Main()
        {
            macOS macOS = new macOS();
            Linux_Application linuxApp = new Linux_Application();
            macOS_Application macApp = new macOS_Application();
            macOS.Application = linuxApp;
            macOS.runApp();

            macOS.Application = macApp;
            macOS.runApp();

            Linux linux = new Linux();
            linux.Application = linuxApp;
            linux.runApp();

        }
    }

}