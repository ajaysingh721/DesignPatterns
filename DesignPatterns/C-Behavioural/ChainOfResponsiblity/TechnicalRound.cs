namespace DesignPatterns.Behavioural.ChainOfResponsiblity
{
    public class TechnicalRound : Round
    {
        public override bool Hire(Candidate candidate)
        {
            if (candidate.score > 70 && _next != null)
            {
                System.Console.WriteLine($"{typeof(TechnicalRound).Name} has approve the Candidate for next round");
                return _next.Hire(candidate);
            }
            else
                System.Console.WriteLine($"Candidate has Rejected by {typeof(TechnicalRound).Name}");

            return false;
        }
    }
}