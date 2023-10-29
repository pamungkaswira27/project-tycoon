using TMPro;
using UnityEngine;

public class RoomUpgradeController : MonoBehaviour
{
    [Header("Upgrade Menu UI")]
    [SerializeField]
    private CanvasGroup _upgradeMenuCanvas;
    [SerializeField]
    private TextMeshProUGUI _upgradeMenuHeader;
    [SerializeField]
    private UI_UpgradePart[] _uIUpgradeParts;

    private RoomController _currentRoom;

    public void OpenUpgradeWindow(RoomController room)
    {
        _currentRoom = room;
        _upgradeMenuHeader.text = $"{_currentRoom.Id}\r\nUpgrade Menu";

        for (int i = 0;  i < _uIUpgradeParts.Length; i++)
        {
            _uIUpgradeParts[i].SetUpgradePartName(_currentRoom.GetUpgradePart(i).name);
            _uIUpgradeParts[i].SetUpgradePartCost(_currentRoom.GetUpgradePart(i).cost);
        }

        _upgradeMenuCanvas.alpha = 1f;

        Debug.Log($"[{nameof(RoomUpgradeController)}]: Open Upgrade Menu for Room {_currentRoom.Id}");
    }

    public void ConfirmUpgrade(int index)
    {
        _currentRoom.BuyUpgradePart(index);
        Debug.Log($"[{nameof(RoomUpgradeController)}]: Room {_currentRoom.Id} Upgraded! Added {_currentRoom.GetUpgradePart(index).name}");
    }
}
