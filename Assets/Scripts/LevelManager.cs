using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    [SerializeField]
    private RoomUpgradeController _roomUpgradeController;

    public RoomUpgradeController RoomUpgradeController => _roomUpgradeController;

    private void Awake()
    {
        Instance = this;
    }
}
