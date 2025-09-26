using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Murdoch.GAD361.GADVRMini;

public class ChopGame : Minigame
{
    int targetCarrots = 3;
    int carrotCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        InitVR();
        //StartGame(); //comment this out to test without timer
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChopCarrot(GameObject knife, GameObject carrot)
    {
        Debug.Log("Chopped a carrot");
        carrotCount = carrotCount + 1;
        Destroy(carrot);
        if (carrotCount == targetCarrots)
        {
            WinGame();
        }
    }

    public void ChopApple(GameObject knife, GameObject apple)
    {
        Debug.Log("Chopped an apple");
        Destroy(apple);
    }
}
