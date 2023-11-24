using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class PlayModeTestGame
{
    [SetUp]
    public void SetUp()
    {
        // Modify this with first scene in the game
        // UnityEngine.SceneManagement.SceneManager.LoadScene("DefaultScene");
    }

    [UnityTest]
    public IEnumerator TestMenu()
    {
        Assert.IsTrue(true);

        yield return false;
    }
}
