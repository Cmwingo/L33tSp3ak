using Xunit;
using LeetSpeak.Objects;
namespace LeetSpeak
{
  public class LeetSpeakTranslatorTest
  {
    [Fact]
    public void LeetSpeakTranslator_ReplaceEsWithThrees_True()
    {
      string testString = "Help";
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.Equal("H3lp", testLeetSpeakTranslator.Translate(testString));
    }
    [Fact]
    public void LeetSpeakTranslator_ReplacesOsWithZeros_True()
    {
      string testString = "Dog";
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.Equal("D0g", testLeetSpeakTranslator.Translate(testString));
    }
    [Fact]
    public void LeetSpeakTranslator_ReplacesIsWithOnes_true()
    {
      string testString = "Inn";
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.Equal("1nn", testLeetSpeakTranslator.Translate(testString));
    }
    [Fact]
    public void LeetSpeakTranslator_ReplacesLowerCaseIsWithOnes_false()
    {
      string testString = "I dig";
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.Equal("1 dig", testLeetSpeakTranslator.Translate(testString));
    }
    [Fact]
    public void LeetSpeakTranslator_ReplacesSsWithZs_True()
    {
      string testString = "As";
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.Equal("Az", testLeetSpeakTranslator.Translate(testString));
    }
    [Fact]
    public void LeetSpeakTranslator_ReplacesWordsThatStartWithSWithZ_False()
    {
      string testString = "As Sam";
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.Equal("Az Sam", testLeetSpeakTranslator.Translate(testString));
    }
  }
}
