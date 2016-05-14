package utilities;

import java.util.HashMap;

import model.MenuItem;

public class ItemFactory {
	
	private HashMap<String, MenuItem> registeredMenuItems = new HashMap<String, MenuItem>();
	 
	private static ItemFactory factory = new ItemFactory();
	
	private ItemFactory() {
		
	}
	
	public static ItemFactory getFactory() {
		return factory;
	}
	
	public void registerMenuItem(String id, MenuItem itemObject) {
		registeredMenuItems.put(id, itemObject);
	}
	
	public MenuItem getMenuItem(String id) {
		MenuItem itemObject = ((MenuItem) registeredMenuItems.get(id));
		if(itemObject != null) {
			return itemObject.createItem(); 
		}
		return null;
	}
	

}
