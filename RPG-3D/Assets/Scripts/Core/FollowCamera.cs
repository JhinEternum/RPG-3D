using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {

        [SerializeField] private Transform player;

        void LateUpdate()
        {
            transform.position = player.position;
        }
    }
}
