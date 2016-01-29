using UnityEngine;
using System.Collections;

namespace Teacher
{
    public class FoodObject : MonoBehaviour
    {
        public float FoodAmount = 0.5f;

        public AudioClip EatingSound;

        void OnTriggerEnter(Collider ObjectThatTouchedMe)
        {
            if (ObjectThatTouchedMe.tag == "Player")
            {
                ObjectThatTouchedMe.GetComponent<Hunger>().HungerBar.value += FoodAmount;

                AudioSource.PlayClipAtPoint(EatingSound, ObjectThatTouchedMe.transform.position);

                Destroy(gameObject);
            }

        }

    }
}
