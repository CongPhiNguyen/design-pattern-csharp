namespace EditorCommand
{
    public class MainApp
    {
        public static void Main()
        {
            Editor a = new TextEditor();
            Command copyCommand = new CopyCommand(a);
            Content img = new Image();

            Invoker invoker = new Invoker();
            invoker.SetContent(img);
            invoker.SetCommand(copyCommand);

            invoker.ExecuteCommand();

            Command pasteCommand = new PasteCommand(a);
            invoker.SetCommand(pasteCommand);
            invoker.ExecuteCommand();
            Console.WriteLine("--------------");


            Editor b = new ImageEditor();
            pasteCommand = new PasteCommand(b);
            invoker.SetCommand(pasteCommand);
            invoker.ExecuteCommand();

            Console.WriteLine("--------------");

            invoker.SetCommand(copyCommand);
            invoker.SetContent(new Text());
            invoker.ExecuteCommand();
            
            invoker.SetCommand(pasteCommand);
            invoker.ExecuteCommand();

        }
    }
}
