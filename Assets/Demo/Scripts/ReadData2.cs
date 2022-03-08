using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LineGrapher;

public class ReadData2 : DataReaderBase
{
    public override float ReadValue()
    {
        return GetComponent<DataSource>().Data2;
    }
}