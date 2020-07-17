using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("速度"), Range(0, 1000)]
    public int speed = 4;
    public Animator Ani;
    public Rigidbody rig;

    private void Move()
    {
        bool key = Input.GetKey(KeyCode.W);
        Ani.SetBool("走路開關",key);
        if (key)
        {
            rig.AddForce(new Vector3(0,0,speed));
        }
    }
    private void Start()
    {
       

    }

    private void FixedUpdate()
    {
        Move();

    }
}
