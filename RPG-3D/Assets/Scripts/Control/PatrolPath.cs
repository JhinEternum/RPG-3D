using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Control
{
    public class PatrolPath : MonoBehaviour
    {

        [SerializeField] private float gizmosRadius = 2f;

        private void OnDrawGizmos()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Vector3 child = GetWaypoint(i);
                int j = GetNextIndex(i);

                Gizmos.DrawSphere(child, gizmosRadius);
                Gizmos.DrawLine(child, GetWaypoint(j));
            }
        }

        public int GetNextIndex(int i)
        {
            return i + 1 == transform.childCount ? 0 : i + 1;
        }

        public Vector3 GetWaypoint(int i)
        {
            return transform.GetChild(i).position;
        }
    }
}
