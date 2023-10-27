using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject[] MonsterPrefabs;    // ������ ������ ���� ������
    public float spawnRateMin = 0.5f;   // �ּ� ���� �ֱ�
    public float spawnRateMax = 3f;     // �ִ� ���� �ֱ�

    private Transform target; // �߻��� ���
    private float spawnRate;  // ���� �ֱ�
    private float timeAfterSpawn; // �ֱ� ���� �������� ���� �ð�

    // Start is called before the first frame update
    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0.0f;
        // ���� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        // PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        // timeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;

        // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if(timeAfterSpawn >= spawnRate)
        {
            // ������ �ð��� ����
            timeAfterSpawn = 0.0f;

            // bulletPrefab�� �������� 
            // transform.position ��ġ�� transform.rotation ȸ������ ����
            // ���������� �迭�� �ִ� ������Ʈ �� ������ ������Ʈ ����
            int index = Random.Range(0, MonsterPrefabs.Length);
            GameObject monster = Instantiate(MonsterPrefabs[index], transform.position, transform.rotation);
            // ������ Monster ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��
            //monster.transform.LookAt(target);

            // ������ ���� ������ spawnRateMin, spawnRateMax ���̿��� ���� ����
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
