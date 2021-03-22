using FluentAssertions;
using NUnit.Framework;
using TestedProject;
using TestStack.BDDfy;

namespace UnitTestProject
{
  [TestFixture]
  public class StringServiceTests
  {
    [Test]
    public void GetStringTest()
    {
      var expected = "Hello, World!";

      var service = new StringService();
      var actual = service.GetString();

      Assert.AreEqual(expected, actual);
    }




    private StringService service;
    private Store store;

    [OneTimeSetUp]
    public void SetUpOnce()
    {
      this.service = new StringService();
    }

    [SetUp]
    public void SetUp()
    {
      this.store = new Store();
    }

    [TearDown]
    public void TearDown()
    {
      this.service.Dispose();
    }

    [Test]
    public void GetStringWithNameTest()
    {
      var expectedName = "Ivan";
      var expected = "Hello, " + expectedName + "!";

      var actual = this.service.GetString(expectedName);

      Assert.AreEqual(expected, actual);
    }






    [Test]
    [TestCase("First", "Second")]
    [TestCase("One", "Two")]
    public void ConcatStringsTest(string string1, string string2)
    {
      var expected = string1 + string2;

      var actual = this.service.ConcatStrings(string1, string2);

      Assert.AreEqual(expected, actual);
    }







    [Test]
    public void GetStringWithDefaultNameTest()
    {
      var expectedName = "Ivan";
      var expected = "Hello, " + expectedName + "!";

      this.store.SetParam("DefaultName", expectedName);

      var actual = this.service.GetString(expectedName);

      Assert.AreEqual(expected, actual);
    }





    private string name;
    private string result;

    [Test]
    public void GetStringWithDefaultNameShouldReturnStringWithGivenDefaultNameTest()
    {
      this
        .Given(_ => _.GivenDefaultName())
        .When(_ => _.WhenGetStringWithDefaultName())
        .Then(_ => _.ThenResultShouldStartWithHello())
          .And(_ => _.ThenResultShouldContainsName())
        .BDDfy();
    }

    private void GivenDefaultName()
    {
      this.name = "John";
      this.store.SetParam("DefaultName", this.name);
    }

    private void WhenGetStringWithDefaultName()
    {
      this.result = this.service.GetStringWithDefaultName();
    }

    private void ThenResultShouldStartWithHello()
    {
      this.result.Should().StartWith("Hello");
    }

    private void ThenResultShouldContainsName()
    {
      this.result.Should().Contain(this.name);
    }
  }
}
