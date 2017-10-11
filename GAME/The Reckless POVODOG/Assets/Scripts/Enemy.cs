using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


	public float esm; // Enemy Speed Movement
	public float health; // Health
	public float eld; // Enemy Look Distance
	private float targetDistance; // Distance TO our player
	public Transform fpsTarget;// Transform of our player
	private bool faceRight = true;
	private Animator anim;
	//------------------------------------------
	public PlayerCNTRL player;
	private float damage;
	//------------------------------
	public GameObject Yourself;



	void Start()
	{
		anim = GetComponent<Animator> ();
	}
	void Update()
	{
		anim.SetFloat ("MonsterSpeed", esm);
	}
	void FixedUpdate()
	{
		
		targetDistance = Vector2.Distance (fpsTarget.position, transform.position); //Расстояние типа float от fpsTarget до объекта к торому прикреплен скрипт
		if (targetDistance < eld) { // Если расстояние меньше дальности видимости уебка то он бежит к нему, охуенно да
			esm = 5f;
			transform.position = Vector2.MoveTowards (transform.position, fpsTarget.position, Time.deltaTime * esm);
		} else
			esm = 0f;
		if (transform.position.x < fpsTarget.transform.position.x && faceRight) // Проеврка поворота ебальника
			flip ();
		else if (transform.position.x > fpsTarget.transform.position.x && !faceRight)
			flip ();
//		if (targetDistance < eld / 2) 
//		{
//			anim.Play ("BigMouth_Attack");
//		}
	}
	void flip() //Поворот
	{
		faceRight = !faceRight;
		transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

	}
	void OnTriggerEnter2D(Collider2D other)// Соприкосновение с коллайдерами
	{
		if (other.tag == "Attack") 
		{
			TakingHits ();
		}

	}
	void TakingHits() //Когда есть соприкосновение с тэгом "Attack"
	{
		health = health - player.damage;
		if (health <= 0) 
		{
			Death (Yourself);
		}
	}
	void Death (GameObject obj)//Смерть(Удаление всего объекта через объект Yourself, который ссылается сам на себя)
	{
		DestroyObject (obj, 0.08f);
	}

}
