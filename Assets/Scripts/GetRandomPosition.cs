using UnityEngine;

internal sealed class GetRandomPosition
{
    private Vector3 _position;
    private readonly float _spawnSpace = 10f;
   
    public Vector3 GetPosition()
    {
        _position =  new Vector3(Random.Range(-_spawnSpace, _spawnSpace), Random.Range(-_spawnSpace, _spawnSpace), 0);
        return _position;
    }
}
