using UnityEngine;

public class GroundPooling : ObjectPooling
{
    public static GroundPooling _sharedInstance;
    public override void Awake()
    {
        base.Awake();
        _sharedInstance = this;
    }

    // Update is called once per frame
   
}
