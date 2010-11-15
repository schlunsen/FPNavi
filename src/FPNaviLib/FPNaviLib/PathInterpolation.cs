using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

namespace FPNavi
{
    [System.Serializable]
    public class PathInterpolation : IInterpolation
    {
        public Transform[] movePath;
        public Transform[] lookPath;

        #region IInterpolation Members

        public IEnumerator DoInterpolation()
        {            
            
            throw new NotImplementedException();
        }

        #endregion
    }
}
