namespace DesignPatterns.Behavioural.ChainOfResponsiblity
{

    public class HRRound : Round
    {

        public override bool Hire(Candidate candidate)
        {
            if (candidate.score > 80)
            {
                System.Console.WriteLine($"{typeof(HRRound).Name} has approve the Candidate");
                return true;
            }
            else
                System.Console.WriteLine($"Candidate has Rejected by {typeof(HRRound).Name}");

            return false;


        }
    }
}