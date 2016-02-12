using UnityEngine;
using System.Collections;

namespace Teacher
{
    public class ResourceController : MonoBehaviour
    {

        public int Wood, Food, Rock;
        public UnityEngine.UI.Text TextWood, TextFood, TextRock;

        void Start()
        {

        }

        void Update()
        {
            TextWood.text = Wood.ToString();
            TextFood.text = Food.ToString();
            TextRock.text = Rock.ToString();
        }


    }
}
