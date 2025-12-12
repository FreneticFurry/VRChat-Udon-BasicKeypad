
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class BasicKeypadKey : UdonSharpBehaviour
{
    [SerializeField] private BasicKeypadTeleport keypad;
    public override void Interact()
    {
        keypad.KeyPress(gameObject.name);
    }
}
