package model;

import utilities.ItemFactory;

public class Cereal extends MenuItem {
	
	static {
		ItemFactory.getFactory().registerMenuItem("3", new Cereal());
	}

	public Cereal() {
		super("Cereal", "3", 3);
	}
	
	public MenuItem createItem() {
		return new Cereal();
	}

}
