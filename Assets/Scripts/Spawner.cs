using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Opponent _opponentPrefab;
    [SerializeField] private Vector3 _direction;

    [SerializeField] private float _delay;
    [SerializeField] private int _countSpawn;

    private void Start()
    {
        StartCoroutine(SpawnOpponents());
    }

    private IEnumerator SpawnOpponents()
    {
        var wait = new WaitForSeconds(_delay);

        for(int i = 0; i < _countSpawn; i++)
        {
            Spawn();
            yield return wait;
        }
    }

    private void Spawn()
    {
        Opponent newOpponent = Instantiate(_opponentPrefab, RandomSpawnPoint(), Quaternion.identity);
        newOpponent.SetDirection(_direction);
    }

    public Vector3 RandomSpawnPoint()
    {
        int randomIndex = Random.Range(0, _spawnPoints.Length);
        Transform spawnPoint = _spawnPoints[randomIndex];

        return spawnPoint.position;
    }
}
