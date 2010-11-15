using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


    [System.Serializable]
    public class IInterpolation
    {
        public enum InterpolationTypes { Move,Path}
        public virtual IEnumerator DoInterpolation()
        {
            return null;
        }
        public float time;
        public InterpolationTypes type;


    }

