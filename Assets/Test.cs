using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("start");
        /*
        //要素数５
        int[] array = { 1, 2, 3, 4, 5 };

       

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length; i >= 0;  i--)
        {
            Debug.Log(array[i]);
        }
        */

        Boss boss = new Boss();

        for(int i = 0;i<10;i++)
        {
            boss.Magic();
        }
        Debug.Log("mpが足りない");
        


    }

        // Update is called once per frame
        void Update()
        {

        }

    public class Boss
    {
        private int mp = 53;

        public void Magic()
        {
            if(mp >=  5)
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは"+mp);
               
            }

            else
            {
                Debug.Log("MPが使えないため、魔法が使えない");
            }
        }
    }

}



    
 