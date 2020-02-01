using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG {
    public class Human : SG.Entity
    {
        private int attackCoolDown;
        private int coolDownRechargeSpeed;
        private bool attackFlag;
        private int attackDuration;
        // Start is called before the first frame update
        void Start()
        {
           this.attackCoolDown = 0;
           this.coolDownRechargeSpeed = 2; 
           this.attackDuration = 50;
        }

        // Update is called once per frame
        void Update()
        {
           if (this.attackCoolDown <= 0 && Input.GetKeyDown("l")) {
               this.attackFlag = true;
               this.attackDuration = 50;
           } 
           if (attackFlag) {
               if (attackDuration > 0) {
                   this.attackDuration--;
               }
               else {
                   this.attackFlag = false;
                   this.attackCoolDown = 100;
               }
           }
           attackCoolDown -= coolDownRechargeSpeed;
        }

        public void Attack(Collider col) {
            Debug.Log("Attack!");
            //GameObject go = col.gameObject;
            //Debug.Log(go.name);
            SG.HealthComponent hc = col.GetComponent<HealthComponent>();
            hc.TakeDamage(1);
        }

        void OnTriggerEnter(Collider col) {
          Debug.Log("hit!!!");
            if (col.GetComponent<Collider>().name == "Robot" && attackFlag) {
                Attack(col);
            }
        }
    }
}