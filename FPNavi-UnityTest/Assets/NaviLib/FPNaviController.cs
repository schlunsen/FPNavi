using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace FPNavi
{
    /**
     * 
     * */
    public class FPNaviController : MonoBehaviour
    {
        public enum ControllerStates { Positioned, Moving }
        private ControllerStates m_controllerState;
        
        public bool isEnabled { get; set; }
        public Camera naviCam;

        public List<Waypoint> Waypoints;


        // Waypoint stuff
        private Waypoint m_currentWaypoint;
        public Waypoint CurrentWaypoint
        {
            get
            { return m_currentWaypoint; }
        }

        private Stack<Waypoint> m_waypointHistory; 
        public Stack<Waypoint> WaypointHistory {
         get  {return m_waypointHistory;}   
        }

        void Awake()
        {
            m_controllerState = ControllerStates.Positioned;
            m_waypointHistory = new Stack<Waypoint>();
        }


        private void changeWaypoint(Waypoint waypoint)
        {
            //push current waypoint to history stack
            m_waypointHistory.Push(m_currentWaypoint);

            m_controllerState = ControllerStates.Moving;

            // Do interpolation           
               
            
            // Change current waypoint on complete         
            m_currentWaypoint = waypoint;

            // Dispatch complete event here
           
        }

        public void MoveToDirection(Direction d)
        {
            StartCoroutine(d.interpolation.DoInterpolation());
        }


    }
}
