/**
 * 
 */
package org.mohit;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Hashtable;
import java.util.List;
import java.util.Map;

import org.shapes.Triangle;
import org.springframework.beans.factory.BeanFactory;
import org.springframework.beans.factory.xml.XmlBeanFactory;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;
import org.springframework.core.io.FileSystemResource;

/**
 * @author gomohit
 *
 */
public class DrawingApp {

	/**
	 * @param args
	 */
	public static void main(String[] args) {

		//BeanFactory factory = new XmlBeanFactory(new FileSystemResource("spring.xml"));
		//Triangle triangle = (Triangle) factory.getBean("triangle");
		
		
		Map<String, List<Triangle>> relatedItemsMap = new HashMap<String, List<Triangle>>(); 
		for (List<Triangle> a : relatedItemsMap) {
			System.out.print(a);
		}
		
		AbstractApplicationContext context = new ClassPathXmlApplicationContext("spring.xml");
		context.registerShutdownHook();
		Triangle triangle = (Triangle) context.getBean("triangle-second-alias");
		triangle.draw();
		
		Hashtable<int, int> a = new Hashtable<K, V>();

	}

}
