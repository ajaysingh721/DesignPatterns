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
        var result = interviewPannel.Hire(new Candidate()
        {
            score = 90
        });

        // Then
        result.Should().Be(true);
    }
}