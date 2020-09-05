using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue : MonoBehaviour
{
    public void Start()
    {
        List<string> FruitList = new List<string>();
        FruitList.Add("Apple");
        FruitList.Add("Orange");
        FruitList.Add("Carrot");
        FruitList.Add("Strawberry");
        FruitList.Add("Banana");

        print(FruitList);
    }

    //public void Update()
    //{
    //    List<string> FruitList = new List<string>();
    //    //string[] fruit = { "Apple", "Orange", "Carrot", "Strawberry", "Banana" };
    //    string i =  ;
    //    while (i < FruitList)
    //    {
    //        if (Input.GetKeyDown(KeyCode.Return))
    //        {
    //            FruitList.RemoveAt(0);
    //            print(FruitList);
    //        }
    //        else
    //        {
    //            print("Item is Empty");
    //        }
    //        i++;
    //    }
    //    }


}
