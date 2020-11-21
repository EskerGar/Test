using System;
using System.Collections;
using UnityEngine;

namespace Task2
{
    public class SpawnPoint : MonoBehaviour
    {
        [SerializeField] private GameObject prefabCube;

        private float _timeDelay = 2f;
        private float _speed = .1f;
        private float _distance = 3f;

        public void ParseTimeDelay(string value) => float.TryParse(value, out _timeDelay);
        
        public void ParseSpeed(string value) => float.TryParse(value, out _speed);
        
        public void ParseDistance(string value) => float.TryParse(value, out _distance);

        private void CreateCube()

        {
            var go = Instantiate(prefabCube, transform.position, transform.rotation).GetComponent<CubeBehaviour>();
            go.Initialize(_speed, _distance);
        }
        
        private IEnumerator GenerateCubes()
        {
            while (true)
            {
                CreateCube();
                yield return new WaitForSeconds(_timeDelay);
            }
        }

        private void Start()
        {
            StartCoroutine(GenerateCubes());
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawCube(transform.position, Vector3.one);
        }
    }
}
