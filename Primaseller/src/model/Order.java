package model;

import utilities.Helper;

public class Order {
	
	private MenuItem item;
	private int orderNumber;
	private String orderReceivedTime;
	
	private String orderPrepStartTime;
	private String orderPrepFinishTime;
	
	public Order(MenuItem mItem, int number) {
		this.item = mItem;
		this.orderNumber = number;
		this.orderReceivedTime = Helper.getCurrentTime();
	}

	public MenuItem getItem() {
		return item;
	}

	public int getOrderNumber() {
		return orderNumber;
	}
	
	public String getOrderReceivedTime() {
		return orderReceivedTime;
	}

	public void setOrderReceivedTime(String orderReceivedTime) {
		this.orderReceivedTime = orderReceivedTime;
	}

	public void setOrderPrepStartTime(String orderPrepStartTime) {
		this.orderPrepStartTime = orderPrepStartTime;
	}
	
	public String getOrderPrepStartTime() {
		return orderPrepStartTime;
	}

	public void setOrderPrepFinishTime(String orderPrepFinishTime) {
		this.orderPrepFinishTime = orderPrepFinishTime;
	}
	
	public String getOrderPrepFinishTime() {
		return orderPrepFinishTime;
	}
}
