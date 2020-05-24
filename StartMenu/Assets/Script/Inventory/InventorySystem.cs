using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public List<Image> inventory_list =  new List<Image>();
    public List<bool> is_enlarge_list = new List<bool>();
    public Image enlargedImage;
    public int current_size = 0;
    public int current_click = -1;
    public const int Max_size = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Reset()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (current_click != -1)
        {
            if (is_enlarge_list[current_click] == true)
            {
                enlargedImage.enabled = true;
                enlargedImage.sprite = inventory_list[current_click].sprite;
            }
            else
            {
                enlargedImage.enabled = false;
            }
        }
        else
        {
            enlargedImage.enabled = false;
        }
    }

    public void setEnlarge()
    {
        is_enlarge_list[current_size - 1] = true;
    }

    //get the name of current item
    public string currentitem()
    {
        if(current_click == -1)
        {
            return null;
        }
        return inventory_list[current_click].sprite.name;
    }

    public void remove()
    {
        if(current_size != 0)
        {
            for (int i = current_click; i < current_size; i++)//shift item
            {
                if (i != -1) inventory_list[i].sprite = inventory_list[i + 1].sprite;
                if (i != -1) is_enlarge_list[i] = is_enlarge_list[i + 1];
            }
            Image image = inventory_list[current_size];
            inventory_list[current_size - 1].color = new Color(image.color.r, image.color.g, image.color.b, 0f);
            current_click = -1;
            foreach (Transform child in GameObject.FindWithTag("Inventory").gameObject.transform)
            {
                if (child != gameObject.transform) child.GetComponent<Image>().color = Color.white;
            }
            current_size--;
        }   
    }

    public bool Additem(Sprite input) 
    {
        inventory_list[current_size].sprite = input;
        Image image = inventory_list[current_size];
        inventory_list[current_size].color = new Color(image.color.r, image.color.g, image.color.b, 1f);
        current_size++;
        return true;
    }
}
