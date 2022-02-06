namespace DesignPatterns.Behavioural.ChainOfResponsiblity
{
    public class ManagerialRound : Round
    {
        public override bool Hire(Candidate candidate)
        {
            if (candidate.score > 60 && _next != null)
            {
                System.Console.WriteLine($"{typeof(ManagerialRound).Name} has approve the Candidate for next round");
                return _next.Hire(candidate);
            }
            else
                System.Console.WriteLine($"Candidate has Rejected by {typeof(ManagerialRound).Name}");
            return false;
        }
    }
}