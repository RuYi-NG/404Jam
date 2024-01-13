using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBehavior : MonoBehaviour
{
    public Transform[] patrolPoints; // Assign in inspector
    [SerializeField] public float speed = 5f;
    private int currentPointIndex = 0;
    private Camera mainCamera;
    private Renderer objectRenderer;

    void Start()
    {
        mainCamera = Camera.main; // Assuming the main camera is the one you want to check against
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (patrolPoints.Length == 0)
            return;

        Transform targetPoint = patrolPoints[currentPointIndex];

        MoveTowards(targetPoint);

        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
        }

        if (IsInView())
        {
            // Do something if the object is seen by the camera
            Debug.Log("Object is in view");
        }
    }

    void MoveTowards(Transform target)
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }

    bool IsInView()
    {
        if (!objectRenderer || !mainCamera)
            return false;

        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(mainCamera);
        return GeometryUtility.TestPlanesAABB(planes, objectRenderer.bounds);
    }
}


