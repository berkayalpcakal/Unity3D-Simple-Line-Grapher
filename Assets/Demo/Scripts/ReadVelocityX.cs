using UnityEngine;
using LineGrapher;

public class ReadVelocityX : DataReaderBase
{
    public override float ReadValue()
    {
        return GetComponent<Rigidbody>().velocity.x;
    }
}