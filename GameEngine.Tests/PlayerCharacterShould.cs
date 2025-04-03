namespace GameEngine.Tests {
  public class PlayerCharacterShould {
    [Fact]
    public void BeInexperienceWhenNew() {
      PlayerCharacter sut = new PlayerCharacter();

      Assert.True(sut.IsNoob);
    }
  }
}