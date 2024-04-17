using Ucu.Poo.TestDateFormat;
namespace Library.Tests;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ChangeFormat()
    {   
        //ARRANGE
        string date = "08/05/2003";
        string expected = "2003-05-08";

        //ACT
        string result = DateFormatter.ChangeFormat(date);

        //ASSERT
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void ChangeFormatIncorrect()
    {   
        //ARRANGE
        string dateIncorrect = "2003/05/08";

        //ACT
        string result = DateFormatter.ChangeFormat(dateIncorrect);

        //ASSERT
        Assert.That(result, Is.Null.Or.Empty);
    }
    [Test]
    public void ChangeFormatEmpty()
    {   
        //ARRANGE
        string dateEmpty = "";

        //ACT
        string result = DateFormatter.ChangeFormat(dateEmpty);

        //ASSERT
        Assert.That(result, Is.Null.Or.Empty);
    }
    [Test]
    public void ChangeFormatIncorrectLength()
    {   
        //ARRANGE
        string dateIncorrectLength = "08/05/20003";

        //ACT
        string result = DateFormatter.ChangeFormat(dateIncorrectLength);

        //ASSERT
        Assert.That(result, Is.Null.Or.Empty);
    }
}