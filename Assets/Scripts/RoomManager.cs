using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public static RoomManager Instance;

    [SerializeField]
    private RoomController[] _roomList;
    [SerializeField]
    private int _maxAvailableRoom;

    public int MaxAvailableRoom => _maxAvailableRoom;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Init();
    }

    public void AddRoom(RoomController room)
    {
        for (int i = 0; i  < _maxAvailableRoom; i++)
        {
            if (_roomList[i] != null) continue;

            _roomList[i] = room;
            break;
        }
    }

    private void Init()
    {
        Instantiate(_roomList[0].gameObject);
    }
}
