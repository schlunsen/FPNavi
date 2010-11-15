using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace FPNavi
{
    class FPNaviManager : MonoBehaviour
    {
        #region // Singleton stuff
        private static FPNaviManager m_instance;

        public static FPNaviManager Instance
        {
            get
            {
                // Check to see if allready added in editor
                if (m_instance == null)
                {
                    m_instance = FindObjectOfType(typeof(FPNaviManager)) as FPNaviManager;
                }

                //if still null
                if (m_instance == null)
                {
                    GameObject go = new GameObject("FPNaviManager");
                    m_instance = go.AddComponent(typeof(FPNaviManager)) as FPNaviManager;
                    Debug.Log("Created new FPNaviManager Gameobject");
                }
                return m_instance;

            }
        }

        #endregion

        private FPNaviController m_currentNaviController;
        public FPNaviController CurrentNaviController
        {
            get
            {
                return m_currentNaviController;
            }

        }


    }
}
