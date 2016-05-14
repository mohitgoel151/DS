package model;

import utilities.ItemFactory;

public class Pizza extends MenuItem {
	
	static {
		ItemFactory.getFactory().registerMenuItem("4", new Pizza());
	}

	public Pizza() {
		super("Pizza", "4", 7);
	}
	
	public MenuItem createItem() {
		return new Pizza();
	}

}
