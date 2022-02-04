using Xunit;
using Moq;
using DesignPatterns.Observer.Services;
using DesignPatterns.Observer.Subscriber;
using DesignPatterns.Observer.Publisher;
using FluentAssertions;

namespace DesignPatterns.Tests;

public class TestObserver
{
    [Fact]

    public void Test_SendEmail_OnVedeoEncoded_Called()
    {
        // Arrange
        var videoEditor = new VideoEditor(new Video() { Title = "Music Video" });
        var mockEmailService = new Mock<EmailService>();
        mockEmailService.Setup(x => x.Send(It.IsAny<string>())).Returns<string>(x => x).Verifiable();
        // Act
        var video = videoEditor.EncodeVideo(mockEmailService.Object);

        // Assert
        video.Title.Should().Be("Music Video");
        mockEmailService.Verify(x => x.Send(It.IsAny<string>()), Times.Once());
    }

    [Fact]

    public void Test_SendSMS_OnVedeoEncoded_Called()
    {
        // Arrange
        var videoEditor = new VideoEditor(new Video() { Title = "Music Video" });
        var mockSMSService = new Mock<SMSService>();
        mockSMSService.Setup(x => x.Send(It.IsAny<string>())).Returns<string>(x => x).Verifiable();

        // Act
        var video = videoEditor.EncodeVideo(mockSMSService.Object);

        // Assert
        video.Title.Should().Be("Music Video");
        mockSMSService.Verify(x => x.Send(It.IsAny<string>()), Times.Once());
    }

}