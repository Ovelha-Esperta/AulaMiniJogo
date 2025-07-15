using UnityEngine;

public class GroundPooling : ObjectPooling
{
    public static GroundPooling _groundPool;
    public override void Awake()
    {
        base.Awake();
        _groundPool = this;
    }

    // Update is called once per frame
   
}
