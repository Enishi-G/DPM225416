namespace Proxy.Structural
{
    /// <summary>
    /// The 'RealSubject' class
    /// </summary>

    public class RealSubject : Subject
    {
        public RealSubject()
        {
        }

        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}


