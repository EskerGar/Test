using System;
using UnityEngine;
using UnityEngine.UI;

namespace Task2
{
    public class SpawnValuesController : MonoBehaviour
    {
        [SerializeField] private InputField delayField;
        [SerializeField] private InputField speedField;
        [SerializeField] private InputField distanceField;

        [SerializeField] private SpawnPoint spawnPoint;

        private void Start()
        {
            delayField.onEndEdit.AddListener(spawnPoint.ParseTimeDelay);
            speedField.onEndEdit.AddListener(spawnPoint.ParseSpeed);
            distanceField.onEndEdit.AddListener(spawnPoint.ParseDistance);
        }
    }
}