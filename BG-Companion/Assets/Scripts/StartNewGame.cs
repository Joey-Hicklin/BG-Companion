using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNewGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		List<Item> gameItems = new List<Item>()
		{
			new Item("Mercenary's Finery", 6, 1, "Clothing", new List<Ability>(){ 
				new Ability("Healing", "TL", new List<string>(){"heal"}, 1, 3, 0, 1),
				new Ability("Shielding", "TR", new List<string>(){"shield"}, 3, 2, 0, 1)
			}),
			new Item("Priest's Robes", 6, 1, "Clothing", new List<Ability>(){
				new Ability("Healing", "TL", new List<string>(){"heal"}, 2, 2, 0, 1),
				new Ability("Shielding", "TR", new List<string>(){"shield"}, 2, 2, 0, 1)
			}),
			new Item("Veteran's Uniform", 6, 1, "Clothing", new List<Ability>(){
				new Ability("Healing", "TL", new List<string>(){"heal"}, 2, 2, 0, 1),
				new Ability("Shielding", "TR", new List<string>(){"shield"}, 3, 1, 0, 1)
			}),
			new Item("Berserker Raiment", 6, 1, "Clothing", new List<Ability>(){
				new Ability("Healing", "TL", new List<string>(){"heal"}, 3, 1, 0, 1),
				new Ability("Shielding", "TR", new List<string>(){"shield"}, 1, 3, 0, 1)
			}),

			new Item("Sledge Hammer", 6, 1, "Tool", new List<Ability>(){
				new Ability("Focus", "TL", new List<string>(){"attack", "focus"}, 1, 4, 4, 1)
			}),
			new Item("Combat Knife", 6, 1, "Tool", new List<Ability>(){
				new Ability("Focus", "TL", new List<string>(){"attack", "focus"}, 1, 2, 2, 1)
			}),
			new Item("Butterfly Knife", 6, 1, "Tool", new List<Ability>(){
				new Ability("Focus", "TL", new List<string>(){"attack", "focus"}, 1, 1, 1, 1)
			}),
			new Item("Timber Axe", 6, 1, "Tool", new List<Ability>(){
				new Ability("Focus", "TL", new List<string>(){"attack", "focus"}, 1, 3, 3, 1)
			}),

			new Item("Scoped Pistol", 6, 1, "Gun", new List<Ability>(){
				new Ability("Shoot", "TL", new List<string>(){"attack"}, 0, 6, 6, 0)
			}),
			new Item("Accurate Pistol", 6, 1, "Gun", new List<Ability>(){
				new Ability("Shoot", "TL", new List<string>(){"attack"}, 0, 6, 6, 0)
			}),
			new Item("Powerful Pistol", 6, 1, "Gun", new List<Ability>(){
				new Ability("Shoot", "TL", new List<string>(){"attack"}, 0, 6, 6, 0)
			}),
			new Item("Reliable Pistol", 6, 1, "Gun", new List<Ability>(){
				new Ability("Shoot", "TL", new List<string>(){"attack"}, 0, 6, 6, 0)
			}),

			new Item("Boots", 6, 1, "Shoes", new List<Ability>(){
				new Ability("Move", "TL", new List<string>(){"movement"}, 3, 8, 0, 0),
				new Ability("Curse", "TR", new List<string>(){"trap"}, 2, 1, 1, 1)
			}),
			new Item("Loafers", 6, 1, "Shoes", new List<Ability>(){
				new Ability("Move", "TL", new List<string>(){"movement"}, 3, 8, 0, 0),
				new Ability("Leap", "TR", new List<string>(){}, 0, 0, 0, 1)
			}),
			new Item("Sneakers", 6, 1, "Shoes", new List<Ability>(){
				new Ability("Move", "TL", new List<string>(){"movement"}, 3, 8, 0, 0),
				new Ability("Acid Walk", "TR", new List<string>(){"trap"}, 1, 2, 2, 2)
			}),
			new Item("Flats", 6, 1, "Shoes", new List<Ability>(){
				new Ability("Move", "TL", new List<string>(){"movement"}, 3, 8, 0, 0),
				new Ability("Float", "TR", new List<string>(){}, 0, 0, 0, 0)
			})
		};	
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
