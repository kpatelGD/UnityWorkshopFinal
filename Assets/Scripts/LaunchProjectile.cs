using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    Transform cam;
    float range = 100f;
    public Transform projectileSpawnPoint;
    public GameObject projectilePrefab;

    [SerializeField] float fadeDuration = 0.3f;

    private AudioSource hitSound;

    private void Awake()
    {
        cam = Camera.main.transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        hitSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
        if(PauseMenu.isPaused == false)
        {
            RaycastHit hit;
                    Vector3 shootingDir = GetShootingDirection();
        
                    if (Physics.Raycast(cam.position, shootingDir, out hit, range))
                    {
                        if (hit.collider != null)
                        {
                            CreateProjectile(hit.point);
                            print(hit.collider.name);
                            if (hit.collider.CompareTag("Enemy"))
                            {
                                Destroy(hit.collider.gameObject);
                                hitSound.Play();

                            }
                        }
                        else
                        {
                            CreateProjectile(cam.position + shootingDir * range);

                        }


                    }
        }

        

    }

    void CreateProjectile(Vector3 end)
    {
        LineRenderer lr = Instantiate(projectilePrefab).GetComponent<LineRenderer>();
        lr.SetPositions(new Vector3[2] { projectileSpawnPoint.position, end });
        StartCoroutine(FadeLaser(lr));

       
    }

    Vector3 GetShootingDirection()
    {
        Vector3 targetPos = cam.position + cam.forward * range;
        Vector3 direction = targetPos - cam.position;
        return direction.normalized;

    }

    IEnumerator FadeLaser(LineRenderer lr)
    {
        float alpha = 1;
        while (alpha > 0)
        {
            alpha -= Time.deltaTime / fadeDuration;
            lr.startColor = new Color(lr.startColor.r, lr.startColor.g, lr.startColor.b, alpha);
            lr.endColor = new Color(lr.endColor.r, lr.endColor.g, lr.endColor.b, alpha);
            yield return null;
        }
        print("Done");
        Destroy(lr);
    }

}
