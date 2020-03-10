using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNewGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Item mercFine;
		Item priestRobe;
		Item vetUni;
		Item berserkRaiment;
		Item sledge;
		Item comKnife;
		Item butKnife;
		Item axe;
		Item scoPis;
		Item accPis;
		Item powPis;
		Item relPis;
		Item boot;
		Item loaf;
		Item sneak;
		Item flat;

		mercFine = new Item("Mercenary's Finery", 6, 1, "Clothing");
		priestRobe = new Item("Priest's Robes", 6, 1, "Clothing");
		vetUni = new Item("Veteran's Uniform", 6, 1, "Clothing");
		berserkRaiment = new Item("Berserker Raiment", 6, 1, "Clothing");

		sledge = new Item("Sledge Hammer", 6, 1, "Tool");
		comKnife = new Item("Combat Knife", 6, 1, "Tool");
		butKnife = new Item("Butterfly Knife", 6, 1, "Tool");
		axe = new Item("Timber Axe", 6, 1, "Tool");

		scoPis = new Item("Scoped Pistol", 6, 1, "Gun");
		accPis = new Item("Accurate Pistol", 6, 1, "Gun");
		powPis = new Item("Powerful Pistol", 6, 1, "Gun");
		relPis = new Item("Reliable Pistol", 6, 1, "Gun");

		boot = new Item("Boots", 6, 1, "Shoes");
		loaf = new Item("Loafers", 6, 1, "Shoes");
		sneak = new Item("Sneakers", 6, 1, "Shoes");
		flat = new Item("Flats", 6, 1, "Shoes");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
