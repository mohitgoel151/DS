package model;

public abstract class MenuItem {

	private String itemName;
	private String itemId;
	private int preparationTime;
	
	public String getItemName() {
		return itemName;
	}

	public String getItemId() {
		return itemId;
	}

	public int getPreparationTime() {
		return preparationTime;
	}
	
	public abstract MenuItem createItem();
	
	public MenuItem(String itemName, String id, int time) {
		this.itemName = itemName;
		this.itemId = id;
		this.preparationTime = time;
	}
	
	
}
