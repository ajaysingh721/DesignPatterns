using DesignPatterns.Behavioural.ChainOfResponsiblity;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Behavioural.ChainOfResponsiblity;


public class TestChainOFResponsiblity
{
    [Fact]
    public void TestName()
    {
        // Given
        var interviewPannel = new InterviewPannel();

        // When
        var score = interviewPannel.Hire(new Candidate()
        {
            score = 80
        });

        // Then
        score.Should().Be(true);
    }
}