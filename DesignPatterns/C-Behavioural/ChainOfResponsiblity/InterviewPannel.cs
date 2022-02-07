namespace DesignPatterns.Behavioural.ChainOfResponsiblity;

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