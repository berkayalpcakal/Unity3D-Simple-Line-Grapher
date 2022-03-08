using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LineGrapher;

public class ReadData1 : DataReaderBase
{
    public override float ReadValue()
    {
        return GetComponent<DataSource>().Data1;
    }
}