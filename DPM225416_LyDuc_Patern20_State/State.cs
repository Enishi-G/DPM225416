namespace State.Structural
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>

    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
