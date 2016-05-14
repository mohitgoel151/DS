package model;

import utilities.ItemFactory;

public class Coffee extends MenuItem {
	
	static {
		ItemFactory.getFactory().registerMenuItem("2", new Coffee());
	}

	public Coffee() {
		super("Coffee", "2", 3);
	}
	
	public MenuItem createItem() {
		return new Coffee();
	}

}
