using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private GameObject[] targets;
    public float speed = 3f;
    public float rotationSpeed = 3f;

    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("BreakableWall");
    }

    void Update()
    {
        Move(targets[0].transform);
    }

    void Move(Transform target)
    {
        if (target == null) return;

        Vector3 dir = target.position - transform.position;
        dir.y = 0;

        if (dir.magnitude < 1f) return;

        Quaternion lookRotation = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            lookRotation,
            rotationSpeed * Time.deltaTime
        );

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
