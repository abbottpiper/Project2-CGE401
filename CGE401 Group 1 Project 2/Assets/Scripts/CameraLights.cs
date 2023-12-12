/* Denver Heneghan
 * CameraLights
 * Group Project 2
 * There is a wire method that is used by a button in the Unity script. The num int is the same from the security camera script, and it is
 * kept track of in a GameManager object. Depending on the number num reaches, a specific light game object and wire box outside game object are
 * destroyed. This clears the obstacle blocking the path, and prevents the player from redoing the completed minigame. 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLights : MonoBehaviour
{
    int num = 0;
    int wireAmount = 0;

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;

    public GameObject WireBoxOutside;
    public GameObject WireBoxOutside1;
    public GameObject WireBoxOutside2;
    public GameObject WireBoxOutside3;
    public GameObject WireBoxOutside4;

    void Update()
    {
        if (num == 1)
        {
            Destroy(Light1);
            Destroy(WireBoxOutside);
        }

        if (num == 2)
        {
            Destroy(Light2);
            Destroy(WireBoxOutside1);
        }

        if (num == 3)
        {
            Destroy(Light3);
            Destroy(WireBoxOutside2);
        }

        if (num == 4)
        {
            Destroy(Light4);
            Destroy(WireBoxOutside3);
        }

        if (num == 5)
        {
            Destroy(Light5);
            Destroy(WireBoxOutside4);
        }
    }

    public void Wires()
    {
        wireAmount++;

        if (wireAmount == 5)
        {
            num++;
            wireAmount = 0;
        }
    }
}
