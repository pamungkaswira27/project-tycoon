using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    [Header("Public Storage Variable")]
    [SerializeField]
    private RoomUpgradeController _roomUpgradeController;
    public RoomUpgradeController RoomUpgradeController => _roomUpgradeController;

    [SerializeField]
    private RoomExpanderController _roomExpanderController;
    public RoomExpanderController RoomExpanderController => _roomExpanderController;

    private void Awake()
    {
        Instance = this;
    }
}
