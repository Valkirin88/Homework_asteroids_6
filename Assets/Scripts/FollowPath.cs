using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpacePatterns
{
    internal sealed class FollowPath : MonoBehaviour
    {
        public enum MovementType
        {
            Moving,
            Lerping
        }
        
        public MovementType Type = MovementType.Moving;
        public EnemeyMovementPathCreator MyPath;
        public float Speed = 1;
        public float maxDistance = 0.1f;

        private IEnumerator<Transform> pointInPath;

        void Start()
        {
            if(MyPath == null)
            {
                Debug.Log("Примени путь");
                return;
            }

            pointInPath = MyPath.GetNextPathPoint();
            pointInPath.MoveNext();

            if(pointInPath.Current == null)
            {
                Debug.Log("Нужны точки");
                return;
            }
            transform.position = pointInPath.Current.position;
        }

        void Update()
        {
            if (pointInPath == null|| pointInPath.Current == null)
            {
                return;
            }

            if(Type == MovementType.Moving)
            {
                transform.position = Vector3.MoveTowards(transform.position, pointInPath.Current.position, Time.deltaTime*Speed);
            }
            else if (Type == MovementType.Lerping)
            {
                transform.position = Vector3.Lerp(transform.position, pointInPath.Current.position, Time.deltaTime*Speed);
            }

            var distanceToPoint = (transform.position - pointInPath.Current.position).sqrMagnitude;
            if (distanceToPoint < maxDistance * maxDistance)
            {
                pointInPath.MoveNext();
            }

        }

    }
}
