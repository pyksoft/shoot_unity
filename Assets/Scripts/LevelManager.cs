using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

  public void LoadLevel(string levelName) {

    SceneManager.LoadScene(levelName);
  }

  public void LoadNextLevel() {
    int indexSC = SceneManager.GetActiveScene().buildIndex;
    int nextScene = indexSC + 1;
    SceneManager.LoadScene(nextScene);
  }

  public void QuitRequest() {

    // Application.Quit(); is an anti-pattern on mobile
    // the application state should be managed by the OS and the User
    Application.Quit();
  }



}
