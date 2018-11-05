using UnityEngine;
using UnityEngine.SceneManagement; //needed to be able to switch scenes

public class PlayerScript : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        //if a collision occurs with an object tagged "Carrot," change scenes
        if(col.gameObject.tag.Equals("Carrot"))
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
