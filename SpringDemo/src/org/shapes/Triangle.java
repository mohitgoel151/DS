package org.shapes;

import java.util.List;

import org.springframework.beans.BeansException;
import org.springframework.beans.factory.BeanNameAware;
import org.springframework.beans.factory.DisposableBean;
import org.springframework.beans.factory.InitializingBean;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ApplicationContextAware;

public class Triangle implements Shape, ApplicationContextAware, BeanNameAware, InitializingBean, DisposableBean  {
	
	private Point pointA;
	private Point pointB;
	private Point pointC;
	
	private List<Point> points;
	private ApplicationContext appContext;
	

	public Point getPointA() {
		return pointA;
	}
	public void setPointA(Point pointA) {
		this.pointA = pointA;
	}
	public Point getPointB() {
		return pointB;
	}
	public void setPointB(Point pointB) {
		this.pointB = pointB;
	}
	public Point getPointC() {
		return pointC;
	}
	public void setPointC(Point pointC) {
		this.pointC = pointC;
	}
	
	public List<Point> getPoints() {
		return points;
	}
	public void setPoints(List<Point> points) {
		this.points = points;
	}
	
	public void draw() {
		
		for (Point point : points) {
			System.out.println("Point = " + point.toString());
		}
		
//		System.out.println("PointA is = " + pointA.toString());
//		System.out.println("PointB is = " + pointB.toString());
//		System.out.println("PointC is = " + pointC.toString());
	}
	
	@Override
	public void setBeanName(String beanName) {
		System.out.println("Bean name is :" + beanName);
		
	}
	
	@Override
	public void setApplicationContext(ApplicationContext context)
			throws BeansException {
		this.appContext = context;
		System.out.println("set applicationContext method called");
		
	}
	@Override
	public void destroy() throws Exception {
		System.out.println("destroy method of disposableBeam interface called");
		
	}
	
	@Override
	public void afterPropertiesSet() throws Exception {
		System.out.println("initialize method of initializeBeam interface called");
		
	}
	
	//This method got overridden by myInit method
	public void defaultInit() {
		System.out.println("default Init called");
	}
	
	//This method got overridden by cleanUp method
	public void defaultCleanUp() {
		System.out.println("default CleanUp called");
	}
	
	public void myInit() {
		System.out.println("myInit called");
	}
	
	public void cleanUp() {
		System.out.println("cleanUp called");
	}
	
	
	
//	private String type;
//	private int height;
//	
//	public int getHeight() {
//		return height;
//	}
//
//	public void setHeight(int height) {
//		this.height = height;
//	}
//
//	public String getType() {
//		return type;
//	}
//
//	public void setType(String type) {
//		this.type = type;
//	}
//	
//	public Triangle(String type) {
//		this.type = type;
//	}
//	
//	public Triangle(String type, int height) {
//		this.type = type;
//		this.height = height;
//	}
//
//	public void draw() {
//		System.out.println(getType() + " Triangle drawn of height = " + getHeight());
//	}

}
