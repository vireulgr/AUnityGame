using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneManager : MonoBehaviour {
    GameObject intro;
    GameObject authorsPanel;
    GameObject menuPanel;
    // Start is called before the first frame update
    void Start() {
        intro = GameObject.Find("zast");
        menuPanel = GameObject.Find("Main menu panel");
        authorsPanel = GameObject.Find("Authors Panel");

        menuPanel.SetActive(false);
        authorsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update() { }

    public void introIsOver() {
        intro.transform.Translate(-10.0f, -10.0f, 0f);
        intro.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void PlayGame()    {
        //Application.LoadLevel("Game");
        SceneManager.LoadScene("LevelOne", LoadSceneMode.Single);
    }

    public void Exit() {
        Application.Quit();
    }

    public void AuthorsPanel() {
        authorsPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void BackFromAuthorsPanel() {
        menuPanel.SetActive(true);
        authorsPanel.SetActive(false);
    }
}
