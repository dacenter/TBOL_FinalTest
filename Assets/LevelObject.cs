using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class LevelObject : MonoBehaviour
{
    public bool UseTrigger;

    public bool CanDeactivate;

    public UnityEvent<Player> PlayerTouch;



    public void OnPlayerTouch(Player player)
    {
        PlayerTouch.Invoke(player);
    }
}
