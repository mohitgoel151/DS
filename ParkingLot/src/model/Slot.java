package model;

import interfaces.ISlot;

public abstract class Slot implements ISlot {

	private int slotId;
	
	public int getSlotId() {
		return slotId;
	}

	public Slot(int id) {
		slotId = id;
	}

}
