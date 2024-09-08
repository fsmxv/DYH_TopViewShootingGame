using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    public Vector3 screeenPoo;
    public Vector3 worldPoo;
    public LayerMask layersOnhit;
    public Transform aimPoint;
    public GameObject prefab_bullet;






    private void Update()
    {
        Aim();
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    private void Aim()
    {
        screeenPoo = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(screeenPoo);

        if(Physics.Raycast(ray, out RaycastHit hitInfo, 100 ,layersOnhit))
        {
            worldPoo = hitInfo.point;
            worldPoo.y = transform.position.y;
        }
        aimPoint.transform.position = worldPoo;
    }


    private void Shoot()
    {
        screeenPoo = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(screeenPoo);

        if (Physics.Raycast(ray, out RaycastHit hitInfo, 100, layersOnhit))
        {
            worldPoo = hitInfo.point;
            worldPoo.y = transform.position.y;
        }


        GameObject _obj = Instantiate(prefab_bullet, transform.position, Quaternion.identity);
        _obj.transform.LookAt(worldPoo);
    }



}

