package model;

import utilities.ItemFactory;

public class Sandwich extends MenuItem {
	
	static {
		ItemFactory.getFactory().registerMenuItem("1", new Sandwich());
	}

	public Sandwich() {
		super("Sandwich", "1", 5);
	}
	
	public MenuItem createItem() {
		return new Sandwich();
	}

}
