using UnityEngine;

public class CharacterCamera : MonoBehaviour
{
    //カメラオブジェクト
    public GameObject MainCamera;
    public GameObject ZoomOutButton;
    public bool onClick = false;


    //軸調整
    int yAdjust = 5;
    int zAdjust = -7;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //float distance = 100; // 飛ばす&表示するRayの長さ デバッグ
            //float duration = 3;   // 表示期間（秒）デバッグ

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            ////光線可視化　デバッグ
            //Debug.DrawRay(ray.origin, ray.direction * distance, Color.red, duration, false);


            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("Animal"))
                {
                    OnClickCharacter();
                }
            }
        }

        if (onClick)
        {
            //ズーム処理
            MainCamera.transform.position = new Vector3(transform.position.x, transform.position.y + yAdjust, transform.position.z + zAdjust);
            MainCamera.transform.LookAt(transform.position);
            ZoomOutButton.SetActive(true);
        }
        else
        {
            ZoomOutButton.SetActive(false);
        }
    }

    public void OnClickCharacter()
    {
        onClick = true;
    }

    public void OnClickReturn()
    {
        MainCamera.transform.position = new Vector3(0, 10f, -20f);
        onClick = false;
    }
}
