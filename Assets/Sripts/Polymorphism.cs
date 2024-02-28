using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
/*public class Mammal
{
    public void GrowFur()
    { }
}
public class Cat : Mammal
{
    public void Meow()
    { }
}
public class Dog : Mammal
{
    public void Woof()
    { }
}*/

public class RescueShelter
{
    public Mammal[] mammals;
    /* public RescueShelter()
     {
         mammals = new Mammal[2];
         mammals[0] = new Cat();
         mammals[1] = new Dog();
     }*/
    /*public RescueShelter()
    {
        mammals = new Mammal[2];
        mammals[0] = new Cat();
        mammals[1] = new Dog();
        // Compile error.
        //mammals[0].Meow();
        Cat cat = mammals[0] as Cat;
        cat.Meow();
        Dog dog = (Dog)mammals[1];
        dog.Woof();
    }*/
    /*ublic RescueShelter()
    {
        mammals = new Mammal[2];
        mammals[0] = new Cat();
        mammals[1] = new Dog();
        // Compile error.
        //mammals[0].Meow();
        if (mammals[0] is Cat)
        {
            Cat cat = mammals[0] as Cat;
            cat.Meow();
        }
        if (mammals[1] is Dog)
        {
            Dog dog = (Dog)mammals[1];
            dog.Woof();
        }
    }*/

}

public class PetShop : MonoBehaviour
{
    [SerializeReference]
    public Mammal mammal = new Cat();
}
public class Animal
{ }
[Serializable]
public class Mammal : Animal
{ }
public class Cat : Mammal
{ }
