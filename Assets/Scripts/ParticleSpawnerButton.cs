using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleSpawnerButton : MonoBehaviour
{
    [SerializeField] private int _index;
    [SerializeField] private int _spawnCount = 1;

    public void RequestSpawnParticle()
    {
        for (var i = 0; i < _spawnCount; i++)
            ParticleSpawner.Instance.Spawn(_index);
    }

    private void OnValidate()
    {
        _index = transform.GetSiblingIndex();
        GetComponentInChildren<Text>().text = (_index + 1).ToString();
    }
}
