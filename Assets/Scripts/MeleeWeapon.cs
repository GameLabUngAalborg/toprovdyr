using UnityEngine;
using System.Collections;

namespace Teacher
{
    public class MeleeWeapon : MonoBehaviour
    {
        public int Damage;
        public Animator AnimationController;
        public float TimeUntilActive = 0.2f;
        public float AttackCooldown = 0.5f, TimeActive = 0.2f;
        public AudioClip SoundPlayedWhenHit;

        private AudioSource _audioSource;
        private bool _isAttacking = false;
        private Collider _collider; 

        void Start()
        {
            _collider = GetComponent<Collider>();
            _collider.enabled = false;

            _audioSource = GetComponent<AudioSource>();
        }

        void Update()
        {

            if(Input.GetMouseButtonDown(0))
            {

                StartCoroutine(Attack());
          
            }
        }

        IEnumerator Attack()
        {
            if(_isAttacking == false)
            {
                _isAttacking = true;
                // Attack start
                AnimationController.SetBool("IsAttacking", true);
                yield return new WaitForSeconds(TimeUntilActive);
                _collider.enabled = true;
                AnimationController.SetBool("IsAttacking", false);
                yield return new WaitForSeconds(TimeActive);
                _collider.enabled = false;
        
                yield return new WaitForSeconds(AttackCooldown);
                _isAttacking = false;
            }
        }

        void OnTriggerEnter(Collider other)
        {

            _collider.enabled = false;

            if(other.tag == "Resource")
            {
                other.GetComponent<Resource>().TakeDamage(Damage);
                _audioSource.PlayOneShot(SoundPlayedWhenHit);
            }
        }
      
    }
}