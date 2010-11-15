using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


    [System.Serializable]
    public class Direction 
    {
        public enum MoveDirections { Up, Down, Forward, Backward, Left, Right, Custom }
        public MoveDirections m_moveDirection;                   
        public Waypoint endPoint;
        public IInterpolation interpolation;

    }

