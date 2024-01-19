using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoints _spawnPoints;
    [SerializeField] private GameObject _opponent;

    [SerializeField] private float _delay;
    [SerializeField] private int _start;

    private void Start()
    {
        StartCoroutine(SpawnOpponent());
    }

    private IEnumerator SpawnOpponent()
    {
        var wait = new WaitForSeconds(_delay);

        for(int i = 0; i < _start; i--)
        {
            Spawn();
            yield return wait;
            Debug.Log("Заспавнен противник" );
        }
    }

    private void Spawn()
    {
        Instantiate(_opponent, _spawnPoints.RandomSpawnPoint(), Quaternion.identity);
    }

}
