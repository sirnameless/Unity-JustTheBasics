using UnityEngine;

public class GameplayScript : MonoBehaviour {

    public Rigidbody2D playerOne; //reference to P1 Bunny, set in the Editor
    public Rigidbody2D playerTwo; //reference to P2 Bunny, set in the Editor

    private float movementSpeed = 10; //how fast our bunnies should move

    private void Start()
    {
        GameObject global = GameObject.Find("GLOBAL_OBJECT");
        GlobalScript globalScript = global.GetComponent<GlobalScript>();
        Debug.Log("PLAYERS: " + globalScript.players);
    }

    void Update () {

        //listen for controller input
        var playerOneMovement = (Input.GetAxis("P1_Horizontal") + Input.GetAxis("P1_Horizontal_Btn")) * movementSpeed;
        var playerTwoMovement = (Input.GetAxis("P2_Horizontal") + Input.GetAxis("P2_Horizontal_Btn")) * movementSpeed;

        //move players
        playerOne.AddForce(new Vector2(playerOneMovement, 0));
        playerTwo.AddForce(new Vector2(playerTwoMovement, 0));

        //mirror the image by flipping the X scale if player is moving left
        if(playerOneMovement < 0)
        {
            playerOne.transform.localScale = new Vector3(-1, 1, 1);
        } else {
            playerOne.transform.localScale = new Vector3(1, 1, 1);
        }

        if(playerTwoMovement < 0)
        {
            playerTwo.transform.localScale = new Vector3(-1, 1, 1);
        } else {
            playerTwo.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
