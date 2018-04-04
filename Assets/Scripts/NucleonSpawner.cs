using UnityEngine;

public class NucleonSpawner : MonoBehaviour {

    public float timeBetweenSpawns;

    public float spawnDistance;

    public Nucleon[] nucleonPrefabs;

    float timeSinceLastSpawn;

    void FixedUpdate() {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= timeBetweenSpawns) {
            timeSinceLastSpawn -= timeBetweenSpawns;
            SpawnNucleon();
        }
    }

    void SpawnNucleon() {

        // Randomly select a prefab 
        Nucleon prefab = nucleonPrefabs[Random.Range(0, nucleonPrefabs.Length)];

        // Instantitate it
        Nucleon spawn = Instantiate<Nucleon>(prefab);

        // Giving it a random position to start
        spawn.transform.localPosition = Random.onUnitSphere * spawnDistance;
    }
}
