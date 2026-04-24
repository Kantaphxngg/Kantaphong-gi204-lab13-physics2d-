using UnityEngine;

public class SawMovement : MonoBehaviour
{
    // การขยับ
    public float speed = 2.0f;          // ความเร็วในการขยับซ้าย-ขวา
    public float distance = 1.2f;       // ระยะที่อยากให้ขยับ (1 ช่องนิดๆ)
    private Vector3 startPos;           // ตำแหน่งเริ่มต้น

    // การหมุน
    public float rotationSpeed = 360f;  // ความเร็วในการหมุน (องศาต่อวินาที)

    void Start()
    {
        // จำตำแหน่งเริ่มต้นไว้
        startPos = transform.position;
    }

    void Update()
    {
        // 1. การขยับซ้าย-ขวา
        float newX = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(startPos.x + newX, startPos.y, startPos.z);

        // 2. การหมุน
        // หมุนรอบแกน Z (แกนที่ทำให้หมุนเหมือนเข็มนาฬิกา)
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}