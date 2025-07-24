using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GameControl : MonoBehaviour
{
    [SerializeField] Transform _groundBase;
    [SerializeField] float _groundH;
    [SerializeField] float _distance;
    void Start()
    {
        _groundH = _groundBase.position.y;
        for (int i = 0; i < 10; i++)
        {
            Invoke("GroundStart", 0.5f);
        }

    }

   void GroundStart()
    {
      //  Debug.Log("Ativar Ground");
        GameObject bullet = GroundPooling._groundPool.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position= new Vector2(_groundBase.transform.position.x, _groundH + _distance);
            _groundH = bullet.transform.position.y;
           // bullet.transform.position = turret.transform.position;
           // bullet.transform.rotation = turret.transform.rotation;
            bullet.SetActive(true);
        }
    }
}
