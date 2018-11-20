using UnityEngine;
using UnityEngine.UI; //needed to use Unity's Canvas UI features
using UnityEngine.SceneManagement; //needed to be able to switch scenes

public class MainMenuScript : MonoBehaviour {

    public GameObject bunny; //reference to bunny image, set in the Editor
    public Text bunnyButtonText; //reference to the bunny button's text, set in the Editor

    //constant strings, which will not change later, can easily be found & edited here
    private const string SHOW_BUNNY_TEXT = "CLICK TO SHOW THE BUNNY";
    private const string HIDE_BUNNY_TEXT = "CLICK TO HIDE THE BUNNY";

    public void StartGameScene()
    {
        GameObject global = GameObject.Find("GLOBAL_OBJECT");
        GlobalScript globalScript = global.GetComponent<GlobalScript>();
        globalScript.players = 2;
        SceneManager.LoadScene("GameScene");
    }

    public void HideOrShowTheBunny()
    {
        if(bunny.activeInHierarchy)
        {
            bunny.SetActive(false);
            bunnyButtonText.text = SHOW_BUNNY_TEXT;
        } else {
            bunny.SetActive(true);
            bunnyButtonText.text = HIDE_BUNNY_TEXT;
        }
    }
}
