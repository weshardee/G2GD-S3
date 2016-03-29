using UnityEngine;
using System.Collections;
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

        // Invoke("HideMessage", 3.5f);
        StartCoroutine(HideMessage(3.5f));
    }

    IEnumerator HideMessage(float delay = 0f)
    {
        if (delay > 0) {
            yield return new WaitForSeconds(delay);
        }
        welcomeCanvas.SetActive(false);
    }
}
