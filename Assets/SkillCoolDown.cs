using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCoolDown : MonoBehaviour {

    public float cooldownTime = 2;
    float timer;
    public Image image;
    public KeyCode key;

	// Use this for initialization
	void Start () {
        timer = cooldownTime;
	}
	
    public void CastSkill()
    {
        if(timer > cooldownTime)
        {
            Debug.Log("Cast skill!!!");
            timer = 0;
        }
    }
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        image.fillAmount = (cooldownTime - timer) / cooldownTime;
        if (Input.GetKeyDown(key))
        {
            CastSkill();
        }
	}
}
