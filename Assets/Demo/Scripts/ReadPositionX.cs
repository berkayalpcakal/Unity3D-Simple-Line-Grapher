using UnityEngine;
using LineGrapher;

public class ReadPositionX : DataReaderBase
{
    public override float ReadValue()
    {
        return GetComponent<Transform>().position.x;
    }
}