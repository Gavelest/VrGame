using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Murdoch.GAD361.GADVRMini;

public class PingPong : Minigame
{
    public int returnsTarget = 3;
    int returns = 0;
    // Start is called before the first frame update
    void Start()
    {
        InitVR();
        //StartGame();
    }

    public void ReturnedBall(GameObject ball, GameObject area)
    {
        Ball ballscript = ball.GetComponent<Ball>();
        if (ballscript != null && ballscript.isActive)
        {
            returns += 1;
            Destroy(ball);
            Debug.Log(returns);
            if (returns == returnsTarget)
            {
                //WinGame();
            }
        }
    }

    public void FailedBall(GameObject ball, GameObject badarea)
    {
        Ball ballscript = ball.GetComponent<Ball>();
        if (ballscript != null && ballscript.isActive)
        {
            Destroy(ball);
        }
    }
}
