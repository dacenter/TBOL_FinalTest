using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Bonus : MonoBehaviour
{

    public LevelObject LevelObject;

    public float SizeMultiplier;

    // Update is called once per frame
    public void OnPlayerPick(Player player)
    {
        player.SetSize(player.Size*SizeMultiplier);
        Destroy(this.gameObject);
    }
}
