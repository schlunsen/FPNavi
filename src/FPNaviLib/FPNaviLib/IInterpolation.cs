using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FPNavi
{
    [System.Serializable]
    public class IInterpolation
    {
        public virtual IEnumerator DoInterpolation()
        {
            return null;
        }
        public float time;
    }
}
