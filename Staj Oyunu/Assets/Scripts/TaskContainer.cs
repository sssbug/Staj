using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class TaskContainer : MonoBehaviour
    {
        void Start()
        {
            TaskManager.Instance.taskBasla = true;
            TaskManager.Instance.missionContainer = gameObject;
        }

    }
}
