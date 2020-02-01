using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG {
    public class Robot : Entity
    {
        private HealthComponent health;
        // Start is called before the first frame update
        void Start()
        {
            health = gameObject.GetComponent<HealthComponent>();
           health.Initialize(20); 
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}