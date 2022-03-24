namespace AnimalBridge
{
    public class MainApp
    {
        public static void Main()
        {
            SinhVat sv = new DongVat();
            sv.Implementor = new AnTap();
            sv.Operation();

            SinhVat sv2 = new ThucVat();
            sv2.Implementor = new AnThit();
            sv2.Operation();
        }
    }
}
