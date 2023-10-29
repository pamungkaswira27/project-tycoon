using UnityEngine;

public class RoomController : MonoBehaviour
{
    [SerializeField]
    private string _id;
    [SerializeField]
    private int _income;
    [SerializeField]
    private UpgradePart[] _upgrades;

    [System.Serializable]
    public struct UpgradePart
    {
        public string name;
        public int cost;
        public int bonusIncome;
        public bool isUpgraded;
    }

    public string Id => _id;

    private void OnMouseDown()
    {
        LevelManager.Instance.RoomUpgradeController.OpenUpgradeWindow(this);
    }

    public UpgradePart GetUpgradePart(int index)
    {
        return _upgrades[index];
    }

    public void BuyUpgradePart(int index)
    {
        _upgrades[index].isUpgraded = true;
    }
}
