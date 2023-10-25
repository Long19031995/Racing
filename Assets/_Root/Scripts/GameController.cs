using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    PlayerSO playerSO;

    public List<Transform> points;
    public CameraFollower cameraFollower;

    private void Awake()
    {
        playerSO = Resources.Load<PlayerSO>("PlayerSO");
    }

    private void Start()
    {
        var randomPrefab = Random.Range(0, playerSO.prefabs.Count);
        var randomPoint = Random.Range(0, points.Count);
        var player = Instantiate(playerSO.prefabs[randomPrefab], transform);
        player.transform.position = points[randomPoint].position;
        cameraFollower.target = player.transform;
    }
}
