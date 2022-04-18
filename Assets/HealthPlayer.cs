using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Obstacle25;

namespace Assets
{
    public class HealthPlayer : Obstacle25
    {
        public Slider sl;
        public Text txDie;
        public GameObject explosion;
        
        
       
        // Start is called before the first frame update
        void Start()
        {
            explosion.SetActive(false);
            txDie.enabled = false;
        }
        public HealthPlayer()
        {
        
        }
        
        
        
        void OnCollisionEnter(Collision other)
        {
           

            if (other.transform.tag == "hp")
            {
                sl.value -= 25;
                Destroy(other.gameObject);

              listObstacle.Remove(other.gameObject);
               
                if (sl.value == 0)
                {
                    sl.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().enabled = false;
                    txDie.enabled = true;

                    explosion.SetActive(true);
                    Instantiate(explosion, explosion.transform.position, Quaternion.identity);
                       
                        Destroy(gameObject);
                    
                }
            }

            // Do stuff
        }
        // Update is called once per frame
        void Update()
        {
            ExplosionDown();

            
        }
        private void ExplosionDown()
        {
            explosion.transform.position = transform.position;
            if (transform.position.y + 5 < 0)
            {
                explosion.SetActive(true);
                Instantiate(explosion, explosion.transform.position, Quaternion.identity);
                Destroy(gameObject);
                sl.value = 0;
            }
        }
      
    }
}