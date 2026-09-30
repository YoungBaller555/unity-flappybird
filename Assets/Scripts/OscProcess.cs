using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;


public class OscProcess : MonoBehaviour
{
    public GameManager gameManager;
    public Player player;


public extOSC.OSCReceiver oscReceiver;

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TriggerJump(OSCMessage message)
    {
        gameManager.StartGame(); // Ignored if game is already playing, handled in GameManager
        player.Jump();
    }
}
