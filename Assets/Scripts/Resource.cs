using UnityEngine;
using System.Collections;

namespace Teacher
{
    public class Resource : MonoBehaviour
    {

        public GameObject DropOnDeath;
        public Transform DropLocation;
        public int Health;

        private AudioSource _audioSource;

        void Start()
        {
            _audioSource = GetComponent<AudioSource>();
        }

   

        public void TakeDamage(int dmg)
        {
            Health -= dmg;

   
            if (Health <= 0)
            {
                Die();
            }
        }

        void Die()
        {
            // destroy myself
            Destroy(gameObject);

            // Drop item
            GameObject item = Instantiate(DropOnDeath) as GameObject;
            item.transform.position = DropLocation.position;
        }



    }

}
