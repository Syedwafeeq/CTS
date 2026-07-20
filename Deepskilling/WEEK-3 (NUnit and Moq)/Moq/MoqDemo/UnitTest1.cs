using Moq;
using NUnit.Framework;

namespace MoqDemo;

public class Tests
{
    [Test]
    public void Register_Should_Return_True_When_Email_Is_Sent()
    {
        // Arrange
        var mock = new Mock<IEmailService>();

        mock.Setup(x => x.SendEmail(It.IsAny<string>()))
            .Returns(true);

        var customerService = new CustomerService(mock.Object);

        // Act
        bool result = customerService.Register("abc@gmail.com");

        // Assert
        Assert.That(result, Is.True);

        mock.Verify(x => x.SendEmail(It.IsAny<string>()), Times.Once);
    }
}