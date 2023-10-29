using UnityEngine;

public class RoomExpanderController : MonoBehaviour
{
    [SerializeField]
    private GameObject _roomPrefab;


    public int _numberOfRoom = 1;

    public void ExpandRoom()
    {
        if(_numberOfRoom <= 6)
        {
            _numberOfRoom++;
        }
        
        if (_numberOfRoom > RoomManager.Instance.MaxAvailableRoom) return;

        GameObject roomPrefab = Instantiate(_roomPrefab);
        RoomController room = roomPrefab.GetComponent<RoomController>();
        RoomManager.Instance.AddRoom(room);
    }
}
