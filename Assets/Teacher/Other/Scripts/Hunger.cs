using UnityEngine;
using System.Collections;


namespace Teacher
{
    public class Hunger : MonoBehaviour
    {

        // Hvilken slider er det vi ændrer på?

        // Vi skriver UnityEngine.UI.Slider i stedet for at tilføje den i toppen af scriptet med 'using UnityEngine.UI'
        public UnityEngine.UI.Slider HungerBar;


        public float HungerSpeed = 1;


        [Range(0f,1f)]


        public float HungerStartValue = 1;

        // Use this for initialization
        void Start()
        {

            HungerBar.value = HungerStartValue;

        }

        // Update is called once per frame
        void Update()
        {
            // Hvert sekund vil vi miste noget hunger
            // Vi sætter hungerbaren til at miste value ved at skrive...
            //

            HungerBar.value -= HungerSpeed * Time.deltaTime;

            // Ved at gange med Time.deltatime betyder det at man taber hunger med "HungerSpeed" hvert sekund.

            // Vi skal tjekke om hunger går under 0

            if(HungerBar.value <= 0)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);
            }
        }
    }
}
