namespace EditorMemento
{
    public class MainApp
    {
        public static void Main()
        {
            TextWindow textWindow = new TextWindow();
            TextEditor textEditor = new TextEditor(textWindow);

            textEditor.write("Nguyen Cong Phi");
            textEditor.print();
            textEditor.hitSave();
            textEditor.write("-19522006");
            textEditor.print();
            textEditor.hitUndo();
            textEditor.print();
        }
    }
}
