using UnityEngine;

namespace LineGrapher
{
    public abstract class DataReaderBase : MonoBehaviour
    {
        public void GetValue(LineGrapher.GraphConfig config)
        {
            config.dataBuffer.AddToBuffer(ReadValue());
        }
        public abstract float ReadValue();
    }
}