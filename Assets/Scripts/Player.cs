using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public float Speed = 10f;
    public float SpeedShift = 200f;
    private Animator animator;
    private Rigidbody2D _rb;
    public int maxhealth = 100;
    public int health;
    public Slider HealthBar;
    public Text TextHelhtBar;

    public int bullets = 10;
    public int maxbullets = 50;

    void Start() 
    {
        HealthBar.value = HealthBar.maxValue;
        TextHelhtBar.text = health.ToString();
        health = maxhealth;
        animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>(); 
    }

    
    void FixedUpdate()
    {
        MovementLogic();
        Sprint();

    }

 private void MovementLogic()
    {
        if (DialogueManager.isActive) return;

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
        _rb.AddForce(movement * Speed);
        //transform.position = transform.position + movement * Time.deltaTime;
    }


    void Sprint()
    {

        if(Input.GetKey(KeyCode.LeftShift))
        {
            
            Speed = 100;

        }

        else if(!Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = 50;
        }


    }


    public void UpdateHealthBar(int Value) 
    {
        HealthBar.value -= Value;
        TextHelhtBar.text = HealthBar.value.ToString();
    }


}