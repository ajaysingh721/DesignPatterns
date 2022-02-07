namespace DesignPatterns.Behavioural.ChainOfResponsiblity;

public abstract class Round
{
    public abstract bool Hire(Candidate candidate);

    protected Round _next;

    public void SetNextRound(Round next) => _next = next;
}
