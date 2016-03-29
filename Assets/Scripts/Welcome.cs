using UnityEngine;
using UnityEngine.UI;

public class Welcome : MonoBehaviour {

    private GameObject welcomeCanvas;
    private Text panelText;

    // Use this for initialization
    void Start()
    {
        welcomeCanvas = GameObject.Find("WelcomeCanvas");
        panelText = GameObject.Find("WelcomeText").GetComponent<Text>();
        panelText.text = "Welcome";

        // Invoke("HideMessage", 3.5f);
        StartCoroutine(HideWithDelay());
    }

    // Update is called once per frame
    void Update()
    {
    }

    void HideMessage() {
        welcomeCanvas.SetActive(false);
    }

    IEnumerator HideWithDelay(float delay = 0f) {
        yield return new WaitForSeconds(delay);
        HideMessage();
    }
}
