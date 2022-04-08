using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class PlayerController : MonoBehaviour
{
    public static PlayerController _instance;
    Flowchart flowchart;
    bool IsPause;
    // Start is called before the first frame update
    Rigidbody2D Rig;
    Animator Anim;
    public float WalkSpeed;
    private bool IfFacingRight = true;
    AudioSource Audio;
    void Awake()
    {
        Audio = GetComponent<AudioSource>();
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
        Rig = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        _instance = this;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        IsPause = flowchart.GetBooleanVariable("IsPause");
        Move();
    }
    private void Move()
    {
        if (Input.GetAxis("Horizontal") > 0.6 && !IsPause) 
        {
            Rig.velocity = new Vector2(WalkSpeed, Rig.velocity.y);
            Anim.SetFloat("Walk", 1f);
            if(!Audio.isPlaying)
                Audio.Play();
        }
        else if (Input.GetAxis("Horizontal") < -0.6 && !IsPause)
        {
            Rig.velocity = new Vector2(WalkSpeed * -1, Rig.velocity.y);
            Anim.SetFloat("Walk", 1f);
            if (!Audio.isPlaying)
                Audio.Play();
        }
        else
        {
            Rig.velocity = new Vector2(0, Rig.velocity.y);
            Anim.SetFloat("Walk", 0f);
            if (Audio.isPlaying)
                Audio.Pause();
        }
        if (Rig.velocity.x > 0.3 && !IfFacingRight)
        {
            flip();
        }
        else if (Rig.velocity.x < -0.3 && IfFacingRight)
        {
            flip();
        }
        void flip()
        {
            IfFacingRight = !IfFacingRight;
            transform.Rotate(0f, 180f, 0f);
        }
    }
}
