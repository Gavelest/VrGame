using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Murdoch.GAD361.GADVRMini;

public class Bat : MonoBehaviour
{
    public float dist = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGrabbed(Draggable d)
    {
        
        GADManager.Instance.minigame.PullToHand(d.currentGrabber, dist);
    }

    public void HitBall(GameObject bat, GameObject ball)
    {
        Ball ballscript = ball.GetComponent<Ball>();
        if (ballscript != null)
        {
            ballscript.isActive = true;
        }
    }
}
