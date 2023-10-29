using TMPro;
using UnityEngine;

public class UI_UpgradePart : MonoBehaviour
{
    [SerializeField]
    private RoomUpgradeController _roomUpgradeController;
    [SerializeField]
    private TextMeshProUGUI _upgradePartNameText;
    [SerializeField]
    private TextMeshProUGUI _upgradePartCostText;

    public void SetUpgradePartName(string partName)
    {
        _upgradePartNameText.text = partName;
    }

    public void SetUpgradePartCost(int partCost)
    {
        _upgradePartCostText.text = partCost.ToString();
    }

    public void Upgrade()
    {
        _roomUpgradeController.ConfirmUpgrade(transform.GetSiblingIndex());
    }
}
