namespace DesignPatterns.Behavioural.ChainOfResponsiblity;

public abstract class Round
{
    public abstract bool Hire(Candidate candidate);

    protected Round _next;

    public void SetNextRound(Round next) => _next = next;
}

public class InterviewPannel
{
    private Round _firstRound = null;

    public InterviewPannel()
    {
        var managerialRound = new ManagerialRound();
        var technicalRound = new TechnicalRound();
        var hRRound = new HRRound();

        _firstRound = technicalRound;

        technicalRound.SetNextRound(managerialRound);
        managerialRound.SetNextRound(hRRound);
    }

    public bool Hire(Candidate candidate)
    {
        return _firstRound.Hire(candidate);
    }
}