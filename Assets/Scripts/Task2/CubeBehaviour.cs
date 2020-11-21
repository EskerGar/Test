using System;
using UnityEngine;

namespace Task2
{
    public class CubeBehaviour : MonoBehaviour
    {
        private float _speed;
        private float _distance;
        private Vector3 _startPoint;
        
        public void Initialize(float speed, float distance)
        {
            _speed = speed;
            _distance = distance;
            _startPoint = transform.position;
        }

        private void Update()
        {
            if((transform.position - _startPoint).magnitude < _distance)
                transform.position += transform.forward * _speed;
            else
                Destroy(gameObject);
        }
    }
}