using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;


public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D myRB;
    [SerializeField]
    private float speed;
    private float limitSuperior;
    private float limitInferior;
    public int player_lives = 3;
    public float player_puntaje =0;
    Vector2 inputMovementPlayer;
    public Vector2 savePositionInitial;
    [SerializeField] Soundscriptableobjects SoundDamage;
    [SerializeField] SavePuntaje soPuntaje;
    //AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        SetMinMax();
        savePositionInitial = transform.position;
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player_lives <=0){
            soPuntaje.GuardarPuntaje(player_puntaje);
        }
        player_puntaje= player_puntaje+ 1*Time.deltaTime;
        Mathf.Clamp(transform.position.y,-4.5f,4.5f);
        myRB.velocity = inputMovementPlayer * speed;
    }

    void SetMinMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        limitInferior = -bounds.y;
        limitSuperior = bounds.y;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Candy")
        {
            CandyGenerator.instance.ManageCandy(other.gameObject.GetComponent<CandyController>(), this);
        }
        else if (other.tag == "Enemy")
        {
            EnemyGenerator.instance.ManageEnemy(other.gameObject.GetComponent<EnemyController>(), this);
            SoundDamage.CreateSound();
        }
    }
    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 inputMovement = value.ReadValue<Vector2>();
        inputMovementPlayer = new Vector2(/*inputMovement.x*/0,inputMovement.y);
    }


}
