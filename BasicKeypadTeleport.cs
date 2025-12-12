
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using TMPro;

[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class BasicKeypadTeleport : UdonSharpBehaviour
{
    [SerializeField] private Transform teleportLocation;
    [SerializeField] private string keyCode = "123";
    [SerializeField] private string defaultMsg = "Enter Code";
    [SerializeField] private string wrongMsg = "Wrong! try again.";
    private VRCPlayerApi localPlayer;
    private TMP_Text output;

    void Start()
    {
        localPlayer = Networking.LocalPlayer;
        output = transform.Find("Canvas/Output").GetComponent<TMP_Text>();
        output.text = defaultMsg;
    }

    bool IsNumeric(string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c < '0' || c > '9')
                return false;
        }
        return true;
    }

    public void KeyPress(string key)
    {
        switch (key)
        {
            case "Enter":
                if (output.text == keyCode)
                    localPlayer.TeleportTo(teleportLocation.transform.position, teleportLocation.transform.rotation, VRC_SceneDescriptor.SpawnOrientation.AlignRoomWithSpawnPoint, false);
                else
                    output.text = wrongMsg;
                break;

            case "Clear":
                output.text = defaultMsg;
                break;

            default:
                if (!IsNumeric(output.text))
                    output.text = key;
                else
                    output.text += key;
                break;
        }
    }
}
