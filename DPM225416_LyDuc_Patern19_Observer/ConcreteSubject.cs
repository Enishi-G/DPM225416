namespace Observer.Structural
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>

    public class ConcreteSubject : Subject
    {
        private string subjectState;

        // Gets or sets subject state

        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}

