using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SpatialPartitionPattern
{
    public class Timer : MonoBehaviour
    {
        public GameController GameController;

        public TextMeshProUGUI TimeText;

        // Update is called once per frame
        void Update()
        {
            float Timer = GameController.Timer;
            TimeText.text = Timer.ToString("F5");
        }
    }
}
