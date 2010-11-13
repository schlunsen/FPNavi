using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace LogicManagerLib
{
    public class GameLogicManager : MonoBehaviour
    {
        #region // Singleton stuff
        private static GameLogicManager m_instance;

        public static GameLogicManager Instance
        {
            get
            {
                // Check to see if allready added in editor
                if (m_instance == null)
                {
                    m_instance = FindObjectOfType(typeof(GameLogicManager)) as GameLogicManager; 
                }   

                //if still null
                if (m_instance == null)
                {
                    GameObject go = new GameObject("GameLogicManager");
                    m_instance = go.AddComponent(typeof(GameLogicManager)) as GameLogicManager;
                    Debug.Log("Created new GameLogicManager Gameobject");
                }
                return m_instance;
                
            }
        }

        #endregion
    }
}
