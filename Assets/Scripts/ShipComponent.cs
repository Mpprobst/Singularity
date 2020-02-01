using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG {
    public class ShipComponent : MonoBehaviour
    {
      private HealthComponent health;
        // Start is called before the first frame update
        void Start()
        {
           HealthComponent health = gameObject.GetComponent<HealthComponent>();
           health.Initialize(10);
        }

        // Update is called once per frame
        void Update()
        {
        }

        void OnTriggerEnter(Collider col) {
            Debug.Log("OnTriggerEnter");
            health.TakeDamage(5);
            // if (col.GetComponent<Collider>().name == ROBOT && attackFlag) {
            //     health.TakeDamage(5);
            // }
        }
    }
}