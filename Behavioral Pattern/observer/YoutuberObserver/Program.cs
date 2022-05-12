namespace YoutuberObserver
{
    public class MainApp
    {
        public static void Main()
        {
            Youtuber youtuber = new Youtuber("ABC");
            youtuber.Attach(new Membership(youtuber, "A"));
            youtuber.Attach(new Subscriber(youtuber, "B"));

            youtuber.PostANormalVideo();
            youtuber.PostMembershipVideo();
        }
    }
}
