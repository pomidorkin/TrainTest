using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainTest : MonoBehaviour
{
    [SerializeField]
    Cinemachine.CinemachinePathBase pathTwo;

    Cinemachine.CinemachinePathBase path;

    // Start is called before the first frame update
    void Start()
    {
        path = gameObject.GetComponent<Cinemachine.CinemachineDollyCart>().m_Path;
        // Получаем у объекта Train его path и назначаем ему другой path
        gameObject.GetComponent<Cinemachine.CinemachineDollyCart>().m_Path = pathTwo;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
