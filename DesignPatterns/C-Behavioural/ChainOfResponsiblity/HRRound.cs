namespace DesignPatterns.Behavioural.ChainOfResponsiblity
{

    public class HRRound : Round
    {
        private int score = 80;
        public override bool Hire(Candidate candidate)
        {
            candidate.score = score;

            if (candidate.score > 80 && _next != null)
            {
                System.Console.WriteLine($"{typeof(HRRound).Name} has approve the Candidate for next round");
                return _next.Hire(candidate);
            }
            else
                System.Console.WriteLine($"Candidate has Rejected by {typeof(HRRound).Name}");
            return false;
        }
    }
}