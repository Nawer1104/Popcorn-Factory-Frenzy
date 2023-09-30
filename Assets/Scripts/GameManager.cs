using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<GameObject> popcorns;

    public List<Transform> spawnPoints;

    public GameObject popcornPrefab;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        foreach(Transform trans in spawnPoints)
        {
            GameObject popcorn = Instantiate(popcornPrefab, trans.position, Quaternion.identity) as GameObject;
            popcorns.Add(popcorn);
        }
    }
    public void ReSpawn()
    {
        if (popcorns.Count == 0)
        {
            Spawn();
        }
    }
}