using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG {
    public class HealthComponent : MonoBehaviour
    {
        private int health;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void Initialize(int value) {
            health = value;
        }

        public void TakeDamage(int damage) {
            this.health -= damage;
            Debug.Log(this.health);
        }
    }
}