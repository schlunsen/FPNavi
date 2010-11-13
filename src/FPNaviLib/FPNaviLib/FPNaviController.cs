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

        public void changeWaypoint(Waypoint waypoint)
        {
            //push current waypoint to history stack
            m_waypointHistory.Push(m_currentWaypoint);
            
            // Change current waypoint         
            m_currentWaypoint = waypoint;

            // Dispatch event here

            
        }

    }
}
